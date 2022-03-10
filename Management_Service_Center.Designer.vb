<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Service_Center
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
        Me.employee_clear_image = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btn_new_user_select_image = New System.Windows.Forms.Button()
        Me.pb_new_user_image = New System.Windows.Forms.PictureBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.txt_pobox = New System.Windows.Forms.TextBox()
        Me.txt_phone_number = New System.Windows.Forms.TextBox()
        Me.txt_tel_number = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_tin_number = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pb_new_user_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employee_clear_image
        '
        Me.employee_clear_image.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.employee_clear_image.AutoSize = True
        Me.employee_clear_image.Cursor = System.Windows.Forms.Cursors.Hand
        Me.employee_clear_image.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_clear_image.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_delete_24
        Me.employee_clear_image.Location = New System.Drawing.Point(67, 121)
        Me.employee_clear_image.Name = "employee_clear_image"
        Me.employee_clear_image.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.employee_clear_image.Size = New System.Drawing.Size(30, 34)
        Me.employee_clear_image.TabIndex = 152
        Me.employee_clear_image.Text = "  "
        Me.employee_clear_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(259, 194)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 17)
        Me.Label18.TabIndex = 151
        Me.Label18.Text = "Max: 60KiB"
        '
        'btn_new_user_select_image
        '
        Me.btn_new_user_select_image.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_user_select_image.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_new_user_select_image.FlatAppearance.BorderSize = 0
        Me.btn_new_user_select_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_user_select_image.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_user_select_image.Location = New System.Drawing.Point(250, 214)
        Me.btn_new_user_select_image.Name = "btn_new_user_select_image"
        Me.btn_new_user_select_image.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btn_new_user_select_image.Size = New System.Drawing.Size(97, 33)
        Me.btn_new_user_select_image.TabIndex = 150
        Me.btn_new_user_select_image.Text = "Select Image"
        Me.btn_new_user_select_image.UseVisualStyleBackColor = False
        '
        'pb_new_user_image
        '
        Me.pb_new_user_image.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pb_new_user_image.BackColor = System.Drawing.Color.White
        Me.pb_new_user_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_new_user_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_new_user_image.InitialImage = Global.Codebot_GMS.My.Resources.Resources.Employee_Blue_4
        Me.pb_new_user_image.Location = New System.Drawing.Point(103, 121)
        Me.pb_new_user_image.Name = "pb_new_user_image"
        Me.pb_new_user_image.Size = New System.Drawing.Size(132, 126)
        Me.pb_new_user_image.TabIndex = 149
        Me.pb_new_user_image.TabStop = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(431, 426)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 18)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Location"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancel.Location = New System.Drawing.Point(414, 530)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_cancel.Size = New System.Drawing.Size(141, 42)
        Me.btn_cancel.TabIndex = 143
        Me.btn_cancel.Text = "CANCEL  "
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(54, 277)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(135, 18)
        Me.Label35.TabIndex = 147
        Me.Label35.Text = "Name / Description"
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_name.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(57, 298)
        Me.txt_name.MaxLength = 12
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(308, 99)
        Me.txt_name.TabIndex = 132
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.Location = New System.Drawing.Point(250, 530)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_save.Size = New System.Drawing.Size(134, 42)
        Me.btn_save.TabIndex = 140
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(432, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 18)
        Me.Label9.TabIndex = 146
        Me.Label9.Text = "mobile Number"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(431, 341)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 18)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "P.O.Box"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(433, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 18)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Telephone Number"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(147, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Logo"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(434, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 18)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(54, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "TIN Number"
        '
        'txt_location
        '
        Me.txt_location.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_location.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_location.Location = New System.Drawing.Point(434, 447)
        Me.txt_location.MaxLength = 50
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(308, 33)
        Me.txt_location.TabIndex = 138
        '
        'txt_pobox
        '
        Me.txt_pobox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_pobox.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pobox.Location = New System.Drawing.Point(433, 364)
        Me.txt_pobox.MaxLength = 10
        Me.txt_pobox.Name = "txt_pobox"
        Me.txt_pobox.Size = New System.Drawing.Size(308, 33)
        Me.txt_pobox.TabIndex = 137
        '
        'txt_phone_number
        '
        Me.txt_phone_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_phone_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone_number.Location = New System.Drawing.Point(434, 280)
        Me.txt_phone_number.MaxLength = 50
        Me.txt_phone_number.Name = "txt_phone_number"
        Me.txt_phone_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_phone_number.TabIndex = 136
        '
        'txt_tel_number
        '
        Me.txt_tel_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_tel_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel_number.Location = New System.Drawing.Point(434, 201)
        Me.txt_tel_number.MaxLength = 35
        Me.txt_tel_number.Name = "txt_tel_number"
        Me.txt_tel_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_tel_number.TabIndex = 135
        '
        'txt_email
        '
        Me.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_email.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(436, 122)
        Me.txt_email.MaxLength = 35
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(308, 33)
        Me.txt_email.TabIndex = 134
        '
        'txt_tin_number
        '
        Me.txt_tin_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_tin_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tin_number.Location = New System.Drawing.Point(57, 447)
        Me.txt_tin_number.MaxLength = 35
        Me.txt_tin_number.Name = "txt_tin_number"
        Me.txt_tin_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_tin_number.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(254, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 45)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "SERVICE CENTER"
        '
        'Management_Service_Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(795, 599)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.employee_clear_image)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btn_new_user_select_image)
        Me.Controls.Add(Me.pb_new_user_image)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.txt_pobox)
        Me.Controls.Add(Me.txt_phone_number)
        Me.Controls.Add(Me.txt_tel_number)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_tin_number)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Management_Service_Center"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management_Service_Center"
        CType(Me.pb_new_user_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents employee_clear_image As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btn_new_user_select_image As Button
    Friend WithEvents pb_new_user_image As PictureBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_location As TextBox
    Friend WithEvents txt_pobox As TextBox
    Friend WithEvents txt_phone_number As TextBox
    Friend WithEvents txt_tel_number As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_tin_number As TextBox
    Friend WithEvents Label2 As Label
End Class
