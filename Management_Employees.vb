Imports MySql.Data.MySqlClient
Public Class Management_Employees
    Dim new_user_id As String
    Dim id As Integer
    'id.format = "N4"
    Private Sub Management_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Generate New user id 
        get_new_user_id("HTU-JTMC0001")

    End Sub

    Private Sub btn_add_new_employee_Click(sender As Object, e As EventArgs) Handles btn_add_new_employee.Click
        sidebar_form_loader(Management_Employees_Add_New)
        Management.lbl_current_tab.Text = "Employees | Add New User"
        Management_Employees_Add_New.btn_new_user_save.Text = "SAVE"
    End Sub
    Private Function get_new_user_id(ByRef user_id As String) As String
        sql_con.Close()
        sql_con.Open()
        sql_da = New MySqlDataAdapter("SELECT ID FROM employee", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        sql_con.Close()
        For Each Row In sql_dt.Rows
            If user_id = Row.ToString Then
                new_user_id = user_id + 1
            End If
        Next
        'For Each item In combo.Items
        '    If office_title = item Then
        '        found = True
        '    End If
        'Next
        Return Management_Employees_Add_New.txt_new_id.Text = new_user_id
    End Function

    Private Sub btn_edit_employee_Click(sender As Object, e As EventArgs) Handles btn_edit_employee.Click
        sidebar_form_loader(Management_Employees_Add_New)
        Management.lbl_current_tab.Text = "Employees | Edit User"
        Management_Employees_Add_New.btn_new_user_save.Text = "UPDATE"
        Management_Employees_Add_New.txt_new_id.Text = EmployeesDataGridView.CurrentRow.Cells(0).Value.ToString()
        Management_Employees_Add_New.txt_new_first_name.Text = EmployeesDataGridView.CurrentRow.Cells(1).Value.ToString()
        Management_Employees_Add_New.txt_new_other_names.Text = EmployeesDataGridView.CurrentRow.Cells(2).Value.ToString()
        Management_Employees_Add_New.txt_new_last_name.Text = EmployeesDataGridView.CurrentRow.Cells(3).Value.ToString()
        Management_Employees_Add_New.txt_new_email.Text = EmployeesDataGridView.CurrentRow.Cells(4).Value.ToString()
        Management_Employees_Add_New.txt_new_number.Text = EmployeesDataGridView.CurrentRow.Cells(5).Value.ToString()
        Management_Employees_Add_New.txt_new_physical_address.Text = EmployeesDataGridView.CurrentRow.Cells(6).Value.ToString()
        Management_Employees_Add_New.txt_new_birth_date.Text = EmployeesDataGridView.CurrentRow.Cells(7).Value.ToString()
        Management_Employees_Add_New.txt_new_position.Text = EmployeesDataGridView.CurrentRow.Cells(8).Value.ToString()
        Management_Employees_Add_New.txt_new_salary.Text = EmployeesDataGridView.CurrentRow.Cells(9).Value.ToString()
        Management_Employees_Add_New.txt_new_gender.Text = EmployeesDataGridView.CurrentRow.Cells(10).Value.ToString()
        If EmployeesDataGridView.CurrentRow.Cells(11).Value.ToString() = True Then
            Management_Employees_Add_New.txt_new_married.Text = "Yes"
        Else
            Management_Employees_Add_New.txt_new_married.Text = "No"
        End If
        If EmployeesDataGridView.CurrentRow.Cells(12).Value.ToString() = True Then
            Management_Employees_Add_New.chkb_new_active.CheckState = CheckState.Checked
        Else
            Management_Employees_Add_New.chkb_new_active.CheckState = CheckState.Unchecked
        End If
    End Sub
    Public Sub add_update_user(ByRef text As String)
        Try
            If text = "UPDATE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to add a new user, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("UPDATE employee SET First_Name = '" & Management_Employees_Add_New.txt_new_first_name.Text & "' Where ID = '" & Management_Employees_Add_New.txt_new_id.Text & "'", sql_con)
                    sql_da.Fill(sql_ds, "employee")
                    'sidebar_active(sender)
                    sidebar_form_loader(Me)
                    datagrid_fill("employee", EmployeesDataGridView)
                End If
            Else
                sql_con.Close()
                sql_con.Open()

                sql_con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub menu_clear()
        Management_Employees_Add_New.txt_new_id.Clear()
        Management_Employees_Add_New.txt_new_first_name.Clear()
        Management_Employees_Add_New.txt_new_other_names.Clear()
        Management_Employees_Add_New.txt_new_last_name.Clear()
        Management_Employees_Add_New.txt_new_email.Clear()
        Management_Employees_Add_New.txt_new_number.Clear()
        Management_Employees_Add_New.txt_new_physical_address.Clear()
        Management_Employees_Add_New.txt_new_birth_date.Value = Date.Now
        Management_Employees_Add_New.txt_new_position.Text = ""
        Management_Employees_Add_New.txt_new_salary.Clear()
        Management_Employees_Add_New.txt_new_gender.Text = ""
        Management_Employees_Add_New.txt_new_married.Text = ""
        Management_Employees_Add_New.chkb_new_active.CheckState = CheckState.Checked
    End Sub
End Class
