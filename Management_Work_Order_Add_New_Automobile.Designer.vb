﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txt_new_category = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
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
        Me.btn_new_automobile_cancel = New System.Windows.Forms.Button()
        Me.btn_new_item_save = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_new_category
        '
        Me.txt_new_category.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_category.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_category.FormattingEnabled = True
        Me.txt_new_category.Location = New System.Drawing.Point(56, 50)
        Me.txt_new_category.MaxLength = 25
        Me.txt_new_category.Name = "txt_new_category"
        Me.txt_new_category.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_category.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(424, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 18)
        Me.Label15.TabIndex = 95
        Me.Label15.Text = "VIN"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(561, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 28)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(120, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 28)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "*"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(53, 29)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(68, 18)
        Me.Label35.TabIndex = 90
        Me.Label35.Text = "Category"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(427, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 18)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Color"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(425, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 18)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Mileag"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Model"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Make"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Year "
        '
        'txt_new_quantity
        '
        Me.txt_new_quantity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_quantity.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_quantity.Location = New System.Drawing.Point(427, 221)
        Me.txt_new_quantity.MaxLength = 25
        Me.txt_new_quantity.Name = "txt_new_quantity"
        Me.txt_new_quantity.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_quantity.TabIndex = 7
        '
        'txt_new_model
        '
        Me.txt_new_model.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_model.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_model.Location = New System.Drawing.Point(427, 134)
        Me.txt_new_model.MaxLength = 25
        Me.txt_new_model.Name = "txt_new_model"
        Me.txt_new_model.Size = New System.Drawing.Size(309, 33)
        Me.txt_new_model.TabIndex = 6
        '
        'txt_new_location
        '
        Me.txt_new_location.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_location.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_location.Location = New System.Drawing.Point(427, 50)
        Me.txt_new_location.MaxLength = 25
        Me.txt_new_location.Name = "txt_new_location"
        Me.txt_new_location.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_location.TabIndex = 5
        '
        'txt_new_alternative
        '
        Me.txt_new_alternative.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_alternative.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_alternative.Location = New System.Drawing.Point(56, 296)
        Me.txt_new_alternative.MaxLength = 25
        Me.txt_new_alternative.Name = "txt_new_alternative"
        Me.txt_new_alternative.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_alternative.TabIndex = 4
        '
        'txt_new_part_number
        '
        Me.txt_new_part_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_part_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_part_number.Location = New System.Drawing.Point(58, 217)
        Me.txt_new_part_number.MaxLength = 25
        Me.txt_new_part_number.Name = "txt_new_part_number"
        Me.txt_new_part_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_part_number.TabIndex = 3
        '
        'txt_new_part_name
        '
        Me.txt_new_part_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_part_name.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_part_name.Location = New System.Drawing.Point(56, 134)
        Me.txt_new_part_name.MaxLength = 4
        Me.txt_new_part_name.Name = "txt_new_part_name"
        Me.txt_new_part_name.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_part_name.TabIndex = 2
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
        Me.btn_new_automobile_cancel.Location = New System.Drawing.Point(403, 413)
        Me.btn_new_automobile_cancel.Name = "btn_new_automobile_cancel"
        Me.btn_new_automobile_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_automobile_cancel.Size = New System.Drawing.Size(141, 38)
        Me.btn_new_automobile_cancel.TabIndex = 10
        Me.btn_new_automobile_cancel.Text = "CANCEL"
        Me.btn_new_automobile_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_item_save
        '
        Me.btn_new_item_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_item_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_item_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_item_save.FlatAppearance.BorderSize = 0
        Me.btn_new_item_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_item_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_item_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_item_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_item_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_item_save.Location = New System.Drawing.Point(226, 413)
        Me.btn_new_item_save.Name = "btn_new_item_save"
        Me.btn_new_item_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_item_save.Size = New System.Drawing.Size(141, 38)
        Me.btn_new_item_save.TabIndex = 9
        Me.btn_new_item_save.Text = "SAVE"
        Me.btn_new_item_save.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(427, 296)
        Me.TextBox1.MaxLength = 25
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(308, 33)
        Me.TextBox1.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(424, 275)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 18)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Registration Nmber"
        '
        'Management_Work_Order_Add_New_Automobile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Codebot_GMS.My.Resources.Resources.icons8_car_24
        Me.ClientSize = New System.Drawing.Size(800, 487)
        Me.Controls.Add(Me.txt_new_category)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_new_automobile_cancel)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.btn_new_item_save)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txt_new_quantity)
        Me.Controls.Add(Me.txt_new_model)
        Me.Controls.Add(Me.txt_new_location)
        Me.Controls.Add(Me.txt_new_alternative)
        Me.Controls.Add(Me.txt_new_part_number)
        Me.Controls.Add(Me.txt_new_part_name)
        Me.Name = "Management_Work_Order_Add_New_Automobile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Work_Order_Add_New_Automobile"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_new_category As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_new_automobile_cancel As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents btn_new_item_save As Button
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
End Class