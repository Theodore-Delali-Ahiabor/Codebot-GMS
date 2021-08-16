Public Class Auth
    Public Sub Auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auth_form_loader(Auth_Login)
        Auth_Login.txt_login_password.Clear()
        Auth_Login.txt_login_username.Clear()
    End Sub
    Private Sub message_timer_Tick(sender As Object, e As EventArgs) Handles message_timer.Tick
        If message_ts.Seconds = 0 Then
            btn_auth_message.Hide()
            Management.btn_management_message.Hide()
            message_timer.Stop()
        Else
            message_ts = message_ts.Subtract(New TimeSpan(0, 0, 1))
        End If
    End Sub
    Private Sub btn_auth_message_Click(sender As Object, e As EventArgs) Handles btn_auth_message.Click
        btn_auth_message.Hide()
    End Sub

End Class