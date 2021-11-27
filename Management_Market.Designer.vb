<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Market
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.MarketDataGridView = New System.Windows.Forms.DataGridView()
        Me.txt_work_order_id = New System.Windows.Forms.TextBox()
        Me.btn_new_parts_requisition_cancel = New System.Windows.Forms.Button()
        Me.btn_new_parts_requisition_save = New System.Windows.Forms.Button()
        CType(Me.MarketDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(66, 27)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(144, 18)
        Me.Label35.TabIndex = 88
        Me.Label35.Text = "Enter Work Order ID"
        '
        'MarketDataGridView
        '
        Me.MarketDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.MarketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MarketDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MarketDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.MarketDataGridView.CausesValidation = False
        Me.MarketDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarketDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MarketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MarketDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.MarketDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.MarketDataGridView.EnableHeadersVisualStyles = False
        Me.MarketDataGridView.GridColor = System.Drawing.Color.Silver
        Me.MarketDataGridView.Location = New System.Drawing.Point(69, 105)
        Me.MarketDataGridView.MultiSelect = False
        Me.MarketDataGridView.Name = "MarketDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarketDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MarketDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarketDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.MarketDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MarketDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.MarketDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.MarketDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.MarketDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarketDataGridView.RowTemplate.Height = 38
        Me.MarketDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.MarketDataGridView.Size = New System.Drawing.Size(911, 394)
        Me.MarketDataGridView.TabIndex = 95
        Me.MarketDataGridView.VirtualMode = True
        '
        'txt_work_order_id
        '
        Me.txt_work_order_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_work_order_id.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_work_order_id.Location = New System.Drawing.Point(69, 48)
        Me.txt_work_order_id.MaxLength = 35
        Me.txt_work_order_id.Name = "txt_work_order_id"
        Me.txt_work_order_id.Size = New System.Drawing.Size(287, 33)
        Me.txt_work_order_id.TabIndex = 79
        '
        'btn_new_parts_requisition_cancel
        '
        Me.btn_new_parts_requisition_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_parts_requisition_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_parts_requisition_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_parts_requisition_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_parts_requisition_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_parts_requisition_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_parts_requisition_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_parts_requisition_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_parts_requisition_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_parts_requisition_cancel.Location = New System.Drawing.Point(538, 521)
        Me.btn_new_parts_requisition_cancel.Name = "btn_new_parts_requisition_cancel"
        Me.btn_new_parts_requisition_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_parts_requisition_cancel.Size = New System.Drawing.Size(141, 52)
        Me.btn_new_parts_requisition_cancel.TabIndex = 94
        Me.btn_new_parts_requisition_cancel.Text = "CANCEL"
        Me.btn_new_parts_requisition_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_parts_requisition_save
        '
        Me.btn_new_parts_requisition_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_parts_requisition_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_parts_requisition_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_parts_requisition_save.FlatAppearance.BorderSize = 0
        Me.btn_new_parts_requisition_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_parts_requisition_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_parts_requisition_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_parts_requisition_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_parts_requisition_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_parts_requisition_save.Location = New System.Drawing.Point(361, 521)
        Me.btn_new_parts_requisition_save.Name = "btn_new_parts_requisition_save"
        Me.btn_new_parts_requisition_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_parts_requisition_save.Size = New System.Drawing.Size(141, 52)
        Me.btn_new_parts_requisition_save.TabIndex = 93
        Me.btn_new_parts_requisition_save.Text = "SAVE"
        Me.btn_new_parts_requisition_save.UseVisualStyleBackColor = False
        '
        'Management_Market
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 585)
        Me.Controls.Add(Me.MarketDataGridView)
        Me.Controls.Add(Me.btn_new_parts_requisition_cancel)
        Me.Controls.Add(Me.btn_new_parts_requisition_save)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txt_work_order_id)
        Me.Name = "Management_Market"
        Me.Text = "Market"
        CType(Me.MarketDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label35 As Label
    Friend WithEvents btn_new_parts_requisition_cancel As Button
    Friend WithEvents btn_new_parts_requisition_save As Button
    Friend WithEvents MarketDataGridView As DataGridView
    Friend WithEvents txt_work_order_id As TextBox
End Class
