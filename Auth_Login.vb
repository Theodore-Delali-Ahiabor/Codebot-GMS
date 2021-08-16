Public Class Auth_Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_login_username.Text <> "" And txt_login_password.Text <> "" Then
            If txt_login_username.Text.Contains("'") Then
                Auth.btn_auth_message.Text = "Unexpeted Character ' in username"
                txt_login_username.Focus()
                message(Auth.btn_auth_message, "warning")
            Else
                Codebot_GMS_Module.login()
            End If
        ElseIf txt_login_username.Text = "" Then
            txt_login_username.Focus()
            Auth.btn_auth_message.Text = "Username Feild is Empty"
            Auth.btn_auth_message.Show()
            message(Auth.btn_auth_message, "warning")
        ElseIf txt_login_password.Text = "" Then
            txt_login_password.Focus()
            Auth.btn_auth_message.Text = "Password Feild is Empty"
            Auth.btn_auth_message.Show()
            message(Auth.btn_auth_message, "warning")
        End If

    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click
        txt_login_username.Clear()
        txt_login_password.Clear()
        Auth_Signup.txt_signup_phone.Clear()
        Auth_Signup.txt_signup_phone.Focus()
        Auth_Signup.txt_signup_username.Clear()
        Auth_Signup.txt_signup_password.Clear()
        Auth_Signup.txt_signup_confirm_password.Clear()
        Auth_Signup.txt_signup_phone.Enabled = True
        Auth_Signup.txt_signup_username.Enabled = False
        Auth_Signup.txt_signup_password.Enabled = False
        Auth_Signup.txt_signup_confirm_password.Enabled = False
        Auth_Signup.signup_middle_panel.Visible = False
        auth_form_loader(Auth_Signup)
        Auth_Signup.btn_signup_verify_create.Text = "VERIFY"
    End Sub

    Private Sub lbl_password_reset_Click(sender As Object, e As EventArgs) Handles lbl_password_reset.Click
        auth_form_loader(Auth_Password_Reset)
        Auth_Password_Reset.btn_password_reset_reset.Enabled = False
        Auth_Password_Reset.btn_password_reset_send_code.Enabled = True
        Auth_Password_Reset.btn_password_reset_send_code.Text = "SEND CODE"
        Auth_Password_Reset.txt_password_reset_phone_number.Enabled = True
        Auth_Password_Reset.txt_password_reset_phone_number.Focus()
    End Sub
End Class