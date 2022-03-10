<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_work_order = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmi_exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoreStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.current_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.current_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_feedbacks = New System.Windows.Forms.Button()
        Me.btn_employees = New System.Windows.Forms.Button()
        Me.btn_inventory = New System.Windows.Forms.Button()
        Me.btn_calenders = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_work_orders = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pb_print = New System.Windows.Forms.PictureBox()
        Me.pb_refresh = New System.Windows.Forms.PictureBox()
        Me.lbl_current_tab = New System.Windows.Forms.Label()
        Me.login_photo = New System.Windows.Forms.PictureBox()
        Me.login_position = New System.Windows.Forms.Label()
        Me.login_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.management_main_container = New System.Windows.Forms.Panel()
        Me.systemtime = New System.Windows.Forms.Timer(Me.components)
        Me.PaymentAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceCenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pb_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.login_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.MoreStripMenuItem, Me.ReportsToolStripMenuItem, Me.MoreToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.MenuStrip.Size = New System.Drawing.Size(1370, 43)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_work_order, Me.ToolStripSeparator10, Me.tsmi_exit})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.Image = CType(resources.GetObject("ToolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(128, 43)
        Me.ToolsToolStripMenuItem.Text = "Quick Access"
        '
        'tsmi_work_order
        '
        Me.tsmi_work_order.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WorkOrderToolStripMenuItem, Me.PartToolStripMenuItem, Me.InvoiceToolStripMenuItem, Me.EmployeeToolStripMenuItem})
        Me.tsmi_work_order.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_plus_math_24
        Me.tsmi_work_order.Name = "tsmi_work_order"
        Me.tsmi_work_order.Size = New System.Drawing.Size(180, 24)
        Me.tsmi_work_order.Text = "New"
        '
        'WorkOrderToolStripMenuItem
        '
        Me.WorkOrderToolStripMenuItem.Name = "WorkOrderToolStripMenuItem"
        Me.WorkOrderToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.WorkOrderToolStripMenuItem.Text = "Work Order"
        '
        'PartToolStripMenuItem
        '
        Me.PartToolStripMenuItem.Name = "PartToolStripMenuItem"
        Me.PartToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.PartToolStripMenuItem.Text = "Part / Equipment"
        '
        'InvoiceToolStripMenuItem
        '
        Me.InvoiceToolStripMenuItem.Name = "InvoiceToolStripMenuItem"
        Me.InvoiceToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.InvoiceToolStripMenuItem.Text = "Invoice"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(182, 24)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(177, 6)
        '
        'tsmi_exit
        '
        Me.tsmi_exit.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_delete_24
        Me.tsmi_exit.Name = "tsmi_exit"
        Me.tsmi_exit.Size = New System.Drawing.Size(180, 24)
        Me.tsmi_exit.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FfToolStripMenuItem})
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(82, 43)
        Me.HelpToolStripMenuItem.Text = "Reports"
        '
        'FfToolStripMenuItem
        '
        Me.FfToolStripMenuItem.Name = "FfToolStripMenuItem"
        Me.FfToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FfToolStripMenuItem.Text = "ff"
        '
        'MoreStripMenuItem
        '
        Me.MoreStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentAccountsToolStripMenuItem, Me.ServiceCenterToolStripMenuItem})
        Me.MoreStripMenuItem.Image = CType(resources.GetObject("MoreStripMenuItem.Image"), System.Drawing.Image)
        Me.MoreStripMenuItem.Name = "MoreStripMenuItem"
        Me.MoreStripMenuItem.Size = New System.Drawing.Size(68, 43)
        Me.MoreStripMenuItem.Text = "More"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DdToolStripMenuItem, Me.DocumentationToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(63, 43)
        Me.ReportsToolStripMenuItem.Text = "Help"
        '
        'DdToolStripMenuItem
        '
        Me.DdToolStripMenuItem.Name = "DdToolStripMenuItem"
        Me.DdToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DdToolStripMenuItem.Text = "Getting Started"
        '
        'DocumentationToolStripMenuItem
        '
        Me.DocumentationToolStripMenuItem.Name = "DocumentationToolStripMenuItem"
        Me.DocumentationToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.DocumentationToolStripMenuItem.Text = "Documentation"
        '
        'MoreToolStripMenuItem
        '
        Me.MoreToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AaToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.MoreToolStripMenuItem.Image = CType(resources.GetObject("MoreToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MoreToolStripMenuItem.Name = "MoreToolStripMenuItem"
        Me.MoreToolStripMenuItem.Size = New System.Drawing.Size(68, 43)
        Me.MoreToolStripMenuItem.Text = "Tools"
        '
        'AaToolStripMenuItem
        '
        Me.AaToolStripMenuItem.Name = "AaToolStripMenuItem"
        Me.AaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AaToolStripMenuItem.Text = "Backup Database"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore Database"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(253, 14)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(828, 55)
        Me.Panel3.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(-102, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 69)
        Me.Panel2.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "HTU - JMTC"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.btn_feedbacks)
        Me.Panel1.Controls.Add(Me.btn_employees)
        Me.Panel1.Controls.Add(Me.btn_inventory)
        Me.Panel1.Controls.Add(Me.btn_calenders)
        Me.Panel1.Controls.Add(Me.btn_invoice)
        Me.Panel1.Controls.Add(Me.btn_work_orders)
        Me.Panel1.Controls.Add(Me.btn_dashboard)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 706)
        Me.Panel1.TabIndex = 16
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Transparent
        Me.StatusStrip1.Font = New System.Drawing.Font("Ebrima", 15.0!)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.current_date, Me.ToolStripStatusLabel2, Me.current_time, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 665)
        Me.StatusStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(233, 41)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'current_date
        '
        Me.current_date.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.current_date.Margin = New System.Windows.Forms.Padding(15, 3, 0, 2)
        Me.current_date.Name = "current_date"
        Me.current_date.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.current_date.Size = New System.Drawing.Size(42, 36)
        Me.current_date.Text = "Date"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(14, 36)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'current_time
        '
        Me.current_time.Font = New System.Drawing.Font("Ebrima", 12.0!)
        Me.current_time.Name = "current_time"
        Me.current_time.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.current_time.Size = New System.Drawing.Size(44, 36)
        Me.current_time.Text = "Time"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(204, 28)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.LightCoral
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.Location = New System.Drawing.Point(0, 405)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_logout.Size = New System.Drawing.Size(233, 48)
        Me.btn_logout.TabIndex = 9
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'btn_feedbacks
        '
        Me.btn_feedbacks.AccessibleName = ""
        Me.btn_feedbacks.BackColor = System.Drawing.Color.Teal
        Me.btn_feedbacks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_feedbacks.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_feedbacks.FlatAppearance.BorderSize = 0
        Me.btn_feedbacks.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_feedbacks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_feedbacks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_feedbacks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_feedbacks.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_feedbacks.ForeColor = System.Drawing.Color.White
        Me.btn_feedbacks.Image = CType(resources.GetObject("btn_feedbacks.Image"), System.Drawing.Image)
        Me.btn_feedbacks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_feedbacks.Location = New System.Drawing.Point(0, 357)
        Me.btn_feedbacks.Name = "btn_feedbacks"
        Me.btn_feedbacks.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_feedbacks.Size = New System.Drawing.Size(233, 48)
        Me.btn_feedbacks.TabIndex = 8
        Me.btn_feedbacks.Text = "Feedbacks"
        Me.btn_feedbacks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_feedbacks.UseVisualStyleBackColor = False
        '
        'btn_employees
        '
        Me.btn_employees.AccessibleName = ""
        Me.btn_employees.BackColor = System.Drawing.Color.Teal
        Me.btn_employees.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_employees.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_employees.FlatAppearance.BorderSize = 0
        Me.btn_employees.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_employees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_employees.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_employees.ForeColor = System.Drawing.Color.White
        Me.btn_employees.Image = CType(resources.GetObject("btn_employees.Image"), System.Drawing.Image)
        Me.btn_employees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_employees.Location = New System.Drawing.Point(0, 309)
        Me.btn_employees.Name = "btn_employees"
        Me.btn_employees.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_employees.Size = New System.Drawing.Size(233, 48)
        Me.btn_employees.TabIndex = 6
        Me.btn_employees.Text = "Employees "
        Me.btn_employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_employees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_employees.UseVisualStyleBackColor = False
        '
        'btn_inventory
        '
        Me.btn_inventory.AccessibleName = ""
        Me.btn_inventory.BackColor = System.Drawing.Color.Teal
        Me.btn_inventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_inventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_inventory.FlatAppearance.BorderSize = 0
        Me.btn_inventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_inventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_inventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inventory.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inventory.ForeColor = System.Drawing.Color.White
        Me.btn_inventory.Image = CType(resources.GetObject("btn_inventory.Image"), System.Drawing.Image)
        Me.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inventory.Location = New System.Drawing.Point(0, 261)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_inventory.Size = New System.Drawing.Size(233, 48)
        Me.btn_inventory.TabIndex = 5
        Me.btn_inventory.Text = "Inventory "
        Me.btn_inventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_inventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_inventory.UseVisualStyleBackColor = False
        '
        'btn_calenders
        '
        Me.btn_calenders.AccessibleName = ""
        Me.btn_calenders.BackColor = System.Drawing.Color.Teal
        Me.btn_calenders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_calenders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_calenders.FlatAppearance.BorderSize = 0
        Me.btn_calenders.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_calenders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_calenders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_calenders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_calenders.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_calenders.ForeColor = System.Drawing.Color.White
        Me.btn_calenders.Image = CType(resources.GetObject("btn_calenders.Image"), System.Drawing.Image)
        Me.btn_calenders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_calenders.Location = New System.Drawing.Point(0, 213)
        Me.btn_calenders.Name = "btn_calenders"
        Me.btn_calenders.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_calenders.Size = New System.Drawing.Size(233, 48)
        Me.btn_calenders.TabIndex = 4
        Me.btn_calenders.Text = "Calendar"
        Me.btn_calenders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_calenders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_calenders.UseVisualStyleBackColor = False
        '
        'btn_invoice
        '
        Me.btn_invoice.AccessibleName = ""
        Me.btn_invoice.BackColor = System.Drawing.Color.Teal
        Me.btn_invoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_invoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_invoice.FlatAppearance.BorderSize = 0
        Me.btn_invoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_invoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_invoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_invoice.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.ForeColor = System.Drawing.Color.White
        Me.btn_invoice.Image = CType(resources.GetObject("btn_invoice.Image"), System.Drawing.Image)
        Me.btn_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_invoice.Location = New System.Drawing.Point(0, 165)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_invoice.Size = New System.Drawing.Size(233, 48)
        Me.btn_invoice.TabIndex = 3
        Me.btn_invoice.Text = "Invoice"
        Me.btn_invoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_invoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_invoice.UseVisualStyleBackColor = False
        '
        'btn_work_orders
        '
        Me.btn_work_orders.AccessibleName = ""
        Me.btn_work_orders.BackColor = System.Drawing.Color.Teal
        Me.btn_work_orders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_work_orders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_work_orders.FlatAppearance.BorderSize = 0
        Me.btn_work_orders.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_work_orders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_work_orders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_work_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_work_orders.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_work_orders.ForeColor = System.Drawing.Color.White
        Me.btn_work_orders.Image = CType(resources.GetObject("btn_work_orders.Image"), System.Drawing.Image)
        Me.btn_work_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_work_orders.Location = New System.Drawing.Point(0, 117)
        Me.btn_work_orders.Name = "btn_work_orders"
        Me.btn_work_orders.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_work_orders.Size = New System.Drawing.Size(233, 48)
        Me.btn_work_orders.TabIndex = 2
        Me.btn_work_orders.Text = "Work Orders"
        Me.btn_work_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_work_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_work_orders.UseVisualStyleBackColor = False
        '
        'btn_dashboard
        '
        Me.btn_dashboard.AccessibleName = ""
        Me.btn_dashboard.BackColor = System.Drawing.Color.Teal
        Me.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_dashboard.FlatAppearance.BorderSize = 0
        Me.btn_dashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dashboard.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dashboard.ForeColor = System.Drawing.Color.White
        Me.btn_dashboard.Image = CType(resources.GetObject("btn_dashboard.Image"), System.Drawing.Image)
        Me.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dashboard.Location = New System.Drawing.Point(0, 69)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_dashboard.Size = New System.Drawing.Size(233, 48)
        Me.btn_dashboard.TabIndex = 1
        Me.btn_dashboard.Text = "Dashboard"
        Me.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_dashboard.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Controls.Add(Me.pb_print)
        Me.Panel5.Controls.Add(Me.pb_refresh)
        Me.Panel5.Controls.Add(Me.lbl_current_tab)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(233, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1137, 51)
        Me.Panel5.TabIndex = 20
        '
        'pb_print
        '
        Me.pb_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_print.BackColor = System.Drawing.Color.Transparent
        Me.pb_print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_print.Image = Global.Codebot_GMS.My.Resources.Resources.print_32_px
        Me.pb_print.ImageLocation = ""
        Me.pb_print.Location = New System.Drawing.Point(980, 4)
        Me.pb_print.Name = "pb_print"
        Me.pb_print.Padding = New System.Windows.Forms.Padding(5)
        Me.pb_print.Size = New System.Drawing.Size(42, 42)
        Me.pb_print.TabIndex = 36
        Me.pb_print.TabStop = False
        '
        'pb_refresh
        '
        Me.pb_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_refresh.BackColor = System.Drawing.Color.Transparent
        Me.pb_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_refresh.Image = Global.Codebot_GMS.My.Resources.Resources.refresh_32_px
        Me.pb_refresh.ImageLocation = ""
        Me.pb_refresh.Location = New System.Drawing.Point(1045, 4)
        Me.pb_refresh.Name = "pb_refresh"
        Me.pb_refresh.Padding = New System.Windows.Forms.Padding(5)
        Me.pb_refresh.Size = New System.Drawing.Size(42, 42)
        Me.pb_refresh.TabIndex = 36
        Me.pb_refresh.TabStop = False
        '
        'lbl_current_tab
        '
        Me.lbl_current_tab.AutoSize = True
        Me.lbl_current_tab.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current_tab.ForeColor = System.Drawing.Color.Teal
        Me.lbl_current_tab.Location = New System.Drawing.Point(37, 10)
        Me.lbl_current_tab.Name = "lbl_current_tab"
        Me.lbl_current_tab.Size = New System.Drawing.Size(121, 28)
        Me.lbl_current_tab.TabIndex = 1
        Me.lbl_current_tab.Text = "Currenrt Tab"
        '
        'login_photo
        '
        Me.login_photo.BackgroundImage = Global.Codebot_GMS.My.Resources.Resources.Employee_Blue_4
        Me.login_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.login_photo.ImageLocation = ""
        Me.login_photo.InitialImage = Global.Codebot_GMS.My.Resources.Resources.Employee_Blue_4
        Me.login_photo.Location = New System.Drawing.Point(871, 5)
        Me.login_photo.Name = "login_photo"
        Me.login_photo.Size = New System.Drawing.Size(33, 34)
        Me.login_photo.TabIndex = 39
        Me.login_photo.TabStop = False
        '
        'login_position
        '
        Me.login_position.AutoSize = True
        Me.login_position.BackColor = System.Drawing.Color.Gainsboro
        Me.login_position.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_position.Location = New System.Drawing.Point(917, 20)
        Me.login_position.Name = "login_position"
        Me.login_position.Size = New System.Drawing.Size(35, 19)
        Me.login_position.TabIndex = 38
        Me.login_position.Text = "Role"
        '
        'login_name
        '
        Me.login_name.AutoSize = True
        Me.login_name.BackColor = System.Drawing.Color.Gainsboro
        Me.login_name.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_name.Location = New System.Drawing.Point(917, 3)
        Me.login_name.Name = "login_name"
        Me.login_name.Size = New System.Drawing.Size(70, 19)
        Me.login_name.TabIndex = 38
        Me.login_name.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(900, -5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 46)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "|"
        '
        'management_main_container
        '
        Me.management_main_container.BackColor = System.Drawing.Color.WhiteSmoke
        Me.management_main_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.management_main_container.Location = New System.Drawing.Point(233, 94)
        Me.management_main_container.Name = "management_main_container"
        Me.management_main_container.Size = New System.Drawing.Size(1137, 655)
        Me.management_main_container.TabIndex = 21
        '
        'systemtime
        '
        Me.systemtime.Enabled = True
        Me.systemtime.Interval = 1000
        '
        'PaymentAccountsToolStripMenuItem
        '
        Me.PaymentAccountsToolStripMenuItem.Name = "PaymentAccountsToolStripMenuItem"
        Me.PaymentAccountsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PaymentAccountsToolStripMenuItem.Text = "Payment Accounts"
        '
        'ServiceCenterToolStripMenuItem
        '
        Me.ServiceCenterToolStripMenuItem.Name = "ServiceCenterToolStripMenuItem"
        Me.ServiceCenterToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ServiceCenterToolStripMenuItem.Text = "Service Center"
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.login_photo)
        Me.Controls.Add(Me.login_position)
        Me.Controls.Add(Me.management_main_container)
        Me.Controls.Add(Me.login_name)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.pb_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.login_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_inventory As Button
    Friend WithEvents btn_calenders As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_work_orders As Button
    Friend WithEvents btn_dashboard As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_employees As Button
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_current_tab As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsmi_work_order As ToolStripMenuItem
    Friend WithEvents MoreStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents management_main_container As Panel
    Friend WithEvents DdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents systemtime As Timer
    Friend WithEvents btn_logout As Button
    Friend WithEvents btn_feedbacks As Button
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents tsmi_exit As ToolStripMenuItem
    Friend WithEvents pb_refresh As PictureBox
    Friend WithEvents pb_print As PictureBox
    Friend WithEvents login_photo As PictureBox
    Friend WithEvents login_position As Label
    Friend WithEvents login_name As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents current_date As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents current_time As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents WorkOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiceCenterToolStripMenuItem As ToolStripMenuItem
End Class
