Imports System.Runtime.InteropServices
Imports Microsoft
Public Class MyForm
    Public MapleProcess As Process = Nothing
    Dim NowSearchPos As Integer, LimitAdr As Integer = &HFFFFFF
    Public Sub UI_Shown_Script()
        Do
            '    ProgressBar.Value = (NowSearchPos / LimitAdr) * 100
            Threading.Thread.Sleep(0)
        Loop Until (NowSearchPos >= LimitAdr)
    End Sub

    Public Function SearchProcessMemory(ByVal p As Process, ByVal ArrayOfByte As String) As List(Of Integer)
        Threading.Thread.CurrentThread.Priority = Threading.ThreadPriority.Highest
        Dim Hwnd As IntPtr = p.Handle
        Dim MBI As New MEMORY_BASIC_INFORMATION
        NowSearchPos = p.MainModule.BaseAddress
        Dim CopyBuffBytes() As Byte = {0}
        Dim Result As List(Of Integer) = New List(Of Integer)
        Dim AOB_Buff() As String = ArrayOfByte.Split(" ")
        Dim ShowUI_Thread As New Threading.Thread(AddressOf UI_Shown_Script)
        ShowUI_Thread.Start()
        Do
            VirtualQueryEx(Hwnd, NowSearchPos, MBI, Marshal.SizeOf(MBI))
            If Not (MBI.State = MEM_COMMIT) Then GoTo NextBlock
            If (MBI.Protect = PAGE_READWRITE) Then GoTo NextBlock
            ReDim CopyBuffBytes(MBI.RegionSize + 1)
            ReadProcessMemory(Hwnd, NowSearchPos, CopyBuffBytes, MBI.RegionSize, IntPtr.Zero)
            For index = 0 To (MBI.RegionSize - 1)
                For Bpos = 0 To (AOB_Buff.Length - 1)
                    If (AOB_Buff(Bpos) = "??") Or (AOB_Buff(Bpos) = "?") Then GoTo NextCmp
                    If Not (Convert.ToInt32(AOB_Buff(Bpos), 16) = CopyBuffBytes(index + Bpos)) Then GoTo NextAddress
NextCmp:
                Next
                Result.Add(NowSearchPos + index)
NextAddress:
            Next
NextBlock:
            NowSearchPos += MBI.RegionSize
        Loop Until (NowSearchPos > LimitAdr)
        ProgressBar.Value = 100
        Threading.Thread.CurrentThread.Priority = Threading.ThreadPriority.Normal
        Return Result
    End Function

    Private Sub Search_Click() Handles Search.Click
        SetMeEnabled(False)
        ListAddress.Items.Clear()
        ArrayOfByteInputTb.Text = GetFixedAobStr(ArrayOfByteInputTb.Text)
        Dim nDate As Date = Now
        Status.Text = ("搜索完成! 共耗時: " & Now.Subtract(nDate).Milliseconds / 1000 & "秒")
        For Each GetAdr As Integer In SearchProcessMemory(MapleProcess, ArrayOfByteInputTb.Text)
            ListAddress.Items.Add(VisualBasic.Hex(GetAdr) & vbNewLine)
        Next
        Label2.Text = "地址列表(" & ListAddress.Items.Count & ")"
        SetMeEnabled(True)
    End Sub


    Private Sub MyFormLoad() Handles MyBase.Load
        Form.CheckForIllegalCrossThreadCalls = False
        Text = "Adr Engine. 【v" & Application.ProductVersion & "】"
        DarkUnHSEagle()
        SetMeEnabled(False)
    End Sub

    Private Sub SetMeEnabled(ByVal Bool As Boolean)
        For Each C As Control In Controls
            C.Enabled = Bool
        Next
        ToolStrip.Enabled = True
    End Sub
    Private Sub ArrayOfByteInputTb_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ArrayOfByteInputTb.KeyDown
        If e.KeyCode = Keys.Control + Keys.A Then CType(sender, TextBox).SelectAll()
    End Sub
    Private Sub ListAddress_DoubleClick() Handles ListAddress.DoubleClick
        Try
            Clipboard.SetText(ListAddress.SelectedItem)
            Status.Text = "已複製至剪貼板. _ 0x" & ListAddress.SelectedItem
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SearchForSkillClick() Handles SearchForSkill.Click
        SetMeEnabled(False)
        Try
            ListAddress.Items.Clear()
            ArrayOfByteInputTb.Text = GetFixedAobStr(ArrayOfByteInputTb.Text)
            Dim nDate As Date = Now
            Status.Text = ("搜索完成! 共耗時: " & Now.Subtract(nDate).Milliseconds / 1000 & "秒")
            '重新定位正確的Address開頭.
            For Each EachAdr As Integer In SearchProcessMemory(MapleProcess, GetFixedAobStr(TurnInt32ToAOB(SkillIdInputTb.Text)))
                Dim ChByte() As Byte = {0}
                ReadProcessMemory(MapleProcess.Handle, EachAdr + 4, ChByte, 1, IntPtr.Zero)
                If (ChByte(0) = &HF) Or (ChByte(0) = &H74) Or (ChByte(0) = &H75) Then
                    EachAdr += 4 : GoTo ListIt
                End If
                ReadProcessMemory(MapleProcess.Handle, EachAdr - 1, ChByte, 1, IntPtr.Zero)
                If (ChByte(0) > &HB7) And (ChByte(0) < &HBC) Then
                    EachAdr -= 1 : GoTo ListIt
                End If
ListIt:
                ListAddress.Items.Add(VisualBasic.Hex(EachAdr) & vbNewLine)
            Next
            '定位完畢
        Catch ex As Exception
            MessageBox.Show("您給的技能ID不是一個合法的數值.", "錯誤訊息", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End Try
        SetMeEnabled(True)
        Status.Text = "技能關鍵位置爆破完畢."
    End Sub
    Private Sub AttackMsClick() Handles AttackMs.Click
        Try
            MapleProcess = Process.GetProcessesByName("MapleStory")(0)
            MsInfo.Text = "PID:" & MapleProcess.Id
            SetMeEnabled(True)
        Catch ex As Exception
            MsInfo.Text = "無目標可攻擊"
            SetMeEnabled(False)
            MessageBox.Show("找不到可攻擊的楓之谷.", "錯誤訊息", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub KillMsClick() Handles KillMs.Click
        MapleProcess.Kill()
    End Sub
End Class
