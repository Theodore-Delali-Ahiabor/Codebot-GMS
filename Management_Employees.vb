Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Management_Employees
    Dim initial_employee_id As String = "HTU-JMTC0001"
    Dim new_employee_id As String

    Private Sub btn_add_new_employee_Click(sender As Object, e As EventArgs) Handles btn_add_new_employee.Click
        sidebar_form_loader(Management_Employees_Add_New)
        Management.lbl_current_tab.Text = "Employees | Add New User"
        Management_Employees_Add_New.btn_new_user_save.Text = "SAVE"
        employee_new_id()
        add_new_employee_clear()
        Management_Employees_Add_New.txt_new_id.Text = new_employee_id
        Management_Employees_Add_New.txt_new_active.SelectedIndex = 0
    End Sub
    Private Function employee_new_id() As String
        sql_da = New MySqlDataAdapter("SELECT ID FROM employee", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Dim id As Integer = sql_dt.Rows.Count
        Dim integer_part As Integer = CInt(initial_employee_id.Substring(8, 4))
        id += 1
        new_employee_id = initial_employee_id.Substring(0, 8) & id.ToString("0000")
        Return new_employee_id
    End Function

    Private Sub btn_edit_employee_Click(sender As Object, e As EventArgs) Handles btn_edit_employee.Click
        add_new_employee_clear()
        Try
            If EmployeesDataGridView.SelectedRows.Count > 0 Then
                sidebar_form_loader(Management_Employees_Add_New)
                Management.lbl_current_tab.Text = "Employees | Edit User"
                Management_Employees_Add_New.btn_new_user_save.Text = "UPDATE"

                sql_da = New MySqlDataAdapter("SELECT * FROM employee WHERE ID = '" & EmployeesDataGridView.CurrentRow.Cells(0).Value.ToString() & "'", sql_con)
                sql_dt = New DataTable
                sql_dt.Clear()
                sql_da.Fill(sql_dt)
                If sql_dt.Rows.Count() > 0 Then
                    If sql_dt.Rows(0).Item("Image").Equals(DBNull.Value) Then
                        With Management_Employees_Add_New
                            .pb_new_user_image.BackgroundImage = Management_Employees_Add_New.pb_new_user_image.InitialImage
                            .txt_new_id.Text = sql_dt.Rows(0).Item("ID").ToString()
                            .txt_new_first_name.Text = sql_dt.Rows(0).Item("First_Name").ToString()
                            .txt_new_other_names.Text = sql_dt.Rows(0).Item("Other_Name").ToString()
                            .txt_new_last_name.Text = sql_dt.Rows(0).Item("Last_Name").ToString()
                            .txt_new_email.Text = sql_dt.Rows(0).Item("Email").ToString()
                            .txt_new_number.Text = sql_dt.Rows(0).Item("Phone").ToString()
                            .txt_new_physical_address.Text = sql_dt.Rows(0).Item("Physical_Address_Area").ToString()
                            .txt_new_birth_date.Value = CDate(sql_dt.Rows(0).Item("Birth_Date").ToString)
                            .txt_new_position.Text = sql_dt.Rows(0).Item("Role").ToString()
                            .txt_new_salary.Text = sql_dt.Rows(0).Item("Salary_GHC").ToString()
                            .txt_new_gender.Text = sql_dt.Rows(0).Item("Gender").ToString()
                        End With

                    Else
                        arr_image = sql_dt.Rows(0).Item(1)
                        Dim mstream As New MemoryStream(arr_image)
                        With Management_Employees_Add_New
                            .pb_new_user_image.BackgroundImage = Image.FromStream(mstream)
                            .txt_new_id.Text = sql_dt.Rows(0).Item("ID").ToString()
                            .txt_new_first_name.Text = sql_dt.Rows(0).Item("First_Name").ToString()
                            .txt_new_other_names.Text = sql_dt.Rows(0).Item("Other_Name").ToString()
                            .txt_new_last_name.Text = sql_dt.Rows(0).Item("Last_Name").ToString()
                            .txt_new_email.Text = sql_dt.Rows(0).Item("Email").ToString()
                            .txt_new_number.Text = sql_dt.Rows(0).Item("Phone").ToString()
                            .txt_new_physical_address.Text = sql_dt.Rows(0).Item("Physical_Address_Area").ToString()
                            .txt_new_birth_date.Value = CDate(sql_dt.Rows(0).Item("Birth_Date").ToString)
                            .txt_new_position.Text = sql_dt.Rows(0).Item("Role").ToString()
                            .txt_new_salary.Text = sql_dt.Rows(0).Item("Salary_GHC").ToString()
                            .txt_new_gender.Text = sql_dt.Rows(0).Item("Gender").ToString()
                        End With

                    End If

                    If sql_dt.Rows(0).Item("Married").ToString() = True Then
                        Management_Employees_Add_New.txt_new_married.Text = "Yes"
                    Else
                        Management_Employees_Add_New.txt_new_married.Text = "No"
                    End If
                    If sql_dt.Rows(0).Item("Active").ToString() = True Then
                        Management_Employees_Add_New.txt_new_active.SelectedIndex = 0
                    Else
                        Management_Employees_Add_New.txt_new_active.SelectedIndex = 1
                    End If
                Else
                    Management.btn_management_message.Text = "No Data Found"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "information")
                End If
            Else
                Management.btn_management_message.Text = "No Row was selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub add_new_employee_clear()
        With Management_Employees_Add_New
            .pb_new_user_image.BackgroundImage = .pb_new_user_image.InitialImage
            .txt_new_id.Clear()
            .txt_new_first_name.Clear()
            .txt_new_other_names.Clear()
            .txt_new_last_name.Clear()
            .txt_new_email.Clear()
            .txt_new_number.Clear()
            .txt_new_physical_address.Clear()
            .txt_new_birth_date.Checked = False
            .txt_new_position.Text = ""
            .txt_new_salary.Clear()
            .txt_new_gender.Text = ""
            .txt_new_married.Text = ""
            .txt_new_active.SelectedIndex = 0
        End With

    End Sub
    Private Sub cmb_employee_position_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_employee_position_filter.SelectedIndexChanged
        If cmb_employee_position_filter.SelectedIndex = 0 Then
            datagrid_fill_default("employee_view", EmployeesDataGridView)
        Else
            datagrid_fill_filter("employee_view", EmployeesDataGridView, "Role", Me.cmb_employee_position_filter)
        End If
    End Sub
    Private Sub txt_employee_name_filter_TextChanged(sender As Object, e As EventArgs) Handles txt_employee_name_filter.TextChanged
        If txt_employee_name_filter.Text = "" Then
            datagrid_fill_default("employee_view", EmployeesDataGridView)
        Else
            datagrid_fill_filter_textbox("employee_view", EmployeesDataGridView, "Name", Me.txt_employee_name_filter)
        End If
    End Sub

    Private Sub EmployeesDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeesDataGridView.ColumnHeaderMouseClick
        datagrid_fill_color_effect("employee_view", Me.EmployeesDataGridView)
        clear_gridview_default_selection(Me.EmployeesDataGridView)
    End Sub

    Private Sub btn_activate_employee_Click(sender As Object, e As EventArgs) Handles btn_activate_employee.Click
        Try
            If Me.EmployeesDataGridView.SelectedRows.Count > 0 Then
                If Me.EmployeesDataGridView.CurrentRow.Cells(7).Value.ToString = True Then
                    Management.btn_management_message.Text = "Employee already active"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "information")
                Else
                    Dim repos As DialogResult = MessageBox.Show("You are about to Activate Employee '" & Me.EmployeesDataGridView.CurrentRow.Cells(1).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("UPDATE employee SET Active = '" & 1 & "' 
                            Where ID = '" & Me.EmployeesDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                        sql_da.Fill(sql_ds, "employee")
                        datagrid_fill_default("employee_view", Me.EmployeesDataGridView)
                        Management.btn_management_message.Text = "Employee activated successfully"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")
                    End If
                End If
            Else
                Management.btn_management_message.Text = "No Employee selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_deactivate_employee_Click(sender As Object, e As EventArgs) Handles btn_deactivate_employee.Click
        Try
            If Me.EmployeesDataGridView.SelectedRows.Count > 0 Then
                If Me.EmployeesDataGridView.CurrentRow.Cells(7).Value.ToString = False Then
                    Management.btn_management_message.Text = "Employee already Inactive"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "information")
                Else
                    Dim repos As DialogResult = MessageBox.Show("You are about to Deactivate Employee '" & Me.EmployeesDataGridView.CurrentRow.Cells(1).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("UPDATE employee SET Active = '" & 0 & "' 
                            Where ID = '" & Me.EmployeesDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                        sql_da.Fill(sql_ds, "employee")
                        datagrid_fill_default("employee_view", Me.EmployeesDataGridView)
                        Management.btn_management_message.Text = "Employee Deactivated successfully"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")
                    End If
                End If
            Else
                Management.btn_management_message.Text = "No Employee selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "warning")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EmployeesDataGridView_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeesDataGridView.CellMouseDoubleClick
        btn_edit_employee_Click(btn_edit_employee, EventArgs.Empty)
    End Sub
End Class
