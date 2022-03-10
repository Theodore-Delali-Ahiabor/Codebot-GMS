<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Invoice_Update_Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_amount_due = New System.Windows.Forms.TextBox()
        Me.btn_invoice_update = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_update_payment_cancel = New System.Windows.Forms.Button()
        Me.txt_available_balance = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_full_payment = New System.Windows.Forms.Button()
        Me.txt_payment_amount = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 18)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Available Balance (GHS)"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 18)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Amount Due (GHS)"
        '
        'txt_amount_due
        '
        Me.txt_amount_due.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_amount_due.Enabled = False
        Me.txt_amount_due.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount_due.Location = New System.Drawing.Point(35, 125)
        Me.txt_amount_due.MaxLength = 35
        Me.txt_amount_due.Name = "txt_amount_due"
        Me.txt_amount_due.Size = New System.Drawing.Size(369, 33)
        Me.txt_amount_due.TabIndex = 138
        '
        'btn_invoice_update
        '
        Me.btn_invoice_update.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_invoice_update.BackColor = System.Drawing.Color.LightGreen
        Me.btn_invoice_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice_update.FlatAppearance.BorderSize = 0
        Me.btn_invoice_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_invoice_update.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice_update.ForeColor = System.Drawing.Color.White
        Me.btn_invoice_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_invoice_update.Location = New System.Drawing.Point(70, 349)
        Me.btn_invoice_update.Name = "btn_invoice_update"
        Me.btn_invoice_update.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_invoice_update.Size = New System.Drawing.Size(125, 39)
        Me.btn_invoice_update.TabIndex = 136
        Me.btn_invoice_update.Text = "CONFIRM"
        Me.btn_invoice_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_invoice_update.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(87, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 45)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "NEW PAYMENT"
        '
        'btn_update_payment_cancel
        '
        Me.btn_update_payment_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_update_payment_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_update_payment_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update_payment_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_update_payment_cancel.FlatAppearance.BorderSize = 0
        Me.btn_update_payment_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update_payment_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update_payment_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_update_payment_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.delete_24px
        Me.btn_update_payment_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_update_payment_cancel.Location = New System.Drawing.Point(232, 348)
        Me.btn_update_payment_cancel.Name = "btn_update_payment_cancel"
        Me.btn_update_payment_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_update_payment_cancel.Size = New System.Drawing.Size(128, 40)
        Me.btn_update_payment_cancel.TabIndex = 137
        Me.btn_update_payment_cancel.Text = "CANCEL    "
        Me.btn_update_payment_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_update_payment_cancel.UseVisualStyleBackColor = False
        '
        'txt_available_balance
        '
        Me.txt_available_balance.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_available_balance.Enabled = False
        Me.txt_available_balance.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_available_balance.Location = New System.Drawing.Point(35, 198)
        Me.txt_available_balance.MaxLength = 35
        Me.txt_available_balance.Name = "txt_available_balance"
        Me.txt_available_balance.Size = New System.Drawing.Size(369, 33)
        Me.txt_available_balance.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 18)
        Me.Label2.TabIndex = 139
        Me.Label2.Text = "Payment Amount (GHS)"
        '
        'btn_full_payment
        '
        Me.btn_full_payment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_full_payment.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_full_payment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_full_payment.FlatAppearance.BorderSize = 0
        Me.btn_full_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_full_payment.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.btn_full_payment.ForeColor = System.Drawing.Color.White
        Me.btn_full_payment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_full_payment.Location = New System.Drawing.Point(290, 274)
        Me.btn_full_payment.Name = "btn_full_payment"
        Me.btn_full_payment.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_full_payment.Size = New System.Drawing.Size(114, 33)
        Me.btn_full_payment.TabIndex = 136
        Me.btn_full_payment.Text = "Full Payment"
        Me.btn_full_payment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_full_payment.UseVisualStyleBackColor = False
        '
        'txt_payment_amount
        '
        Me.txt_payment_amount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_payment_amount.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_payment_amount.Location = New System.Drawing.Point(35, 274)
        Me.txt_payment_amount.MaxLength = 35
        Me.txt_payment_amount.Name = "txt_payment_amount"
        Me.txt_payment_amount.Size = New System.Drawing.Size(249, 33)
        Me.txt_payment_amount.TabIndex = 138
        '
        'Management_Invoice_Update_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(436, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_payment_amount)
        Me.Controls.Add(Me.txt_available_balance)
        Me.Controls.Add(Me.txt_amount_due)
        Me.Controls.Add(Me.btn_update_payment_cancel)
        Me.Controls.Add(Me.btn_full_payment)
        Me.Controls.Add(Me.btn_invoice_update)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Management_Invoice_Update_Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management_Invoice_Update_Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_amount_due As TextBox
    Friend WithEvents btn_update_payment_cancel As Button
    Friend WithEvents btn_invoice_update As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_available_balance As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_full_payment As Button
    Friend WithEvents txt_payment_amount As TextBox
End Class
