<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Work_Order_Add_New_Automobile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Work_Order_Add_New_Automobile))
        Me.automobile_new_datails_panel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_new_fuel = New System.Windows.Forms.ComboBox()
        Me.txt_new_make = New System.Windows.Forms.ComboBox()
        Me.txt_new_category = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_new_reg_number = New System.Windows.Forms.TextBox()
        Me.txt_new_vin = New System.Windows.Forms.TextBox()
        Me.txt_new_color = New System.Windows.Forms.TextBox()
        Me.txt_new_model = New System.Windows.Forms.TextBox()
        Me.txt_new_year = New System.Windows.Forms.TextBox()
        Me.automobile_select_edit_panel = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AutomobileDataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_automobile_select_cancel = New System.Windows.Forms.Button()
        Me.btn_automobile_select_select = New System.Windows.Forms.Button()
        Me.btn_automobile_select_edit = New System.Windows.Forms.Button()
        Me.btn_automobile_select_new = New System.Windows.Forms.Button()
        Me.btn_new_automobile_cancel = New System.Windows.Forms.Button()
        Me.btn_new_automobile_save = New System.Windows.Forms.Button()
        Me.automobile_new_datails_panel.SuspendLayout()
        Me.automobile_select_edit_panel.SuspendLayout()
        CType(Me.AutomobileDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'automobile_new_datails_panel
        '
        Me.automobile_new_datails_panel.BackColor = System.Drawing.Color.Transparent
        Me.automobile_new_datails_panel.Controls.Add(Me.Label8)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_fuel)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_make)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_category)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label10)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label15)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label6)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label2)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label1)
        Me.automobile_new_datails_panel.Controls.Add(Me.btn_new_automobile_cancel)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label35)
        Me.automobile_new_datails_panel.Controls.Add(Me.btn_new_automobile_save)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label9)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label7)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label5)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label4)
        Me.automobile_new_datails_panel.Controls.Add(Me.Label3)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_reg_number)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_vin)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_color)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_model)
        Me.automobile_new_datails_panel.Controls.Add(Me.txt_new_year)
        Me.automobile_new_datails_panel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.automobile_new_datails_panel.Location = New System.Drawing.Point(548, 12)
        Me.automobile_new_datails_panel.Name = "automobile_new_datails_panel"
        Me.automobile_new_datails_panel.Size = New System.Drawing.Size(469, 497)
        Me.automobile_new_datails_panel.TabIndex = 0
        Me.automobile_new_datails_panel.Visible = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(0, -3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(386, 49)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Add New Automobile"
        '
        'txt_new_fuel
        '
        Me.txt_new_fuel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_fuel.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_fuel.FormattingEnabled = True
        Me.txt_new_fuel.Location = New System.Drawing.Point(267, 182)
        Me.txt_new_fuel.MaxLength = 25
        Me.txt_new_fuel.Name = "txt_new_fuel"
        Me.txt_new_fuel.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_fuel.TabIndex = 96
        '
        'txt_new_make
        '
        Me.txt_new_make.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_make.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_make.FormattingEnabled = True
        Me.txt_new_make.Location = New System.Drawing.Point(-105, 269)
        Me.txt_new_make.MaxLength = 25
        Me.txt_new_make.Name = "txt_new_make"
        Me.txt_new_make.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_make.TabIndex = 96
        '
        'txt_new_category
        '
        Me.txt_new_category.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_category.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_category.FormattingEnabled = True
        Me.txt_new_category.Location = New System.Drawing.Point(-104, 98)
        Me.txt_new_category.MaxLength = 25
        Me.txt_new_category.Name = "txt_new_category"
        Me.txt_new_category.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_category.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(264, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 18)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Registration Nmber"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(264, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 18)
        Me.Label15.TabIndex = 115
        Me.Label15.Text = "VIN"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(-53, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 28)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "*"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(307, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 28)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(-40, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 28)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "*"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label35.Location = New System.Drawing.Point(-107, 77)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 18)
        Me.Label35.TabIndex = 111
        Me.Label35.Text = "Category"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(267, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 18)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Color"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(265, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 18)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Fuel"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(-105, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Model"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(-104, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Make"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(-107, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Year "
        '
        'txt_new_reg_number
        '
        Me.txt_new_reg_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_reg_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_reg_number.Location = New System.Drawing.Point(267, 345)
        Me.txt_new_reg_number.MaxLength = 25
        Me.txt_new_reg_number.Name = "txt_new_reg_number"
        Me.txt_new_reg_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_reg_number.TabIndex = 103
        '
        'txt_new_vin
        '
        Me.txt_new_vin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_vin.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_vin.Location = New System.Drawing.Point(267, 269)
        Me.txt_new_vin.MaxLength = 25
        Me.txt_new_vin.Name = "txt_new_vin"
        Me.txt_new_vin.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_vin.TabIndex = 102
        '
        'txt_new_color
        '
        Me.txt_new_color.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_color.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_color.Location = New System.Drawing.Point(267, 98)
        Me.txt_new_color.MaxLength = 25
        Me.txt_new_color.Name = "txt_new_color"
        Me.txt_new_color.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_color.TabIndex = 100
        '
        'txt_new_model
        '
        Me.txt_new_model.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_model.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_model.Location = New System.Drawing.Point(-104, 345)
        Me.txt_new_model.MaxLength = 25
        Me.txt_new_model.Name = "txt_new_model"
        Me.txt_new_model.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_model.TabIndex = 99
        '
        'txt_new_year
        '
        Me.txt_new_year.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_year.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_year.Location = New System.Drawing.Point(-104, 182)
        Me.txt_new_year.MaxLength = 4
        Me.txt_new_year.Name = "txt_new_year"
        Me.txt_new_year.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_year.TabIndex = 97
        '
        'automobile_select_edit_panel
        '
        Me.automobile_select_edit_panel.BackColor = System.Drawing.Color.Transparent
        Me.automobile_select_edit_panel.Controls.Add(Me.Label11)
        Me.automobile_select_edit_panel.Controls.Add(Me.btn_automobile_select_select)
        Me.automobile_select_edit_panel.Controls.Add(Me.btn_automobile_select_cancel)
        Me.automobile_select_edit_panel.Controls.Add(Me.btn_automobile_select_edit)
        Me.automobile_select_edit_panel.Controls.Add(Me.btn_automobile_select_new)
        Me.automobile_select_edit_panel.Controls.Add(Me.AutomobileDataGridView)
        Me.automobile_select_edit_panel.Location = New System.Drawing.Point(0, 12)
        Me.automobile_select_edit_panel.Name = "automobile_select_edit_panel"
        Me.automobile_select_edit_panel.Size = New System.Drawing.Size(524, 497)
        Me.automobile_select_edit_panel.TabIndex = 1
        Me.automobile_select_edit_panel.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(97, -7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(391, 49)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Select an Automobile"
        '
        'AutomobileDataGridView
        '
        Me.AutomobileDataGridView.AllowUserToAddRows = False
        Me.AutomobileDataGridView.AllowUserToDeleteRows = False
        Me.AutomobileDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutomobileDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AutomobileDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.AutomobileDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AutomobileDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.AutomobileDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AutomobileDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.AutomobileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AutomobileDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.AutomobileDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.AutomobileDataGridView.EnableHeadersVisualStyles = False
        Me.AutomobileDataGridView.GridColor = System.Drawing.Color.Silver
        Me.AutomobileDataGridView.Location = New System.Drawing.Point(34, 58)
        Me.AutomobileDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AutomobileDataGridView.MultiSelect = False
        Me.AutomobileDataGridView.Name = "AutomobileDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AutomobileDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.AutomobileDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AutomobileDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.AutomobileDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutomobileDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.AutomobileDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.AutomobileDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.AutomobileDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.AutomobileDataGridView.RowTemplate.Height = 38
        Me.AutomobileDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AutomobileDataGridView.Size = New System.Drawing.Size(449, 371)
        Me.AutomobileDataGridView.TabIndex = 2
        Me.AutomobileDataGridView.VirtualMode = True
        '
        'btn_automobile_select_cancel
        '
        Me.btn_automobile_select_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_automobile_select_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_automobile_select_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_automobile_select_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_automobile_select_cancel.FlatAppearance.BorderSize = 0
        Me.btn_automobile_select_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_automobile_select_cancel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_automobile_select_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_automobile_select_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_automobile_select_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_automobile_select_cancel.Location = New System.Drawing.Point(393, 455)
        Me.btn_automobile_select_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_automobile_select_cancel.Name = "btn_automobile_select_cancel"
        Me.btn_automobile_select_cancel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_automobile_select_cancel.Size = New System.Drawing.Size(128, 38)
        Me.btn_automobile_select_cancel.TabIndex = 35
        Me.btn_automobile_select_cancel.Text = "CANCEL"
        Me.btn_automobile_select_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_automobile_select_cancel.UseVisualStyleBackColor = False
        '
        'btn_automobile_select_select
        '
        Me.btn_automobile_select_select.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_automobile_select_select.BackColor = System.Drawing.Color.LightGreen
        Me.btn_automobile_select_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_automobile_select_select.FlatAppearance.BorderSize = 0
        Me.btn_automobile_select_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_automobile_select_select.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_automobile_select_select.ForeColor = System.Drawing.Color.White
        Me.btn_automobile_select_select.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_checkmark_24
        Me.btn_automobile_select_select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_automobile_select_select.Location = New System.Drawing.Point(254, 455)
        Me.btn_automobile_select_select.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_automobile_select_select.Name = "btn_automobile_select_select"
        Me.btn_automobile_select_select.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_automobile_select_select.Size = New System.Drawing.Size(113, 38)
        Me.btn_automobile_select_select.TabIndex = 35
        Me.btn_automobile_select_select.Text = "SELECT"
        Me.btn_automobile_select_select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_automobile_select_select.UseVisualStyleBackColor = False
        '
        'btn_automobile_select_edit
        '
        Me.btn_automobile_select_edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_automobile_select_edit.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_automobile_select_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_automobile_select_edit.FlatAppearance.BorderSize = 0
        Me.btn_automobile_select_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_automobile_select_edit.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_automobile_select_edit.ForeColor = System.Drawing.Color.White
        Me.btn_automobile_select_edit.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_edit_white_24
        Me.btn_automobile_select_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_automobile_select_edit.Location = New System.Drawing.Point(127, 455)
        Me.btn_automobile_select_edit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_automobile_select_edit.Name = "btn_automobile_select_edit"
        Me.btn_automobile_select_edit.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_automobile_select_edit.Size = New System.Drawing.Size(100, 38)
        Me.btn_automobile_select_edit.TabIndex = 35
        Me.btn_automobile_select_edit.Text = "EDIT"
        Me.btn_automobile_select_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_automobile_select_edit.UseVisualStyleBackColor = False
        '
        'btn_automobile_select_new
        '
        Me.btn_automobile_select_new.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_automobile_select_new.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_automobile_select_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_automobile_select_new.FlatAppearance.BorderSize = 0
        Me.btn_automobile_select_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_automobile_select_new.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_automobile_select_new.ForeColor = System.Drawing.Color.White
        Me.btn_automobile_select_new.Image = CType(resources.GetObject("btn_automobile_select_new.Image"), System.Drawing.Image)
        Me.btn_automobile_select_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_automobile_select_new.Location = New System.Drawing.Point(6, 455)
        Me.btn_automobile_select_new.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_automobile_select_new.Name = "btn_automobile_select_new"
        Me.btn_automobile_select_new.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_automobile_select_new.Size = New System.Drawing.Size(100, 38)
        Me.btn_automobile_select_new.TabIndex = 34
        Me.btn_automobile_select_new.Text = "NEW"
        Me.btn_automobile_select_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_automobile_select_new.UseVisualStyleBackColor = False
        '
        'btn_new_automobile_cancel
        '
        Me.btn_new_automobile_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_automobile_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_automobile_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_automobile_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_automobile_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_automobile_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_automobile_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_automobile_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_automobile_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_automobile_cancel.Location = New System.Drawing.Point(259, 426)
        Me.btn_new_automobile_cancel.Name = "btn_new_automobile_cancel"
        Me.btn_new_automobile_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_automobile_cancel.Size = New System.Drawing.Size(141, 38)
        Me.btn_new_automobile_cancel.TabIndex = 105
        Me.btn_new_automobile_cancel.Text = "CANCEL"
        Me.btn_new_automobile_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_automobile_save
        '
        Me.btn_new_automobile_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_automobile_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_automobile_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_automobile_save.FlatAppearance.BorderSize = 0
        Me.btn_new_automobile_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_automobile_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_automobile_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_automobile_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_automobile_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_automobile_save.Location = New System.Drawing.Point(82, 426)
        Me.btn_new_automobile_save.Name = "btn_new_automobile_save"
        Me.btn_new_automobile_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_automobile_save.Size = New System.Drawing.Size(141, 38)
        Me.btn_new_automobile_save.TabIndex = 104
        Me.btn_new_automobile_save.Text = "SAVE"
        Me.btn_new_automobile_save.UseVisualStyleBackColor = False
        '
        'Management_Work_Order_Add_New_Automobile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.btn_automobile_select_cancel
        Me.ClientSize = New System.Drawing.Size(1030, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.automobile_select_edit_panel)
        Me.Controls.Add(Me.automobile_new_datails_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(280, 150)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Management_Work_Order_Add_New_Automobile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Automobile"
        Me.TopMost = True
        Me.automobile_new_datails_panel.ResumeLayout(False)
        Me.automobile_new_datails_panel.PerformLayout()
        Me.automobile_select_edit_panel.ResumeLayout(False)
        Me.automobile_select_edit_panel.PerformLayout()
        CType(Me.AutomobileDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents automobile_new_datails_panel As Panel
    Friend WithEvents txt_new_category As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_new_automobile_cancel As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents btn_new_automobile_save As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_new_reg_number As TextBox
    Friend WithEvents txt_new_vin As TextBox
    Friend WithEvents txt_new_color As TextBox
    Friend WithEvents txt_new_model As TextBox
    Friend WithEvents txt_new_year As TextBox
    Friend WithEvents txt_new_fuel As ComboBox
    Friend WithEvents automobile_select_edit_panel As Panel
    Friend WithEvents AutomobileDataGridView As DataGridView
    Friend WithEvents btn_automobile_select_select As Button
    Friend WithEvents btn_automobile_select_cancel As Button
    Friend WithEvents btn_automobile_select_edit As Button
    Friend WithEvents btn_automobile_select_new As Button
    Friend WithEvents txt_new_make As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
End Class
