<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Feedbacks
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Feedbacks))
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_deactivate_employee = New System.Windows.Forms.Button()
        Me.btn_activate_employee = New System.Windows.Forms.Button()
        Me.btn_new_mail = New System.Windows.Forms.Button()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EmployeesDataGridView
        '
        Me.EmployeesDataGridView.AllowUserToAddRows = False
        Me.EmployeesDataGridView.AllowUserToDeleteRows = False
        Me.EmployeesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EmployeesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.EmployeesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EmployeesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmployeesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.EmployeesDataGridView.EnableHeadersVisualStyles = False
        Me.EmployeesDataGridView.GridColor = System.Drawing.Color.Silver
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(54, 74)
        Me.EmployeesDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.EmployeesDataGridView.MultiSelect = False
        Me.EmployeesDataGridView.Name = "EmployeesDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeesDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeesDataGridView.RowTemplate.Height = 38
        Me.EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(1012, 479)
        Me.EmployeesDataGridView.TabIndex = 2
        Me.EmployeesDataGridView.VirtualMode = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(50, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 21)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "-Internet connectivity is needed to view customer feedbacks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(51, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "NOTICE"
        '
        'btn_deactivate_employee
        '
        Me.btn_deactivate_employee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_deactivate_employee.AutoEllipsis = True
        Me.btn_deactivate_employee.BackColor = System.Drawing.Color.Coral
        Me.btn_deactivate_employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deactivate_employee.FlatAppearance.BorderSize = 0
        Me.btn_deactivate_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deactivate_employee.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deactivate_employee.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_deactivate_employee.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_toggle_off_32
        Me.btn_deactivate_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_deactivate_employee.Location = New System.Drawing.Point(218, 561)
        Me.btn_deactivate_employee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_deactivate_employee.Name = "btn_deactivate_employee"
        Me.btn_deactivate_employee.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_deactivate_employee.Size = New System.Drawing.Size(155, 46)
        Me.btn_deactivate_employee.TabIndex = 44
        Me.btn_deactivate_employee.Text = "Deactivate"
        Me.btn_deactivate_employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_deactivate_employee.UseVisualStyleBackColor = False
        '
        'btn_activate_employee
        '
        Me.btn_activate_employee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_activate_employee.AutoEllipsis = True
        Me.btn_activate_employee.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_activate_employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_activate_employee.FlatAppearance.BorderSize = 0
        Me.btn_activate_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_activate_employee.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_activate_employee.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_activate_employee.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_toggle_on_32
        Me.btn_activate_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_activate_employee.Location = New System.Drawing.Point(54, 561)
        Me.btn_activate_employee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_activate_employee.Name = "btn_activate_employee"
        Me.btn_activate_employee.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_activate_employee.Size = New System.Drawing.Size(139, 46)
        Me.btn_activate_employee.TabIndex = 43
        Me.btn_activate_employee.Text = "Activate"
        Me.btn_activate_employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_activate_employee.UseVisualStyleBackColor = False
        '
        'btn_new_mail
        '
        Me.btn_new_mail.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_new_mail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_mail.FlatAppearance.BorderSize = 0
        Me.btn_new_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_mail.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_mail.Image = CType(resources.GetObject("btn_new_mail.Image"), System.Drawing.Image)
        Me.btn_new_mail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_mail.Location = New System.Drawing.Point(460, 483)
        Me.btn_new_mail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_new_mail.Name = "btn_new_mail"
        Me.btn_new_mail.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_new_mail.Size = New System.Drawing.Size(97, 46)
        Me.btn_new_mail.TabIndex = 45
        Me.btn_new_mail.Text = "    New"
        Me.btn_new_mail.UseVisualStyleBackColor = False
        '
        'Management_Feedbacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1121, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_new_mail)
        Me.Controls.Add(Me.btn_deactivate_employee)
        Me.Controls.Add(Me.btn_activate_employee)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmployeesDataGridView)
        Me.Name = "Management_Feedbacks"
        Me.Text = "Management_Feedbacks"
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EmployeesDataGridView As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_deactivate_employee As Button
    Friend WithEvents btn_activate_employee As Button
    Friend WithEvents btn_new_mail As Button
End Class
