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
        Me.btn_add_new_employee = New System.Windows.Forms.Button()
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.cmbusertype = New System.Windows.Forms.ComboBox()
        Me.txtnewfname = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_edit_employee = New System.Windows.Forms.Button()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_add_new_employee.Location = New System.Drawing.Point(38, 12)
        Me.btn_add_new_employee.Name = "btn_add_new_employee"
        Me.btn_add_new_employee.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_add_new_employee.Size = New System.Drawing.Size(105, 46)
        Me.btn_add_new_employee.TabIndex = 0
        Me.btn_add_new_employee.Text = "    New"
        Me.btn_add_new_employee.UseVisualStyleBackColor = False
        '
        'EmployeesDataGridView
        '
        Me.EmployeesDataGridView.AllowUserToAddRows = False
        Me.EmployeesDataGridView.AllowUserToDeleteRows = False
        Me.EmployeesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EmployeesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmployeesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.EmployeesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.EmployeesDataGridView.GridColor = System.Drawing.Color.Silver
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(38, 95)
        Me.EmployeesDataGridView.Name = "EmployeesDataGridView"
        Me.EmployeesDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray
        Me.EmployeesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightCyan
        Me.EmployeesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray
        Me.EmployeesDataGridView.RowTemplate.Height = 38
        Me.EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(1280, 570)
        Me.EmployeesDataGridView.TabIndex = 1
        '
        'cmbusertype
        '
        Me.cmbusertype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbusertype.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusertype.FormattingEnabled = True
        Me.cmbusertype.Items.AddRange(New Object() {"Waiter/Waitress", "Chef/Cook", "Manager/Supervisor", "Administrator"})
        Me.cmbusertype.Location = New System.Drawing.Point(918, 37)
        Me.cmbusertype.Name = "cmbusertype"
        Me.cmbusertype.Size = New System.Drawing.Size(182, 36)
        Me.cmbusertype.TabIndex = 30
        '
        'txtnewfname
        '
        Me.txtnewfname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnewfname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewfname.Location = New System.Drawing.Point(606, 37)
        Me.txtnewfname.Name = "txtnewfname"
        Me.txtnewfname.Size = New System.Drawing.Size(222, 35)
        Me.txtnewfname.TabIndex = 29
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Waiter/Waitress", "Chef/Cook", "Manager/Supervisor", "Administrator"})
        Me.ComboBox1.Location = New System.Drawing.Point(1136, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 36)
        Me.ComboBox1.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(824, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 36)
        Me.Button1.TabIndex = 32
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_edit_employee
        '
        Me.btn_edit_employee.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_edit_employee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit_employee.FlatAppearance.BorderSize = 0
        Me.btn_edit_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit_employee.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit_employee.Image = CType(resources.GetObject("btn_edit_employee.Image"), System.Drawing.Image)
        Me.btn_edit_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_edit_employee.Location = New System.Drawing.Point(163, 12)
        Me.btn_edit_employee.Name = "btn_edit_employee"
        Me.btn_edit_employee.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_edit_employee.Size = New System.Drawing.Size(105, 46)
        Me.btn_edit_employee.TabIndex = 33
        Me.btn_edit_employee.Text = "    Edit"
        Me.btn_edit_employee.UseVisualStyleBackColor = False
        '
        'Management_Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.btn_edit_employee)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbusertype)
        Me.Controls.Add(Me.txtnewfname)
        Me.Controls.Add(Me.EmployeesDataGridView)
        Me.Controls.Add(Me.btn_add_new_employee)
        Me.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Management_Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_add_new_employee As Button
    Friend WithEvents EmployeesDataGridView As DataGridView
    Friend WithEvents cmbusertype As ComboBox
    Friend WithEvents txtnewfname As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_edit_employee As Button
End Class
