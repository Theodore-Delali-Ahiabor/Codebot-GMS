Imports MySql.Data.MySqlClient
Public Class Management_Employees_Add_New
    Dim married, active As Byte
    Dim birth_date As String
    Private Sub btn_new_user_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_user_cancel.Click
        sidebar_form_loader(Management_Employees)
        Management.lbl_current_tab.Text = "Employees"
    End Sub

    Private Sub btn_new_user_select_image_Click(sender As Object, e As EventArgs) Handles btn_new_user_select_image.Click
        Try
            With open_image_file_dialog

                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True

                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True

                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"

                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False

                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        pb_new_user_image.BackgroundImage = Image.FromFile(open_image_file_dialog.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Image Selection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub employee_clear_image_Click(sender As Object, e As EventArgs) Handles employee_clear_image.Click
        pb_new_user_image.BackgroundImage = pb_new_user_image.InitialImage
    End Sub

    Private Sub btn_new_user_save_Click(sender As Object, e As EventArgs) Handles btn_new_user_save.Click
        birth_date = CStr(txt_new_birth_date.Value.Year) + "-" + CStr(txt_new_birth_date.Value.Month) + "-" + CStr(txt_new_birth_date.Value.Day)
        Try
            If txt_new_married.Text = "Yes" Then
                married = 1
            Else
                married = 0
            End If
            If txt_new_active.Text = "Yes" Then
                active = 1
            Else
                active = 0
            End If

            Dim mstream As New IO.MemoryStream()
            'SPECIFIES THE FILE FORMAT OF THE IMAGE
            pb_new_user_image.BackgroundImage.Save(mstream, Imaging.ImageFormat.Jpeg)

            'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
            arr_image = mstream.GetBuffer()
            Dim FileSize As UInt32
            FileSize = mstream.Length
            If FileSize < 15000 Then
                If btn_new_user_save.Text = "UPDATE" Then
                    Dim repos As DialogResult = MessageBox.Show("You are about to Update info @ ID '" & Management_Employees.EmployeesDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        mstream.Close()
                        sql_con.Close()
                        sql_con.Open()
                        sql_stmt = "UPDATE employee SET `First_Name` = @fname, `Other_Name` = @onames,`Last_Name` = @lname, `Email` = @email, `Physical_Address_Area` = @paddress,
                            `Role` = @role, `Gender` = @gender, `Phone` = @phone, `Image` = @Image,`Married` = @married, `Active` = @active, `Salary_GHC` = @salary,`Birth_Date` = @bday
                            Where ID = @id"
                        sql_cmd = New MySqlCommand
                        With sql_cmd
                            .Connection = sql_con
                            .CommandText = sql_stmt
                            .Parameters.AddWithValue("@Image", arr_image)
                            .Parameters.AddWithValue("@fname", txt_new_first_name.Text)
                            .Parameters.AddWithValue("@onames", txt_new_other_names.Text)
                            .Parameters.AddWithValue("@lname", txt_new_last_name.Text)
                            .Parameters.AddWithValue("@email", txt_new_email.Text)
                            .Parameters.AddWithValue("@paddress", txt_new_physical_address.Text)
                            .Parameters.AddWithValue("@role", txt_new_position.Text)
                            .Parameters.AddWithValue("@gender", txt_new_gender.Text)
                            .Parameters.AddWithValue("@phone", txt_new_number.Text)
                            .Parameters.AddWithValue("@married", married)
                            .Parameters.AddWithValue("@active", active)
                            .Parameters.AddWithValue("@salary", txt_new_salary.Text)
                            .Parameters.AddWithValue("@id", txt_new_id.Text)
                            .Parameters.AddWithValue("@bday", birth_date)
                        End With
                        If sql_cmd.ExecuteNonQuery > 0 Then
                            sidebar_form_loader(Management_Employees)
                            datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)

                            Management.btn_management_message.Text = "Employee Details Updated Successfully"
                            Management.btn_management_message.Show()
                            message(Management.btn_management_message, "success")
                        Else
                            MsgBox("Error query", MsgBoxStyle.Exclamation)
                        End If

                        sidebar_form_loader(Management_Employees)
                        datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)
                    End If
                ElseIf btn_new_user_save.Text = "SAVE" Then
                    Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Employee with ID '" & txt_new_id.Text & "', are you sure to continue ?", "Saving new employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        mstream.Close()
                        sql_con.Close()
                        sql_con.Open()
                        sql_stmt = "INSERT INTO  `employee` (`First_Name`,`Other_Name`,`Last_Name`,`Email`,`Physical_Address_Area`,`Role`,`Gender`,`Phone`,`Married`,`Active`,`Salary_GHC`,`ID`,`Birth_Date`)
                    VALUES (@Image,@fname,@onames,@lname,@email,@paddress,@role,@gender,@phone,@married,@active,@salary,@id,@bday)"
                        sql_cmd = New MySqlCommand
                        With sql_cmd
                            .Connection = sql_con
                            .CommandText = sql_stmt
                            .Parameters.AddWithValue("@Image", arr_image)
                            .Parameters.AddWithValue("@fname", txt_new_first_name.Text)
                            .Parameters.AddWithValue("@onames", txt_new_other_names.Text)
                            .Parameters.AddWithValue("@lname", txt_new_last_name.Text)
                            .Parameters.AddWithValue("@email", txt_new_email.Text)
                            .Parameters.AddWithValue("@paddress", txt_new_physical_address.Text)
                            .Parameters.AddWithValue("@role", txt_new_position.Text)
                            .Parameters.AddWithValue("@gender", txt_new_gender.Text)
                            .Parameters.AddWithValue("@phone", txt_new_number.Text)
                            .Parameters.AddWithValue("@married", married)
                            .Parameters.AddWithValue("@active", active)
                            .Parameters.AddWithValue("@salary", txt_new_salary.Text)
                            .Parameters.AddWithValue("@id", txt_new_id.Text)
                            .Parameters.AddWithValue("@bday", birth_date)
                        End With
                        If sql_cmd.ExecuteNonQuery > 0 Then
                            sidebar_form_loader(Management_Employees)
                            datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)

                            Management.btn_management_message.Text = "New Employee Added Successfully"
                            Management.btn_management_message.Show()
                            message(Management.btn_management_message, "success")
                        Else
                            MsgBox("Error query", MsgBoxStyle.Exclamation)
                        End If

                    End If
                End If
            Else
                MessageBox.Show("The Image file selected has exceeded the file size limit of 10Kilobytes (Width=110, hight=147). Resize the file or choose a diferent file.", "Invalid File Size", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                btn_new_user_select_image_Click(btn_new_user_select_image, EventArgs.Empty)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save New Employee Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Finally
            sql_con.Close()
        End Try
    End Sub
End Class