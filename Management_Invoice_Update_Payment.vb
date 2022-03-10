Public Class Management_Invoice_Update_Payment
    Public update As Boolean = False
    Public balance As Decimal = 0.00
    Public payment_amt As Decimal = 0.00
    Public payment_status As String
    Private Sub btn_invoice_update_Click(sender As Object, e As EventArgs) Handles btn_invoice_update.Click
        If txt_payment_amount.Text <> "" Then
            update = True
            balance = CDec(txt_available_balance.Text)
            payment_amt = CDec(txt_payment_amount.Text)
            Me.Close()
        Else
            message("error", "Please enter an amount")
        End If
    End Sub

    Private Sub btn_update_payment_cancel_Click(sender As Object, e As EventArgs) Handles btn_update_payment_cancel.Click
        Me.Close()
    End Sub

    Private Sub Management_Invoice_Update_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update = False
        balance = 0.00
        payment_amt = 0.00
    End Sub

    Private Sub btn_full_payment_Click(sender As Object, e As EventArgs) Handles btn_full_payment.Click
        txt_payment_amount.Text = txt_amount_due.Text
    End Sub

    Private Sub txt_payment_amount_TextChanged(sender As Object, e As EventArgs) Handles txt_payment_amount.TextChanged
        If IsNumeric(txt_payment_amount.Text) Then
            If CDec(txt_payment_amount.Text) < 0.00 Then
                message("warning", "Enter positive Numbers ONLY")
                txt_payment_amount.Clear()
                txt_payment_amount.Focus()
            Else
                txt_available_balance.Text = CDec(txt_amount_due.Text) - CDec(txt_payment_amount.Text)
                balance = CDec(txt_available_balance.Text)
                payment_amt = CDec(txt_payment_amount.Text)
            End If

        Else
            message("warning", "Enter Numbers ONLY")
            txt_payment_amount.Clear()
            txt_payment_amount.Focus()
        End If

    End Sub
End Class