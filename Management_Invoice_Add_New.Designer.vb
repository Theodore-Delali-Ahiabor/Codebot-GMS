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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_invoice_work_order = New System.Windows.Forms.TextBox()
        Me.InvoicePartsDataGridView = New System.Windows.Forms.DataGridView()
        Me.InvoiceServicesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_payment_status_filter = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_new_invoice_total_services_cost = New System.Windows.Forms.Label()
        Me.lbl_new_invoice_total_parts_cost = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_new_invoice_tax = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_new_invoice_payable_amount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_payment_method_filter = New System.Windows.Forms.ComboBox()
        Me.btn_new_invoice_save = New System.Windows.Forms.Button()
        Me.btn_new_ivoice_cancel = New System.Windows.Forms.Button()
        Me.btn_new_incoice_existing_work_order = New System.Windows.Forms.Button()
        Me.txt_invoice_payment_amount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.InvoicePartsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceServicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(41, 312)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 18)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "Parts"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(129, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 28)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "*"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(36, 21)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(87, 18)
        Me.Label35.TabIndex = 123
        Me.Label35.Text = "Work Order"
        '
        'txt_invoice_work_order
        '
        Me.txt_invoice_work_order.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_invoice_work_order.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice_work_order.Location = New System.Drawing.Point(39, 45)
        Me.txt_invoice_work_order.MaxLength = 35
        Me.txt_invoice_work_order.Name = "txt_invoice_work_order"
        Me.txt_invoice_work_order.Size = New System.Drawing.Size(221, 33)
        Me.txt_invoice_work_order.TabIndex = 103
        '
        'InvoicePartsDataGridView
        '
        Me.InvoicePartsDataGridView.AllowUserToAddRows = False
        Me.InvoicePartsDataGridView.AllowUserToDeleteRows = False
        Me.InvoicePartsDataGridView.AllowUserToResizeColumns = False
        Me.InvoicePartsDataGridView.AllowUserToResizeRows = False
        Me.InvoicePartsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InvoicePartsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InvoicePartsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InvoicePartsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.InvoicePartsDataGridView.CausesValidation = False
        Me.InvoicePartsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoicePartsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InvoicePartsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InvoicePartsDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.InvoicePartsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.InvoicePartsDataGridView.EnableHeadersVisualStyles = False
        Me.InvoicePartsDataGridView.GridColor = System.Drawing.Color.Silver
        Me.InvoicePartsDataGridView.Location = New System.Drawing.Point(39, 333)
        Me.InvoicePartsDataGridView.MultiSelect = False
        Me.InvoicePartsDataGridView.Name = "InvoicePartsDataGridView"
        Me.InvoicePartsDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoicePartsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.InvoicePartsDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoicePartsDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.InvoicePartsDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoicePartsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.InvoicePartsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.InvoicePartsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.InvoicePartsDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoicePartsDataGridView.RowTemplate.Height = 38
        Me.InvoicePartsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InvoicePartsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InvoicePartsDataGridView.Size = New System.Drawing.Size(669, 267)
        Me.InvoicePartsDataGridView.TabIndex = 131
        Me.InvoicePartsDataGridView.VirtualMode = True
        '
        'InvoiceServicesDataGridView
        '
        Me.InvoiceServicesDataGridView.AllowUserToAddRows = False
        Me.InvoiceServicesDataGridView.AllowUserToDeleteRows = False
        Me.InvoiceServicesDataGridView.AllowUserToResizeColumns = False
        Me.InvoiceServicesDataGridView.AllowUserToResizeRows = False
        Me.InvoiceServicesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.InvoiceServicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InvoiceServicesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InvoiceServicesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.InvoiceServicesDataGridView.CausesValidation = False
        Me.InvoiceServicesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceServicesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.InvoiceServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InvoiceServicesDataGridView.DefaultCellStyle = DataGridViewCellStyle6
        Me.InvoiceServicesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.InvoiceServicesDataGridView.EnableHeadersVisualStyles = False
        Me.InvoiceServicesDataGridView.GridColor = System.Drawing.Color.Silver
        Me.InvoiceServicesDataGridView.Location = New System.Drawing.Point(384, 45)
        Me.InvoiceServicesDataGridView.MultiSelect = False
        Me.InvoiceServicesDataGridView.Name = "InvoiceServicesDataGridView"
        Me.InvoiceServicesDataGridView.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceServicesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.InvoiceServicesDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceServicesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.InvoiceServicesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceServicesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.InvoiceServicesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.InvoiceServicesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.InvoiceServicesDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceServicesDataGridView.RowTemplate.Height = 38
        Me.InvoiceServicesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.InvoiceServicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InvoiceServicesDataGridView.Size = New System.Drawing.Size(698, 268)
        Me.InvoiceServicesDataGridView.TabIndex = 131
        Me.InvoiceServicesDataGridView.VirtualMode = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(388, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 129
        Me.Label4.Text = "Services"
        '
        'cmb_payment_status_filter
        '
        Me.cmb_payment_status_filter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_payment_status_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_payment_status_filter.FormattingEnabled = True
        Me.cmb_payment_status_filter.Items.AddRange(New Object() {"Pending Payment", "Partial Payment", "Full Payment"})
        Me.cmb_payment_status_filter.Location = New System.Drawing.Point(40, 235)
        Me.cmb_payment_status_filter.Margin = New System.Windows.Forms.Padding(10)
        Me.cmb_payment_status_filter.Name = "cmb_payment_status_filter"
        Me.cmb_payment_status_filter.Size = New System.Drawing.Size(309, 29)
        Me.cmb_payment_status_filter.TabIndex = 132
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Payment Status"
        '
        'lbl_new_invoice_total_services_cost
        '
        Me.lbl_new_invoice_total_services_cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_new_invoice_total_services_cost.AutoSize = True
        Me.lbl_new_invoice_total_services_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_invoice_total_services_cost.Location = New System.Drawing.Point(215, 11)
        Me.lbl_new_invoice_total_services_cost.Name = "lbl_new_invoice_total_services_cost"
        Me.lbl_new_invoice_total_services_cost.Size = New System.Drawing.Size(44, 18)
        Me.lbl_new_invoice_total_services_cost.TabIndex = 116
        Me.lbl_new_invoice_total_services_cost.Text = "00.00"
        '
        'lbl_new_invoice_total_parts_cost
        '
        Me.lbl_new_invoice_total_parts_cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_new_invoice_total_parts_cost.AutoSize = True
        Me.lbl_new_invoice_total_parts_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_invoice_total_parts_cost.Location = New System.Drawing.Point(215, 51)
        Me.lbl_new_invoice_total_parts_cost.Name = "lbl_new_invoice_total_parts_cost"
        Me.lbl_new_invoice_total_parts_cost.Size = New System.Drawing.Size(44, 18)
        Me.lbl_new_invoice_total_parts_cost.TabIndex = 116
        Me.lbl_new_invoice_total_parts_cost.Text = "00.00"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 18)
        Me.Label8.TabIndex = 116
        Me.Label8.Text = "Total Service Cost"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Total Parts Cost"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 18)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Taxable Amount"
        '
        'lbl_new_invoice_tax
        '
        Me.lbl_new_invoice_tax.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_new_invoice_tax.AutoSize = True
        Me.lbl_new_invoice_tax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_invoice_tax.Location = New System.Drawing.Point(215, 85)
        Me.lbl_new_invoice_tax.Name = "lbl_new_invoice_tax"
        Me.lbl_new_invoice_tax.Size = New System.Drawing.Size(44, 18)
        Me.lbl_new_invoice_tax.TabIndex = 116
        Me.lbl_new_invoice_tax.Text = "00.00"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(162, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 18)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "GHS"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(162, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 18)
        Me.Label14.TabIndex = 116
        Me.Label14.Text = "GHS"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(162, 51)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 18)
        Me.Label16.TabIndex = 116
        Me.Label16.Text = "GHS"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(162, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 18)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "GHS"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 18)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "Payable Ammount"
        '
        'lbl_new_invoice_payable_amount
        '
        Me.lbl_new_invoice_payable_amount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_new_invoice_payable_amount.AutoSize = True
        Me.lbl_new_invoice_payable_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_new_invoice_payable_amount.Location = New System.Drawing.Point(215, 122)
        Me.lbl_new_invoice_payable_amount.Name = "lbl_new_invoice_payable_amount"
        Me.lbl_new_invoice_payable_amount.Size = New System.Drawing.Size(44, 18)
        Me.lbl_new_invoice_payable_amount.TabIndex = 116
        Me.lbl_new_invoice_payable_amount.Text = "00.00"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lbl_new_invoice_total_services_cost)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lbl_new_invoice_total_parts_cost)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lbl_new_invoice_payable_amount)
        Me.Panel1.Controls.Add(Me.lbl_new_invoice_tax)
        Me.Panel1.Location = New System.Drawing.Point(729, 333)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 180)
        Me.Panel1.TabIndex = 133
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 18)
        Me.Label6.TabIndex = 116
        Me.Label6.Text = "Payment Method"
        '
        'cmb_payment_method_filter
        '
        Me.cmb_payment_method_filter.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmb_payment_method_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_payment_method_filter.FormattingEnabled = True
        Me.cmb_payment_method_filter.Items.AddRange(New Object() {"MTN Mobile Money", "Vodafone Cash", "AirtelTigo", "Bank Transfer", "Physical Cash", "Other"})
        Me.cmb_payment_method_filter.Location = New System.Drawing.Point(40, 110)
        Me.cmb_payment_method_filter.Margin = New System.Windows.Forms.Padding(10)
        Me.cmb_payment_method_filter.Name = "cmb_payment_method_filter"
        Me.cmb_payment_method_filter.Size = New System.Drawing.Size(309, 29)
        Me.cmb_payment_method_filter.TabIndex = 132
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
        Me.btn_new_invoice_save.Location = New System.Drawing.Point(740, 559)
        Me.btn_new_invoice_save.Name = "btn_new_invoice_save"
        Me.btn_new_invoice_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_invoice_save.Size = New System.Drawing.Size(141, 41)
        Me.btn_new_invoice_save.TabIndex = 16
        Me.btn_new_invoice_save.Text = "SAVE"
        Me.btn_new_invoice_save.UseVisualStyleBackColor = False
        '
        'btn_new_ivoice_cancel
        '
        Me.btn_new_ivoice_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_ivoice_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_ivoice_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_ivoice_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_new_ivoice_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_ivoice_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_ivoice_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_ivoice_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_ivoice_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_ivoice_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_ivoice_cancel.Location = New System.Drawing.Point(933, 559)
        Me.btn_new_ivoice_cancel.Name = "btn_new_ivoice_cancel"
        Me.btn_new_ivoice_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_ivoice_cancel.Size = New System.Drawing.Size(141, 41)
        Me.btn_new_ivoice_cancel.TabIndex = 17
        Me.btn_new_ivoice_cancel.Text = "CANCEL"
        Me.btn_new_ivoice_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_incoice_existing_work_order
        '
        Me.btn_new_incoice_existing_work_order.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_incoice_existing_work_order.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_new_incoice_existing_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_incoice_existing_work_order.FlatAppearance.BorderSize = 0
        Me.btn_new_incoice_existing_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_incoice_existing_work_order.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_incoice_existing_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_new_incoice_existing_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_incoice_existing_work_order.Location = New System.Drawing.Point(266, 45)
        Me.btn_new_incoice_existing_work_order.Name = "btn_new_incoice_existing_work_order"
        Me.btn_new_incoice_existing_work_order.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_incoice_existing_work_order.Size = New System.Drawing.Size(83, 33)
        Me.btn_new_incoice_existing_work_order.TabIndex = 101
        Me.btn_new_incoice_existing_work_order.Text = "SELECT"
        Me.btn_new_incoice_existing_work_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_incoice_existing_work_order.UseVisualStyleBackColor = False
        '
        'txt_invoice_payment_amount
        '
        Me.txt_invoice_payment_amount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_invoice_payment_amount.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice_payment_amount.Location = New System.Drawing.Point(40, 173)
        Me.txt_invoice_payment_amount.MaxLength = 35
        Me.txt_invoice_payment_amount.Name = "txt_invoice_payment_amount"
        Me.txt_invoice_payment_amount.Size = New System.Drawing.Size(309, 33)
        Me.txt_invoice_payment_amount.TabIndex = 103
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(166, 18)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "Payment Amount / GHS"
        '
        'Management_Invoice_Add_New
        '
        Me.AcceptButton = Me.btn_new_invoice_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btn_new_ivoice_cancel
        Me.ClientSize = New System.Drawing.Size(1121, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.InvoiceServicesDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmb_payment_method_filter)
        Me.Controls.Add(Me.cmb_payment_status_filter)
        Me.Controls.Add(Me.InvoicePartsDataGridView)
        Me.Controls.Add(Me.btn_new_incoice_existing_work_order)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_invoice_payment_amount)
        Me.Controls.Add(Me.txt_invoice_work_order)
        Me.Controls.Add(Me.btn_new_ivoice_cancel)
        Me.Controls.Add(Me.btn_new_invoice_save)
        Me.Name = "Management_Invoice_Add_New"
        Me.Text = "Management_Invoice_Add_New"
        CType(Me.InvoicePartsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceServicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_new_ivoice_cancel As Button
    Friend WithEvents btn_new_invoice_save As Button
    Friend WithEvents btn_new_incoice_existing_work_order As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_invoice_work_order As TextBox
    Friend WithEvents InvoicePartsDataGridView As DataGridView
    Friend WithEvents InvoiceServicesDataGridView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_payment_status_filter As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_new_invoice_total_services_cost As Label
    Friend WithEvents lbl_new_invoice_total_parts_cost As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_new_invoice_tax As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_new_invoice_payable_amount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_payment_method_filter As ComboBox
    Friend WithEvents txt_invoice_payment_amount As TextBox
    Friend WithEvents Label7 As Label
End Class
