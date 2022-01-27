Public Class Management_Invoice_Select_Work_Order
    Private Sub btn_invoice_select_cancel_Click(sender As Object, e As EventArgs) Handles btn_invoice_select_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_invoice_select_select_Click(sender As Object, e As EventArgs) Handles btn_invoice_select_select.Click
        Me.Close()
        Management_Invoice_Add_New.txt_invoice_work_order.Text = InvoiceSelectWorkOrderDataGridView.CurrentRow.Cells(0).Value

    End Sub

    Private Sub btn_invoice_select_new_Click(sender As Object, e As EventArgs) Handles btn_invoice_select_new.Click
        Me.Close()
        Management_Work_Order.btn_add_new_work_order_Click(Management_Work_Order.btn_add_new_work_order, EventArgs.Empty)
    End Sub

    Private Sub Management_Invoice_Select_Work_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagrid_fill_default("work_order_view", InvoiceSelectWorkOrderDataGridView)
        'datagrid_fill_color_effect("work_order_view", Management_Invoice_Select_Work_Order.InvoiceSelectWorkOrderDataGridView)
        'datagrid_fill_column_resize("work_order_view", Management_Invoice_Select_Work_Order.InvoiceSelectWorkOrderDataGridView)
    End Sub
End Class