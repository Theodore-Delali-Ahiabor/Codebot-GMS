<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Work_Order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Work_Order))
        Me.WorkOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.cmb_work_order_status_filter = New System.Windows.Forms.ComboBox()
        Me.txt_work_order_automobile_name_filter = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_complete_work_order = New System.Windows.Forms.Button()
        Me.btn_start_work_order = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_add_new_work_order = New System.Windows.Forms.Button()
        Me.btn_terminate_work_order = New System.Windows.Forms.Button()
        CType(Me.WorkOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.WorkOrderDataGridView.Location = New System.Drawing.Point(45, 76)
        Me.WorkOrderDataGridView.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.WorkOrderDataGridView.MultiSelect = False
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
        Me.WorkOrderDataGridView.TabIndex = 38
        '
        'cmb_work_order_status_filter
        '
        Me.cmb_work_order_status_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_work_order_status_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_work_order_status_filter.FormattingEnabled = True
        Me.cmb_work_order_status_filter.Location = New System.Drawing.Point(828, 33)
        Me.cmb_work_order_status_filter.Margin = New System.Windows.Forms.Padding(10)
        Me.cmb_work_order_status_filter.Name = "cmb_work_order_status_filter"
        Me.cmb_work_order_status_filter.Size = New System.Drawing.Size(222, 29)
        Me.cmb_work_order_status_filter.TabIndex = 59
        '
        'txt_work_order_automobile_name_filter
        '
        Me.txt_work_order_automobile_name_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_work_order_automobile_name_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_work_order_automobile_name_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_work_order_automobile_name_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_work_order_automobile_name_filter.Location = New System.Drawing.Point(593, 33)
        Me.txt_work_order_automobile_name_filter.Name = "txt_work_order_automobile_name_filter"
        Me.txt_work_order_automobile_name_filter.Size = New System.Drawing.Size(222, 29)
        Me.txt_work_order_automobile_name_filter.TabIndex = 61
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(473, 430)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(577, 81)
        Me.Panel1.TabIndex = 64
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(196, 59)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(16, 17)
        Me.Button6.TabIndex = 45
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Black
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(396, 6)
        Me.Button8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(16, 17)
        Me.Button8.TabIndex = 45
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightGreen
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(196, 6)
        Me.Button5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button5.Size = New System.Drawing.Size(16, 17)
        Me.Button5.TabIndex = 45
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CadetBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(196, 31)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(16, 17)
        Me.Button4.TabIndex = 45
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gold
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(3, 62)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(16, 17)
        Me.Button3.TabIndex = 45
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Honeydew
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(3, 6)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(16, 17)
        Me.Button2.TabIndex = 44
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(3, 33)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(16, 17)
        Me.Button1.TabIndex = 43
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(218, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Pending Start Work Order"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(418, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 19)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Terminated Work Order"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(218, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 19)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "In Progress Work Order"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(218, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 19)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Selected Work Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(25, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Due Soon Work Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Overdue Work Order"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Completed Work Order"
        '
        'btn_complete_work_order
        '
        Me.btn_complete_work_order.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_complete_work_order.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_complete_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_complete_work_order.FlatAppearance.BorderSize = 0
        Me.btn_complete_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_complete_work_order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_complete_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_complete_work_order.Image = CType(resources.GetObject("btn_complete_work_order.Image"), System.Drawing.Image)
        Me.btn_complete_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_complete_work_order.Location = New System.Drawing.Point(155, 455)
        Me.btn_complete_work_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_complete_work_order.Name = "btn_complete_work_order"
        Me.btn_complete_work_order.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_complete_work_order.Size = New System.Drawing.Size(138, 46)
        Me.btn_complete_work_order.TabIndex = 66
        Me.btn_complete_work_order.Text = "COMPLETE"
        Me.btn_complete_work_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_complete_work_order.UseVisualStyleBackColor = False
        '
        'btn_start_work_order
        '
        Me.btn_start_work_order.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_start_work_order.BackColor = System.Drawing.Color.LightGreen
        Me.btn_start_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start_work_order.FlatAppearance.BorderSize = 0
        Me.btn_start_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start_work_order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_start_work_order.Image = CType(resources.GetObject("btn_start_work_order.Image"), System.Drawing.Image)
        Me.btn_start_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_start_work_order.Location = New System.Drawing.Point(43, 455)
        Me.btn_start_work_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_start_work_order.Name = "btn_start_work_order"
        Me.btn_start_work_order.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_start_work_order.Size = New System.Drawing.Size(96, 46)
        Me.btn_start_work_order.TabIndex = 65
        Me.btn_start_work_order.Text = "START"
        Me.btn_start_work_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_start_work_order.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_search_80
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(590, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(177, 27)
        Me.Label3.TabIndex = 63
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
        Me.Label2.Location = New System.Drawing.Point(825, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(191, 27)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Progress Status      "
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
        Me.btn_add_new_work_order.Location = New System.Drawing.Point(45, 5)
        Me.btn_add_new_work_order.Name = "btn_add_new_work_order"
        Me.btn_add_new_work_order.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_add_new_work_order.Size = New System.Drawing.Size(105, 46)
        Me.btn_add_new_work_order.TabIndex = 58
        Me.btn_add_new_work_order.Text = "    New"
        Me.btn_add_new_work_order.UseVisualStyleBackColor = False
        '
        'btn_terminate_work_order
        '
        Me.btn_terminate_work_order.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_terminate_work_order.BackColor = System.Drawing.Color.Black
        Me.btn_terminate_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_terminate_work_order.FlatAppearance.BorderSize = 0
        Me.btn_terminate_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_terminate_work_order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_terminate_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_terminate_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_terminate_work_order.Location = New System.Drawing.Point(309, 455)
        Me.btn_terminate_work_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_terminate_work_order.Name = "btn_terminate_work_order"
        Me.btn_terminate_work_order.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_terminate_work_order.Size = New System.Drawing.Size(138, 46)
        Me.btn_terminate_work_order.TabIndex = 66
        Me.btn_terminate_work_order.Text = "TERMINATE"
        Me.btn_terminate_work_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_terminate_work_order.UseVisualStyleBackColor = False
        '
        'Management_Work_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1101, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_terminate_work_order)
        Me.Controls.Add(Me.btn_complete_work_order)
        Me.Controls.Add(Me.btn_start_work_order)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_work_order_status_filter)
        Me.Controls.Add(Me.btn_add_new_work_order)
        Me.Controls.Add(Me.txt_work_order_automobile_name_filter)
        Me.Controls.Add(Me.WorkOrderDataGridView)
        Me.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "Management_Work_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management_Work_Order"
        CType(Me.WorkOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WorkOrderDataGridView As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_work_order_status_filter As ComboBox
    Friend WithEvents btn_add_new_work_order As Button
    Friend WithEvents txt_work_order_automobile_name_filter As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_complete_work_order As Button
    Friend WithEvents btn_start_work_order As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_terminate_work_order As Button
End Class
