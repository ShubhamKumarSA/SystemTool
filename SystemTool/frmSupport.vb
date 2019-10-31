Public Class frmSupport
    Public dir As String = My.Application.Info.DirectoryPath
    Public LapTime As Integer

    Private Sub frmSupport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        rdTimer.Enabled = True
        WebBrowser.Url = New Uri(dir + "\Test.html")
    End Sub

    Private Sub Welcome_MouseClick(sender As Object, e As MouseEventArgs) Handles Welcome.MouseClick
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Welcome.Visible = False
    End Sub

    Private Sub rdTimer_Tick(sender As Object, e As EventArgs) Handles rdTimer.Tick
        LapTime = LapTime + 1
        If (LapTime >= 2) Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Welcome.Visible = False
        End If
    End Sub
End Class