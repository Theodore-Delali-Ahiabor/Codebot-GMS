<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Invoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_work_order_status_filter = New System.Windows.Forms.ComboBox()
        Me.btn_add_new_work_order = New System.Windows.Forms.Button()
        Me.txt_work_order_automobile_name_filter = New System.Windows.Forms.TextBox()
        Me.WorkOrderDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.WorkOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_search_80
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(593, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(177, 27)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Work Order ID       "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(828, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(173, 27)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Invoice Status       "
        '
        'cmb_work_order_status_filter
        '
        Me.cmb_work_order_status_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_work_order_status_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_work_order_status_filter.FormattingEnabled = True
        Me.cmb_work_order_status_filter.Location = New System.Drawing.Point(831, 48)
        Me.cmb_work_order_status_filter.Margin = New System.Windows.Forms.Padding(10)
        Me.cmb_work_order_status_filter.Name = "cmb_work_order_status_filter"
        Me.cmb_work_order_status_filter.Size = New System.Drawing.Size(222, 29)
        Me.cmb_work_order_status_filter.TabIndex = 66
        '
        'btn_add_new_work_order
        '
        Me.btn_add_new_work_order.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_add_new_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_new_work_order.FlatAppearance.BorderSize = 0
        Me.btn_add_new_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_new_work_order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_add_new_work_order.Image = CType(resources.GetObject("btn_add_new_work_order.Image"), System.Drawing.Image)
        Me.btn_add_new_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_new_work_order.Location = New System.Drawing.Point(48, 20)
        Me.btn_add_new_work_order.Name = "btn_add_new_work_order"
        Me.btn_add_new_work_order.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_add_new_work_order.Size = New System.Drawing.Size(105, 46)
        Me.btn_add_new_work_order.TabIndex = 65
        Me.btn_add_new_work_order.Text = "    New"
        Me.btn_add_new_work_order.UseVisualStyleBackColor = False
        '
        'txt_work_order_automobile_name_filter
        '
        Me.txt_work_order_automobile_name_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_work_order_automobile_name_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_work_order_automobile_name_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_work_order_automobile_name_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_work_order_automobile_name_filter.Location = New System.Drawing.Point(596, 48)
        Me.txt_work_order_automobile_name_filter.Name = "txt_work_order_automobile_name_filter"
        Me.txt_work_order_automobile_name_filter.Size = New System.Drawing.Size(222, 29)
        Me.txt_work_order_automobile_name_filter.TabIndex = 68
        '
        'WorkOrderDataGridView
        '
        Me.WorkOrderDataGridView.AllowUserToAddRows = False
        Me.WorkOrderDataGridView.AllowUserToDeleteRows = False
        Me.WorkOrderDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WorkOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.WorkOrderDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.WorkOrderDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WorkOrderDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.WorkOrderDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WorkOrderDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.WorkOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.WorkOrderDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.WorkOrderDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.WorkOrderDataGridView.EnableHeadersVisualStyles = False
        Me.WorkOrderDataGridView.GridColor = System.Drawing.Color.Silver
        Me.WorkOrderDataGridView.Location = New System.Drawing.Point(48, 91)
        Me.WorkOrderDataGridView.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.WorkOrderDataGridView.Name = "WorkOrderDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WorkOrderDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.WorkOrderDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WorkOrderDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.WorkOrderDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkOrderDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.WorkOrderDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.WorkOrderDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.WorkOrderDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.WorkOrderDataGridView.RowTemplate.Height = 38
        Me.WorkOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.WorkOrderDataGridView.Size = New System.Drawing.Size(1005, 347)
        Me.WorkOrderDataGridView.TabIndex = 64
        '
        'Management_Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 538)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_work_order_status_filter)
        Me.Controls.Add(Me.btn_add_new_work_order)
        Me.Controls.Add(Me.txt_work_order_automobile_name_filter)
        Me.Controls.Add(Me.WorkOrderDataGridView)
        Me.Name = "Management_Invoice"
        Me.Text = "Management_Invoice"
        CType(Me.WorkOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_work_order_status_filter As ComboBox
    Friend WithEvents btn_add_new_work_order As Button
    Friend WithEvents txt_work_order_automobile_name_filter As TextBox
    Friend WithEvents WorkOrderDataGridView As DataGridView
End Class
