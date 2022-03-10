<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Inventory_Stock_In
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_stock_in = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_stock_in_name = New System.Windows.Forms.TextBox()
        Me.txt_stock_in_quntity = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_stock_in_cancel = New System.Windows.Forms.Button()
        CType(Me.txt_stock_in_quntity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(168, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 45)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Stock In "
        '
        'btn_stock_in
        '
        Me.btn_stock_in.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_stock_in.BackColor = System.Drawing.Color.LightGreen
        Me.btn_stock_in.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_stock_in.FlatAppearance.BorderSize = 0
        Me.btn_stock_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stock_in.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stock_in.ForeColor = System.Drawing.Color.White
        Me.btn_stock_in.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_stock_in.Location = New System.Drawing.Point(84, 318)
        Me.btn_stock_in.Name = "btn_stock_in"
        Me.btn_stock_in.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_stock_in.Size = New System.Drawing.Size(136, 39)
        Me.btn_stock_in.TabIndex = 130
        Me.btn_stock_in.Text = "STOCK IN"
        Me.btn_stock_in.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_stock_in.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 18)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Item Name / Description"
        '
        'txt_stock_in_name
        '
        Me.txt_stock_in_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_stock_in_name.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_stock_in_name.Location = New System.Drawing.Point(49, 136)
        Me.txt_stock_in_name.MaxLength = 35
        Me.txt_stock_in_name.Name = "txt_stock_in_name"
        Me.txt_stock_in_name.Size = New System.Drawing.Size(369, 33)
        Me.txt_stock_in_name.TabIndex = 132
        '
        'txt_stock_in_quntity
        '
        Me.txt_stock_in_quntity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_stock_in_quntity.Font = New System.Drawing.Font("Ebrima", 14.25!)
        Me.txt_stock_in_quntity.Location = New System.Drawing.Point(49, 231)
        Me.txt_stock_in_quntity.Name = "txt_stock_in_quntity"
        Me.txt_stock_in_quntity.Size = New System.Drawing.Size(369, 33)
        Me.txt_stock_in_quntity.TabIndex = 134
        Me.txt_stock_in_quntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 18)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Stock In Quantity"
        '
        'btn_stock_in_cancel
        '
        Me.btn_stock_in_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_stock_in_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_stock_in_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_stock_in_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_stock_in_cancel.FlatAppearance.BorderSize = 0
        Me.btn_stock_in_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stock_in_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stock_in_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_stock_in_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.delete_24px
        Me.btn_stock_in_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_stock_in_cancel.Location = New System.Drawing.Point(246, 317)
        Me.btn_stock_in_cancel.Name = "btn_stock_in_cancel"
        Me.btn_stock_in_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_stock_in_cancel.Size = New System.Drawing.Size(128, 40)
        Me.btn_stock_in_cancel.TabIndex = 131
        Me.btn_stock_in_cancel.Text = "CANCEL    "
        Me.btn_stock_in_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_stock_in_cancel.UseVisualStyleBackColor = False
        '
        'Management_Inventory_Stock_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(469, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_stock_in_quntity)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_stock_in_name)
        Me.Controls.Add(Me.btn_stock_in_cancel)
        Me.Controls.Add(Me.btn_stock_in)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Management_Inventory_Stock_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management_Inventory_Stock_In"
        CType(Me.txt_stock_in_quntity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btn_stock_in_cancel As Button
    Friend WithEvents btn_stock_in As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_stock_in_name As TextBox
    Friend WithEvents txt_stock_in_quntity As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
