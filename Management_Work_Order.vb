Public Class Management_Work_Order
    Private Sub cmb_work_order_status_filter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_work_order_status_filter.SelectedIndexChanged
        If cmb_work_order_status_filter.SelectedIndex = 0 Then
            datagrid_fill_default("work_order_view", Me.WorkOrderDataGridView)
        Else
            datagrid_fill_filter("work_order_view", Me.WorkOrderDataGridView, "Progress_Status", Me.cmb_work_order_status_filter)
        End If
    End Sub

    Private Sub btn_add_new_work_order_Click(sender As Object, e As EventArgs) Handles btn_add_new_work_order.Click
        Management.lbl_current_tab.Text = "Work Orders | Add New Order"
        sidebar_form_loader(Management_Work_Order_Add_New)
        'Management_Inventory_Add_New.btn_new_item_save.Text = "SAVE"
    End Sub

    Private Sub txt_work_order_automobile_name_filter_TextChanged(sender As Object, e As EventArgs) Handles txt_work_order_automobile_name_filter.TextChanged
        If txt_work_order_automobile_name_filter.Text = "" Then
            datagrid_fill_default("work_order_view", Me.WorkOrderDataGridView)
        Else
            datagrid_fill_filter_textbox("work_order_view", Me.WorkOrderDataGridView, "ID", txt_work_order_automobile_name_filter)
        End If
    End Sub
    Private Sub WorkOrderDataGridView_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles WorkOrderDataGridView.ColumnHeaderMouseClick
        datagrid_fill_color_effect("work_order_view", Me.WorkOrderDataGridView)
        clear_gridview_default_selection(Me.WorkOrderDataGridView)
    End Sub
End Class