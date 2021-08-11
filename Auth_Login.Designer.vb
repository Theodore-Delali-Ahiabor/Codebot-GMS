<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auth_Login
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
        Me.lbl_password_reset = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_login_username = New System.Windows.Forms.TextBox()
        Me.txt_login_password = New System.Windows.Forms.TextBox()
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Login = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_password_reset
        '
        Me.lbl_password_reset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_password_reset.AutoSize = True
        Me.lbl_password_reset.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_password_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_password_reset.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password_reset.ForeColor = System.Drawing.Color.Red
        Me.lbl_password_reset.Location = New System.Drawing.Point(246, 355)
        Me.lbl_password_reset.Name = "lbl_password_reset"
        Me.lbl_password_reset.Size = New System.Drawing.Size(122, 19)
        Me.lbl_password_reset.TabIndex = 21
        Me.lbl_password_reset.Text = "Forgot Password ?"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(245, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 28)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Password"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(245, 190)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 28)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Username"
        '
        'txt_login_username
        '
        Me.txt_login_username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_login_username.BackColor = System.Drawing.Color.White
        Me.txt_login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_login_username.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_username.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_login_username.Location = New System.Drawing.Point(246, 221)
        Me.txt_login_username.Name = "txt_login_username"
        Me.txt_login_username.Size = New System.Drawing.Size(309, 35)
        Me.txt_login_username.TabIndex = 15
        Me.txt_login_username.WordWrap = False
        '
        'txt_login_password
        '
        Me.txt_login_password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_login_password.BackColor = System.Drawing.Color.White
        Me.txt_login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_login_password.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_login_password.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txt_login_password.Location = New System.Drawing.Point(246, 308)
        Me.txt_login_password.Name = "txt_login_password"
        Me.txt_login_password.Size = New System.Drawing.Size(309, 35)
        Me.txt_login_password.TabIndex = 16
        Me.txt_login_password.UseSystemPasswordChar = True
        '
        'btn_signup
        '
        Me.btn_signup.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_signup.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_signup.FlatAppearance.BorderSize = 0
        Me.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_signup.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup.ForeColor = System.Drawing.Color.White
        Me.btn_signup.Location = New System.Drawing.Point(423, 393)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(112, 40)
        Me.btn_signup.TabIndex = 18
        Me.btn_signup.Text = "SIGNUP"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_login.BackColor = System.Drawing.Color.LightGreen
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(270, 393)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(103, 40)
        Me.btn_login.TabIndex = 17
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Login.AutoSize = True
        Me.Login.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.Color.Teal
        Me.Login.Location = New System.Drawing.Point(339, 115)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(116, 49)
        Me.Login.TabIndex = 14
        Me.Login.Text = "Login"
        '
        'Auth_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 548)
        Me.Controls.Add(Me.lbl_password_reset)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_login_username)
        Me.Controls.Add(Me.txt_login_password)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.Login)
        Me.Name = "Auth_Login"
        Me.Text = "Auth_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_password_reset As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_signup As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents Login As Label
    Public WithEvents txt_login_username As TextBox
    Public WithEvents txt_login_password As TextBox
End Class
