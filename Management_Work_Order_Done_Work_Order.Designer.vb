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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_done_complete = New System.Windows.Forms.Button()
        Me.txt_done_mileage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbtn_pick_up_yes = New System.Windows.Forms.RadioButton()
        Me.rbtn_pick_up_no = New System.Windows.Forms.RadioButton()
        Me.btn_done_reset = New System.Windows.Forms.Button()
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
        Me.txt_done_next_service_due_date.Location = New System.Drawing.Point(72, 64)
        Me.txt_done_next_service_due_date.MaxDate = New Date(2029, 12, 31, 0, 0, 0, 0)
        Me.txt_done_next_service_due_date.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.txt_done_next_service_due_date.Name = "txt_done_next_service_due_date"
        Me.txt_done_next_service_due_date.Size = New System.Drawing.Size(308, 33)
        Me.txt_done_next_service_due_date.TabIndex = 1
        Me.txt_done_next_service_due_date.Value = New Date(2021, 9, 15, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 18)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Next service due date"
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
        Me.btn_done_complete.Location = New System.Drawing.Point(268, 376)
        Me.btn_done_complete.Name = "btn_done_complete"
        Me.btn_done_complete.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_done_complete.Size = New System.Drawing.Size(148, 41)
        Me.btn_done_complete.TabIndex = 7
        Me.btn_done_complete.Text = "COMPLETE"
        Me.btn_done_complete.UseVisualStyleBackColor = False
        '
        'txt_done_mileage
        '
        Me.txt_done_mileage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_done_mileage.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_done_mileage.Location = New System.Drawing.Point(74, 161)
        Me.txt_done_mileage.MaxLength = 25
        Me.txt_done_mileage.Name = "txt_done_mileage"
        Me.txt_done_mileage.Size = New System.Drawing.Size(306, 33)
        Me.txt_done_mileage.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 18)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Next Service Due mileage"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(223, 18)
        Me.Label7.TabIndex = 124
        Me.Label7.Text = "Notify the customer for pick-up ?"
        '
        'rbtn_pick_up_yes
        '
        Me.rbtn_pick_up_yes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbtn_pick_up_yes.AutoSize = True
        Me.rbtn_pick_up_yes.Checked = True
        Me.rbtn_pick_up_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_pick_up_yes.Location = New System.Drawing.Point(89, 296)
        Me.rbtn_pick_up_yes.Name = "rbtn_pick_up_yes"
        Me.rbtn_pick_up_yes.Size = New System.Drawing.Size(51, 22)
        Me.rbtn_pick_up_yes.TabIndex = 4
        Me.rbtn_pick_up_yes.TabStop = True
        Me.rbtn_pick_up_yes.Text = "Yes"
        Me.rbtn_pick_up_yes.UseVisualStyleBackColor = True
        '
        'rbtn_pick_up_no
        '
        Me.rbtn_pick_up_no.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rbtn_pick_up_no.AutoSize = True
        Me.rbtn_pick_up_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_pick_up_no.Location = New System.Drawing.Point(174, 296)
        Me.rbtn_pick_up_no.Name = "rbtn_pick_up_no"
        Me.rbtn_pick_up_no.Size = New System.Drawing.Size(46, 22)
        Me.rbtn_pick_up_no.TabIndex = 5
        Me.rbtn_pick_up_no.Text = "No"
        Me.rbtn_pick_up_no.UseVisualStyleBackColor = True
        '
        'btn_done_reset
        '
        Me.btn_done_reset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_done_reset.BackColor = System.Drawing.Color.LightCoral
        Me.btn_done_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_done_reset.FlatAppearance.BorderSize = 0
        Me.btn_done_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_done_reset.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done_reset.ForeColor = System.Drawing.Color.White
        Me.btn_done_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_done_reset.Location = New System.Drawing.Point(41, 376)
        Me.btn_done_reset.Name = "btn_done_reset"
        Me.btn_done_reset.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_done_reset.Size = New System.Drawing.Size(191, 41)
        Me.btn_done_reset.TabIndex = 6
        Me.btn_done_reset.Text = "RESET VALUES"
        Me.btn_done_reset.UseVisualStyleBackColor = False
        '
        'Management_Work_Order_Done_Work_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 451)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_done_reset)
        Me.Controls.Add(Me.rbtn_pick_up_no)
        Me.Controls.Add(Me.rbtn_pick_up_yes)
        Me.Controls.Add(Me.btn_done_complete)
        Me.Controls.Add(Me.txt_done_next_service_due_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_done_mileage)
        Me.Location = New System.Drawing.Point(550, 150)
        Me.Name = "Management_Work_Order_Done_Work_Order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Work_Order_Done_Work_Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_done_next_service_due_date As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_done_complete As Button
    Friend WithEvents txt_done_mileage As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rbtn_pick_up_yes As RadioButton
    Friend WithEvents rbtn_pick_up_no As RadioButton
    Friend WithEvents btn_done_reset As Button
End Class
