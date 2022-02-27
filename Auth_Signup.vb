Imports MySql.Data.MySqlClient
Public Class Auth_Signup
    Private Sub btn_signup_verify_create_Click(sender As Object, e As EventArgs) Handles btn_signup_verify_create.Click
        If btn_signup_verify_create.Text = "VERIFY" Then
            'check if the user is permited to signup to signup 
            If txt_signup_email.Text <> "" Then
                If txt_signup_email.Text.Contains("'") Then
                    message("error", "Unexpected sign ' in email") '
                    txt_signup_email.Focus()
                Else
                    If txt_signup_email.Text.Contains("@") And txt_signup_email.Text.Contains(".") Then
                        Try
                            sql_da = New MySqlDataAdapter("SELECT * FROM employee WHERE Email = '" & txt_signup_email.Text & "'", sql_con)
                            sql_dt = New DataTable
                            sql_dt.Clear()
                            sql_da.Fill(sql_dt)
                            If sql_dt.Rows.Count() = 1 Then
                                signup_id = sql_dt.Rows(0).Item("ID").ToString()
                                signup_name = sql_dt.Rows(0).Item("First_Name") & " " & sql_dt.Rows(0).Item("Last_Name")
                                sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Employee_ID = '" & signup_id & "'", sql_con)
                                sql_dt = New DataTable
                                sql_dt.Clear()
                                sql_da.Fill(sql_dt)
                                If sql_dt.Rows.Count() <= 0 Then
                                    message("information", "Hi '" & signup_name & "'. Continue Signup")
                                    signup_middle_panel.Visible = True
                                    txt_signup_email.Enabled = False
                                    txt_signup_username.Focus()
                                    txt_signup_username.Enabled = True
                                    txt_signup_password.Enabled = True
                                    signup_notice_panel.Visible = False
                                    btn_signup_verify_create.Text = "SIGNUP"
                                ElseIf sql_dt.Rows.Count() > 0 And sql_dt.Rows(0).Item("Username") = "" And sql_dt.Rows(0).Item("Password") = "" Then
                                    message("information", "Welcome '" & signup_name & "'. Continue Reset")
                                    signup_middle_panel.Visible = True
                                    txt_signup_email.Enabled = False
                                    txt_signup_username.Focus()
                                    txt_signup_username.Enabled = True
                                    txt_signup_password.Enabled = True
                                    signup_notice_panel.Visible = False
                                    btn_signup_verify_create.Text = "RESET"
                                Else
                                    message("error", "Employee already signed up")
                                End If
                            Else
                                message("warning", "Signup not authorized for this employee")
                            End If
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Employee Verification Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    Else
                        message("error", "Enter a valid email address") '
                        txt_signup_email.Focus()
                    End If
                End If
            Else
                message("warning", "Email address field is empty")
                txt_signup_email.Focus()
            End If
        ElseIf btn_signup_verify_create.Text = "SIGNUP" Then
            'check if the details are valid then add user
            If txt_signup_email.Text <> "" And txt_signup_username.Text <> "" And txt_signup_password.Text <> "" And txt_signup_confirm_password.Text <> "" Then
                Try
                    sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & txt_signup_username.Text & "'", sql_con)
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() <= 0 Then
                        If StrComp(txt_signup_password.Text, txt_signup_confirm_password.Text, CompareMethod.Binary) Then
                            message("warning", "Passwords Did NOT Match")
                        Else
                            Dim repos As DialogResult = MessageBox.Show("You are about to Signup with Username '" & txt_signup_username.Text.ToString() & "', are you sure to continue ?", "Signup", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            If repos = DialogResult.Yes Then
                                sql_ds = New DataSet
                                sql_da = New MySqlDataAdapter("INSERT INTO user(Employee_ID,Username,Password,`Created_On`,`Last_Updated`)
                            VALUES('" & signup_id & "', '" & txt_signup_username.Text.ToString() & "', '" & Encoding(txt_signup_confirm_password.Text.ToString()) & "','" & Date.UtcNow & "','" & Date.UtcNow & "')", sql_con)
                                sql_da.Fill(sql_ds, "user")
                                auth_form_loader(Auth_Login)
                                message("susccess", "You have sucessfully created a user account. You can now Login")
                            End If
                        End If
                    Else
                        message("warning", "Username Is Occupied. Emter New")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "SignUp Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                txt_signup_email.Focus()
                message("warning", " Please Fill Out All Required * Fields")
            End If
        ElseIf btn_signup_verify_create.Text = "RESET" Then
            'check if the details are valid then add user
            If txt_signup_email.Text <> "" And txt_signup_username.Text <> "" And txt_signup_password.Text <> "" And txt_signup_confirm_password.Text <> "" Then
                Try
                    sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & txt_signup_username.Text & "'", sql_con)
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() <= 0 Then
                        If StrComp(txt_signup_password.Text, txt_signup_confirm_password.Text, CompareMethod.Binary) Then
                            message("warning", "Passwords Did NOT Match")
                        Else
                            Dim repos As DialogResult = MessageBox.Show("You are about to Signup with Username '" & txt_signup_username.Text.ToString() & "', are you sure to continue ?", "Signup", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            If repos = DialogResult.Yes Then
                                sql_ds = New DataSet
                                sql_da = New MySqlDataAdapter("UPDATE user SET `Username` = '" & txt_signup_username.Text.ToString() & "', `Password` = '" & Encoding(txt_signup_confirm_password.Text.ToString()) & "', `Last_Updated`='" & Date.UtcNow & "' WHERE `Employee_ID` = '" & Auth_Password_Reset.reset_id & "' ", sql_con)
                                sql_da.Fill(sql_ds, "user")
                                auth_form_loader(Auth_Login)
                                message("susccess", "You have sucessfully reset your  login. You can now Login")
                            End If
                        End If
                    Else
                        message("error", "Username is occupied. Enter different username")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Username Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                txt_signup_email.Focus()
                message("warning", "Please Fill Out All Required * Fields")
            End If
        End If
    End Sub

    Private Sub btn_signup_cancel_Click(sender As Object, e As EventArgs) Handles btn_signup_cancel.Click
        auth_form_loader(Auth_Login)
    End Sub

    Private Sub txt_signup_password_TextChanged(sender As Object, e As EventArgs) Handles txt_signup_password.TextChanged
        If txt_signup_password.TextLength > 7 Then
            signup_validate_8_chars.Image = signup_valid.Image
        Else
            signup_validate_8_chars.Image = signup_invalid.Image
        End If


        Dim symbols() = {"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "-", "=", "+", "{", "[", "}", "]", "\", "|", ":", ";", "<", ">", "?", "/"}
        Dim symbol_count As Integer = 0
        For Each symbol In symbols
            'Checking for the occurance of any of the symbols in the text
            If txt_signup_password.Text.Contains(symbol) Then
                symbol_count += 1
            End If

            If symbol_count > 0 Then
                signup_validate_symbol.Image = signup_valid.Image
            Else
                signup_validate_symbol.Image = signup_invalid.Image
            End If
        Next

        Dim numbers() = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}
        Dim number_count As Integer = 0
        For Each number In numbers
            'checking for the occurance of a numeric value in the text
            If txt_signup_password.Text.Contains(number.ToString) Then
                number_count += 1
            End If

            If number_count > 0 Then
                signup_validate_num.Image = signup_valid.Image
            Else
                signup_validate_num.Image = signup_invalid.Image
            End If
        Next


        If signup_validate_8_chars.Image Is signup_valid.Image And signup_validate_symbol.Image Is signup_valid.Image And signup_validate_num.Image Is signup_valid.Image Then
            txt_signup_confirm_password.Enabled = True
        Else
            txt_signup_confirm_password.Enabled = False
        End If
    End Sub
End Class