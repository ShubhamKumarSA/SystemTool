Option Explicit On
Public Class frmMain

    Public TimeOut As Integer   'Records Time for Schedule Shutdown
    Public FClose As Boolean
    Dim TT As New ToolTip
    Dim MRes As Integer
    '-------------------------Starts Getting Token--------------------------'
    Private Structure LUID
        Dim UsedPart As Integer
        Dim IgnoredForNowHigh32BitPart As Integer
    End Structure
    Private Structure TOKEN_PRIVILEGES
        Dim PrivilegeCount As Integer
        Dim TheLuid As LUID
        Dim Attributes As Integer
    End Structure
    'The API functions below are all used to give the application the proper privilege so the OS will allow the app to Shutdown Windows.
    Private Declare Function OpenProcessToken Lib "advapi32" (ByVal ProcessHandle As IntPtr, ByVal DesiredAccess As Integer, ByRef TokenHandle As Integer) As Integer
    Private Declare Function LookupPrivilegeValue Lib "advapi32" Alias "LookupPrivilegeValueA" (ByVal lpSystemName As String, ByVal lpName As String, ByRef lpLuid As LUID) As Integer
    Private Declare Function AdjustTokenPrivileges Lib "advapi32" (ByVal TokenHandle As Integer, ByVal DisableAllPrivileges As Boolean, ByRef NewState As TOKEN_PRIVILEGES, ByVal BufferLength As Integer, ByRef PreviousState As TOKEN_PRIVILEGES, ByRef ReturnLength As Integer) As Integer

    'This sub will do all of the work of setting up your apps process using the APIs posted above to get the
    'proper privileges to shutdown the OS.
    'I originally got this function from msdn and converted it from VB 6.0 to VB.Net and did a tweak here and there.
    Private Sub AdjustToken()
        Const TOKEN_ADJUST_PRIVILEGES As Int32 = &H20
        Const TOKEN_QUERY As Int32 = &H8
        Const SE_PRIVILEGE_ENABLED As Int32 = &H2
        Dim hdlProcessHandle As IntPtr
        Dim hdlTokenHandle As Int32
        Dim tmpLuid As LUID
        Dim tkp As TOKEN_PRIVILEGES
        Dim tkpNewButIgnored As TOKEN_PRIVILEGES
        Dim lBufferNeeded As Int32

        hdlProcessHandle = Process.GetCurrentProcess.Handle
        OpenProcessToken(hdlProcessHandle, (TOKEN_ADJUST_PRIVILEGES Or TOKEN_QUERY), hdlTokenHandle)
        'Get the LUID for shutdown privilege.
        LookupPrivilegeValue("", "SeShutdownPrivilege", tmpLuid)
        tkp.PrivilegeCount = 1 'One privilege to set
        tkp.TheLuid = tmpLuid
        tkp.Attributes = SE_PRIVILEGE_ENABLED
        'Enable the shutdown privilege in the access token of this process.
        AdjustTokenPrivileges(hdlTokenHandle, False, tkp, Len(tkpNewButIgnored), tkpNewButIgnored, lBufferNeeded)
    End Sub
    '-----------------------------------------------------------------------'
    Private Declare Function ExitWindowsEx Lib "user32" (ByVal dwOptions As Integer, ByVal dwReserved As Integer) As Integer
    Private Const EWX_LOGOFF As Integer = &H0
    Private Const EWX_SHUTDOWN As Integer = &H1
    Private Const EWX_REBOOT As Integer = &H2
    Private Const EWX_FORCE As Integer = &H4
    Private Const EWX_POWEROFF As Integer = &H8
    Private Const EWX_FORCEIFHUNG As Integer = &H10 '2000/XP only

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TT.SetToolTip(sysTOff, "Shutdown System")
        TT.SetToolTip(sysRStart, "Restart System")
        TT.SetToolTip(sysSleep, "Sleep Mode")
        TT.SetToolTip(sysLOff, "Log Off System")
        TT.SetToolTip(sysHibernate, "Hibernate System")
        TT.SetToolTip(sysSchedule, "Schedule System Shutdown")
        TT.SetToolTip(OneClick, "Confirmation required before using features.")
        TT.SetToolTip(Label4, "Close Panel")
        TT.SetToolTip(Button1, "Minimize to SystemTray")
        TT.SetToolTip(Button2, "Reschedule Shutdown Time")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub sysTOff_Click(sender As Object, e As EventArgs) Handles sysTOff.Click
        If OneClick.CheckState = CheckState.Checked Then
            FClose = True
            AdjustToken()       'Getting Permission
            ExitWindowsEx(EWX_SHUTDOWN, Nothing)
        ElseIf OneClick.CheckState = CheckState.Unchecked Then
            MRes = MsgBox("Are you sure to shutdown system?", vbQuestion + vbYesNo, "Shutdown Approval")
            If MRes = vbYes Then
                FClose = True
                AdjustToken()       'Getting Permission
                ExitWindowsEx(EWX_SHUTDOWN, Nothing)
            End If
        End If
    End Sub

    Private Sub sysRStart_Click(sender As Object, e As EventArgs) Handles sysRStart.Click
        If OneClick.CheckState = CheckState.Checked Then
            FClose = True
            AdjustToken()       'Getting Permission
            ExitWindowsEx(EWX_REBOOT, Nothing)
        ElseIf OneClick.CheckState = CheckState.Unchecked Then
            MRes = MsgBox("Are you sure to restart system?", vbQuestion + vbYesNo, "Restart Approval")
            If MRes = vbYes Then
                FClose = True
                AdjustToken()       'Getting Permission
                ExitWindowsEx(EWX_REBOOT, Nothing)
            End If
        End If
    End Sub

    Private Sub sysHibernate_Click(sender As Object, e As EventArgs) Handles sysHibernate.Click
        If OneClick.CheckState = CheckState.Checked Then
            FClose = True
            Application.SetSuspendState(PowerState.Hibernate, True, True)
        ElseIf OneClick.CheckState = CheckState.Unchecked Then
            MRes = MsgBox("Are you sure to hibernate the system in current stat?", vbQuestion + vbYesNo, "Hibernation Approval")
            If MRes = vbYes Then
                FClose = True
                Application.SetSuspendState(PowerState.Hibernate, True, True)
            End If
        End If
    End Sub

    Private Sub sysSleep_Click(sender As Object, e As EventArgs) Handles sysSleep.Click
        If OneClick.CheckState = CheckState.Checked Then
            FClose = True
            Application.SetSuspendState(PowerState.Suspend, True, True)
        ElseIf OneClick.CheckState = CheckState.Unchecked Then
            MRes = MsgBox("Are you sure to send system in sleep mode?", vbQuestion + vbYesNo, "Sleep Mode Approval")
            If MRes = vbYes Then
                FClose = True
                Application.SetSuspendState(PowerState.Suspend, True, True)
            End If
        End If
    End Sub

    Private Sub sysLOff_Click(sender As Object, e As EventArgs) Handles sysLOff.Click
        If OneClick.CheckState = CheckState.Checked Then
            FClose = True
            AdjustToken()       'Getting Permission
            ExitWindowsEx(EWX_LOGOFF, Nothing)
        ElseIf OneClick.CheckState = CheckState.Unchecked Then
            MRes = MsgBox("Are you sure to log off system?", vbQuestion + vbYesNo, "Log Off Approval")
            If MRes = vbYes Then
                FClose = True
                AdjustToken()       'Getting Permission
                ExitWindowsEx(EWX_LOGOFF, Nothing)
            End If
        End If
    End Sub

    Private Sub sysSchedule_Click(sender As Object, e As EventArgs) Handles sysSchedule.Click
        Me.FormBorderStyle = FormBorderStyle.None
        OneClick.Visible = False
        OneClick.Checked = True
        Label7.Visible = False
        Panel1.Visible = True
    End Sub

    Private Sub OneClick_CheckedChanged(sender As Object, e As EventArgs) Handles OneClick.CheckedChanged
        If OneClick.CheckState = CheckState.Checked Then
            TT.SetToolTip(OneClick, "Confirmation not required." + vbNewLine + "Single click feature enabled.")
            OneClick.Text = "One Click Enabled"
            Label7.Visible = True
            OneClick.ForeColor = Color.Green
        ElseIf OneClick.CheckState = CheckState.Unchecked Then
            TT.SetToolTip(OneClick, "Confirmation required before using features.")
            OneClick.Text = "One Click Disabled"
            Label7.Visible = False
            OneClick.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub sysTOff_MouseHover(sender As Object, e As EventArgs) Handles sysTOff.MouseHover
        Me.BackColor = Color.Firebrick
        sysTOff.BorderStyle = BorderStyle.FixedSingle
        BtnTips.Text = "Shutdown"
        BtnTips.Visible = True
    End Sub

    Private Sub sysTOff_MouseLeave(sender As Object, e As EventArgs) Handles sysTOff.MouseLeave
        Me.BackColor = Color.DarkSeaGreen
        sysTOff.BorderStyle = BorderStyle.None
        BtnTips.Visible = False
    End Sub

    Private Sub sysRStart_MouseHover(sender As Object, e As EventArgs) Handles sysRStart.MouseHover
        Me.BackColor = Color.Gold
        sysRStart.BorderStyle = BorderStyle.FixedSingle
        BtnTips.Text = "Restart"
        BtnTips.Visible = True
    End Sub

    Private Sub sysRStart_MouseLeave(sender As Object, e As EventArgs) Handles sysRStart.MouseLeave
        Me.BackColor = Color.DarkSeaGreen
        sysRStart.BorderStyle = BorderStyle.None
        BtnTips.Visible = False
    End Sub

    Private Sub sysSleep_MouseHover(sender As Object, e As EventArgs) Handles sysSleep.MouseHover
        Me.BackColor = Color.Teal
        sysSleep.BorderStyle = BorderStyle.FixedSingle
        BtnTips.Text = "Sleep Mode"
        BtnTips.Visible = True
    End Sub

    Private Sub sysSleep_MouseLeave(sender As Object, e As EventArgs) Handles sysSleep.MouseLeave
        Me.BackColor = Color.DarkSeaGreen
        sysSleep.BorderStyle = BorderStyle.None
        BtnTips.Visible = False
    End Sub

    Private Sub sysLOff_MouseHover(sender As Object, e As EventArgs) Handles sysLOff.MouseHover
        Me.BackColor = Color.Maroon
        sysLOff.BorderStyle = BorderStyle.FixedSingle
        BtnTips.Text = "Log Off"
        BtnTips.Visible = True
    End Sub

    Private Sub sysLOff_MouseLeave(sender As Object, e As EventArgs) Handles sysLOff.MouseLeave
        Me.BackColor = Color.DarkSeaGreen
        sysLOff.BorderStyle = BorderStyle.None
        BtnTips.Visible = False
    End Sub

    Private Sub sysHibernate_MouseHover(sender As Object, e As EventArgs) Handles sysHibernate.MouseHover
        Me.BackColor = Color.SlateGray
        sysHibernate.BorderStyle = BorderStyle.FixedSingle
        BtnTips.Text = "Hibernation"
        BtnTips.Visible = True
        AlertViewer.Text = "This feature may work on laptops only"
        AlertViewer.Visible = True
    End Sub

    Private Sub sysHibernate_MouseLeave(sender As Object, e As EventArgs) Handles sysHibernate.MouseLeave
        Me.BackColor = Color.DarkSeaGreen
        sysHibernate.BorderStyle = BorderStyle.None
        AlertViewer.Visible = False
        BtnTips.Visible = False
    End Sub

    Private Sub sysSchedule_MouseHover(sender As Object, e As EventArgs) Handles sysSchedule.MouseHover
        Me.BackColor = Color.Silver
        sysSchedule.BorderStyle = BorderStyle.FixedSingle
        BtnTips.Text = "Schedule Shutdown"
        BtnTips.Visible = True
    End Sub

    Private Sub sysSchedule_MouseLeave(sender As Object, e As EventArgs) Handles sysSchedule.MouseLeave
        Me.BackColor = Color.DarkSeaGreen
        sysSchedule.BorderStyle = BorderStyle.None
        BtnTips.Visible = False
    End Sub

    Private Sub ActSchedule_Click(sender As Object, e As EventArgs) Handles ActSchedule.Click
        If ComboBox1.SelectedIndex > -1 Then
            If ComboBox1.SelectedIndex = 0 Then
                TimeOut = 301
            ElseIf ComboBox1.SelectedIndex = 1 Then
                TimeOut = 601
            ElseIf ComboBox1.SelectedIndex = 2 Then
                TimeOut = 1801
            ElseIf ComboBox1.SelectedIndex = 3 Then
                TimeOut = 3601
            ElseIf ComboBox1.SelectedIndex = 4 Then
                TimeOut = 7201
            ElseIf ComboBox1.SelectedIndex = 5 Then
                TimeOut = 10801
            ElseIf ComboBox1.SelectedIndex = 6 Then
                TimeOut = 18001
            End If
            Countdown.Enabled = True
            Label3.Visible = False
            ComboBox1.Visible = False
            ActSchedule.Visible = False
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Label5.Visible = True
            Label4.Visible = False
        Else
            MsgBox("Oops! Time is needed to use schedule shutdown feature.", vbInformation, "System Utility Alert")
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub Countdown_Tick(sender As Object, e As EventArgs) Handles Countdown.Tick
        If TimeOut = 301 And Label1.Text = "Label1" Then
            Label1.Text = TimeOut
            Label6.Text = "5 Minutes"
            Label1.Visible = True
            Label2.Visible = True
            Label6.Visible = True
        ElseIf TimeOut = 601 And Label1.Text = "Label1" Then
            Label1.Text = TimeOut
            Label6.Text = "10 Minutes"
            Label1.Visible = True
            Label2.Visible = True
            Label6.Visible = True
        ElseIf TimeOut = 1801 And Label1.Text = "Label1" Then
            Label1.Text = TimeOut
            Label6.Text = "30 Minutes"
            Label1.Visible = True
            Label2.Visible = True
            Label6.Visible = True
        ElseIf TimeOut = 3601 And Label1.Text = "Label1" Then
            Label1.Text = TimeOut
            Label6.Text = "1 Hour"
            Label1.Visible = True
            Label2.Visible = True
            Label6.Visible = True
        ElseIf TimeOut = 7201 And Label1.Text = "Label1" Then
            Label1.Text = TimeOut
            Label6.Text = "2 Hours"
            Label1.Visible = True
            Label2.Visible = True
            Label6.Visible = True
        ElseIf TimeOut = 10801 And Label1.Text = "Label1" Then
            Label1.Text = TimeOut
            Label6.Text = "3 Hours"
            Label1.Visible = True
            Label2.Visible = True
            Label6.Visible = True
        ElseIf TimeOut = 18001 And Label1.Text = "Label1" Then
            Label1.Text = TimeOut
            Label6.Text = "5 Hours"
            Label1.Visible = True
            Label2.Visible = True
            Label6.Visible = True
        End If
        If Label1.Text = 0 Then

            sysTOff_Click(sender, e)
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(1500)
    End Sub

    Private Sub MaximizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaximizeToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Dim res As Integer
        res = MsgBox("Do you wish to stop schedule shutdown and quit System Utility?", vbQuestion + vbYesNo, "Quit Confirmation")
        If res = vbYes Then
            FClose = True
            Me.Close()
        End If
    End Sub

    Private Sub AlertViewer_Click(sender As Object, e As EventArgs) Handles AlertViewer.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        OneClick.CheckState = CheckState.Unchecked
        OneClick.Visible = True
        Panel1.Hide()
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.ForeColor = Color.Maroon
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Red
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If FClose = False Then
            If Countdown.Enabled = True Then
                Dim Temp As Integer
                Me.TopMost = False
                Temp = MsgBox("Schedule shutdown feature is currently running in your system." + vbNewLine + "Do you wish to stop service and close this application?", vbYesNo + vbCritical, "System Utility")
                If Temp = vbYes Then
                    Countdown.Enabled = False
                    e.Cancel = False
                Else
                    Me.TopMost = True
                    e.Cancel = True
                End If
            End If
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MRes = MsgBox("Do you wish to stop schedule shutdown feature?", vbQuestion + vbYesNo, "System Utility Alert")
        If MRes = vbYes Then
            frmSupport.Close()
            FClose = True
            Application.Restart()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MRes = MsgBox("Do you wish to reschedule shutdown feature?", vbQuestion + vbYesNo, "System Utility Alert")
        If MRes = vbYes Then
            Label1.Text = "Label1"
            Countdown.Enabled = False
            ComboBox1.SelectedIndex = -1
            ComboBox1.Visible = True
            ActSchedule.Visible = True
            Label5.Visible = False
            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = True
            Button1.Visible = False
            Button2.Visible = False
            Button3.Visible = False
            Label6.Visible = False
            Label4.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs) Handles NotifyIcon1.BalloonTipClicked
        frmSupport.Show()
    End Sub

    Private Sub SupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportToolStripMenuItem.Click
        frmSupport.Show()
    End Sub

End Class
