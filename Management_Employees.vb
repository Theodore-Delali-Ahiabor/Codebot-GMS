Imports MySql.Data.MySqlClient
Public Class Management_Employees
    Dim initial_employee_id As String = "HTU-JTMC0001"
    Dim new_employee_id As String
    Dim integer_part As Integer = 1
    Dim married As Byte
    Dim birth_date As Date
    Private Sub Management_Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmployeesDataGridView.Columns(9).DefaultCellStyle.Format = "N2"
    End Sub

    Private Sub btn_add_new_employee_Click(sender As Object, e As EventArgs) Handles btn_add_new_employee.Click
        sidebar_form_loader(Management_Employees_Add_New)
        Management.lbl_current_tab.Text = "Employees | Add New User"
        Management_Employees_Add_New.btn_new_user_save.Text = "SAVE"
        employee_new_id()
        add_new_employee_clear()
        Management_Employees_Add_New.txt_new_id.Text = new_employee_id
    End Sub
    Private Function employee_new_id() As String
        sql_da = New MySqlDataAdapter("SELECT ID FROM employee", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Dim id As Integer = sql_dt.Rows.Count
        integer_part = CInt(initial_employee_id.Substring(8, 4))
        id += 1
        new_employee_id = initial_employee_id.Substring(0, 8) & id.ToString("0000")
        Return new_employee_id
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
        Management_Employees_Add_New.txt_new_birth_date.Text = EmployeesDataGridView.CurrentRow.Cells(7).Value
        Management_Employees_Add_New.txt_new_position.Text = EmployeesDataGridView.CurrentRow.Cells(8).Value.ToString()
        Management_Employees_Add_New.txt_new_salary.Text = Format(EmployeesDataGridView.CurrentRow.Cells(9).Value, "N2")
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
            If Management_Employees_Add_New.txt_new_married.Text = "Yes" Then
                married = 1
            Else
                married = 0
            End If
            If Management_Employees_Add_New.txt_new_birth_date.Checked = True Then
                birth_date = Management_Employees_Add_New.txt_new_birth_date.Value
            Else
                birth_date = " "
            End If
            If text = "UPDATE" Then
                Dim repos As DialogResult = MessageBox.Show("You are about to Update info @ ID '" & EmployeesDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("UPDATE employee SET First_Name = '" & Management_Employees_Add_New.txt_new_first_name.Text & "', Other_Name = '" & Management_Employees_Add_New.txt_new_other_names.Text & "',
                            Last_Name = '" & Management_Employees_Add_New.txt_new_last_name.Text & "', Email = '" & Management_Employees_Add_New.txt_new_email.Text & "', Physical_Address_Area = '" & Management_Employees_Add_New.txt_new_physical_address.Text & "',
                            Position = '" & Management_Employees_Add_New.txt_new_position.Text & "', Gender = '" & Management_Employees_Add_New.txt_new_gender.Text & "', Phone = '" & Management_Employees_Add_New.txt_new_number.Text & "',
                            Married = '" & married & "', Active = '" & Management_Employees_Add_New.chkb_new_active.CheckState & "', Salary_GHC = '" & Management_Employees_Add_New.txt_new_salary.Text & "'
                            Where ID = '" & Management_Employees_Add_New.txt_new_id.Text & "'", sql_con)
                    'Birth_Date = '" & Management_Employees_Add_New.txt_new_birth_date.Value & "'
                    sql_da.Fill(sql_ds, "employee")
                    sidebar_form_loader(Me)
                    datagrid_fill("employee", EmployeesDataGridView)
                End If
            Else
                Dim repos As DialogResult = MessageBox.Show("You are about to Add new Employee with ID '" & Management_Employees_Add_New.txt_new_id.Text & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO employee(First_Name,Other_Name,Last_Name,Email,Physical_Address_Area,Position,Gender,Phone,Married,Active,Salary_GHC,ID,Birth_Date)
                            VALUES('" & Management_Employees_Add_New.txt_new_first_name.Text & "', '" & Management_Employees_Add_New.txt_new_other_names.Text & "', '" & Management_Employees_Add_New.txt_new_last_name.Text & "', '" & Management_Employees_Add_New.txt_new_email.Text & "',
                            '" & Management_Employees_Add_New.txt_new_physical_address.Text & "', '" & Management_Employees_Add_New.txt_new_position.Text & "', '" & Management_Employees_Add_New.txt_new_gender.Text & "', '" & Management_Employees_Add_New.txt_new_number.Text & "',
                            '" & married & "', '" & Management_Employees_Add_New.chkb_new_active.CheckState & "', '" & Management_Employees_Add_New.txt_new_salary.Text & "', '" & Management_Employees_Add_New.txt_new_id.Text & "','" & birth_date & "'
                            )", sql_con)
                    '
                    sql_da.Fill(sql_ds, "employee")
                    sidebar_form_loader(Me)
                    datagrid_fill("employee", EmployeesDataGridView)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Public Sub add_new_employee_clear()
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
