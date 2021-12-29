<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Inventory_Add_New_Suplyer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Inventory_Add_New_Suplyer))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.supplier_select_panel = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_suplier_select_select = New System.Windows.Forms.Button()
        Me.btn_suplier_select_cancel = New System.Windows.Forms.Button()
        Me.btn_suplier_select_edit = New System.Windows.Forms.Button()
        Me.btn_suplier_select_new = New System.Windows.Forms.Button()
        Me.SupplierDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_new_supplier_location = New System.Windows.Forms.TextBox()
        Me.txt_new_supplier_rep = New System.Windows.Forms.TextBox()
        Me.supplier_new_datails_panel = New System.Windows.Forms.Panel()
        Me.btn_new_suplier_cancel = New System.Windows.Forms.Button()
        Me.btn_new_suplier_save = New System.Windows.Forms.Button()
        Me.txt_new_supplier_description = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_new_supplier_email = New System.Windows.Forms.TextBox()
        Me.txt_new_supplier_phone_number = New System.Windows.Forms.TextBox()
        Me.txt_new_supplier_post_box = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_post_box = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_new_supplier_business_sector = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.supplier_select_panel.SuspendLayout()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.supplier_new_datails_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'supplier_select_panel
        '
        Me.supplier_select_panel.BackColor = System.Drawing.Color.Transparent
        Me.supplier_select_panel.Controls.Add(Me.Label11)
        Me.supplier_select_panel.Controls.Add(Me.btn_suplier_select_select)
        Me.supplier_select_panel.Controls.Add(Me.btn_suplier_select_cancel)
        Me.supplier_select_panel.Controls.Add(Me.btn_suplier_select_edit)
        Me.supplier_select_panel.Controls.Add(Me.btn_suplier_select_new)
        Me.supplier_select_panel.Controls.Add(Me.SupplierDataGridView)
        Me.supplier_select_panel.Location = New System.Drawing.Point(33, 8)
        Me.supplier_select_panel.Name = "supplier_select_panel"
        Me.supplier_select_panel.Size = New System.Drawing.Size(482, 497)
        Me.supplier_select_panel.TabIndex = 3
        Me.supplier_select_panel.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(76, -7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(322, 49)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Select a Supplier"
        '
        'btn_suplier_select_select
        '
        Me.btn_suplier_select_select.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_suplier_select_select.BackColor = System.Drawing.Color.LightGreen
        Me.btn_suplier_select_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suplier_select_select.FlatAppearance.BorderSize = 0
        Me.btn_suplier_select_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suplier_select_select.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suplier_select_select.ForeColor = System.Drawing.Color.White
        Me.btn_suplier_select_select.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_checkmark_24
        Me.btn_suplier_select_select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_suplier_select_select.Location = New System.Drawing.Point(233, 455)
        Me.btn_suplier_select_select.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_suplier_select_select.Name = "btn_suplier_select_select"
        Me.btn_suplier_select_select.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_suplier_select_select.Size = New System.Drawing.Size(113, 38)
        Me.btn_suplier_select_select.TabIndex = 35
        Me.btn_suplier_select_select.Text = "SELECT"
        Me.btn_suplier_select_select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suplier_select_select.UseVisualStyleBackColor = False
        '
        'btn_suplier_select_cancel
        '
        Me.btn_suplier_select_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_suplier_select_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_suplier_select_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suplier_select_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_suplier_select_cancel.FlatAppearance.BorderSize = 0
        Me.btn_suplier_select_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suplier_select_cancel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suplier_select_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_suplier_select_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_suplier_select_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_suplier_select_cancel.Location = New System.Drawing.Point(372, 455)
        Me.btn_suplier_select_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_suplier_select_cancel.Name = "btn_suplier_select_cancel"
        Me.btn_suplier_select_cancel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_suplier_select_cancel.Size = New System.Drawing.Size(128, 38)
        Me.btn_suplier_select_cancel.TabIndex = 35
        Me.btn_suplier_select_cancel.Text = "CANCEL"
        Me.btn_suplier_select_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suplier_select_cancel.UseVisualStyleBackColor = False
        '
        'btn_suplier_select_edit
        '
        Me.btn_suplier_select_edit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_suplier_select_edit.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_suplier_select_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suplier_select_edit.FlatAppearance.BorderSize = 0
        Me.btn_suplier_select_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suplier_select_edit.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suplier_select_edit.ForeColor = System.Drawing.Color.White
        Me.btn_suplier_select_edit.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_edit_white_24
        Me.btn_suplier_select_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_suplier_select_edit.Location = New System.Drawing.Point(106, 455)
        Me.btn_suplier_select_edit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_suplier_select_edit.Name = "btn_suplier_select_edit"
        Me.btn_suplier_select_edit.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_suplier_select_edit.Size = New System.Drawing.Size(100, 38)
        Me.btn_suplier_select_edit.TabIndex = 35
        Me.btn_suplier_select_edit.Text = "EDIT"
        Me.btn_suplier_select_edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suplier_select_edit.UseVisualStyleBackColor = False
        '
        'btn_suplier_select_new
        '
        Me.btn_suplier_select_new.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_suplier_select_new.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_suplier_select_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_suplier_select_new.FlatAppearance.BorderSize = 0
        Me.btn_suplier_select_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_suplier_select_new.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_suplier_select_new.ForeColor = System.Drawing.Color.White
        Me.btn_suplier_select_new.Image = CType(resources.GetObject("btn_suplier_select_new.Image"), System.Drawing.Image)
        Me.btn_suplier_select_new.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_suplier_select_new.Location = New System.Drawing.Point(-15, 455)
        Me.btn_suplier_select_new.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_suplier_select_new.Name = "btn_suplier_select_new"
        Me.btn_suplier_select_new.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_suplier_select_new.Size = New System.Drawing.Size(100, 38)
        Me.btn_suplier_select_new.TabIndex = 34
        Me.btn_suplier_select_new.Text = "NEW"
        Me.btn_suplier_select_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_suplier_select_new.UseVisualStyleBackColor = False
        '
        'SupplierDataGridView
        '
        Me.SupplierDataGridView.AllowUserToAddRows = False
        Me.SupplierDataGridView.AllowUserToDeleteRows = False
        Me.SupplierDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SupplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SupplierDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.SupplierDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.SupplierDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SupplierDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.SupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SupplierDataGridView.DefaultCellStyle = DataGridViewCellStyle14
        Me.SupplierDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SupplierDataGridView.EnableHeadersVisualStyles = False
        Me.SupplierDataGridView.GridColor = System.Drawing.Color.Silver
        Me.SupplierDataGridView.Location = New System.Drawing.Point(34, 58)
        Me.SupplierDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SupplierDataGridView.MultiSelect = False
        Me.SupplierDataGridView.Name = "SupplierDataGridView"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.SupplierDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.SupplierDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.SupplierDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.SupplierDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.SupplierDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SupplierDataGridView.RowTemplate.Height = 38
        Me.SupplierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SupplierDataGridView.Size = New System.Drawing.Size(407, 371)
        Me.SupplierDataGridView.TabIndex = 2
        Me.SupplierDataGridView.VirtualMode = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(60, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(314, 49)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Add New Suplier"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(-38, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 28)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(78, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 28)
        Me.Label1.TabIndex = 112
        Me.Label1.Text = "*"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label35.Location = New System.Drawing.Point(-112, 93)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(162, 18)
        Me.Label35.TabIndex = 111
        Me.Label35.Text = "Full Name / Description"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(-109, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Location"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(-112, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Representative"
        '
        'txt_new_supplier_location
        '
        Me.txt_new_supplier_location.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier_location.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier_location.Location = New System.Drawing.Point(-113, 287)
        Me.txt_new_supplier_location.MaxLength = 100
        Me.txt_new_supplier_location.Name = "txt_new_supplier_location"
        Me.txt_new_supplier_location.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_supplier_location.TabIndex = 3
        '
        'txt_new_supplier_rep
        '
        Me.txt_new_supplier_rep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier_rep.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier_rep.Location = New System.Drawing.Point(-113, 206)
        Me.txt_new_supplier_rep.MaxLength = 100
        Me.txt_new_supplier_rep.Name = "txt_new_supplier_rep"
        Me.txt_new_supplier_rep.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_supplier_rep.TabIndex = 2
        '
        'supplier_new_datails_panel
        '
        Me.supplier_new_datails_panel.BackColor = System.Drawing.Color.Transparent
        Me.supplier_new_datails_panel.Controls.Add(Me.txt_new_supplier_business_sector)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label8)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label13)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label2)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label12)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label15)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label6)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label10)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label1)
        Me.supplier_new_datails_panel.Controls.Add(Me.btn_new_suplier_cancel)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label9)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label35)
        Me.supplier_new_datails_panel.Controls.Add(Me.btn_new_suplier_save)
        Me.supplier_new_datails_panel.Controls.Add(Me.lbl_post_box)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label14)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label4)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label5)
        Me.supplier_new_datails_panel.Controls.Add(Me.Label3)
        Me.supplier_new_datails_panel.Controls.Add(Me.txt_new_supplier_post_box)
        Me.supplier_new_datails_panel.Controls.Add(Me.txt_new_supplier_location)
        Me.supplier_new_datails_panel.Controls.Add(Me.txt_new_supplier_phone_number)
        Me.supplier_new_datails_panel.Controls.Add(Me.txt_new_supplier_description)
        Me.supplier_new_datails_panel.Controls.Add(Me.txt_new_supplier_email)
        Me.supplier_new_datails_panel.Controls.Add(Me.txt_new_supplier_rep)
        Me.supplier_new_datails_panel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.supplier_new_datails_panel.Location = New System.Drawing.Point(576, 11)
        Me.supplier_new_datails_panel.Name = "supplier_new_datails_panel"
        Me.supplier_new_datails_panel.Size = New System.Drawing.Size(442, 497)
        Me.supplier_new_datails_panel.TabIndex = 2
        Me.supplier_new_datails_panel.Visible = False
        '
        'btn_new_suplier_cancel
        '
        Me.btn_new_suplier_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_suplier_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_suplier_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_suplier_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_suplier_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_suplier_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_suplier_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_suplier_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_suplier_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_suplier_cancel.Location = New System.Drawing.Point(241, 435)
        Me.btn_new_suplier_cancel.Name = "btn_new_suplier_cancel"
        Me.btn_new_suplier_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_suplier_cancel.Size = New System.Drawing.Size(133, 38)
        Me.btn_new_suplier_cancel.TabIndex = 105
        Me.btn_new_suplier_cancel.Text = "CANCEL"
        Me.btn_new_suplier_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_suplier_save
        '
        Me.btn_new_suplier_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_suplier_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_suplier_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_suplier_save.FlatAppearance.BorderSize = 0
        Me.btn_new_suplier_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_suplier_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_suplier_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_suplier_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_suplier_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_suplier_save.Location = New System.Drawing.Point(67, 435)
        Me.btn_new_suplier_save.Name = "btn_new_suplier_save"
        Me.btn_new_suplier_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_suplier_save.Size = New System.Drawing.Size(133, 38)
        Me.btn_new_suplier_save.TabIndex = 104
        Me.btn_new_suplier_save.Text = "SAVE"
        Me.btn_new_suplier_save.UseVisualStyleBackColor = False
        '
        'txt_new_supplier_description
        '
        Me.txt_new_supplier_description.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier_description.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier_description.Location = New System.Drawing.Point(-113, 124)
        Me.txt_new_supplier_description.MaxLength = 100
        Me.txt_new_supplier_description.Name = "txt_new_supplier_description"
        Me.txt_new_supplier_description.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_supplier_description.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(14, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 28)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "*"
        '
        'txt_new_supplier_email
        '
        Me.txt_new_supplier_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier_email.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier_email.Location = New System.Drawing.Point(257, 206)
        Me.txt_new_supplier_email.MaxLength = 100
        Me.txt_new_supplier_email.Name = "txt_new_supplier_email"
        Me.txt_new_supplier_email.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_supplier_email.TabIndex = 6
        '
        'txt_new_supplier_phone_number
        '
        Me.txt_new_supplier_phone_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier_phone_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier_phone_number.Location = New System.Drawing.Point(257, 124)
        Me.txt_new_supplier_phone_number.MaxLength = 100
        Me.txt_new_supplier_phone_number.Name = "txt_new_supplier_phone_number"
        Me.txt_new_supplier_phone_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_supplier_phone_number.TabIndex = 5
        '
        'txt_new_supplier_post_box
        '
        Me.txt_new_supplier_post_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier_post_box.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier_post_box.Location = New System.Drawing.Point(257, 287)
        Me.txt_new_supplier_post_box.MaxLength = 100
        Me.txt_new_supplier_post_box.Name = "txt_new_supplier_post_box"
        Me.txt_new_supplier_post_box.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_supplier_post_box.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(258, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Email Address"
        '
        'lbl_post_box
        '
        Me.lbl_post_box.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_post_box.AutoSize = True
        Me.lbl_post_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_post_box.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_post_box.Location = New System.Drawing.Point(262, 260)
        Me.lbl_post_box.Name = "lbl_post_box"
        Me.lbl_post_box.Size = New System.Drawing.Size(64, 18)
        Me.lbl_post_box.TabIndex = 107
        Me.lbl_post_box.Text = "P.O.Box"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(258, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 18)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Phone Number"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(372, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 28)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "*"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(332, 250)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 28)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(358, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 28)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "*"
        '
        'txt_new_supplier_business_sector
        '
        Me.txt_new_supplier_business_sector.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier_business_sector.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier_business_sector.FormattingEnabled = True
        Me.txt_new_supplier_business_sector.Items.AddRange(New Object() {"Public", "Private"})
        Me.txt_new_supplier_business_sector.Location = New System.Drawing.Point(-113, 365)
        Me.txt_new_supplier_business_sector.MaxLength = 25
        Me.txt_new_supplier_business_sector.Name = "txt_new_supplier_business_sector"
        Me.txt_new_supplier_business_sector.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_supplier_business_sector.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label14.Location = New System.Drawing.Point(-112, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 18)
        Me.Label14.TabIndex = 107
        Me.Label14.Text = "Business Sector"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(1, 334)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(20, 28)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "*"
        '
        'Management_Inventory_Add_New_Suplyer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1030, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.supplier_new_datails_panel)
        Me.Controls.Add(Me.supplier_select_panel)
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(280, 150)
        Me.Name = "Management_Inventory_Add_New_Suplyer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Inventory_Add_New_Suplyer"
        Me.supplier_select_panel.ResumeLayout(False)
        Me.supplier_select_panel.PerformLayout()
        CType(Me.SupplierDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.supplier_new_datails_panel.ResumeLayout(False)
        Me.supplier_new_datails_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents supplier_select_panel As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_suplier_select_select As Button
    Friend WithEvents btn_suplier_select_cancel As Button
    Friend WithEvents btn_suplier_select_edit As Button
    Friend WithEvents btn_suplier_select_new As Button
    Friend WithEvents SupplierDataGridView As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_new_suplier_cancel As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents btn_new_suplier_save As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_new_supplier_location As TextBox
    Friend WithEvents txt_new_supplier_rep As TextBox
    Friend WithEvents supplier_new_datails_panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_new_supplier_description As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_post_box As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_new_supplier_post_box As TextBox
    Friend WithEvents txt_new_supplier_phone_number As TextBox
    Friend WithEvents txt_new_supplier_email As TextBox
    Friend WithEvents txt_new_supplier_business_sector As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
End Class
