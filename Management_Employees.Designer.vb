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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Employees))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmb_employee_position_filter = New System.Windows.Forms.ComboBox()
        Me.txt_employee_number_filter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_edit_employee = New System.Windows.Forms.Button()
        Me.btn_add_new_employee = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_employee_name_filter = New System.Windows.Forms.TextBox()
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_employee_position_filter
        '
        Me.cmb_employee_position_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_employee_position_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_employee_position_filter.FormattingEnabled = True
        Me.cmb_employee_position_filter.Location = New System.Drawing.Point(837, 49)
        Me.cmb_employee_position_filter.Margin = New System.Windows.Forms.Padding(9, 14, 9, 14)
        Me.cmb_employee_position_filter.Name = "cmb_employee_position_filter"
        Me.cmb_employee_position_filter.Size = New System.Drawing.Size(222, 29)
        Me.cmb_employee_position_filter.TabIndex = 30
        '
        'txt_employee_number_filter
        '
        Me.txt_employee_number_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_employee_number_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_employee_number_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_employee_number_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_employee_number_filter.Location = New System.Drawing.Point(603, 49)
        Me.txt_employee_number_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_employee_number_filter.Name = "txt_employee_number_filter"
        Me.txt_employee_number_filter.Size = New System.Drawing.Size(222, 29)
        Me.txt_employee_number_filter.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_search_80
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(600, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Label1.Size = New System.Drawing.Size(152, 35)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Moblie Number      "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_filter_24
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(834, 11)
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
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(551, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "+223"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_search_80
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(320, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Label4.Size = New System.Drawing.Size(84, 35)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Name      "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_employee_name_filter
        '
        Me.txt_employee_name_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_employee_name_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_employee_name_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_employee_name_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_employee_name_filter.Location = New System.Drawing.Point(323, 49)
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
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(33, 96)
        Me.EmployeesDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(1026, 379)
        Me.EmployeesDataGridView.TabIndex = 1
        Me.EmployeesDataGridView.VirtualMode = True
        '
        'Management_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1101, 538)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_employee_name_filter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_employee_number_filter)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add_new_employee As Button
    Friend WithEvents cmb_employee_position_filter As ComboBox
    Friend WithEvents btn_edit_employee As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_employee_number_filter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_employee_name_filter As TextBox
    Friend WithEvents EmployeesDataGridView As DataGridView
End Class
