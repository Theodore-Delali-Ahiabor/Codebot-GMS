<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Work_Order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Work_Order))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmbusertype = New System.Windows.Forms.ComboBox()
        Me.txtnewfname = New System.Windows.Forms.TextBox()
        Me.EmployeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_add_new_Order = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Waiter/Waitress", "Chef/Cook", "Manager/Supervisor", "Administrator"})
        Me.ComboBox1.Location = New System.Drawing.Point(1145, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 36)
        Me.ComboBox1.TabIndex = 36
        '
        'cmbusertype
        '
        Me.cmbusertype.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbusertype.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbusertype.FormattingEnabled = True
        Me.cmbusertype.Items.AddRange(New Object() {"Waiter/Waitress", "Chef/Cook", "Manager/Supervisor", "Administrator"})
        Me.cmbusertype.Location = New System.Drawing.Point(930, 36)
        Me.cmbusertype.Name = "cmbusertype"
        Me.cmbusertype.Size = New System.Drawing.Size(182, 36)
        Me.cmbusertype.TabIndex = 35
        '
        'txtnewfname
        '
        Me.txtnewfname.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnewfname.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnewfname.Location = New System.Drawing.Point(617, 39)
        Me.txtnewfname.Name = "txtnewfname"
        Me.txtnewfname.Size = New System.Drawing.Size(222, 35)
        Me.txtnewfname.TabIndex = 34
        '
        'EmployeesDataGridView
        '
        Me.EmployeesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EmployeesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.EmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Copperplate Gothic Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.EmployeesDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.EmployeesDataGridView.GridColor = System.Drawing.Color.Gainsboro
        Me.EmployeesDataGridView.Location = New System.Drawing.Point(38, 94)
        Me.EmployeesDataGridView.Name = "EmployeesDataGridView"
        Me.EmployeesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeesDataGridView.Size = New System.Drawing.Size(1289, 562)
        Me.EmployeesDataGridView.TabIndex = 33
        '
        'btn_add_new_Order
        '
        Me.btn_add_new_Order.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_add_new_Order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_new_Order.FlatAppearance.BorderSize = 0
        Me.btn_add_new_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_new_Order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_Order.ForeColor = System.Drawing.Color.White
        Me.btn_add_new_Order.Image = CType(resources.GetObject("btn_add_new_Order.Image"), System.Drawing.Image)
        Me.btn_add_new_Order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_new_Order.Location = New System.Drawing.Point(38, 12)
        Me.btn_add_new_Order.Name = "btn_add_new_Order"
        Me.btn_add_new_Order.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_add_new_Order.Size = New System.Drawing.Size(105, 46)
        Me.btn_add_new_Order.TabIndex = 32
        Me.btn_add_new_Order.Text = "    New"
        Me.btn_add_new_Order.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(836, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 36)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Management_Work_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1366, 749)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cmbusertype)
        Me.Controls.Add(Me.txtnewfname)
        Me.Controls.Add(Me.EmployeesDataGridView)
        Me.Controls.Add(Me.btn_add_new_Order)
        Me.Name = "Management_Work_Order"
        Me.Text = "Management_Work_Order"
        CType(Me.EmployeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents cmbusertype As ComboBox
    Friend WithEvents txtnewfname As TextBox
    Friend WithEvents EmployeesDataGridView As DataGridView
    Friend WithEvents btn_add_new_Order As Button
    Friend WithEvents Button1 As Button
End Class
