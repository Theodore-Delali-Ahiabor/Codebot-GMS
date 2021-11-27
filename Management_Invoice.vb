Public Class Management_Invoice
    Private Sub btn_add_new_invoice_Click(sender As Object, e As EventArgs) Handles btn_add_new_invoice.Click
        Management.lbl_current_tab.Text = "Invoice | Add New Invoice"
        sidebar_form_loader(Management_Invoice_Add_New)
    End Sub
End Class