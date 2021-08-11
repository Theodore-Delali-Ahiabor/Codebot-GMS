Public Class Auth
    Dim message_ts As TimeSpan
    Public Sub Auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auth_form_loader(Auth_Login)
        Auth_Login.txt_login_password.Clear()
        Auth_Login.txt_login_username.Clear()
    End Sub
    Private Sub auth_message_timer_Tick(sender As Object, e As EventArgs) Handles auth_message_timer.Tick
        If message_ts.Seconds = 0 Then
            btn_message.Hide()
            auth_message_timer.Stop()
        Else
            message_ts = message_ts.Subtract(New TimeSpan(0, 0, 1))
        End If
    End Sub
    Private Sub btn_message_Click(sender As Object, e As EventArgs) Handles btn_message.Click
        btn_message.Hide()
    End Sub
    Public Sub message()
        btn_message.Show()
        auth_message_timer.Enabled = True
        message_ts = New TimeSpan(0, 0, 2)
    End Sub
End Class