Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New
    Public customer, automobile As Integer
    Public date_in, date_due_out As String
    Private Sub btn_new_work_order_new_cusromer_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_cusromer.Click
        Management_Work_Order_Add_New_Customer.customer_new_datails_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Visible = False
        Management_Work_Order_Add_New_Customer.customer_new_datails_panel.Visible = True
        Management_Work_Order_Add_New_Customer.ShowDialog()
        Management_Work_Order_Add_New_Customer.btn_new_customer_save.Text = "SAVE"
    End Sub

    Public Sub btn_new_work_order_new_automobile_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_automobile.Click
        Management_Work_Order_Add_New_Automobile.automobile_new_datails_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Visible = False
        Management_Work_Order_Add_New_Automobile.automobile_new_datails_panel.Visible = True
        Management_Work_Order_Add_New_Automobile.ShowDialog()
        Management_Work_Order_Add_New_Automobile.btn_new_automobile_save.Text = "SAVE"
    End Sub

    Private Sub btn_new_item_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_item_cancel.Click
        sidebar_form_loader(Management_Work_Order)
        Management.lbl_current_tab.Text = "Work Orders"
    End Sub

    Private Sub btn_new_item_save_Click(sender As Object, e As EventArgs) Handles btn_new_item_save.Click
        Try
            If txt_work_order_new_customer.Text <> "" And txt_work_order_new_automobile.Text <> "" And txt_new_work_order_technicians.Text <> "" And txt_new_work_order_date_in.Checked = True And txt_new_work_order_date_out.Checked = True And
           txt_new_work_order_mileage.Text <> "" And txt_new_work_order_progress_stats.Text <> "" Then
                date_in = txt_new_work_order_date_in.Value.Year & "-" & txt_new_work_order_date_in.Value.Month & "-" & txt_new_work_order_date_in.Value.Day
                date_due_out = txt_new_work_order_date_out.Value.Year & "-" & txt_new_work_order_date_out.Value.Month & "-" & txt_new_work_order_date_out.Value.Day
                Dim repos As DialogResult = MessageBox.Show("You are about to Add a new Work Order, are you sure to continue ?", "Updating User Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If repos = DialogResult.Yes Then
                    sql_ds = New DataSet
                    sql_da = New MySqlDataAdapter("INSERT INTO work_order(`Customer`,`Automobile`,`Technician`,`Date_In`,`Date_Due_Out`,`Mileage`,`Status`,`Relevant_Informations`)
                            VALUES('" & customer & "','" & automobile & "','" & txt_new_work_order_technicians.Text & "', '" & date_in & "','" & date_due_out & "',
                            '" & txt_new_work_order_mileage.Text & "', '" & txt_new_work_order_progress_stats.Text & "','" & txt_new_work_order_relevant_information.Text & "')", sql_con)
                    sql_da.Fill(sql_ds, "work_order")
                    sidebar_form_loader(Management_Work_Order)
                    datagrid_fill_default("work_order_view", Management_Work_Order.WorkOrderDataGridView)
                    message("success", "Work Order Added Successflly")
                End If
            Else
                message("warning", "Please fill out all required (*) fields")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Save New Work Order Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btn_new_work_order_existing_automobile_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_existing_automobile.Click
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Visible = True
        Management_Work_Order_Add_New_Automobile.automobile_new_datails_panel.Visible = False
        datagrid_fill_default("automobile_info", Management_Work_Order_Add_New_Automobile.AutomobileDataGridView)
        Management_Work_Order_Add_New_Automobile.ShowDialog()
        Management_Work_Order_Add_New_Automobile.AutomobileDataGridView.Rows(0).Selected = True
    End Sub

    Private Sub btn_new_work_order_existing_cusromer_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_existing_cusromer.Click
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Visible = True
        Management_Work_Order_Add_New_Customer.customer_new_datails_panel.Visible = False
        datagrid_fill_default("customer_info", Management_Work_Order_Add_New_Customer.CustomerDataGridView)
        Management_Work_Order_Add_New_Customer.ShowDialog()
        Management_Work_Order_Add_New_Customer.CustomerDataGridView.Rows(0).Selected = True
    End Sub

    Private Sub work_order_clear_customer_Click(sender As Object, e As EventArgs) Handles work_order_clear_customer.Click
        txt_work_order_new_customer.Clear()
    End Sub

    Private Sub work_order_cleartechnician_Click(sender As Object, e As EventArgs) Handles work_order_cleartechnician.Click
        txt_new_work_order_technicians.Clear()
    End Sub

    Private Sub txt_new_work_order_relevant_information_TextChanged(sender As Object, e As EventArgs) Handles txt_new_work_order_relevant_information.TextChanged
        lbl_relevant_infomation_character_count.Text = "(" + (200 - txt_new_work_order_relevant_information.TextLength).ToString + "/200)"
    End Sub

    Private Sub work_order_clear_automobile_Click(sender As Object, e As EventArgs) Handles work_order_clear_automobile.Click
        txt_work_order_new_automobile.Clear()
    End Sub

    Private Sub btn_new_work_order_add_technician_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_add_technician.Click
        datagrid_fill("technician_view", Management_Work_Order_Add_New_Technician.TechnicianDataGridView)
        Management_Work_Order_Add_New_Technician.ShowDialog()
    End Sub
End Class