<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auth_Signup
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
        Me.signup_top_panel = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_signup_phone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.signup_middle_panel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_signup_confirm_password = New System.Windows.Forms.TextBox()
        Me.txt_signup_username = New System.Windows.Forms.TextBox()
        Me.txt_signup_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.signup_bottom_panel = New System.Windows.Forms.Panel()
        Me.btn_signup_cancel = New System.Windows.Forms.Button()
        Me.btn_signup_verify_create = New System.Windows.Forms.Button()
        Me.signup_top_panel.SuspendLayout()
        Me.signup_middle_panel.SuspendLayout()
        Me.signup_bottom_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'signup_top_panel
        '
        Me.signup_top_panel.Controls.Add(Me.Label17)
        Me.signup_top_panel.Controls.Add(Me.Label18)
        Me.signup_top_panel.Controls.Add(Me.txt_signup_phone)
        Me.signup_top_panel.Controls.Add(Me.Label1)
        Me.signup_top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.signup_top_panel.Location = New System.Drawing.Point(0, 0)
        Me.signup_top_panel.Name = "signup_top_panel"
        Me.signup_top_panel.Size = New System.Drawing.Size(765, 299)
        Me.signup_top_panel.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Teal
        Me.Label17.Location = New System.Drawing.Point(219, 229)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 28)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Phone Number"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightCoral
        Me.Label18.Location = New System.Drawing.Point(358, 229)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 28)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "*"
        '
        'txt_signup_phone
        '
        Me.txt_signup_phone.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_signup_phone.BackColor = System.Drawing.Color.White
        Me.txt_signup_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_signup_phone.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_phone.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_phone.Location = New System.Drawing.Point(217, 260)
        Me.txt_signup_phone.MaxLength = 10
        Me.txt_signup_phone.Name = "txt_signup_phone"
        Me.txt_signup_phone.Size = New System.Drawing.Size(350, 35)
        Me.txt_signup_phone.TabIndex = 16
        Me.txt_signup_phone.WordWrap = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(313, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 49)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "SignUp"
        '
        'signup_middle_panel
        '
        Me.signup_middle_panel.Controls.Add(Me.Label2)
        Me.signup_middle_panel.Controls.Add(Me.Label7)
        Me.signup_middle_panel.Controls.Add(Me.Label6)
        Me.signup_middle_panel.Controls.Add(Me.Label5)
        Me.signup_middle_panel.Controls.Add(Me.Label4)
        Me.signup_middle_panel.Controls.Add(Me.txt_signup_confirm_password)
        Me.signup_middle_panel.Controls.Add(Me.txt_signup_username)
        Me.signup_middle_panel.Controls.Add(Me.txt_signup_password)
        Me.signup_middle_panel.Controls.Add(Me.Label3)
        Me.signup_middle_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.signup_middle_panel.Location = New System.Drawing.Point(0, 299)
        Me.signup_middle_panel.Name = "signup_middle_panel"
        Me.signup_middle_panel.Size = New System.Drawing.Size(765, 271)
        Me.signup_middle_panel.TabIndex = 14
        Me.signup_middle_panel.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(219, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 28)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Username"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightCoral
        Me.Label7.Location = New System.Drawing.Point(380, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 28)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightCoral
        Me.Label6.Location = New System.Drawing.Point(314, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 28)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightCoral
        Me.Label5.Location = New System.Drawing.Point(314, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 28)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(217, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 28)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Confirm Password"
        '
        'txt_signup_confirm_password
        '
        Me.txt_signup_confirm_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_signup_confirm_password.BackColor = System.Drawing.Color.White
        Me.txt_signup_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_signup_confirm_password.Enabled = False
        Me.txt_signup_confirm_password.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_confirm_password.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_confirm_password.Location = New System.Drawing.Point(217, 211)
        Me.txt_signup_confirm_password.MaxLength = 25
        Me.txt_signup_confirm_password.Name = "txt_signup_confirm_password"
        Me.txt_signup_confirm_password.Size = New System.Drawing.Size(350, 35)
        Me.txt_signup_confirm_password.TabIndex = 14
        Me.txt_signup_confirm_password.UseSystemPasswordChar = True
        '
        'txt_signup_username
        '
        Me.txt_signup_username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_signup_username.BackColor = System.Drawing.Color.White
        Me.txt_signup_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_signup_username.Enabled = False
        Me.txt_signup_username.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_username.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_username.Location = New System.Drawing.Point(217, 36)
        Me.txt_signup_username.MaxLength = 25
        Me.txt_signup_username.Name = "txt_signup_username"
        Me.txt_signup_username.Size = New System.Drawing.Size(350, 35)
        Me.txt_signup_username.TabIndex = 12
        Me.txt_signup_username.WordWrap = False
        '
        'txt_signup_password
        '
        Me.txt_signup_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_signup_password.BackColor = System.Drawing.Color.White
        Me.txt_signup_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_signup_password.Enabled = False
        Me.txt_signup_password.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_password.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_password.Location = New System.Drawing.Point(217, 123)
        Me.txt_signup_password.MaxLength = 25
        Me.txt_signup_password.Name = "txt_signup_password"
        Me.txt_signup_password.Size = New System.Drawing.Size(350, 35)
        Me.txt_signup_password.TabIndex = 13
        Me.txt_signup_password.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(219, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 28)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Password"
        '
        'signup_bottom_panel
        '
        Me.signup_bottom_panel.Controls.Add(Me.btn_signup_cancel)
        Me.signup_bottom_panel.Controls.Add(Me.btn_signup_verify_create)
        Me.signup_bottom_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.signup_bottom_panel.Location = New System.Drawing.Point(0, 570)
        Me.signup_bottom_panel.Name = "signup_bottom_panel"
        Me.signup_bottom_panel.Size = New System.Drawing.Size(765, 129)
        Me.signup_bottom_panel.TabIndex = 15
        '
        'btn_signup_cancel
        '
        Me.btn_signup_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_signup_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_signup_cancel.FlatAppearance.BorderSize = 0
        Me.btn_signup_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signup_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_signup_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_signup_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_signup_cancel.Location = New System.Drawing.Point(404, 54)
        Me.btn_signup_cancel.Name = "btn_signup_cancel"
        Me.btn_signup_cancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_signup_cancel.Size = New System.Drawing.Size(120, 40)
        Me.btn_signup_cancel.TabIndex = 8
        Me.btn_signup_cancel.Text = "CANCEL"
        Me.btn_signup_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_signup_cancel.UseVisualStyleBackColor = False
        '
        'btn_signup_verify_create
        '
        Me.btn_signup_verify_create.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_signup_verify_create.BackColor = System.Drawing.Color.LightGreen
        Me.btn_signup_verify_create.FlatAppearance.BorderSize = 0
        Me.btn_signup_verify_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signup_verify_create.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup_verify_create.ForeColor = System.Drawing.Color.White
        Me.btn_signup_verify_create.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_submit_for_approval_24
        Me.btn_signup_verify_create.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_signup_verify_create.Location = New System.Drawing.Point(258, 54)
        Me.btn_signup_verify_create.Name = "btn_signup_verify_create"
        Me.btn_signup_verify_create.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_signup_verify_create.Size = New System.Drawing.Size(120, 40)
        Me.btn_signup_verify_create.TabIndex = 7
        Me.btn_signup_verify_create.Text = "VERIFY"
        Me.btn_signup_verify_create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_signup_verify_create.UseVisualStyleBackColor = False
        '
        'Auth_Signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(765, 723)
        Me.Controls.Add(Me.signup_bottom_panel)
        Me.Controls.Add(Me.signup_middle_panel)
        Me.Controls.Add(Me.signup_top_panel)
        Me.Name = "Auth_Signup"
        Me.Text = "Auth_Signup"
        Me.signup_top_panel.ResumeLayout(False)
        Me.signup_top_panel.PerformLayout()
        Me.signup_middle_panel.ResumeLayout(False)
        Me.signup_middle_panel.PerformLayout()
        Me.signup_bottom_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents signup_top_panel As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_signup_phone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents signup_middle_panel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_signup_confirm_password As TextBox
    Friend WithEvents txt_signup_username As TextBox
    Friend WithEvents txt_signup_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents signup_bottom_panel As Panel
    Friend WithEvents btn_signup_cancel As Button
    Friend WithEvents btn_signup_verify_create As Button
End Class
