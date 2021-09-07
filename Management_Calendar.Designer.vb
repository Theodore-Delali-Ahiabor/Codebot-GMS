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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.btn_add_new_Order = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(4, 3)
        Me.MonthCalendar1.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(18, 74)
        Me.MonthCalendar1.MaxDate = New Date(2029, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar1.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        Me.MonthCalendar1.TodayDate = New Date(2021, 9, 1, 0, 0, 0, 0)
        '
        'btn_add_new_Order
        '
        Me.btn_add_new_Order.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_add_new_Order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_new_Order.FlatAppearance.BorderSize = 0
        Me.btn_add_new_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_new_Order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_Order.ForeColor = System.Drawing.Color.White
        Me.btn_add_new_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_new_Order.Location = New System.Drawing.Point(43, 16)
        Me.btn_add_new_Order.Name = "btn_add_new_Order"
        Me.btn_add_new_Order.Size = New System.Drawing.Size(117, 46)
        Me.btn_add_new_Order.TabIndex = 33
        Me.btn_add_new_Order.Text = "New Event"
        Me.btn_add_new_Order.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(175, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 46)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "All Events"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Management_Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(961, 566)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_add_new_Order)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.MaximumSize = New System.Drawing.Size(8000, 5000)
        Me.Name = "Management_Calendar"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management_Calendar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents btn_add_new_Order As Button
    Friend WithEvents Button1 As Button
End Class
