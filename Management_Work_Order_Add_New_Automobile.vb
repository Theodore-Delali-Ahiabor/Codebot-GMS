Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New_Automobile
    Private Sub btn_new_automobile_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_automobile_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_automobile_select_new_Click(sender As Object, e As EventArgs) Handles btn_automobile_select_new.Click
        txt_new_category.Text = ""
        txt_new_year.Clear()
        txt_new_make.Text = ""
        txt_new_model.Clear()
        txt_new_color.Clear()
        txt_new_fuel.Text = ""
        txt_new_vin.Clear()
        txt_new_reg_number.Clear()
        Me.automobile_new_datails_panel.Dock = DockStyle.Fill
        Me.automobile_select_edit_panel.Visible = False
        Me.automobile_new_datails_panel.Visible = True
        btn_new_automobile_save.Text = "SAVE"

    End Sub

    Private Sub btn_automobile_select_edit_Click(sender As Object, e As EventArgs) Handles btn_automobile_select_edit.Click
        btn_automobile_select_new_Click(btn_automobile_select_new, EventArgs.Empty)
        txt_new_category.Text = AutomobileDataGridView.CurrentRow.Cells(1).Value
        txt_new_year.Text = AutomobileDataGridView.CurrentRow.Cells(2).Value
        txt_new_make.Text = AutomobileDataGridView.CurrentRow.Cells(3).Value
        txt_new_model.Text = AutomobileDataGridView.CurrentRow.Cells(4).Value
        txt_new_color.Text = AutomobileDataGridView.CurrentRow.Cells(5).Value
        txt_new_fuel.Text = AutomobileDataGridView.CurrentRow.Cells(6).Value
        txt_new_vin.Text = AutomobileDataGridView.CurrentRow.Cells(7).Value
        txt_new_reg_number.Text = AutomobileDataGridView.CurrentRow.Cells(8).Value
        btn_new_automobile_save.Text = "UPDATE"
    End Sub

    Private Sub btn_automobile_select_select_Click(sender As Object, e As EventArgs) Handles btn_automobile_select_select.Click
        Try
            If AutomobileDataGridView.SelectedRows.Count = 1 Then
                Management_Work_Order_Add_New.txt_work_order_new_automobile.Text = CStr(AutomobileDataGridView.CurrentRow.Cells(2).Value & " " & AutomobileDataGridView.CurrentRow.Cells(5).Value & " " &
                    AutomobileDataGridView.CurrentRow.Cells(3).Value & " " & AutomobileDataGridView.CurrentRow.Cells(4).Value)
                Management_Work_Order_Add_New.automobile = AutomobileDataGridView.CurrentRow.Cells(0).Value
                Me.Close()
            Else
                Management.btn_management_message.Text = "No Automobile Selected"
                Management.btn_management_message.Show()
                message(Management.btn_management_message, "information")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Automobile Selection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_automobile_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_automobile_select_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_new_automobile_save_Click(sender As Object, e As EventArgs) Handles btn_new_automobile_save.Click
        If txt_new_make.Text <> "" And txt_new_fuel.Text <> "" Then
            Try
                If btn_new_automobile_save.Text = "SAVE" Then
                    Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Automobile, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("INSERT INTO automobile_info(Category,Year,Make,Model,Color,Fuel,VIN,Reg_Number)
                            VALUES('" & txt_new_category.Text & "','" & txt_new_year.Text & "','" & txt_new_make.Text & "', '" & txt_new_model.Text & "', '" & txt_new_color.Text & "',
                            '" & txt_new_fuel.Text & "', '" & txt_new_vin.Text & "', '" & txt_new_reg_number.Text & "')", sql_con)
                        sql_da.Fill(sql_ds, "automobile_info")
                        Management_Work_Order_Add_New.txt_work_order_new_automobile.Text = CStr(txt_new_year.Text & " " & txt_new_color.Text & " " & txt_new_make.Text & " " & txt_new_model.Text)
                        Management_Work_Order_Add_New.automobile = AutomobileDataGridView.CurrentRow.Cells(0).Value
                        Me.Close()
                        datagrid_fill_default("automobile_info", Me.AutomobileDataGridView)
                        Management.btn_management_message.Text = "Automobile Updated Successflly"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")

                    End If
                Else
                    Dim repos As DialogResult = MessageBox.Show("You are about to Update Autoombile @ ID '" & Me.AutomobileDataGridView.CurrentRow.Cells(0).Value & "', are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    If repos = DialogResult.Yes Then
                        sql_ds = New DataSet
                        sql_da = New MySqlDataAdapter("UPDATE automobile_info SET Category = '" & txt_new_category.Text & "', Year = '" & txt_new_year.Text & "', Make = '" & txt_new_make.Text & "', Model = '" & txt_new_model.Text & "',
                            Color = '" & txt_new_color.Text & "', Fuel = '" & txt_new_fuel.Text & "', VIN = '" & txt_new_vin.Text & "', Reg_Number = '" & txt_new_reg_number.Text & "' 
                            Where ID = '" & Me.AutomobileDataGridView.CurrentRow.Cells(0).Value & "'", sql_con)
                        sql_da.Fill(sql_ds, "automobile_info")
                        datagrid_fill_default("automobile_info", Me.AutomobileDataGridView)
                        Management.btn_management_message.Text = "Automobile Info Updated successfully"
                        Management.btn_management_message.Show()
                        message(Management.btn_management_message, "success")
                        Me.automobile_new_datails_panel.Dock = DockStyle.Fill
                        Me.automobile_new_datails_panel.Visible = False
                        Me.automobile_select_edit_panel.Visible = True
                        Me.AutomobileDataGridView.Rows(0).Selected = True
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Save Automobile Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        Else
            Management.btn_management_message.Text = "Kindly fill out all required (*) fields"
            Management.btn_management_message.Show()
            message(Management.btn_management_message, "warning")
        End If
    End Sub

    Private Sub Management_Work_Order_Add_New_Automobile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txt_new_category.Items.Clear()
        add_combobox_items(Me.txt_new_category, "automobile_info", "Category")
        Me.txt_new_fuel.Items.Clear()
        add_combobox_items(Me.txt_new_fuel, "automobile_info", "Fuel")
        Me.txt_new_make.Items.Clear()
        add_combobox_items(Me.txt_new_make, "automobile_info", "Make")
    End Sub
End Class