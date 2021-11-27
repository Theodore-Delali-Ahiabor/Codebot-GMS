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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_password_reset_email = New System.Windows.Forms.TextBox()
        Me.txt_password_reset_code = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_password_reset_send_code = New System.Windows.Forms.Button()
        Me.btn_password_reset_cancel = New System.Windows.Forms.Button()
        Me.btn_password_reset_reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(205, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 28)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Email Address"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.LightCoral
        Me.Label12.Location = New System.Drawing.Point(309, 389)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 28)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.LightCoral
        Me.Label13.Location = New System.Drawing.Point(336, 275)
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
        Me.txt_password_reset_email.Location = New System.Drawing.Point(210, 306)
        Me.txt_password_reset_email.MaxLength = 100
        Me.txt_password_reset_email.Name = "txt_password_reset_email"
        Me.txt_password_reset_email.Size = New System.Drawing.Size(350, 31)
        Me.txt_password_reset_email.TabIndex = 1
        Me.txt_password_reset_email.WordWrap = False
        '
        'txt_password_reset_code
        '
        Me.txt_password_reset_code.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_password_reset_code.BackColor = System.Drawing.Color.White
        Me.txt_password_reset_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password_reset_code.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password_reset_code.ForeColor = System.Drawing.Color.Teal
        Me.txt_password_reset_code.Location = New System.Drawing.Point(210, 420)
        Me.txt_password_reset_code.MaxLength = 6
        Me.txt_password_reset_code.Name = "txt_password_reset_code"
        Me.txt_password_reset_code.Size = New System.Drawing.Size(129, 31)
        Me.txt_password_reset_code.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Teal
        Me.Label15.Location = New System.Drawing.Point(241, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(303, 49)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "LOGIN RESET"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(205, 389)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 28)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Enter Code"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(207, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "NOTICE"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(206, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(369, 21)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "-After a succesful login reset, you will be required to"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(206, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(284, 21)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "  create a new Username and Password."
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(206, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(358, 21)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "-Internet connectivity is needed to reset your login"
        '
        'btn_password_reset_send_code
        '
        Me.btn_password_reset_send_code.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_password_reset_send_code.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_password_reset_send_code.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_password_reset_send_code.FlatAppearance.BorderSize = 0
        Me.btn_password_reset_send_code.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_password_reset_send_code.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_password_reset_send_code.ForeColor = System.Drawing.Color.White
        Me.btn_password_reset_send_code.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_send_24
        Me.btn_password_reset_send_code.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_password_reset_send_code.Location = New System.Drawing.Point(419, 343)
        Me.btn_password_reset_send_code.Name = "btn_password_reset_send_code"
        Me.btn_password_reset_send_code.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_password_reset_send_code.Size = New System.Drawing.Size(141, 32)
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
        Me.btn_password_reset_cancel.FlatAppearance.BorderSize = 0
        Me.btn_password_reset_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_password_reset_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_password_reset_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_password_reset_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_password_reset_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_password_reset_cancel.Location = New System.Drawing.Point(397, 494)
        Me.btn_password_reset_cancel.Name = "btn_password_reset_cancel"
        Me.btn_password_reset_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_password_reset_cancel.Size = New System.Drawing.Size(128, 40)
        Me.btn_password_reset_cancel.TabIndex = 5
        Me.btn_password_reset_cancel.Text = "  CANCEL    "
        Me.btn_password_reset_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_password_reset_cancel.UseVisualStyleBackColor = False
        '
        'btn_password_reset_reset
        '
        Me.btn_password_reset_reset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_password_reset_reset.BackColor = System.Drawing.Color.LightGreen
        Me.btn_password_reset_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_password_reset_reset.Enabled = False
        Me.btn_password_reset_reset.FlatAppearance.BorderSize = 0
        Me.btn_password_reset_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_password_reset_reset.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_password_reset_reset.ForeColor = System.Drawing.Color.White
        Me.btn_password_reset_reset.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_reset_24
        Me.btn_password_reset_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_password_reset_reset.Location = New System.Drawing.Point(250, 494)
        Me.btn_password_reset_reset.Name = "btn_password_reset_reset"
        Me.btn_password_reset_reset.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_password_reset_reset.Size = New System.Drawing.Size(116, 40)
        Me.btn_password_reset_reset.TabIndex = 4
        Me.btn_password_reset_reset.Text = "  RESET"
        Me.btn_password_reset_reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_password_reset_reset.UseVisualStyleBackColor = False
        '
        'Auth_Password_Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(796, 574)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_password_reset_send_code)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_password_reset_email)
        Me.Controls.Add(Me.txt_password_reset_code)
        Me.Controls.Add(Me.btn_password_reset_cancel)
        Me.Controls.Add(Me.btn_password_reset_reset)
        Me.Controls.Add(Me.Label15)
        Me.Name = "Auth_Password_Reset"
        Me.Text = "Auth_Password_Reset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_password_reset_email As TextBox
    Friend WithEvents txt_password_reset_code As TextBox
    Friend WithEvents btn_password_reset_cancel As Button
    Friend WithEvents btn_password_reset_reset As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_password_reset_send_code As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
