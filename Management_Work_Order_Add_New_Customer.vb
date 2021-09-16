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
                If btn_new_customer_save.Text = "SAVE" Then
                    Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Customer, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("INSERT INTO customer_info(First_Name,Other_Name,Last_Name,Gender,Post_Box_Address,City_Town,Phone,Email)
                            VALUES('" & txt_new_customer_first_name.Text & "','" & txt_new_customer_other_name.Text & "','" & txt_new_customer_last_name.Text & "', '" & gender & "', '" & txt_new_customer_pobox.Text & "',
                            '" & txt_new_customer_city_town.Text & "', '" & txt_new_customer_phone.Text & "', '" & txt_new_customer_email.Text & "')", sql_con)
                        sql_da.Fill(sql_ds, "customer_info")
                        'sidebar_form_loader(Management_Employees)
                        'datagrid_fill_default("employee_view", Management_Employees.EmployeesDataGridView)
                        Management_Work_Order_Add_New.txt_work_order_new_customer.Text = txt_new_customer_first_name.Text & " " & txt_new_customer_other_name.Text & " " & txt_new_customer_last_name.Text
                        Me.Close()
                    End If
                Else
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("UPDATE customer_info SET First_Name = '" & txt_new_customer_first_name.Text & "', Other_Name = '" & txt_new_customer_other_name.Text & "', Last_Name = '" & txt_new_customer_last_name.Text & "', Gender = '" & gender & "',
                            Post_Box_Address = '" & txt_new_customer_pobox.Text & "', City_Town = '" & txt_new_customer_city_town.Text & "', Phone = '" & txt_new_customer_phone.Text & "', Email = '" & txt_new_customer_email.Text & "' 
                            Where ID = '" & Me.CustomerDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                    sql_da.Fill(sql_ds, "customer_info")
                    datagrid_fill_default("customer_info", Me.CustomerDataGridView)
                    Management.btn_management_message.Text = "Customer Info Updated successfully"
                    Management.btn_management_message.Show()
                    message(Management.btn_management_message, "success")
                    Me.customer_new_datails_panel.Dock = DockStyle.Fill
                    Me.customer_new_datails_panel.Visible = False
                    Me.customer_select_edit_panel.Visible = True
                    Me.CustomerDataGridView.Rows(0).Selected = True
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

    Private Sub btn_customer_select_new_Click(sender As Object, e As EventArgs) Handles btn_customer_select_new.Click
        Me.customer_new_datails_panel.Dock = DockStyle.Fill
        Me.customer_select_edit_panel.Visible = False
        Me.customer_new_datails_panel.Visible = True
        Me.btn_new_customer_save.Text = "SAVE"
        txt_new_customer_first_name.Clear()
        txt_new_customer_other_name.Clear()
        txt_new_customer_last_name.Clear()
        rbtn_new_customer_male.Checked = False
        rbtn_new_customer_female.Checked = False
        txt_new_customer_pobox.Clear()
        txt_new_customer_city_town.Clear()
        txt_new_customer_phone.Clear()
        txt_new_customer_email.Clear()

    End Sub

    Private Sub btn_customer_select_edit_Click(sender As Object, e As EventArgs) Handles btn_customer_select_edit.Click
        Me.customer_new_datails_panel.Dock = DockStyle.Fill
        Me.customer_select_edit_panel.Visible = False
        Me.customer_new_datails_panel.Visible = True
        Me.btn_new_customer_save.Text = "UPDATE"
        txt_new_customer_first_name.Text = CustomerDataGridView.CurrentRow.Cells(1).Value
        txt_new_customer_other_name.Text = CustomerDataGridView.CurrentRow.Cells(2).Value
        txt_new_customer_last_name.Text = CustomerDataGridView.CurrentRow.Cells(3).Value
        If CustomerDataGridView.CurrentRow.Cells(4).Value = "M" Then
            rbtn_new_customer_male.Checked = True
        Else
            rbtn_new_customer_female.Checked = True
        End If
        txt_new_customer_pobox.Text = CustomerDataGridView.CurrentRow.Cells(5).Value
        txt_new_customer_city_town.Text = CustomerDataGridView.CurrentRow.Cells(6).Value
        txt_new_customer_phone.Text = CustomerDataGridView.CurrentRow.Cells(7).Value
        txt_new_customer_email.Text = CustomerDataGridView.CurrentRow.Cells(8).Value
    End Sub

    Private Sub btn_customer_select_select_Click(sender As Object, e As EventArgs) Handles btn_customer_select_select.Click
        Management_Work_Order_Add_New.txt_work_order_new_customer.Text = CustomerDataGridView.CurrentRow.Cells(1).Value & " " & CustomerDataGridView.CurrentRow.Cells(2).Value & " " & CustomerDataGridView.CurrentRow.Cells(3).Value
        Management_Work_Order_Add_New.customer = CustomerDataGridView.CurrentRow.Cells(0).Value
        Me.Close()
    End Sub

    Private Sub btn_customer_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_customer_select_cancel.Click
        Me.Close()
    End Sub
End Class