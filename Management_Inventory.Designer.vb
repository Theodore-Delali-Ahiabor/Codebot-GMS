<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Inventory))
        Me.InventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.cmb_inventory_category_filter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_inventory_part_name_filter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_inventory_location_filter = New System.Windows.Forms.ComboBox()
        Me.btn_edit_inventory_item = New System.Windows.Forms.Button()
        Me.btn_add_new_inventory_item = New System.Windows.Forms.Button()
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InventoryDataGridView
        '
        Me.InventoryDataGridView.AllowUserToAddRows = False
        Me.InventoryDataGridView.AllowUserToDeleteRows = False
        Me.InventoryDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InventoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InventoryDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.InventoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.InventoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InventoryDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.InventoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InventoryDataGridView.EnableHeadersVisualStyles = False
        Me.InventoryDataGridView.GridColor = System.Drawing.Color.Silver
        Me.InventoryDataGridView.Location = New System.Drawing.Point(51, 103)
        Me.InventoryDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.InventoryDataGridView.Name = "InventoryDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.InventoryDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.InventoryDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.InventoryDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.InventoryDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.InventoryDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InventoryDataGridView.RowTemplate.Height = 38
        Me.InventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InventoryDataGridView.Size = New System.Drawing.Size(1008, 377)
        Me.InventoryDataGridView.TabIndex = 44
        '
        'cmb_inventory_category_filter
        '
        Me.cmb_inventory_category_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_inventory_category_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_inventory_category_filter.FormattingEnabled = True
        Me.cmb_inventory_category_filter.Location = New System.Drawing.Point(606, 60)
        Me.cmb_inventory_category_filter.Margin = New System.Windows.Forms.Padding(10)
        Me.cmb_inventory_category_filter.Name = "cmb_inventory_category_filter"
        Me.cmb_inventory_category_filter.Size = New System.Drawing.Size(222, 29)
        Me.cmb_inventory_category_filter.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_search_80
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(372, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(91, 27)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Name       "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(603, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5)
        Me.Label1.Size = New System.Drawing.Size(127, 27)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Category      "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_inventory_part_name_filter
        '
        Me.txt_inventory_part_name_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_inventory_part_name_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_inventory_part_name_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_inventory_part_name_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_inventory_part_name_filter.Location = New System.Drawing.Point(375, 60)
        Me.txt_inventory_part_name_filter.Name = "txt_inventory_part_name_filter"
        Me.txt_inventory_part_name_filter.Size = New System.Drawing.Size(222, 29)
        Me.txt_inventory_part_name_filter.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(834, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(122, 27)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Location      "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_inventory_location_filter
        '
        Me.cmb_inventory_location_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_inventory_location_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_inventory_location_filter.FormattingEnabled = True
        Me.cmb_inventory_location_filter.Location = New System.Drawing.Point(837, 60)
        Me.cmb_inventory_location_filter.Margin = New System.Windows.Forms.Padding(10)
        Me.cmb_inventory_location_filter.Name = "cmb_inventory_location_filter"
        Me.cmb_inventory_location_filter.Size = New System.Drawing.Size(222, 29)
        Me.cmb_inventory_location_filter.TabIndex = 54
        '
        'btn_edit_inventory_item
        '
        Me.btn_edit_inventory_item.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_edit_inventory_item.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_inventory_item.FlatAppearance.BorderSize = 0
        Me.btn_edit_inventory_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_inventory_item.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_inventory_item.ForeColor = System.Drawing.Color.White
        Me.btn_edit_inventory_item.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_edit_white_24
        Me.btn_edit_inventory_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit_inventory_item.Location = New System.Drawing.Point(162, 26)
        Me.btn_edit_inventory_item.Name = "btn_edit_inventory_item"
        Me.btn_edit_inventory_item.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_edit_inventory_item.Size = New System.Drawing.Size(97, 46)
        Me.btn_edit_inventory_item.TabIndex = 53
        Me.btn_edit_inventory_item.Text = "   Edit"
        Me.btn_edit_inventory_item.UseVisualStyleBackColor = False
        '
        'btn_add_new_inventory_item
        '
        Me.btn_add_new_inventory_item.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_add_new_inventory_item.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_new_inventory_item.FlatAppearance.BorderSize = 0
        Me.btn_add_new_inventory_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_new_inventory_item.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_inventory_item.ForeColor = System.Drawing.Color.White
        Me.btn_add_new_inventory_item.Image = CType(resources.GetObject("btn_add_new_inventory_item.Image"), System.Drawing.Image)
        Me.btn_add_new_inventory_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_new_inventory_item.Location = New System.Drawing.Point(47, 26)
        Me.btn_add_new_inventory_item.Name = "btn_add_new_inventory_item"
        Me.btn_add_new_inventory_item.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_add_new_inventory_item.Size = New System.Drawing.Size(97, 46)
        Me.btn_add_new_inventory_item.TabIndex = 52
        Me.btn_add_new_inventory_item.Text = "    Item"
        Me.btn_add_new_inventory_item.UseVisualStyleBackColor = False
        '
        'Management_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1101, 538)
        Me.Controls.Add(Me.cmb_inventory_category_filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_inventory_part_name_filter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_inventory_location_filter)
        Me.Controls.Add(Me.btn_edit_inventory_item)
        Me.Controls.Add(Me.btn_add_new_inventory_item)
        Me.Controls.Add(Me.InventoryDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Management_Inventory"
        Me.Text = "Management_Inventory"
        CType(Me.InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InventoryDataGridView As DataGridView
    Friend WithEvents cmb_inventory_category_filter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_inventory_part_name_filter As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_inventory_location_filter As ComboBox
    Friend WithEvents btn_edit_inventory_item As Button
    Friend WithEvents btn_add_new_inventory_item As Button
End Class
