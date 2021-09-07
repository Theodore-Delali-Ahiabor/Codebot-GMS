Imports MySql.Data.MySqlClient
Public Class Management_Employees_Add_New
    Dim married, active As Byte
    Dim birth_date As String
    Private Sub btn_new_user_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_user_cancel.Click
        sidebar_form_loader(Management_Employees)
        Management.lbl_current_tab.Text = "Employees"
    End Sub

    Private Sub btn_new_user_select_image_Click(sender As Object, e As EventArgs) Handles btn_new_user_select_image.Click

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
            If btn_new_user_save.Text = "UPDATE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Update info @ ID '" & Management_Employees.EmployeesDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("UPDATE employee SET First_Name = '" & txt_new_first_name.Text & "', Other_Name = '" & txt_new_other_names.Text & "',
                            Last_Name = '" & txt_new_last_name.Text & "', Email = '" & txt_new_email.Text & "', Physical_Address_Area = '" & txt_new_physical_address.Text & "',
                            Role = '" & txt_new_position.Text & "', Gender = '" & txt_new_gender.Text & "', Phone = '" & txt_new_number.Text & "',
                            Married = '" & married & "', Active = '" & active & "' , Salary_GHC = '" & txt_new_salary.Text & "',`Birth_Date` = '" & birth_date & "'
                            Where ID = '" & txt_new_id.Text & "'", sql_con)
                    sql_da.Fill(sql_ds, "employee")
                    sidebar_form_loader(Management_Employees)
                    datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)
                End If
            ElseIf btn_new_user_save.Text = "SAVE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Employee with ID '" & txt_new_id.Text & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO employee(First_Name,Other_Name,Last_Name,Email,Physical_Address_Area,Role,Gender,Phone,Married,Active,Salary_GHC,ID,Birth_Date)
                            VALUES('" & txt_new_first_name.Text & "', '" & txt_new_other_names.Text & "', '" & txt_new_last_name.Text & "', '" & txt_new_email.Text & "',
                             '" & txt_new_physical_address.Text & "', '" & txt_new_position.Text & "', '" & txt_new_gender.Text & "', '" & txt_new_number.Text & "',
                            '" & married & "', '" & active & "', '" & txt_new_salary.Text & "', '" & txt_new_id.Text & "', '" & birth_date & "'
                            )", sql_con)
                    ','" & txt_new_birth_date.Value.ToShortDateString & "'
                    sql_da.Fill(sql_ds, "employee")
                    sidebar_form_loader(Management_Employees)
                    datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)
                End If
            Else
                MsgBox("Nothing to Do")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class