<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Employees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Employees))
        Me.cmb_employee_position_filter = New System.Windows.Forms.ComboBox()
        Me.txt_employee_name_filter = New System.Windows.Forms.TextBox()
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_deactivate_employee = New System.Windows.Forms.Button()
        Me.btn_activate_employee = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_edit_employee = New System.Windows.Forms.Button()
        Me.btn_add_new_employee = New System.Windows.Forms.Button()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_employee_position_filter
        '
        Me.cmb_employee_position_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_employee_position_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employee_position_filter.FormattingEnabled = True
        Me.cmb_employee_position_filter.Location = New System.Drawing.Point(837, 44)
        Me.cmb_employee_position_filter.Margin = New System.Windows.Forms.Padding(9, 14, 9, 14)
        Me.cmb_employee_position_filter.Name = "cmb_employee_position_filter"
        Me.cmb_employee_position_filter.Size = New System.Drawing.Size(222, 29)
        Me.cmb_employee_position_filter.TabIndex = 30
        '
        'txt_employee_name_filter
        '
        Me.txt_employee_name_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_employee_name_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_employee_name_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_employee_name_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_employee_name_filter.Location = New System.Drawing.Point(586, 44)
        Me.txt_employee_name_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_employee_name_filter.Name = "txt_employee_name_filter"
        Me.txt_employee_name_filter.Size = New System.Drawing.Size(222, 29)
        Me.txt_employee_name_filter.TabIndex = 39
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
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(33, 88)
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
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(1026, 405)
        Me.EmployeesDataGridView.TabIndex = 1
        Me.EmployeesDataGridView.VirtualMode = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(697, 513)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 46)
        Me.Panel1.TabIndex = 43
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.CadetBlue
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(209, 2)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(16, 17)
        Me.Button3.TabIndex = 45
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Honeydew
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(18, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(16, 17)
        Me.Button2.TabIndex = 44
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(18, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(16, 17)
        Me.Button1.TabIndex = 43
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(231, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Selected Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(40, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Inactive Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Active Employee"
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
        Me.btn_deactivate_employee.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_toggle_off_32
        Me.btn_deactivate_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_deactivate_employee.Location = New System.Drawing.Point(197, 511)
        Me.btn_deactivate_employee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_deactivate_employee.Name = "btn_deactivate_employee"
        Me.btn_deactivate_employee.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_deactivate_employee.Size = New System.Drawing.Size(155, 46)
        Me.btn_deactivate_employee.TabIndex = 42
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
        Me.btn_activate_employee.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_toggle_on_32
        Me.btn_activate_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_activate_employee.Location = New System.Drawing.Point(33, 511)
        Me.btn_activate_employee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_activate_employee.Name = "btn_activate_employee"
        Me.btn_activate_employee.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_activate_employee.Size = New System.Drawing.Size(139, 46)
        Me.btn_activate_employee.TabIndex = 41
        Me.btn_activate_employee.Text = "Activate"
        Me.btn_activate_employee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_activate_employee.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_search_80
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(583, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Label4.Size = New System.Drawing.Size(84, 35)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Name      "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_filter_24
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(834, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Label2.Size = New System.Drawing.Size(73, 35)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Role      "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_edit_employee
        '
        Me.btn_edit_employee.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_edit_employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_employee.FlatAppearance.BorderSize = 0
        Me.btn_edit_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_employee.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_employee.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_edit_white_24
        Me.btn_edit_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit_employee.Location = New System.Drawing.Point(143, 17)
        Me.btn_edit_employee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_edit_employee.Name = "btn_edit_employee"
        Me.btn_edit_employee.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_edit_employee.Size = New System.Drawing.Size(97, 46)
        Me.btn_edit_employee.TabIndex = 33
        Me.btn_edit_employee.Text = "  Edit"
        Me.btn_edit_employee.UseVisualStyleBackColor = False
        '
        'btn_add_new_employee
        '
        Me.btn_add_new_employee.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_add_new_employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_new_employee.FlatAppearance.BorderSize = 0
        Me.btn_add_new_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_new_employee.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_employee.Image = CType(resources.GetObject("btn_add_new_employee.Image"), System.Drawing.Image)
        Me.btn_add_new_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_new_employee.Location = New System.Drawing.Point(33, 17)
        Me.btn_add_new_employee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_add_new_employee.Name = "btn_add_new_employee"
        Me.btn_add_new_employee.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btn_add_new_employee.Size = New System.Drawing.Size(97, 46)
        Me.btn_add_new_employee.TabIndex = 0
        Me.btn_add_new_employee.Text = "    New"
        Me.btn_add_new_employee.UseVisualStyleBackColor = False
        '
        'Management_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1101, 571)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_deactivate_employee)
        Me.Controls.Add(Me.btn_activate_employee)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_employee_name_filter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_edit_employee)
        Me.Controls.Add(Me.cmb_employee_position_filter)
        Me.Controls.Add(Me.EmployeesDataGridView)
        Me.Controls.Add(Me.btn_add_new_employee)
        Me.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Management_Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add_new_employee As Button
    Friend WithEvents cmb_employee_position_filter As ComboBox
    Friend WithEvents btn_edit_employee As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_employee_name_filter As TextBox
    Friend WithEvents EmployeesDataGridView As DataGridView
    Friend WithEvents btn_activate_employee As Button
    Friend WithEvents btn_deactivate_employee As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
