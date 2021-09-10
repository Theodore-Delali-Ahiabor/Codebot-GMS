Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New_Customer
    Dim gender As Char
    Private Sub btn_new_customer_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_customer_cancel.Click
        Me.Close()
    End Sub

    Private Sub rbtn_new_customer_male_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_new_customer_male.CheckedChanged
        If rbtn_new_customer_male.Checked = True Then
            gender = "M"
        End If
    End Sub

    Private Sub rbtn_new_customer_female_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_new_customer_female.CheckedChanged
        If rbtn_new_customer_female.Checked = True Then
            gender = "F"
        End If
    End Sub

    Private Sub btn_new_customer_save_Click(sender As Object, e As EventArgs) Handles btn_new_customer_save.Click
        If txt_new_customer_first_name.Text <> "" And txt_new_customer_last_name.Text <> "" And txt_new_customer_phone.Text <> "" Then
            Try
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Customer, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO customer_info(First_Name,Other_Name,Last_Name,Gender,Post_Box_Address,City_Town,Phone,Email)
                            VALUES('" & txt_new_customer_first_name.Text & "','" & txt_new_customer_other_name.Text & "','" & txt_new_customer_last_name.Text & "', '" & gender & "', '" & txt_new_customer_pobox.Text & "',
                            '" & txt_new_customer_city_town.Text & "', '" & txt_new_customer_phone.Text & "', '" & txt_new_customer_email.Text & "')", sql_con)
                    sql_da.Fill(sql_ds, "customer_info")
                    'sidebar_form_loader(Management_Employees)
                    'datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Management.btn_management_message.Text = "Please fill out all REQUIRED '*' fields"
            Management.btn_management_message.Show()
            message(Management.btn_management_message, "warning")
        End If
    End Sub
End Class