Public Class Management_Work_Order
    Private Sub btn_add_new_Order_Click(sender As Object, e As EventArgs)
        Management.lbl_current_tab.Text = "Work Orders | Add New Order"
        sidebar_form_loader(Management_Work_Order_Add_New)
        'Management_Inventory_Add_New.btn_new_item_save.Text = "SAVE"
    End Sub
End Class