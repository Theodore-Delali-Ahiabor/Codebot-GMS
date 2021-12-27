Public Class Auth
    Public Sub Auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        auth_form_loader(Auth_Login)
        Auth_Login.txt_login_password.Clear()
        Auth_Login.txt_login_username.Clear()
    End Sub
End Class