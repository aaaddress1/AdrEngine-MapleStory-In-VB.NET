Imports System.Runtime.InteropServices
Imports Microsoft
Module Win32Api
    Public Declare Function ReadProcessMemory Lib "kernel32" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByVal lpBuffer() As Byte, ByVal nSize As Integer, ByRef lpNumberOfBytesWritten As Integer) As Integer
    Public Declare Function VirtualQueryEx Lib "Kernel32" (ByVal hProcess As Integer, ByVal lpBaseAddress As Integer, ByRef info As MEMORY_BASIC_INFORMATION, ByVal dwLength As Integer) As Integer
    Public Structure MEMORY_BASIC_INFORMATION
        Public BaseAddress As Integer
        Public AllocationBase As Integer
        Public AllocationProtect As Integer
        Public RegionSize As Integer
        Public State As Integer
        Public Protect As Integer
        Public Type As Integer
    End Structure
    Public Const PAGE_READWRITE = &H4
    Public Const MEM_COMMIT = &H1000


    Public Function GetFixedAobStr(ByVal Str As String) As String
        Dim GetN As String = Str.Replace("  ", " ")
        If VisualBasic.Left(GetN, 1) = " " Then GetN = VisualBasic.Right(GetN, GetN.Length - 1)
        If VisualBasic.Right(GetN, 1) = " " Then GetN = VisualBasic.Left(GetN, GetN.Length - 1)
        Return GetN
    End Function

    Public Function TurnInt32ToAOB(ByVal Int As Integer) As String
        Dim GetAOB_Str As String = VisualBasic.Hex(Int)
        Dim nGet As String
        Do Until GetAOB_Str.Length = 8
            GetAOB_Str = "0" + GetAOB_Str
        Loop
        For index = 0 To (GetAOB_Str.Length - 1) Step 2
            nGet = GetAOB_Str.Substring(index, 2) + " " + nGet
        Next
        Return GetFixedAobStr(nGet)
    End Function




End Module
