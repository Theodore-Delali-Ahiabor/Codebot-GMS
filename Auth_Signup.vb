Imports MySql.Data.MySqlClient
Public Class Auth_Signup
    Private Sub btn_signup_verify_create_Click(sender As Object, e As EventArgs) Handles btn_signup_verify_create.Click
        If btn_signup_verify_create.Text = "VERIFY" Then
            'check if the user is permited to signup to signup 
            If txt_signup_phone.Text <> "" And IsNumeric(txt_signup_phone.Text) Then
                Try
                    'sql_con.Close()
                    'sql_con.Open()
                    sql_da = New MySqlDataAdapter("SELECT * FROM employee WHERE Phone = '" & CInt(txt_signup_phone.Text) & "'", sql_con)
                    sql_dt = New DataTable
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() = 1 Then
                        signup_id = sql_dt.Rows(0).Item("ID").ToString()
                        signup_name = sql_dt.Rows(0).Item("First_Name") & " " & sql_dt.Rows(0).Item("Last_Name")
                        'sql_con.Close()
                        'sql_con.Open()
                        sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Employee_ID = '" & signup_id & "'", sql_con)
                        sql_dt = New DataTable
                        sql_dt.Clear()
                        sql_da.Fill(sql_dt)
                        If sql_dt.Rows.Count() <= 0 Then
                            Auth.btn_auth_message.Text = "Welcome '" & signup_name & "'. Continue Signup"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "information")
                            signup_middle_panel.Visible = True
                            txt_signup_phone.Enabled = False
                            txt_signup_username.Focus()
                            txt_signup_username.Enabled = True
                            txt_signup_password.Enabled = True
                            txt_signup_confirm_password.Enabled = True
                            btn_signup_verify_create.Text = "CREATE"
                        ElseIf sql_dt.Rows.Count() > 0 And sql_dt.Rows(0).Item("Username") = "" And sql_dt.Rows(0).Item("Password") = "" Then
                            Auth.btn_auth_message.Text = "Welcome '" & signup_name & "'. Continue Signup"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "information")
                            signup_middle_panel.Visible = True
                            txt_signup_phone.Enabled = False
                            txt_signup_username.Focus()
                            txt_signup_username.Enabled = True
                            txt_signup_password.Enabled = True
                            txt_signup_confirm_password.Enabled = True
                            btn_signup_verify_create.Text = "CONTINUE"

                        Else
                            Auth.btn_auth_message.Text = "User already Signed Up"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")
                        End If
                    Else
                        Auth.btn_auth_message.Text = "Signup not Authorized for this Employee"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            ElseIf txt_signup_phone.Text = "" Then
                txt_signup_phone.Focus()
                Auth.btn_auth_message.Text = "Phone Number Field is Required"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning")
            Else
                txt_signup_phone.Focus()
                Auth.btn_auth_message.Text = "Invalid input, Numeric Values Only"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning")
            End If

        ElseIf btn_signup_verify_create.Text = "CREATE" Then
            'check if the details are valid then add user
            If txt_signup_phone.Text <> "" And txt_signup_username.Text <> "" And txt_signup_password.Text <> "" And txt_signup_confirm_password.Text <> "" Then
                Try
                    'sql_con.Close()
                    'sql_con.Open()
                    sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & txt_signup_username.Text & "'", sql_con)
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() <= 0 Then
                        If StrComp(txt_signup_password.Text, txt_signup_confirm_password.Text, CompareMethod.Binary) Then
                            Auth.btn_auth_message.Text = "Passwords Did NOT Match"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")

                        Else
                            Dim repos As DialogResult = MessageBox.Show("You are about to Signup with Username '" & txt_signup_username.Text.ToString() & "', are you sure to continue ?", "Signup", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            If repos = DialogResult.Yes Then
                                sql_ds = New DataSet
                                sql_da = New MySqlDataAdapter("INSERT INTO user(Employee_ID,Username,Password)
                            VALUES('" & signup_id & "', '" & txt_signup_username.Text.ToString() & "', '" & txt_signup_confirm_password.Text.ToString() & "')", sql_con)
                                sql_da.Fill(sql_ds, "user")
                                auth_form_loader(Auth_Login)
                            End If
                        End If
                    Else
                        Auth.btn_auth_message.Text = "Username Is Occupied. Emter New"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                txt_signup_phone.Focus()
                Auth.btn_auth_message.Text = " Please Fill Out All Required * Fields"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning")
            End If
        ElseIf btn_signup_verify_create.Text = "CONTINUE" Then
            'check if the details are valid then add user
            If txt_signup_phone.Text <> "" And txt_signup_username.Text <> "" And txt_signup_password.Text <> "" And txt_signup_confirm_password.Text <> "" Then
                Try
                    'sql_con.Close()
                    'sql_con.Open()
                    sql_da = New MySqlDataAdapter("SELECT * FROM user WHERE Username = '" & txt_signup_username.Text & "'", sql_con)
                    sql_dt.Clear()
                    sql_da.Fill(sql_dt)
                    If sql_dt.Rows.Count() <= 0 Then
                        If StrComp(txt_signup_password.Text, txt_signup_confirm_password.Text, CompareMethod.Binary) Then
                            Auth.btn_auth_message.Text = "Passwords Did NOT Match"
                            Auth.btn_auth_message.Show()
                            message(Auth.btn_auth_message, "warning")

                        Else
                            Dim repos As DialogResult = MessageBox.Show("You are about to Signup with Username '" & txt_signup_username.Text.ToString() & "', are you sure to continue ?", "Signup", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                            If repos = DialogResult.Yes Then
                                sql_ds = New DataSet
                                sql_da = New MySqlDataAdapter("UPDATE user SET Username = '" & txt_signup_username.Text.ToString() & "', Password = '" & txt_signup_confirm_password.Text.ToString() & "' WHERE Employee_ID = '" & signup_id & "' ", sql_con)
                                sql_da.Fill(sql_ds, "user")
                                auth_form_loader(Auth_Login)
                            End If
                        End If
                    Else
                        Auth.btn_auth_message.Text = "Username Is Unavailable. Enter New"
                        Auth.btn_auth_message.Show()
                        message(Auth.btn_auth_message, "warning")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                txt_signup_phone.Focus()
                Auth.btn_auth_message.Text = " Please Fill Out All Required * Fields"
                Auth.btn_auth_message.Show()
                message(Auth.btn_auth_message, "warning")
            End If
        End If
    End Sub

    Private Sub btn_signup_cancel_Click(sender As Object, e As EventArgs) Handles btn_signup_cancel.Click
        auth_form_loader(Auth_Login)
    End Sub

End Class