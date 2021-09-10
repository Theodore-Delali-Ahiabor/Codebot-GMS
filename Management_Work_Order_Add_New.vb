Imports MySql.Data.MySqlClient
Public Class Management_Work_Order_Add_New
    Private Sub btn_new_work_order_new_cusromer_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_cusromer.Click
        Management_Work_Order_Add_New_Customer.Show()
    End Sub

    Private Sub btn_new_work_order_new_automobile_Click(sender As Object, e As EventArgs) Handles btn_new_work_order_new_automobile.Click
        Management_Work_Order_Add_New_Automobile.Show()
    End Sub

    Private Sub btn_new_item_cancel_Click(sender As Object, e As EventArgs) Handles btn_new_item_cancel.Click
        sidebar_form_loader(Management_Work_Order)
        Management.lbl_current_tab.Text = "Work Orders"
    End Sub

    Private Sub btn_new_item_save_Click(sender As Object, e As EventArgs) Handles btn_new_item_save.Click

    End Sub
End Class