<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Inventory_Add_New
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
        Me.txt_new_unit_cost = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_new_quantity = New System.Windows.Forms.TextBox()
        Me.txt_new_model = New System.Windows.Forms.TextBox()
        Me.txt_new_location = New System.Windows.Forms.TextBox()
        Me.txt_new_alternative = New System.Windows.Forms.TextBox()
        Me.txt_new_part_number = New System.Windows.Forms.TextBox()
        Me.txt_new_part_name = New System.Windows.Forms.TextBox()
        Me.txt_new_category = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_new_supplier = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_new_item_save = New System.Windows.Forms.Button()
        Me.btn_new_item_cancel = New System.Windows.Forms.Button()
        Me.btn_new_item_existing_supplier = New System.Windows.Forms.Button()
        Me.btn_new_item_new_supplier = New System.Windows.Forms.Button()
        Me.inventory_clear_supplier = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_new_unit_cost
        '
        Me.txt_new_unit_cost.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_unit_cost.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_unit_cost.Location = New System.Drawing.Point(519, 257)
        Me.txt_new_unit_cost.MaxLength = 50
        Me.txt_new_unit_cost.Name = "txt_new_unit_cost"
        Me.txt_new_unit_cost.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_unit_cost.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(513, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 18)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "Quantity"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(613, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 28)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "*"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(309, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 28)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(220, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 28)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "*"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(146, 69)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 18)
        Me.Label35.TabIndex = 67
        Me.Label35.Text = "Category"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(515, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 18)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Unit Cost (GHC)"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(147, 390)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Location"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(514, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 18)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Model / Type"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(148, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 18)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Alternative"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(149, 236)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Item Serial Number"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 18)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Item Name / Description"
        '
        'txt_new_quantity
        '
        Me.txt_new_quantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_quantity.Enabled = False
        Me.txt_new_quantity.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_quantity.Location = New System.Drawing.Point(516, 177)
        Me.txt_new_quantity.MaxLength = 50
        Me.txt_new_quantity.Name = "txt_new_quantity"
        Me.txt_new_quantity.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_quantity.TabIndex = 7
        '
        'txt_new_model
        '
        Me.txt_new_model.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_model.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_model.Location = New System.Drawing.Point(516, 90)
        Me.txt_new_model.MaxLength = 35
        Me.txt_new_model.Name = "txt_new_model"
        Me.txt_new_model.Size = New System.Drawing.Size(309, 33)
        Me.txt_new_model.TabIndex = 6
        '
        'txt_new_location
        '
        Me.txt_new_location.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_location.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_location.Location = New System.Drawing.Point(149, 411)
        Me.txt_new_location.MaxLength = 50
        Me.txt_new_location.Name = "txt_new_location"
        Me.txt_new_location.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_location.TabIndex = 5
        '
        'txt_new_alternative
        '
        Me.txt_new_alternative.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_alternative.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_alternative.Location = New System.Drawing.Point(149, 336)
        Me.txt_new_alternative.MaxLength = 45
        Me.txt_new_alternative.Name = "txt_new_alternative"
        Me.txt_new_alternative.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_alternative.TabIndex = 4
        '
        'txt_new_part_number
        '
        Me.txt_new_part_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_part_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_part_number.Location = New System.Drawing.Point(151, 257)
        Me.txt_new_part_number.MaxLength = 35
        Me.txt_new_part_number.Name = "txt_new_part_number"
        Me.txt_new_part_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_part_number.TabIndex = 3
        '
        'txt_new_part_name
        '
        Me.txt_new_part_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_part_name.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_part_name.Location = New System.Drawing.Point(149, 174)
        Me.txt_new_part_name.MaxLength = 35
        Me.txt_new_part_name.Name = "txt_new_part_name"
        Me.txt_new_part_name.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_part_name.TabIndex = 2
        '
        'txt_new_category
        '
        Me.txt_new_category.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_category.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_category.FormattingEnabled = True
        Me.txt_new_category.Location = New System.Drawing.Point(149, 90)
        Me.txt_new_category.MaxLength = 25
        Me.txt_new_category.Name = "txt_new_category"
        Me.txt_new_category.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_category.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(218, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 28)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "*"
        '
        'txt_new_supplier
        '
        Me.txt_new_supplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_supplier.Enabled = False
        Me.txt_new_supplier.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_supplier.Location = New System.Drawing.Point(516, 375)
        Me.txt_new_supplier.MaxLength = 35
        Me.txt_new_supplier.Name = "txt_new_supplier"
        Me.txt_new_supplier.Size = New System.Drawing.Size(309, 33)
        Me.txt_new_supplier.TabIndex = 95
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(516, 310)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 18)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Supplier"
        '
        'btn_new_item_save
        '
        Me.btn_new_item_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_new_item_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_item_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_item_save.FlatAppearance.BorderSize = 0
        Me.btn_new_item_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_item_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_item_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_item_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_item_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_item_save.Location = New System.Drawing.Point(339, 535)
        Me.btn_new_item_save.Name = "btn_new_item_save"
        Me.btn_new_item_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_item_save.Size = New System.Drawing.Size(130, 40)
        Me.btn_new_item_save.TabIndex = 9
        Me.btn_new_item_save.Text = "SAVE"
        Me.btn_new_item_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_item_save.UseVisualStyleBackColor = False
        '
        'btn_new_item_cancel
        '
        Me.btn_new_item_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_new_item_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_item_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_item_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_new_item_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_item_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_item_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_item_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_item_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_item_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_item_cancel.Location = New System.Drawing.Point(516, 535)
        Me.btn_new_item_cancel.Name = "btn_new_item_cancel"
        Me.btn_new_item_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_item_cancel.Size = New System.Drawing.Size(130, 40)
        Me.btn_new_item_cancel.TabIndex = 10
        Me.btn_new_item_cancel.Text = "CANCEL"
        Me.btn_new_item_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_item_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_item_existing_supplier
        '
        Me.btn_new_item_existing_supplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_item_existing_supplier.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_new_item_existing_supplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_item_existing_supplier.FlatAppearance.BorderSize = 0
        Me.btn_new_item_existing_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_item_existing_supplier.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_item_existing_supplier.ForeColor = System.Drawing.Color.White
        Me.btn_new_item_existing_supplier.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_customer_24
        Me.btn_new_item_existing_supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_item_existing_supplier.Location = New System.Drawing.Point(517, 331)
        Me.btn_new_item_existing_supplier.Name = "btn_new_item_existing_supplier"
        Me.btn_new_item_existing_supplier.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_item_existing_supplier.Size = New System.Drawing.Size(130, 33)
        Me.btn_new_item_existing_supplier.TabIndex = 93
        Me.btn_new_item_existing_supplier.Text = "EXISTING"
        Me.btn_new_item_existing_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_item_existing_supplier.UseVisualStyleBackColor = False
        '
        'btn_new_item_new_supplier
        '
        Me.btn_new_item_new_supplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_item_new_supplier.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_new_item_new_supplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_item_new_supplier.FlatAppearance.BorderSize = 0
        Me.btn_new_item_new_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_item_new_supplier.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_item_new_supplier.ForeColor = System.Drawing.Color.White
        Me.btn_new_item_new_supplier.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_customer_24
        Me.btn_new_item_new_supplier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_item_new_supplier.Location = New System.Drawing.Point(681, 331)
        Me.btn_new_item_new_supplier.Name = "btn_new_item_new_supplier"
        Me.btn_new_item_new_supplier.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_item_new_supplier.Size = New System.Drawing.Size(88, 33)
        Me.btn_new_item_new_supplier.TabIndex = 94
        Me.btn_new_item_new_supplier.Text = "NEW"
        Me.btn_new_item_new_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_item_new_supplier.UseVisualStyleBackColor = False
        '
        'inventory_clear_supplier
        '
        Me.inventory_clear_supplier.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.inventory_clear_supplier.AutoSize = True
        Me.inventory_clear_supplier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.inventory_clear_supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventory_clear_supplier.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_delete_24
        Me.inventory_clear_supplier.Location = New System.Drawing.Point(831, 375)
        Me.inventory_clear_supplier.Name = "inventory_clear_supplier"
        Me.inventory_clear_supplier.Padding = New System.Windows.Forms.Padding(5)
        Me.inventory_clear_supplier.Size = New System.Drawing.Size(30, 34)
        Me.inventory_clear_supplier.TabIndex = 96
        Me.inventory_clear_supplier.Text = "  "
        Me.inventory_clear_supplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Management_Inventory_Add_New
        '
        Me.AcceptButton = Me.btn_new_item_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btn_new_item_cancel
        Me.ClientSize = New System.Drawing.Size(1121, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_new_item_existing_supplier)
        Me.Controls.Add(Me.btn_new_item_new_supplier)
        Me.Controls.Add(Me.inventory_clear_supplier)
        Me.Controls.Add(Me.txt_new_supplier)
        Me.Controls.Add(Me.txt_new_category)
        Me.Controls.Add(Me.txt_new_unit_cost)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_new_item_cancel)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.btn_new_item_save)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_new_quantity)
        Me.Controls.Add(Me.txt_new_model)
        Me.Controls.Add(Me.txt_new_location)
        Me.Controls.Add(Me.txt_new_alternative)
        Me.Controls.Add(Me.txt_new_part_number)
        Me.Controls.Add(Me.txt_new_part_name)
        Me.Name = "Management_Inventory_Add_New"
        Me.Text = "Management_Inventory_Add_New"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_new_unit_cost As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_new_item_cancel As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents btn_new_item_save As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_new_quantity As TextBox
    Friend WithEvents txt_new_model As TextBox
    Friend WithEvents txt_new_location As TextBox
    Friend WithEvents txt_new_alternative As TextBox
    Friend WithEvents txt_new_part_number As TextBox
    Friend WithEvents txt_new_part_name As TextBox
    Friend WithEvents txt_new_category As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_new_item_existing_supplier As Button
    Friend WithEvents btn_new_item_new_supplier As Button
    Friend WithEvents inventory_clear_supplier As Label
    Friend WithEvents txt_new_supplier As TextBox
    Friend WithEvents Label10 As Label
End Class
