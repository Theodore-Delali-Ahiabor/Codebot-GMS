<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auth_Password_Reset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auth_Password_Reset))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_password_reset_email = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_password_reset_send_code = New System.Windows.Forms.Button()
        Me.btn_password_reset_cancel = New System.Windows.Forms.Button()
        Me.chkb_login_reset_send_sms = New System.Windows.Forms.CheckBox()
        Me.chkb_login_reset_send_whatsapp = New System.Windows.Forms.CheckBox()
        Me.chkb_login_reset_send_email = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(69, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 28)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Email Address"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightCoral
        Me.Label13.Location = New System.Drawing.Point(200, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 28)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "*"
        '
        'txt_password_reset_email
        '
        Me.txt_password_reset_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_password_reset_email.BackColor = System.Drawing.Color.White
        Me.txt_password_reset_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password_reset_email.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_reset_email.ForeColor = System.Drawing.Color.Teal
        Me.txt_password_reset_email.Location = New System.Drawing.Point(74, 237)
        Me.txt_password_reset_email.MaxLength = 100
        Me.txt_password_reset_email.Name = "txt_password_reset_email"
        Me.txt_password_reset_email.Size = New System.Drawing.Size(350, 31)
        Me.txt_password_reset_email.TabIndex = 1
        Me.txt_password_reset_email.WordWrap = False
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Teal
        Me.Label15.Location = New System.Drawing.Point(105, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(234, 49)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Login Reset"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(71, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "NOTICE"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(70, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(369, 21)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "-After a succesful login reset, you will be required to"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(70, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 21)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "  create a new Username and Password."
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(70, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(358, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "-Internet connectivity is needed to reset your login"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(73, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 28)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Send Code Via : "
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(74, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "-Multiple selection is allowed"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(217, 478)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "(This option is Inactive)"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.IndianRed
        Me.Label9.Location = New System.Drawing.Point(75, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "HINT"
        '
        'btn_password_reset_send_code
        '
        Me.btn_password_reset_send_code.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_password_reset_send_code.BackColor = System.Drawing.Color.Teal
        Me.btn_password_reset_send_code.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_password_reset_send_code.FlatAppearance.BorderSize = 0
        Me.btn_password_reset_send_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_password_reset_send_code.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_password_reset_send_code.ForeColor = System.Drawing.Color.White
        Me.btn_password_reset_send_code.Image = CType(resources.GetObject("btn_password_reset_send_code.Image"), System.Drawing.Image)
        Me.btn_password_reset_send_code.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_password_reset_send_code.Location = New System.Drawing.Point(74, 551)
        Me.btn_password_reset_send_code.Name = "btn_password_reset_send_code"
        Me.btn_password_reset_send_code.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_password_reset_send_code.Size = New System.Drawing.Size(141, 40)
        Me.btn_password_reset_send_code.TabIndex = 2
        Me.btn_password_reset_send_code.Text = "SEND CODE"
        Me.btn_password_reset_send_code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_password_reset_send_code.UseVisualStyleBackColor = False
        '
        'btn_password_reset_cancel
        '
        Me.btn_password_reset_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_password_reset_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_password_reset_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_password_reset_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_password_reset_cancel.FlatAppearance.BorderSize = 0
        Me.btn_password_reset_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_password_reset_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_password_reset_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_password_reset_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.delete_24px
        Me.btn_password_reset_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_password_reset_cancel.Location = New System.Drawing.Point(267, 551)
        Me.btn_password_reset_cancel.Name = "btn_password_reset_cancel"
        Me.btn_password_reset_cancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_password_reset_cancel.Size = New System.Drawing.Size(141, 40)
        Me.btn_password_reset_cancel.TabIndex = 5
        Me.btn_password_reset_cancel.Text = "CANCEL    "
        Me.btn_password_reset_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_password_reset_cancel.UseVisualStyleBackColor = False
        '
        'chkb_login_reset_send_sms
        '
        Me.chkb_login_reset_send_sms.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkb_login_reset_send_sms.AutoSize = True
        Me.chkb_login_reset_send_sms.BackColor = System.Drawing.Color.Transparent
        Me.chkb_login_reset_send_sms.Enabled = False
        Me.chkb_login_reset_send_sms.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_login_reset_send_sms.Image = Global.Codebot_GMS.My.Resources.Resources.sms_24px
        Me.chkb_login_reset_send_sms.Location = New System.Drawing.Point(95, 472)
        Me.chkb_login_reset_send_sms.Name = "chkb_login_reset_send_sms"
        Me.chkb_login_reset_send_sms.Padding = New System.Windows.Forms.Padding(5)
        Me.chkb_login_reset_send_sms.Size = New System.Drawing.Size(95, 35)
        Me.chkb_login_reset_send_sms.TabIndex = 40
        Me.chkb_login_reset_send_sms.Text = "SMS"
        Me.chkb_login_reset_send_sms.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkb_login_reset_send_sms.UseVisualStyleBackColor = False
        '
        'chkb_login_reset_send_whatsapp
        '
        Me.chkb_login_reset_send_whatsapp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkb_login_reset_send_whatsapp.AutoSize = True
        Me.chkb_login_reset_send_whatsapp.BackColor = System.Drawing.Color.Transparent
        Me.chkb_login_reset_send_whatsapp.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_login_reset_send_whatsapp.Image = Global.Codebot_GMS.My.Resources.Resources.whatsapp_24px
        Me.chkb_login_reset_send_whatsapp.Location = New System.Drawing.Point(95, 432)
        Me.chkb_login_reset_send_whatsapp.Name = "chkb_login_reset_send_whatsapp"
        Me.chkb_login_reset_send_whatsapp.Padding = New System.Windows.Forms.Padding(5)
        Me.chkb_login_reset_send_whatsapp.Size = New System.Drawing.Size(133, 35)
        Me.chkb_login_reset_send_whatsapp.TabIndex = 40
        Me.chkb_login_reset_send_whatsapp.Text = "Whatsapp"
        Me.chkb_login_reset_send_whatsapp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkb_login_reset_send_whatsapp.UseVisualStyleBackColor = False
        '
        'chkb_login_reset_send_email
        '
        Me.chkb_login_reset_send_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkb_login_reset_send_email.AutoSize = True
        Me.chkb_login_reset_send_email.Checked = True
        Me.chkb_login_reset_send_email.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_login_reset_send_email.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_login_reset_send_email.Image = Global.Codebot_GMS.My.Resources.Resources.email_24px
        Me.chkb_login_reset_send_email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkb_login_reset_send_email.Location = New System.Drawing.Point(95, 393)
        Me.chkb_login_reset_send_email.Name = "chkb_login_reset_send_email"
        Me.chkb_login_reset_send_email.Padding = New System.Windows.Forms.Padding(5)
        Me.chkb_login_reset_send_email.Size = New System.Drawing.Size(101, 35)
        Me.chkb_login_reset_send_email.TabIndex = 40
        Me.chkb_login_reset_send_email.Text = "Email"
        Me.chkb_login_reset_send_email.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkb_login_reset_send_email.UseVisualStyleBackColor = True
        '
        'Auth_Password_Reset
        '
        Me.AcceptButton = Me.btn_password_reset_send_code
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btn_password_reset_cancel
        Me.ClientSize = New System.Drawing.Size(504, 614)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkb_login_reset_send_sms)
        Me.Controls.Add(Me.chkb_login_reset_send_whatsapp)
        Me.Controls.Add(Me.chkb_login_reset_send_email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_password_reset_send_code)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_password_reset_email)
        Me.Controls.Add(Me.btn_password_reset_cancel)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Auth_Password_Reset"
        Me.Text = "Auth_Password_Reset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_password_reset_email As TextBox
    Friend WithEvents btn_password_reset_cancel As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_password_reset_send_code As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkb_login_reset_send_whatsapp As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkb_login_reset_send_sms As CheckBox
    Friend WithEvents chkb_login_reset_send_email As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
End Class
