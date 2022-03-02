<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Invoice_Select_Work_Order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Invoice_Select_Work_Order))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.InvoiceSelectWorkOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_invoice_select_select = New System.Windows.Forms.Button()
        Me.btn_invoice_select_cancel = New System.Windows.Forms.Button()
        Me.btn_invoice_select_new = New System.Windows.Forms.Button()
        CType(Me.InvoiceSelectWorkOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(310, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(442, 45)
        Me.Label11.TabIndex = 134
        Me.Label11.Text = "Select an Existing work Order"
        '
        'InvoiceSelectWorkOrderDataGridView
        '
        Me.InvoiceSelectWorkOrderDataGridView.AllowUserToAddRows = False
        Me.InvoiceSelectWorkOrderDataGridView.AllowUserToDeleteRows = False
        Me.InvoiceSelectWorkOrderDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoiceSelectWorkOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InvoiceSelectWorkOrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InvoiceSelectWorkOrderDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.InvoiceSelectWorkOrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.InvoiceSelectWorkOrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceSelectWorkOrderDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InvoiceSelectWorkOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InvoiceSelectWorkOrderDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.InvoiceSelectWorkOrderDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InvoiceSelectWorkOrderDataGridView.EnableHeadersVisualStyles = False
        Me.InvoiceSelectWorkOrderDataGridView.GridColor = System.Drawing.Color.Silver
        Me.InvoiceSelectWorkOrderDataGridView.Location = New System.Drawing.Point(34, 56)
        Me.InvoiceSelectWorkOrderDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InvoiceSelectWorkOrderDataGridView.MultiSelect = False
        Me.InvoiceSelectWorkOrderDataGridView.Name = "InvoiceSelectWorkOrderDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceSelectWorkOrderDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.InvoiceSelectWorkOrderDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceSelectWorkOrderDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.InvoiceSelectWorkOrderDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceSelectWorkOrderDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.InvoiceSelectWorkOrderDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.InvoiceSelectWorkOrderDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.InvoiceSelectWorkOrderDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceSelectWorkOrderDataGridView.RowTemplate.Height = 38
        Me.InvoiceSelectWorkOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InvoiceSelectWorkOrderDataGridView.Size = New System.Drawing.Size(954, 414)
        Me.InvoiceSelectWorkOrderDataGridView.TabIndex = 129
        Me.InvoiceSelectWorkOrderDataGridView.VirtualMode = True
        '
        'btn_invoice_select_select
        '
        Me.btn_invoice_select_select.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_invoice_select_select.BackColor = System.Drawing.Color.LightGreen
        Me.btn_invoice_select_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice_select_select.FlatAppearance.BorderSize = 0
        Me.btn_invoice_select_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_invoice_select_select.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice_select_select.ForeColor = System.Drawing.Color.White
        Me.btn_invoice_select_select.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_checkmark_24
        Me.btn_invoice_select_select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_invoice_select_select.Location = New System.Drawing.Point(452, 489)
        Me.btn_invoice_select_select.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_invoice_select_select.Name = "btn_invoice_select_select"
        Me.btn_invoice_select_select.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_invoice_select_select.Size = New System.Drawing.Size(113, 38)
        Me.btn_invoice_select_select.TabIndex = 131
        Me.btn_invoice_select_select.Text = "SELECT"
        Me.btn_invoice_select_select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_invoice_select_select.UseVisualStyleBackColor = False
        '
        'btn_invoice_select_cancel
        '
        Me.btn_invoice_select_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_invoice_select_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_invoice_select_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice_select_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_invoice_select_cancel.FlatAppearance.BorderSize = 0
        Me.btn_invoice_select_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_invoice_select_cancel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice_select_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_invoice_select_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_invoice_select_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_invoice_select_cancel.Location = New System.Drawing.Point(595, 489)
        Me.btn_invoice_select_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_invoice_select_cancel.Name = "btn_invoice_select_cancel"
        Me.btn_invoice_select_cancel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_invoice_select_cancel.Size = New System.Drawing.Size(128, 38)
        Me.btn_invoice_select_cancel.TabIndex = 132
        Me.btn_invoice_select_cancel.Text = "CANCEL"
        Me.btn_invoice_select_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_invoice_select_cancel.UseVisualStyleBackColor = False
        '
        'btn_invoice_select_new
        '
        Me.btn_invoice_select_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_invoice_select_new.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_invoice_select_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice_select_new.FlatAppearance.BorderSize = 0
        Me.btn_invoice_select_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_invoice_select_new.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice_select_new.ForeColor = System.Drawing.Color.White
        Me.btn_invoice_select_new.Image = CType(resources.GetObject("btn_invoice_select_new.Image"), System.Drawing.Image)
        Me.btn_invoice_select_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_invoice_select_new.Location = New System.Drawing.Point(318, 489)
        Me.btn_invoice_select_new.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_invoice_select_new.Name = "btn_invoice_select_new"
        Me.btn_invoice_select_new.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_invoice_select_new.Size = New System.Drawing.Size(100, 38)
        Me.btn_invoice_select_new.TabIndex = 130
        Me.btn_invoice_select_new.Text = "NEW"
        Me.btn_invoice_select_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_invoice_select_new.UseVisualStyleBackColor = False
        '
        'Management_Invoice_Select_Work_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1014, 540)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_invoice_select_select)
        Me.Controls.Add(Me.btn_invoice_select_cancel)
        Me.Controls.Add(Me.btn_invoice_select_new)
        Me.Controls.Add(Me.InvoiceSelectWorkOrderDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(280, 150)
        Me.Name = "Management_Invoice_Select_Work_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Invoice_Select_Work_Order"
        CType(Me.InvoiceSelectWorkOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents btn_invoice_select_select As Button
    Friend WithEvents btn_invoice_select_cancel As Button
    Friend WithEvents btn_invoice_select_new As Button
    Friend WithEvents InvoiceSelectWorkOrderDataGridView As DataGridView
End Class
