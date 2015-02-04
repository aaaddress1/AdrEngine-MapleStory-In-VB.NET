Imports System.Runtime.InteropServices
Module InlineHook
    <System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack:=1)> _
    Public Structure Process_Basic_Information
        Public ExitStatus As IntPtr
        Public PebBaseAddress As IntPtr
        Public AffinityMask As IntPtr
        Public BasePriority As IntPtr
        Public UniqueProcessID As IntPtr
        Public InheritedFromUniqueProcessId As IntPtr
    End Structure
    Private Enum PROCESSINFOCLASS
        ProcessBasicInformation = 0
        ProcessQuotaLimits
        ProcessIoCounters
        ProcessVmCounters
        ProcessTimes
        ProcessBasePriority
        ProcessRaisePriority
        ProcessDebugPort
        ProcessExceptionPort
        ProcessAccessToken
        ProcessLdtInformation
        ProcessLdtSize
        ProcessDefaultHardErrorMode
        ProcessIoPortHandlers
        ProcessPooledUsageAndLimits
        ProcessWorkingSetWatch
        ProcessUserModeIOPL
        ProcessEnableAlignmentFaultFixup
        ProcessPriorityClass
        ProcessWx86Information
        ProcessHandleCount
        ProcessAffinityMask
        ProcessPriorityBoost
        ProcessDeviceMap
        ProcessSessionInformation
        ProcessForegroundInformation
        ProcessWow64Information
        ProcessImageFileName
        ProcessLUIDDeviceMapsEnabled
        ProcessBreakOnTermination
        ProcessDebugObjectHandle
        ProcessDebugFlags
        ProcessHandleTracing
        ProcessIoPriority
        ProcessExecuteFlags
        ProcessResourceManagement
        ProcessCookie
        ProcessImageInformation
        MaxProcessInfoClass
    End Enum
    <System.Runtime.InteropServices.DllImport("ntdll.dll", EntryPoint:="NtQueryInformationProcess")> _
    Public Function NtQueryInformationProcess(ByVal handle As IntPtr, ByVal processinformationclass As UInteger, ByRef ProcessInformation As Process_Basic_Information, ByVal ProcessInformationLength As Integer, ByRef ReturnLength As UInteger) As Integer
    End Function
    ''' <summary>
    ''' Fake Taskmgr APIBypassing BY 小可, Translation BY NIMO1993.
    ''' </summary>
    ''' 
    Public Sub DarkUnHSEagle()
        '
        '             * 感謝 大可 提供PEB偽造ImagePathName方法，原C++作
        '             	_asm
        '            	{
        '		            mov eax,fs:[0x30]    //eax points to PEB
        '            		mov eax,[eax+0x010]  //eax points to _PEB->_RTL_USER_PROCESS_PARAMETERS
        '            		add eax,0x38         //eax points to ImagePathName(UNICODE_STRING)
        '            		add eax,0x4			 //UNICODE_STRING.Buffer
        '            		mov ebx,wszImagePathName
        '            		mov [eax],ebx
        '            		mov eax,[eax]
        '            	}
        '            

        Dim PBI As New Process_Basic_Information()
        Dim nsize As Integer
        Dim PEBBaseAddress As Integer
        Dim RTL_USER_PROCESS_PARAMETERS As Integer
        Dim ImagePathName_UNICODE_STRING As Integer
        Dim UNICODE_STRING_Buffer As Integer
        Dim FakeTaskMgr As IntPtr
        Try
            If Environment.Is64BitProcess Then
                NtQueryInformationProcess(-1, PROCESSINFOCLASS.ProcessBasicInformation, PBI, Marshal.SizeOf(GetType(Process_Basic_Information)), nsize)
                PEBBaseAddress = PBI.PebBaseAddress
                RTL_USER_PROCESS_PARAMETERS = Marshal.ReadInt32(PEBBaseAddress + &H20)
                ImagePathName_UNICODE_STRING = RTL_USER_PROCESS_PARAMETERS + &H60
                UNICODE_STRING_Buffer = ImagePathName_UNICODE_STRING + &H8
                '儲存字串所在位址的Buffer
                FakeTaskMgr = Marshal.StringToHGlobalAuto(Environment.SystemDirectory + "\taskmgr.exe")

                '置換成自己偽裝的位址
            Else
                NtQueryInformationProcess(-1, PROCESSINFOCLASS.ProcessBasicInformation, PBI, Marshal.SizeOf(GetType(Process_Basic_Information)), nsize)
                PEBBaseAddress = PBI.PebBaseAddress
                RTL_USER_PROCESS_PARAMETERS = Marshal.ReadInt32(PEBBaseAddress + &H10)
                ImagePathName_UNICODE_STRING = RTL_USER_PROCESS_PARAMETERS + &H38
                UNICODE_STRING_Buffer = ImagePathName_UNICODE_STRING + &H4
                '儲存字串所在位址的Buffer
                FakeTaskMgr = Marshal.StringToHGlobalAuto(Environment.SystemDirectory + "\taskmgr.exe")
                '置換成自己偽裝的位址
            End If
            Marshal.WriteIntPtr(UNICODE_STRING_Buffer, FakeTaskMgr)
        Catch ex As Exception

        End Try
    End Sub


End Module
