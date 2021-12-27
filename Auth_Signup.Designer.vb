<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Auth_Signup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auth_Signup))
        Me.signup_top_panel = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_signup_email = New System.Windows.Forms.TextBox()
        Me.lbl_signup_title = New System.Windows.Forms.Label()
        Me.signup_middle_panel = New System.Windows.Forms.Panel()
        Me.signup_validate_num = New System.Windows.Forms.PictureBox()
        Me.signup_validate_symbol = New System.Windows.Forms.PictureBox()
        Me.signup_valid = New System.Windows.Forms.PictureBox()
        Me.signup_invalid = New System.Windows.Forms.PictureBox()
        Me.signup_validate_8_chars = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.signup_notice_panel = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.signup_top_panel.SuspendLayout()
        Me.signup_middle_panel.SuspendLayout()
        CType(Me.signup_validate_num, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signup_validate_symbol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signup_valid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signup_invalid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signup_validate_8_chars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.signup_bottom_panel.SuspendLayout()
        Me.signup_notice_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'signup_top_panel
        '
        Me.signup_top_panel.Controls.Add(Me.Label17)
        Me.signup_top_panel.Controls.Add(Me.Label18)
        Me.signup_top_panel.Controls.Add(Me.txt_signup_email)
        Me.signup_top_panel.Controls.Add(Me.lbl_signup_title)
        Me.signup_top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.signup_top_panel.Location = New System.Drawing.Point(0, 0)
        Me.signup_top_panel.Name = "signup_top_panel"
        Me.signup_top_panel.Size = New System.Drawing.Size(504, 198)
        Me.signup_top_panel.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label17.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Teal
        Me.Label17.Location = New System.Drawing.Point(71, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 28)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Email Address"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.LightCoral
        Me.Label18.Location = New System.Drawing.Point(210, 107)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 28)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "*"
        '
        'txt_signup_email
        '
        Me.txt_signup_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_signup_email.BackColor = System.Drawing.Color.White
        Me.txt_signup_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_signup_email.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_email.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_email.Location = New System.Drawing.Point(69, 138)
        Me.txt_signup_email.MaxLength = 100
        Me.txt_signup_email.Name = "txt_signup_email"
        Me.txt_signup_email.Size = New System.Drawing.Size(350, 31)
        Me.txt_signup_email.TabIndex = 16
        Me.txt_signup_email.WordWrap = False
        '
        'lbl_signup_title
        '
        Me.lbl_signup_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_signup_title.AutoSize = True
        Me.lbl_signup_title.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_signup_title.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_signup_title.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_signup_title.ForeColor = System.Drawing.Color.Teal
        Me.lbl_signup_title.Location = New System.Drawing.Point(162, 42)
        Me.lbl_signup_title.Name = "lbl_signup_title"
        Me.lbl_signup_title.Size = New System.Drawing.Size(146, 49)
        Me.lbl_signup_title.TabIndex = 15
        Me.lbl_signup_title.Text = "SignUp"
        '
        'signup_middle_panel
        '
        Me.signup_middle_panel.Controls.Add(Me.signup_validate_num)
        Me.signup_middle_panel.Controls.Add(Me.signup_validate_symbol)
        Me.signup_middle_panel.Controls.Add(Me.signup_valid)
        Me.signup_middle_panel.Controls.Add(Me.signup_invalid)
        Me.signup_middle_panel.Controls.Add(Me.signup_validate_8_chars)
        Me.signup_middle_panel.Controls.Add(Me.Label8)
        Me.signup_middle_panel.Controls.Add(Me.Label11)
        Me.signup_middle_panel.Controls.Add(Me.Label10)
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
        Me.signup_middle_panel.Location = New System.Drawing.Point(0, 198)
        Me.signup_middle_panel.Name = "signup_middle_panel"
        Me.signup_middle_panel.Size = New System.Drawing.Size(504, 335)
        Me.signup_middle_panel.TabIndex = 14
        Me.signup_middle_panel.Visible = False
        '
        'signup_validate_num
        '
        Me.signup_validate_num.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signup_validate_num.Image = CType(resources.GetObject("signup_validate_num.Image"), System.Drawing.Image)
        Me.signup_validate_num.Location = New System.Drawing.Point(81, 227)
        Me.signup_validate_num.Name = "signup_validate_num"
        Me.signup_validate_num.Size = New System.Drawing.Size(24, 24)
        Me.signup_validate_num.TabIndex = 44
        Me.signup_validate_num.TabStop = False
        '
        'signup_validate_symbol
        '
        Me.signup_validate_symbol.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signup_validate_symbol.Image = CType(resources.GetObject("signup_validate_symbol.Image"), System.Drawing.Image)
        Me.signup_validate_symbol.Location = New System.Drawing.Point(81, 196)
        Me.signup_validate_symbol.Name = "signup_validate_symbol"
        Me.signup_validate_symbol.Size = New System.Drawing.Size(24, 24)
        Me.signup_validate_symbol.TabIndex = 44
        Me.signup_validate_symbol.TabStop = False
        '
        'signup_valid
        '
        Me.signup_valid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signup_valid.ErrorImage = Nothing
        Me.signup_valid.Image = Global.Codebot_GMS.My.Resources.Resources.checkmark_24px
        Me.signup_valid.Location = New System.Drawing.Point(38, 223)
        Me.signup_valid.Name = "signup_valid"
        Me.signup_valid.Size = New System.Drawing.Size(24, 24)
        Me.signup_valid.TabIndex = 44
        Me.signup_valid.TabStop = False
        Me.signup_valid.Visible = False
        '
        'signup_invalid
        '
        Me.signup_invalid.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signup_invalid.ErrorImage = Global.Codebot_GMS.My.Resources.Resources.checkmark_24px
        Me.signup_invalid.Image = CType(resources.GetObject("signup_invalid.Image"), System.Drawing.Image)
        Me.signup_invalid.Location = New System.Drawing.Point(38, 193)
        Me.signup_invalid.Name = "signup_invalid"
        Me.signup_invalid.Size = New System.Drawing.Size(24, 24)
        Me.signup_invalid.TabIndex = 44
        Me.signup_invalid.TabStop = False
        Me.signup_invalid.Visible = False
        '
        'signup_validate_8_chars
        '
        Me.signup_validate_8_chars.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signup_validate_8_chars.ErrorImage = Nothing
        Me.signup_validate_8_chars.Image = CType(resources.GetObject("signup_validate_8_chars.Image"), System.Drawing.Image)
        Me.signup_validate_8_chars.Location = New System.Drawing.Point(81, 165)
        Me.signup_validate_8_chars.Name = "signup_validate_8_chars"
        Me.signup_validate_8_chars.Size = New System.Drawing.Size(24, 24)
        Me.signup_validate_8_chars.TabIndex = 44
        Me.signup_validate_8_chars.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(111, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(305, 21)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "must contain at least a numeric value (0-9)"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(111, 170)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(214, 21)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "must be 8 or more characters"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(108, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(331, 21)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "must contain at least a symbol (e.g @ # $ % & ?)"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(71, 6)
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
        Me.Label7.Location = New System.Drawing.Point(236, 263)
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
        Me.Label6.Location = New System.Drawing.Point(166, 93)
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
        Me.Label5.Location = New System.Drawing.Point(166, 6)
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
        Me.Label4.Location = New System.Drawing.Point(69, 263)
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
        Me.txt_signup_confirm_password.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_confirm_password.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_confirm_password.Location = New System.Drawing.Point(69, 294)
        Me.txt_signup_confirm_password.MaxLength = 25
        Me.txt_signup_confirm_password.Name = "txt_signup_confirm_password"
        Me.txt_signup_confirm_password.Size = New System.Drawing.Size(350, 31)
        Me.txt_signup_confirm_password.TabIndex = 14
        Me.txt_signup_confirm_password.UseSystemPasswordChar = True
        '
        'txt_signup_username
        '
        Me.txt_signup_username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_signup_username.BackColor = System.Drawing.Color.White
        Me.txt_signup_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_signup_username.Enabled = False
        Me.txt_signup_username.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_username.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_username.Location = New System.Drawing.Point(69, 37)
        Me.txt_signup_username.MaxLength = 25
        Me.txt_signup_username.Name = "txt_signup_username"
        Me.txt_signup_username.Size = New System.Drawing.Size(350, 31)
        Me.txt_signup_username.TabIndex = 12
        Me.txt_signup_username.WordWrap = False
        '
        'txt_signup_password
        '
        Me.txt_signup_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_signup_password.BackColor = System.Drawing.Color.White
        Me.txt_signup_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_signup_password.Enabled = False
        Me.txt_signup_password.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_signup_password.ForeColor = System.Drawing.Color.Teal
        Me.txt_signup_password.Location = New System.Drawing.Point(69, 124)
        Me.txt_signup_password.MaxLength = 25
        Me.txt_signup_password.Name = "txt_signup_password"
        Me.txt_signup_password.Size = New System.Drawing.Size(350, 31)
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
        Me.Label3.Location = New System.Drawing.Point(71, 93)
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
        Me.signup_bottom_panel.Location = New System.Drawing.Point(0, 533)
        Me.signup_bottom_panel.Name = "signup_bottom_panel"
        Me.signup_bottom_panel.Size = New System.Drawing.Size(504, 85)
        Me.signup_bottom_panel.TabIndex = 16
        '
        'btn_signup_cancel
        '
        Me.btn_signup_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_signup_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_signup_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_signup_cancel.FlatAppearance.BorderSize = 0
        Me.btn_signup_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signup_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_signup_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_signup_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_signup_cancel.Location = New System.Drawing.Point(245, 27)
        Me.btn_signup_cancel.Name = "btn_signup_cancel"
        Me.btn_signup_cancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_signup_cancel.Size = New System.Drawing.Size(132, 40)
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
        Me.btn_signup_verify_create.Location = New System.Drawing.Point(99, 27)
        Me.btn_signup_verify_create.Name = "btn_signup_verify_create"
        Me.btn_signup_verify_create.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_signup_verify_create.Size = New System.Drawing.Size(120, 40)
        Me.btn_signup_verify_create.TabIndex = 7
        Me.btn_signup_verify_create.Text = "VERIFY"
        Me.btn_signup_verify_create.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_signup_verify_create.UseVisualStyleBackColor = False
        '
        'signup_notice_panel
        '
        Me.signup_notice_panel.Controls.Add(Me.Label9)
        Me.signup_notice_panel.Controls.Add(Me.Label12)
        Me.signup_notice_panel.Controls.Add(Me.Label15)
        Me.signup_notice_panel.Controls.Add(Me.Label13)
        Me.signup_notice_panel.Controls.Add(Me.Label14)
        Me.signup_notice_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.signup_notice_panel.Location = New System.Drawing.Point(0, 618)
        Me.signup_notice_panel.Name = "signup_notice_panel"
        Me.signup_notice_panel.Size = New System.Drawing.Size(504, 131)
        Me.signup_notice_panel.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(83, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(323, 21)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "-your details have been added to the systems"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(68, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(265, 21)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "You can ONLY create a user login if : "
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(83, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(183, 21)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "-you have been activated"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DimGray
        Me.Label13.Location = New System.Drawing.Point(83, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 21)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "-you are an employee"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.IndianRed
        Me.Label14.Location = New System.Drawing.Point(69, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 13)
        Me.Label14.TabIndex = 40
        Me.Label14.Text = "NOTICE"
        '
        'Auth_Signup
        '
        Me.AcceptButton = Me.btn_signup_verify_create
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btn_signup_cancel
        Me.ClientSize = New System.Drawing.Size(504, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.signup_notice_panel)
        Me.Controls.Add(Me.signup_bottom_panel)
        Me.Controls.Add(Me.signup_middle_panel)
        Me.Controls.Add(Me.signup_top_panel)
        Me.Name = "Auth_Signup"
        Me.Text = "Auth_Signup"
        Me.signup_top_panel.ResumeLayout(False)
        Me.signup_top_panel.PerformLayout()
        Me.signup_middle_panel.ResumeLayout(False)
        Me.signup_middle_panel.PerformLayout()
        CType(Me.signup_validate_num, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signup_validate_symbol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signup_valid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signup_invalid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signup_validate_8_chars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.signup_bottom_panel.ResumeLayout(False)
        Me.signup_notice_panel.ResumeLayout(False)
        Me.signup_notice_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents signup_top_panel As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_signup_email As TextBox
    Friend WithEvents lbl_signup_title As Label
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents signup_validate_8_chars As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents signup_validate_num As PictureBox
    Friend WithEvents signup_validate_symbol As PictureBox
    Friend WithEvents signup_valid As PictureBox
    Friend WithEvents signup_invalid As PictureBox
    Friend WithEvents signup_notice_panel As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
