Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New
    Private Sub btn_new_work_order_new_cusromer_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_cusromer.Click
        Management_Work_Order_Add_New_Customer.customer_new_datails_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Visible = False
        Management_Work_Order_Add_New_Customer.customer_new_datails_panel.Visible = True
        Management_Work_Order_Add_New_Customer.Show()
        Management_Work_Order_Add_New_Customer.btn_new_customer_save.Text = "SAVE"
    End Sub

    Public Sub btn_new_work_order_new_automobile_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_automobile.Click
        Management_Work_Order_Add_New_Automobile.automobile_new_datails_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Visible = False
        Management_Work_Order_Add_New_Automobile.automobile_new_datails_panel.Visible = True
        Management_Work_Order_Add_New_Automobile.Show()
        Management_Work_Order_Add_New_Automobile.btn_new_automobile_save.Text = "SAVE"
    End Sub

    Private Sub btn_new_item_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_item_cancel.Click
        sidebar_form_loader(Management_Work_Order)
        Management.lbl_current_tab.Text = "Work Orders"
    End Sub

    Private Sub btn_new_item_save_Click(sender As Object, e As EventArgs) Handles btn_new_item_save.Click

    End Sub

    Private Sub btn_new_work_order_existing_automobile_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_existing_automobile.Click
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Automobile.automobile_select_edit_panel.Visible = True
        Management_Work_Order_Add_New_Automobile.automobile_new_datails_panel.Visible = False
        datagrid_fill_default("automobile_info", Management_Work_Order_Add_New_Automobile.AutomobileDataGridView)
        Management_Work_Order_Add_New_Automobile.Show()
        Management_Work_Order_Add_New_Automobile.AutomobileDataGridView.Rows(0).Selected = True
    End Sub

    Private Sub btn_new_work_order_existing_cusromer_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_existing_cusromer.Click
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Dock = DockStyle.Fill
        Management_Work_Order_Add_New_Customer.customer_select_edit_panel.Visible = True
        Management_Work_Order_Add_New_Customer.customer_new_datails_panel.Visible = False
        datagrid_fill_default("customer_info", Management_Work_Order_Add_New_Customer.CustomerDataGridView)
        Management_Work_Order_Add_New_Customer.Show()
        Management_Work_Order_Add_New_Customer.CustomerDataGridView.Rows(0).Selected = True
    End Sub
End Class