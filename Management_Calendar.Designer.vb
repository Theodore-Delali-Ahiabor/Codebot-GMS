<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Calendar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Calendar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_month_year = New System.Windows.Forms.Label()
        Me.btn_calendar_current_month = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.fl_days = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_calender_previous_month = New System.Windows.Forms.Button()
        Me.btn_calendar_next_month = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_calendar_current_month)
        Me.Panel1.Controls.Add(Me.btn_calender_previous_month)
        Me.Panel1.Controls.Add(Me.lbl_month_year)
        Me.Panel1.Controls.Add(Me.btn_calendar_next_month)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1101, 52)
        Me.Panel1.TabIndex = 35
        '
        'lbl_month_year
        '
        Me.lbl_month_year.AutoSize = True
        Me.lbl_month_year.Font = New System.Drawing.Font("Ebrima", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_month_year.Location = New System.Drawing.Point(38, 9)
        Me.lbl_month_year.Name = "lbl_month_year"
        Me.lbl_month_year.Size = New System.Drawing.Size(195, 37)
        Me.lbl_month_year.TabIndex = 1
        Me.lbl_month_year.Text = "January, 2000"
        '
        'btn_calendar_current_month
        '
        Me.btn_calendar_current_month.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_calendar_current_month.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calendar_current_month.FlatAppearance.BorderSize = 0
        Me.btn_calendar_current_month.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calendar_current_month.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calendar_current_month.ForeColor = System.Drawing.Color.White
        Me.btn_calendar_current_month.Image = CType(resources.GetObject("btn_calendar_current_month.Image"), System.Drawing.Image)
        Me.btn_calendar_current_month.Location = New System.Drawing.Point(525, 9)
        Me.btn_calendar_current_month.Name = "btn_calendar_current_month"
        Me.btn_calendar_current_month.Size = New System.Drawing.Size(70, 37)
        Me.btn_calendar_current_month.TabIndex = 34
        Me.btn_calendar_current_month.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Button9)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1101, 46)
        Me.Panel3.TabIndex = 36
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(935, 6)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(142, 32)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Saturday"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(787, 6)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(142, 32)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Friday"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(639, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(142, 32)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Thursday"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(491, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(142, 32)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "Wednessday"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(343, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 32)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Tuesday"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(195, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(142, 32)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Monday"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(45, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 32)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Sunday"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 98)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(42, 425)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1060, 98)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(41, 425)
        Me.Panel5.TabIndex = 38
        '
        'fl_days
        '
        Me.fl_days.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fl_days.Location = New System.Drawing.Point(42, 98)
        Me.fl_days.Name = "fl_days"
        Me.fl_days.Size = New System.Drawing.Size(1018, 425)
        Me.fl_days.TabIndex = 39
        '
        'btn_calender_previous_month
        '
        Me.btn_calender_previous_month.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_calender_previous_month.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calender_previous_month.FlatAppearance.BorderSize = 0
        Me.btn_calender_previous_month.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calender_previous_month.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calender_previous_month.ForeColor = System.Drawing.Color.White
        Me.btn_calender_previous_month.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_back_24
        Me.btn_calender_previous_month.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_calender_previous_month.Location = New System.Drawing.Point(481, 9)
        Me.btn_calender_previous_month.Name = "btn_calender_previous_month"
        Me.btn_calender_previous_month.Size = New System.Drawing.Size(39, 37)
        Me.btn_calender_previous_month.TabIndex = 33
        Me.btn_calender_previous_month.UseVisualStyleBackColor = False
        '
        'btn_calendar_next_month
        '
        Me.btn_calendar_next_month.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_calendar_next_month.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calendar_next_month.FlatAppearance.BorderSize = 0
        Me.btn_calendar_next_month.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calendar_next_month.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calendar_next_month.ForeColor = System.Drawing.Color.White
        Me.btn_calendar_next_month.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_forward_24
        Me.btn_calendar_next_month.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_calendar_next_month.Location = New System.Drawing.Point(601, 9)
        Me.btn_calendar_next_month.Name = "btn_calendar_next_month"
        Me.btn_calendar_next_month.Size = New System.Drawing.Size(39, 37)
        Me.btn_calendar_next_month.TabIndex = 34
        Me.btn_calendar_next_month.UseVisualStyleBackColor = False
        '
        'Management_Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1101, 523)
        Me.Controls.Add(Me.fl_days)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(8000, 5000)
        Me.Name = "Management_Calendar"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management_Calendar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_calender_previous_month As Button
    Friend WithEvents btn_calendar_next_month As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_calendar_current_month As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents fl_days As FlowLayoutPanel
    Friend WithEvents lbl_month_year As Label
End Class
