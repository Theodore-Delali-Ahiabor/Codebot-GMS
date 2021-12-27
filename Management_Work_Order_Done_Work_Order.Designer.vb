<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Work_Order_Done_Work_Order
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
        Me.txt_done_next_service_due_date = New System.Windows.Forms.DateTimePicker()
        Me.btn_done_complete = New System.Windows.Forms.Button()
        Me.txt_done_mileage = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkb_work_order_send_sms = New System.Windows.Forms.CheckBox()
        Me.chkb_work_order_send_whatsapp = New System.Windows.Forms.CheckBox()
        Me.chkb_work_order_send_email = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txt_done_next_service_due_date
        '
        Me.txt_done_next_service_due_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_done_next_service_due_date.Checked = False
        Me.txt_done_next_service_due_date.CustomFormat = ""
        Me.txt_done_next_service_due_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txt_done_next_service_due_date.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_done_next_service_due_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_done_next_service_due_date.Location = New System.Drawing.Point(74, 109)
        Me.txt_done_next_service_due_date.MaxDate = New Date(2029, 12, 31, 0, 0, 0, 0)
        Me.txt_done_next_service_due_date.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.txt_done_next_service_due_date.Name = "txt_done_next_service_due_date"
        Me.txt_done_next_service_due_date.Size = New System.Drawing.Size(308, 33)
        Me.txt_done_next_service_due_date.TabIndex = 1
        Me.txt_done_next_service_due_date.Value = New Date(2021, 9, 15, 0, 0, 0, 0)
        '
        'btn_done_complete
        '
        Me.btn_done_complete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_done_complete.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_done_complete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_done_complete.FlatAppearance.BorderSize = 0
        Me.btn_done_complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_done_complete.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done_complete.ForeColor = System.Drawing.Color.White
        Me.btn_done_complete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_done_complete.Location = New System.Drawing.Point(155, 482)
        Me.btn_done_complete.Name = "btn_done_complete"
        Me.btn_done_complete.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_done_complete.Size = New System.Drawing.Size(136, 41)
        Me.btn_done_complete.TabIndex = 7
        Me.btn_done_complete.Text = "FINISH"
        Me.btn_done_complete.UseVisualStyleBackColor = False
        '
        'txt_done_mileage
        '
        Me.txt_done_mileage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_done_mileage.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_done_mileage.Location = New System.Drawing.Point(76, 200)
        Me.txt_done_mileage.MaxLength = 25
        Me.txt_done_mileage.Name = "txt_done_mileage"
        Me.txt_done_mileage.Size = New System.Drawing.Size(306, 33)
        Me.txt_done_mileage.TabIndex = 2
        '
        'Login
        '
        Me.Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Login.AutoSize = True
        Me.Login.BackColor = System.Drawing.Color.Transparent
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Login.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.Color.MintCream
        Me.Login.Location = New System.Drawing.Point(146, 9)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(159, 49)
        Me.Login.TabIndex = 125
        Me.Login.Text = "Finalize"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(71, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(199, 28)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "Next service due date"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(71, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 28)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Notify the customer for pick-up ? Via : "
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(71, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 28)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = "Next Service Due mileage"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGray
        Me.Label7.Location = New System.Drawing.Point(80, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 21)
        Me.Label7.TabIndex = 129
        Me.Label7.Text = "-Multiple selection is allowed"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(203, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 21)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "(This option is Inactive)"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.IndianRed
        Me.Label9.Location = New System.Drawing.Point(81, 286)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "HINT"
        '
        'chkb_work_order_send_sms
        '
        Me.chkb_work_order_send_sms.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkb_work_order_send_sms.AutoSize = True
        Me.chkb_work_order_send_sms.Enabled = False
        Me.chkb_work_order_send_sms.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_work_order_send_sms.Image = Global.Codebot_GMS.My.Resources.Resources.sms_24px
        Me.chkb_work_order_send_sms.Location = New System.Drawing.Point(101, 416)
        Me.chkb_work_order_send_sms.Name = "chkb_work_order_send_sms"
        Me.chkb_work_order_send_sms.Padding = New System.Windows.Forms.Padding(5)
        Me.chkb_work_order_send_sms.Size = New System.Drawing.Size(95, 35)
        Me.chkb_work_order_send_sms.TabIndex = 130
        Me.chkb_work_order_send_sms.Text = "SMS"
        Me.chkb_work_order_send_sms.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkb_work_order_send_sms.UseVisualStyleBackColor = True
        '
        'chkb_work_order_send_whatsapp
        '
        Me.chkb_work_order_send_whatsapp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkb_work_order_send_whatsapp.AutoSize = True
        Me.chkb_work_order_send_whatsapp.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_work_order_send_whatsapp.Image = Global.Codebot_GMS.My.Resources.Resources.whatsapp_24px
        Me.chkb_work_order_send_whatsapp.Location = New System.Drawing.Point(101, 376)
        Me.chkb_work_order_send_whatsapp.Name = "chkb_work_order_send_whatsapp"
        Me.chkb_work_order_send_whatsapp.Padding = New System.Windows.Forms.Padding(5)
        Me.chkb_work_order_send_whatsapp.Size = New System.Drawing.Size(133, 35)
        Me.chkb_work_order_send_whatsapp.TabIndex = 131
        Me.chkb_work_order_send_whatsapp.Text = "Whatsapp"
        Me.chkb_work_order_send_whatsapp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkb_work_order_send_whatsapp.UseVisualStyleBackColor = True
        '
        'chkb_work_order_send_email
        '
        Me.chkb_work_order_send_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkb_work_order_send_email.AutoSize = True
        Me.chkb_work_order_send_email.Checked = True
        Me.chkb_work_order_send_email.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkb_work_order_send_email.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkb_work_order_send_email.Image = Global.Codebot_GMS.My.Resources.Resources.email_24px
        Me.chkb_work_order_send_email.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkb_work_order_send_email.Location = New System.Drawing.Point(101, 337)
        Me.chkb_work_order_send_email.Name = "chkb_work_order_send_email"
        Me.chkb_work_order_send_email.Padding = New System.Windows.Forms.Padding(5)
        Me.chkb_work_order_send_email.Size = New System.Drawing.Size(101, 35)
        Me.chkb_work_order_send_email.TabIndex = 132
        Me.chkb_work_order_send_email.Text = "Email"
        Me.chkb_work_order_send_email.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.chkb_work_order_send_email.UseVisualStyleBackColor = True
        '
        'Management_Work_Order_Done_Work_Order
        '
        Me.AcceptButton = Me.btn_done_complete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(464, 545)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkb_work_order_send_sms)
        Me.Controls.Add(Me.chkb_work_order_send_whatsapp)
        Me.Controls.Add(Me.chkb_work_order_send_email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.btn_done_complete)
        Me.Controls.Add(Me.txt_done_next_service_due_date)
        Me.Controls.Add(Me.txt_done_mileage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(550, 150)
        Me.Name = "Management_Work_Order_Done_Work_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Work_Order_Done_Work_Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_done_next_service_due_date As DateTimePicker
    Friend WithEvents btn_done_complete As Button
    Friend WithEvents txt_done_mileage As TextBox
    Friend WithEvents Login As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkb_work_order_send_sms As CheckBox
    Friend WithEvents chkb_work_order_send_whatsapp As CheckBox
    Friend WithEvents chkb_work_order_send_email As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
End Class
