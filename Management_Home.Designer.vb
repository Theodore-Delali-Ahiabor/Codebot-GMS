<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Home))
        Me.work_oders_due_panel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_work_orders_due = New System.Windows.Forms.Label()
        Me.work_order_overdue = New System.Windows.Forms.Label()
        Me.work_order_due_soon = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_low_inventory = New System.Windows.Forms.Label()
        Me.low_inventory_low_stock = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.low_inventory_out_of_stock = New System.Windows.Forms.Label()
        Me.low_inventory_panel = New System.Windows.Forms.Panel()
        Me.activebar_inventory = New System.Windows.Forms.Button()
        Me.activebar_work_orders = New System.Windows.Forms.Button()
        Me.HomeDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBoxInventory = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWorkOrders = New System.Windows.Forms.PictureBox()
        Me.work_oders_due_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.low_inventory_panel.SuspendLayout()
        CType(Me.HomeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWorkOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'work_oders_due_panel
        '
        Me.work_oders_due_panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.work_oders_due_panel.BackColor = System.Drawing.Color.White
        Me.work_oders_due_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.work_oders_due_panel.Controls.Add(Me.Label7)
        Me.work_oders_due_panel.Controls.Add(Me.PictureBoxWorkOrders)
        Me.work_oders_due_panel.Controls.Add(Me.lbl_work_orders_due)
        Me.work_oders_due_panel.Controls.Add(Me.work_order_overdue)
        Me.work_oders_due_panel.Controls.Add(Me.work_order_due_soon)
        Me.work_oders_due_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.work_oders_due_panel.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.work_oders_due_panel.Location = New System.Drawing.Point(24, 13)
        Me.work_oders_due_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.work_oders_due_panel.Name = "work_oders_due_panel"
        Me.work_oders_due_panel.Size = New System.Drawing.Size(235, 88)
        Me.work_oders_due_panel.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "|"
        '
        'lbl_work_orders_due
        '
        Me.lbl_work_orders_due.AutoSize = True
        Me.lbl_work_orders_due.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_work_orders_due.Location = New System.Drawing.Point(3, 0)
        Me.lbl_work_orders_due.Name = "lbl_work_orders_due"
        Me.lbl_work_orders_due.Size = New System.Drawing.Size(151, 25)
        Me.lbl_work_orders_due.TabIndex = 0
        Me.lbl_work_orders_due.Text = "Work Orders Due"
        '
        'work_order_overdue
        '
        Me.work_order_overdue.AutoSize = True
        Me.work_order_overdue.ForeColor = System.Drawing.Color.Red
        Me.work_order_overdue.Location = New System.Drawing.Point(14, 58)
        Me.work_order_overdue.Name = "work_order_overdue"
        Me.work_order_overdue.Size = New System.Drawing.Size(62, 19)
        Me.work_order_overdue.TabIndex = 0
        Me.work_order_overdue.Text = "Overdue"
        '
        'work_order_due_soon
        '
        Me.work_order_due_soon.AutoSize = True
        Me.work_order_due_soon.ForeColor = System.Drawing.Color.DarkOrange
        Me.work_order_due_soon.Location = New System.Drawing.Point(109, 58)
        Me.work_order_due_soon.Name = "work_order_due_soon"
        Me.work_order_due_soon.Size = New System.Drawing.Size(69, 19)
        Me.work_order_due_soon.TabIndex = 0
        Me.work_order_due_soon.Text = "Due Soon"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(832, 13)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 87)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Work Order Report"
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(564, 13)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(235, 87)
        Me.Panel4.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Next Service Due"
        '
        'lbl_low_inventory
        '
        Me.lbl_low_inventory.AutoSize = True
        Me.lbl_low_inventory.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_low_inventory.Location = New System.Drawing.Point(3, 0)
        Me.lbl_low_inventory.Name = "lbl_low_inventory"
        Me.lbl_low_inventory.Size = New System.Drawing.Size(129, 25)
        Me.lbl_low_inventory.TabIndex = 0
        Me.lbl_low_inventory.Text = "Low Inventory "
        '
        'low_inventory_low_stock
        '
        Me.low_inventory_low_stock.AutoSize = True
        Me.low_inventory_low_stock.ForeColor = System.Drawing.Color.DarkOrange
        Me.low_inventory_low_stock.Location = New System.Drawing.Point(141, 58)
        Me.low_inventory_low_stock.Name = "low_inventory_low_stock"
        Me.low_inventory_low_stock.Size = New System.Drawing.Size(71, 19)
        Me.low_inventory_low_stock.TabIndex = 0
        Me.low_inventory_low_stock.Text = "Low Stock"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(120, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 19)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "|"
        '
        'low_inventory_out_of_stock
        '
        Me.low_inventory_out_of_stock.AutoSize = True
        Me.low_inventory_out_of_stock.ForeColor = System.Drawing.Color.Red
        Me.low_inventory_out_of_stock.Location = New System.Drawing.Point(21, 58)
        Me.low_inventory_out_of_stock.Name = "low_inventory_out_of_stock"
        Me.low_inventory_out_of_stock.Size = New System.Drawing.Size(86, 19)
        Me.low_inventory_out_of_stock.TabIndex = 0
        Me.low_inventory_out_of_stock.Text = "Out of Stock"
        '
        'low_inventory_panel
        '
        Me.low_inventory_panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.low_inventory_panel.BackColor = System.Drawing.Color.White
        Me.low_inventory_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.low_inventory_panel.Controls.Add(Me.Label13)
        Me.low_inventory_panel.Controls.Add(Me.PictureBoxInventory)
        Me.low_inventory_panel.Controls.Add(Me.lbl_low_inventory)
        Me.low_inventory_panel.Controls.Add(Me.low_inventory_low_stock)
        Me.low_inventory_panel.Controls.Add(Me.low_inventory_out_of_stock)
        Me.low_inventory_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.low_inventory_panel.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.low_inventory_panel.Location = New System.Drawing.Point(295, 13)
        Me.low_inventory_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.low_inventory_panel.Name = "low_inventory_panel"
        Me.low_inventory_panel.Size = New System.Drawing.Size(235, 88)
        Me.low_inventory_panel.TabIndex = 0
        '
        'activebar_inventory
        '
        Me.activebar_inventory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.activebar_inventory.BackColor = System.Drawing.Color.CadetBlue
        Me.activebar_inventory.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.activebar_inventory.FlatAppearance.BorderSize = 0
        Me.activebar_inventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_inventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.activebar_inventory.Font = New System.Drawing.Font("Ebrima", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activebar_inventory.ForeColor = System.Drawing.Color.CadetBlue
        Me.activebar_inventory.Location = New System.Drawing.Point(295, 5)
        Me.activebar_inventory.Name = "activebar_inventory"
        Me.activebar_inventory.Size = New System.Drawing.Size(235, 7)
        Me.activebar_inventory.TabIndex = 0
        Me.activebar_inventory.UseVisualStyleBackColor = False
        Me.activebar_inventory.Visible = False
        '
        'activebar_work_orders
        '
        Me.activebar_work_orders.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.activebar_work_orders.BackColor = System.Drawing.Color.CadetBlue
        Me.activebar_work_orders.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.activebar_work_orders.FlatAppearance.BorderSize = 0
        Me.activebar_work_orders.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_work_orders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_work_orders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_work_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.activebar_work_orders.Font = New System.Drawing.Font("Ebrima", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activebar_work_orders.ForeColor = System.Drawing.Color.CadetBlue
        Me.activebar_work_orders.Location = New System.Drawing.Point(24, 5)
        Me.activebar_work_orders.Name = "activebar_work_orders"
        Me.activebar_work_orders.Size = New System.Drawing.Size(235, 7)
        Me.activebar_work_orders.TabIndex = 0
        Me.activebar_work_orders.UseVisualStyleBackColor = False
        Me.activebar_work_orders.Visible = False
        '
        'HomeDataGridView
        '
        Me.HomeDataGridView.AllowUserToAddRows = False
        Me.HomeDataGridView.AllowUserToDeleteRows = False
        Me.HomeDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.HomeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.HomeDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.HomeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.HomeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.HomeDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HomeDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.HomeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.HomeDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.HomeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.HomeDataGridView.EnableHeadersVisualStyles = False
        Me.HomeDataGridView.GridColor = System.Drawing.Color.Silver
        Me.HomeDataGridView.Location = New System.Drawing.Point(24, 132)
        Me.HomeDataGridView.Name = "HomeDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HomeDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.HomeDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HomeDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.HomeDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.HomeDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.HomeDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.HomeDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.HomeDataGridView.RowTemplate.Height = 38
        Me.HomeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HomeDataGridView.Size = New System.Drawing.Size(1043, 394)
        Me.HomeDataGridView.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button1.Location = New System.Drawing.Point(564, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 7)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.BackColor = System.Drawing.Color.CadetBlue
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ebrima", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.CadetBlue
        Me.Button2.Location = New System.Drawing.Point(832, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(235, 7)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'PictureBoxInventory
        '
        Me.PictureBoxInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxInventory.Image = CType(resources.GetObject("PictureBoxInventory.Image"), System.Drawing.Image)
        Me.PictureBoxInventory.Location = New System.Drawing.Point(171, 4)
        Me.PictureBoxInventory.Name = "PictureBoxInventory"
        Me.PictureBoxInventory.Size = New System.Drawing.Size(48, 50)
        Me.PictureBoxInventory.TabIndex = 12
        Me.PictureBoxInventory.TabStop = False
        '
        'PictureBoxWorkOrders
        '
        Me.PictureBoxWorkOrders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxWorkOrders.Image = CType(resources.GetObject("PictureBoxWorkOrders.Image"), System.Drawing.Image)
        Me.PictureBoxWorkOrders.Location = New System.Drawing.Point(181, 3)
        Me.PictureBoxWorkOrders.Name = "PictureBoxWorkOrders"
        Me.PictureBoxWorkOrders.Size = New System.Drawing.Size(49, 50)
        Me.PictureBoxWorkOrders.TabIndex = 9
        Me.PictureBoxWorkOrders.TabStop = False
        '
        'Management_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1101, 538)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HomeDataGridView)
        Me.Controls.Add(Me.activebar_work_orders)
        Me.Controls.Add(Me.activebar_inventory)
        Me.Controls.Add(Me.low_inventory_panel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.work_oders_due_panel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Management_Home"
        Me.Text = "Home"
        Me.work_oders_due_panel.ResumeLayout(False)
        Me.work_oders_due_panel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.low_inventory_panel.ResumeLayout(False)
        Me.low_inventory_panel.PerformLayout()
        CType(Me.HomeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWorkOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents work_oders_due_panel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_work_orders_due As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents work_order_overdue As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents work_order_due_soon As Label
    Friend WithEvents PictureBoxWorkOrders As PictureBox
    Friend WithEvents lbl_low_inventory As Label
    Friend WithEvents low_inventory_low_stock As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents low_inventory_out_of_stock As Label
    Friend WithEvents low_inventory_panel As Panel
    Friend WithEvents PictureBoxInventory As PictureBox
    Friend WithEvents activebar_inventory As Button
    Friend WithEvents activebar_work_orders As Button
    Friend WithEvents HomeDataGridView As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
