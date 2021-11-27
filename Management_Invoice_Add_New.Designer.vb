<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Invoice_Add_New
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_new_ivoice_cancel = New System.Windows.Forms.Button()
        Me.btn_new_invoice_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_new_ivoice_cancel
        '
        Me.btn_new_ivoice_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_ivoice_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_ivoice_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_ivoice_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_ivoice_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_ivoice_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_ivoice_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_ivoice_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_ivoice_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_ivoice_cancel.Location = New System.Drawing.Point(590, 451)
        Me.btn_new_ivoice_cancel.Name = "btn_new_ivoice_cancel"
        Me.btn_new_ivoice_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_ivoice_cancel.Size = New System.Drawing.Size(141, 41)
        Me.btn_new_ivoice_cancel.TabIndex = 17
        Me.btn_new_ivoice_cancel.Text = "CANCEL"
        Me.btn_new_ivoice_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_invoice_save
        '
        Me.btn_new_invoice_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_invoice_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_invoice_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_invoice_save.FlatAppearance.BorderSize = 0
        Me.btn_new_invoice_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_invoice_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_invoice_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_invoice_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_invoice_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_invoice_save.Location = New System.Drawing.Point(422, 451)
        Me.btn_new_invoice_save.Name = "btn_new_invoice_save"
        Me.btn_new_invoice_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_invoice_save.Size = New System.Drawing.Size(141, 41)
        Me.btn_new_invoice_save.TabIndex = 16
        Me.btn_new_invoice_save.Text = "SAVE"
        Me.btn_new_invoice_save.UseVisualStyleBackColor = False
        '
        'Management_Invoice_Add_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 523)
        Me.Controls.Add(Me.btn_new_ivoice_cancel)
        Me.Controls.Add(Me.btn_new_invoice_save)
        Me.Name = "Management_Invoice_Add_New"
        Me.Text = "Management_Invoice_Add_New"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_new_ivoice_cancel As Button
    Friend WithEvents btn_new_invoice_save As Button
End Class
