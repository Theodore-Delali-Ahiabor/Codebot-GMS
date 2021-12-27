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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Home))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.work_oders_due_panel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBoxWorkOrders = New System.Windows.Forms.PictureBox()
        Me.lbl_work_orders_due = New System.Windows.Forms.Label()
        Me.work_order_overdue = New System.Windows.Forms.Label()
        Me.work_order_due_soon = New System.Windows.Forms.Label()
        Me.invoice_payments_panel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_invoice_payments = New System.Windows.Forms.Label()
        Me.invoice_payments_incomplete = New System.Windows.Forms.Label()
        Me.invoice_payments_pending = New System.Windows.Forms.Label()
        Me.upcoming_events_panel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_upcoming_events = New System.Windows.Forms.Label()
        Me.upcoming_events_soon = New System.Windows.Forms.Label()
        Me.upcoming_events_past = New System.Windows.Forms.Label()
        Me.upcoming_events_today = New System.Windows.Forms.Label()
        Me.lbl_low_inventory = New System.Windows.Forms.Label()
        Me.low_inventory_low_stock = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.low_inventory_out_of_stock = New System.Windows.Forms.Label()
        Me.low_inventory_panel = New System.Windows.Forms.Panel()
        Me.PictureBoxInventory = New System.Windows.Forms.PictureBox()
        Me.activebar_inventory = New System.Windows.Forms.Button()
        Me.activebar_work_orders = New System.Windows.Forms.Button()
        Me.HomeDataGridView = New System.Windows.Forms.DataGridView()
        Me.activebar_events = New System.Windows.Forms.Button()
        Me.activebar_payments = New System.Windows.Forms.Button()
        Me.work_oders_due_panel.SuspendLayout()
        CType(Me.PictureBoxWorkOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.invoice_payments_panel.SuspendLayout()
        Me.upcoming_events_panel.SuspendLayout()
        Me.low_inventory_panel.SuspendLayout()
        CType(Me.PictureBoxInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HomeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label7.Location = New System.Drawing.Point(90, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "|"
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
        Me.work_order_overdue.Location = New System.Drawing.Point(13, 58)
        Me.work_order_overdue.Name = "work_order_overdue"
        Me.work_order_overdue.Size = New System.Drawing.Size(62, 19)
        Me.work_order_overdue.TabIndex = 0
        Me.work_order_overdue.Text = "Overdue"
        '
        'work_order_due_soon
        '
        Me.work_order_due_soon.AutoSize = True
        Me.work_order_due_soon.ForeColor = System.Drawing.Color.DarkOrange
        Me.work_order_due_soon.Location = New System.Drawing.Point(112, 58)
        Me.work_order_due_soon.Name = "work_order_due_soon"
        Me.work_order_due_soon.Size = New System.Drawing.Size(69, 19)
        Me.work_order_due_soon.TabIndex = 0
        Me.work_order_due_soon.Text = "Due Soon"
        '
        'invoice_payments_panel
        '
        Me.invoice_payments_panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.invoice_payments_panel.BackColor = System.Drawing.Color.White
        Me.invoice_payments_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.invoice_payments_panel.Controls.Add(Me.Label4)
        Me.invoice_payments_panel.Controls.Add(Me.lbl_invoice_payments)
        Me.invoice_payments_panel.Controls.Add(Me.invoice_payments_incomplete)
        Me.invoice_payments_panel.Controls.Add(Me.invoice_payments_pending)
        Me.invoice_payments_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.invoice_payments_panel.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_payments_panel.Location = New System.Drawing.Point(293, 13)
        Me.invoice_payments_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.invoice_payments_panel.Name = "invoice_payments_panel"
        Me.invoice_payments_panel.Size = New System.Drawing.Size(235, 87)
        Me.invoice_payments_panel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(86, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "|"
        '
        'lbl_invoice_payments
        '
        Me.lbl_invoice_payments.AutoSize = True
        Me.lbl_invoice_payments.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_invoice_payments.Location = New System.Drawing.Point(3, 0)
        Me.lbl_invoice_payments.Name = "lbl_invoice_payments"
        Me.lbl_invoice_payments.Size = New System.Drawing.Size(163, 28)
        Me.lbl_invoice_payments.TabIndex = 2
        Me.lbl_invoice_payments.Text = "Invoice Payments"
        '
        'invoice_payments_incomplete
        '
        Me.invoice_payments_incomplete.AutoSize = True
        Me.invoice_payments_incomplete.ForeColor = System.Drawing.Color.DarkOrange
        Me.invoice_payments_incomplete.Location = New System.Drawing.Point(107, 58)
        Me.invoice_payments_incomplete.Name = "invoice_payments_incomplete"
        Me.invoice_payments_incomplete.Size = New System.Drawing.Size(77, 19)
        Me.invoice_payments_incomplete.TabIndex = 0
        Me.invoice_payments_incomplete.Text = "Incomplete"
        '
        'invoice_payments_pending
        '
        Me.invoice_payments_pending.AutoSize = True
        Me.invoice_payments_pending.ForeColor = System.Drawing.Color.Red
        Me.invoice_payments_pending.Location = New System.Drawing.Point(11, 58)
        Me.invoice_payments_pending.Name = "invoice_payments_pending"
        Me.invoice_payments_pending.Size = New System.Drawing.Size(59, 19)
        Me.invoice_payments_pending.TabIndex = 0
        Me.invoice_payments_pending.Text = "Pending"
        '
        'upcoming_events_panel
        '
        Me.upcoming_events_panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.upcoming_events_panel.BackColor = System.Drawing.Color.White
        Me.upcoming_events_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.upcoming_events_panel.Controls.Add(Me.Label2)
        Me.upcoming_events_panel.Controls.Add(Me.Label5)
        Me.upcoming_events_panel.Controls.Add(Me.lbl_upcoming_events)
        Me.upcoming_events_panel.Controls.Add(Me.upcoming_events_soon)
        Me.upcoming_events_panel.Controls.Add(Me.upcoming_events_past)
        Me.upcoming_events_panel.Controls.Add(Me.upcoming_events_today)
        Me.upcoming_events_panel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.upcoming_events_panel.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upcoming_events_panel.Location = New System.Drawing.Point(565, 13)
        Me.upcoming_events_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.upcoming_events_panel.Name = "upcoming_events_panel"
        Me.upcoming_events_panel.Size = New System.Drawing.Size(235, 87)
        Me.upcoming_events_panel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "|"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "|"
        '
        'lbl_upcoming_events
        '
        Me.lbl_upcoming_events.AutoSize = True
        Me.lbl_upcoming_events.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_upcoming_events.Location = New System.Drawing.Point(3, 0)
        Me.lbl_upcoming_events.Name = "lbl_upcoming_events"
        Me.lbl_upcoming_events.Size = New System.Drawing.Size(165, 28)
        Me.lbl_upcoming_events.TabIndex = 4
        Me.lbl_upcoming_events.Text = "Upcoming Events"
        '
        'upcoming_events_soon
        '
        Me.upcoming_events_soon.AutoSize = True
        Me.upcoming_events_soon.ForeColor = System.Drawing.Color.DarkOrange
        Me.upcoming_events_soon.Location = New System.Drawing.Point(83, 58)
        Me.upcoming_events_soon.Name = "upcoming_events_soon"
        Me.upcoming_events_soon.Size = New System.Drawing.Size(40, 19)
        Me.upcoming_events_soon.TabIndex = 0
        Me.upcoming_events_soon.Text = "Soon"
        '
        'upcoming_events_past
        '
        Me.upcoming_events_past.AutoSize = True
        Me.upcoming_events_past.ForeColor = System.Drawing.Color.Red
        Me.upcoming_events_past.Location = New System.Drawing.Point(17, 59)
        Me.upcoming_events_past.Name = "upcoming_events_past"
        Me.upcoming_events_past.Size = New System.Drawing.Size(35, 19)
        Me.upcoming_events_past.TabIndex = 0
        Me.upcoming_events_past.Text = "Past"
        '
        'upcoming_events_today
        '
        Me.upcoming_events_today.AutoSize = True
        Me.upcoming_events_today.ForeColor = System.Drawing.Color.Green
        Me.upcoming_events_today.Location = New System.Drawing.Point(158, 58)
        Me.upcoming_events_today.Name = "upcoming_events_today"
        Me.upcoming_events_today.Size = New System.Drawing.Size(46, 19)
        Me.upcoming_events_today.TabIndex = 0
        Me.upcoming_events_today.Text = "Today"
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
        Me.low_inventory_low_stock.Location = New System.Drawing.Point(138, 58)
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
        Me.low_inventory_out_of_stock.Location = New System.Drawing.Point(16, 58)
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
        Me.low_inventory_panel.Location = New System.Drawing.Point(840, 14)
        Me.low_inventory_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.low_inventory_panel.Name = "low_inventory_panel"
        Me.low_inventory_panel.Size = New System.Drawing.Size(235, 86)
        Me.low_inventory_panel.TabIndex = 0
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
        Me.activebar_inventory.Location = New System.Drawing.Point(840, 6)
        Me.activebar_inventory.Name = "activebar_inventory"
        Me.activebar_inventory.Size = New System.Drawing.Size(235, 10)
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
        Me.HomeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.HomeDataGridView.MultiSelect = False
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
        Me.HomeDataGridView.Size = New System.Drawing.Size(1051, 384)
        Me.HomeDataGridView.TabIndex = 9
        '
        'activebar_events
        '
        Me.activebar_events.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.activebar_events.BackColor = System.Drawing.Color.CadetBlue
        Me.activebar_events.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.activebar_events.FlatAppearance.BorderSize = 0
        Me.activebar_events.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_events.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_events.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.activebar_events.Font = New System.Drawing.Font("Ebrima", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activebar_events.ForeColor = System.Drawing.Color.CadetBlue
        Me.activebar_events.Location = New System.Drawing.Point(565, 5)
        Me.activebar_events.Name = "activebar_events"
        Me.activebar_events.Size = New System.Drawing.Size(235, 10)
        Me.activebar_events.TabIndex = 10
        Me.activebar_events.UseVisualStyleBackColor = False
        Me.activebar_events.Visible = False
        '
        'activebar_payments
        '
        Me.activebar_payments.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.activebar_payments.BackColor = System.Drawing.Color.CadetBlue
        Me.activebar_payments.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue
        Me.activebar_payments.FlatAppearance.BorderSize = 0
        Me.activebar_payments.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_payments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_payments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.activebar_payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.activebar_payments.Font = New System.Drawing.Font("Ebrima", 1.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activebar_payments.ForeColor = System.Drawing.Color.CadetBlue
        Me.activebar_payments.Location = New System.Drawing.Point(293, 5)
        Me.activebar_payments.Name = "activebar_payments"
        Me.activebar_payments.Size = New System.Drawing.Size(235, 7)
        Me.activebar_payments.TabIndex = 11
        Me.activebar_payments.UseVisualStyleBackColor = False
        Me.activebar_payments.Visible = False
        '
        'Management_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1101, 538)
        Me.ControlBox = False
        Me.Controls.Add(Me.activebar_payments)
        Me.Controls.Add(Me.activebar_events)
        Me.Controls.Add(Me.HomeDataGridView)
        Me.Controls.Add(Me.activebar_work_orders)
        Me.Controls.Add(Me.activebar_inventory)
        Me.Controls.Add(Me.low_inventory_panel)
        Me.Controls.Add(Me.upcoming_events_panel)
        Me.Controls.Add(Me.invoice_payments_panel)
        Me.Controls.Add(Me.work_oders_due_panel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Management_Home"
        Me.Text = "Home"
        Me.work_oders_due_panel.ResumeLayout(False)
        Me.work_oders_due_panel.PerformLayout()
        CType(Me.PictureBoxWorkOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.invoice_payments_panel.ResumeLayout(False)
        Me.invoice_payments_panel.PerformLayout()
        Me.upcoming_events_panel.ResumeLayout(False)
        Me.upcoming_events_panel.PerformLayout()
        Me.low_inventory_panel.ResumeLayout(False)
        Me.low_inventory_panel.PerformLayout()
        CType(Me.PictureBoxInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HomeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents work_oders_due_panel As Panel
    Friend WithEvents invoice_payments_panel As Panel
    Friend WithEvents upcoming_events_panel As Panel
    Friend WithEvents lbl_work_orders_due As Label
    Friend WithEvents lbl_invoice_payments As Label
    Friend WithEvents lbl_upcoming_events As Label
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
    Friend WithEvents activebar_events As Button
    Friend WithEvents activebar_payments As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents upcoming_events_soon As Label
    Friend WithEvents upcoming_events_today As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents invoice_payments_incomplete As Label
    Friend WithEvents invoice_payments_pending As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents upcoming_events_past As Label
End Class
