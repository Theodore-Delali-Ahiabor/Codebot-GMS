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
        Me.CcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DocumentationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DateTimeStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.current_date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.current_time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserBioStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.login_name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.login_position = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_statistics = New System.Windows.Forms.Button()
        Me.btn_employees = New System.Windows.Forms.Button()
        Me.btn_purcahse_orders = New System.Windows.Forms.Button()
        Me.btn_inventory = New System.Windows.Forms.Button()
        Me.btn_calenders = New System.Windows.Forms.Button()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.btn_work_orders = New System.Windows.Forms.Button()
        Me.btn_market = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_management_message = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbl_current_tab = New System.Windows.Forms.Label()
        Me.management_main_container = New System.Windows.Forms.Panel()
        Me.systemtime = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.DateTimeStatusStrip.SuspendLayout()
        Me.UserBioStatusStrip.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuStrip.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.QuickAccessToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.MoreToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.MenuStrip.Size = New System.Drawing.Size(1350, 43)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CcToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.Image = CType(resources.GetObject("ToolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(10)
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(128, 43)
        Me.ToolsToolStripMenuItem.Text = "Quick Access"
        '
        'CcToolStripMenuItem
        '
        Me.CcToolStripMenuItem.Name = "CcToolStripMenuItem"
        Me.CcToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CcToolStripMenuItem.Text = "cc"
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
        Me.FfToolStripMenuItem.Size = New System.Drawing.Size(84, 22)
        Me.FfToolStripMenuItem.Text = "ff"
        '
        'QuickAccessToolStripMenuItem
        '
        Me.QuickAccessToolStripMenuItem.Image = CType(resources.GetObject("QuickAccessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QuickAccessToolStripMenuItem.Name = "QuickAccessToolStripMenuItem"
        Me.QuickAccessToolStripMenuItem.Size = New System.Drawing.Size(68, 43)
        Me.QuickAccessToolStripMenuItem.Text = "More"
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
        Me.AaToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.AaToolStripMenuItem.Text = "Backup"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.DateTimeStatusStrip)
        Me.Panel4.Controls.Add(Me.UserBioStatusStrip)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(233, 674)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1117, 45)
        Me.Panel4.TabIndex = 18
        '
        'DateTimeStatusStrip
        '
        Me.DateTimeStatusStrip.BackColor = System.Drawing.Color.Transparent
        Me.DateTimeStatusStrip.Dock = System.Windows.Forms.DockStyle.Right
        Me.DateTimeStatusStrip.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.current_date, Me.ToolStripStatusLabel7, Me.current_time})
        Me.DateTimeStatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.DateTimeStatusStrip.Location = New System.Drawing.Point(868, 0)
        Me.DateTimeStatusStrip.Name = "DateTimeStatusStrip"
        Me.DateTimeStatusStrip.Padding = New System.Windows.Forms.Padding(1, 3, 1, 20)
        Me.DateTimeStatusStrip.Size = New System.Drawing.Size(249, 45)
        Me.DateTimeStatusStrip.TabIndex = 2
        Me.DateTimeStatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(62, 28)
        Me.ToolStripStatusLabel3.Text = "Date :"
        Me.ToolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'current_date
        '
        Me.current_date.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current_date.Name = "current_date"
        Me.current_date.Size = New System.Drawing.Size(51, 28)
        Me.current_date.Text = "date"
        Me.current_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(63, 28)
        Me.ToolStripStatusLabel7.Text = "Time :"
        Me.ToolStripStatusLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'current_time
        '
        Me.current_time.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current_time.Name = "current_time"
        Me.current_time.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.current_time.Size = New System.Drawing.Size(71, 28)
        Me.current_time.Text = "time"
        Me.current_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UserBioStatusStrip
        '
        Me.UserBioStatusStrip.BackColor = System.Drawing.Color.Transparent
        Me.UserBioStatusStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.UserBioStatusStrip.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserBioStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.login_name, Me.ToolStripStatusLabel5, Me.login_position})
        Me.UserBioStatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.UserBioStatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.UserBioStatusStrip.Name = "UserBioStatusStrip"
        Me.UserBioStatusStrip.Padding = New System.Windows.Forms.Padding(1, 3, 1, 20)
        Me.UserBioStatusStrip.Size = New System.Drawing.Size(259, 45)
        Me.UserBioStatusStrip.TabIndex = 0
        Me.UserBioStatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(73, 28)
        Me.ToolStripStatusLabel1.Text = "Name :"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'login_name
        '
        Me.login_name.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_name.Name = "login_name"
        Me.login_name.Size = New System.Drawing.Size(60, 28)
        Me.login_name.Text = "name"
        Me.login_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(58, 28)
        Me.ToolStripStatusLabel5.Text = "Title :"
        Me.ToolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'login_position
        '
        Me.login_position.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_position.Name = "login_position"
        Me.login_position.Padding = New System.Windows.Forms.Padding(0, 0, 20, 0)
        Me.login_position.Size = New System.Drawing.Size(66, 28)
        Me.login_position.Text = "title"
        Me.login_position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_statistics)
        Me.Panel1.Controls.Add(Me.btn_employees)
        Me.Panel1.Controls.Add(Me.btn_purcahse_orders)
        Me.Panel1.Controls.Add(Me.btn_inventory)
        Me.Panel1.Controls.Add(Me.btn_calenders)
        Me.Panel1.Controls.Add(Me.btn_invoice)
        Me.Panel1.Controls.Add(Me.btn_work_orders)
        Me.Panel1.Controls.Add(Me.btn_market)
        Me.Panel1.Controls.Add(Me.btn_home)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(233, 676)
        Me.Panel1.TabIndex = 16
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
        Me.btn_logout.Location = New System.Drawing.Point(0, 549)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_logout.Size = New System.Drawing.Size(233, 48)
        Me.btn_logout.TabIndex = 11
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AccessibleName = ""
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 501)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(233, 48)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Messages"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_statistics
        '
        Me.btn_statistics.AccessibleName = ""
        Me.btn_statistics.BackColor = System.Drawing.Color.Teal
        Me.btn_statistics.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_statistics.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_statistics.FlatAppearance.BorderSize = 0
        Me.btn_statistics.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_statistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_statistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_statistics.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_statistics.ForeColor = System.Drawing.Color.White
        Me.btn_statistics.Image = CType(resources.GetObject("btn_statistics.Image"), System.Drawing.Image)
        Me.btn_statistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_statistics.Location = New System.Drawing.Point(0, 453)
        Me.btn_statistics.Name = "btn_statistics"
        Me.btn_statistics.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_statistics.Size = New System.Drawing.Size(233, 48)
        Me.btn_statistics.TabIndex = 9
        Me.btn_statistics.Text = "Statistics"
        Me.btn_statistics.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btn_statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_statistics.UseVisualStyleBackColor = False
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
        Me.btn_employees.Location = New System.Drawing.Point(0, 405)
        Me.btn_employees.Name = "btn_employees"
        Me.btn_employees.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_employees.Size = New System.Drawing.Size(233, 48)
        Me.btn_employees.TabIndex = 8
        Me.btn_employees.Text = "Employees "
        Me.btn_employees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_employees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_employees.UseVisualStyleBackColor = False
        '
        'btn_purcahse_orders
        '
        Me.btn_purcahse_orders.AccessibleName = ""
        Me.btn_purcahse_orders.BackColor = System.Drawing.Color.Teal
        Me.btn_purcahse_orders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_purcahse_orders.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_purcahse_orders.FlatAppearance.BorderSize = 0
        Me.btn_purcahse_orders.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_purcahse_orders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_purcahse_orders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_purcahse_orders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_purcahse_orders.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_purcahse_orders.ForeColor = System.Drawing.Color.White
        Me.btn_purcahse_orders.Image = CType(resources.GetObject("btn_purcahse_orders.Image"), System.Drawing.Image)
        Me.btn_purcahse_orders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_purcahse_orders.Location = New System.Drawing.Point(0, 357)
        Me.btn_purcahse_orders.Name = "btn_purcahse_orders"
        Me.btn_purcahse_orders.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_purcahse_orders.Size = New System.Drawing.Size(233, 48)
        Me.btn_purcahse_orders.TabIndex = 7
        Me.btn_purcahse_orders.Text = "Sales History"
        Me.btn_purcahse_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_purcahse_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_purcahse_orders.UseVisualStyleBackColor = False
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
        Me.btn_inventory.Location = New System.Drawing.Point(0, 309)
        Me.btn_inventory.Name = "btn_inventory"
        Me.btn_inventory.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_inventory.Size = New System.Drawing.Size(233, 48)
        Me.btn_inventory.TabIndex = 6
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
        Me.btn_calenders.Location = New System.Drawing.Point(0, 261)
        Me.btn_calenders.Name = "btn_calenders"
        Me.btn_calenders.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_calenders.Size = New System.Drawing.Size(233, 48)
        Me.btn_calenders.TabIndex = 5
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
        Me.btn_invoice.Location = New System.Drawing.Point(0, 213)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_invoice.Size = New System.Drawing.Size(233, 48)
        Me.btn_invoice.TabIndex = 4
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
        Me.btn_work_orders.Location = New System.Drawing.Point(0, 165)
        Me.btn_work_orders.Name = "btn_work_orders"
        Me.btn_work_orders.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_work_orders.Size = New System.Drawing.Size(233, 48)
        Me.btn_work_orders.TabIndex = 3
        Me.btn_work_orders.Text = "Work Orders"
        Me.btn_work_orders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_work_orders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_work_orders.UseVisualStyleBackColor = False
        '
        'btn_market
        '
        Me.btn_market.AccessibleName = ""
        Me.btn_market.BackColor = System.Drawing.Color.Teal
        Me.btn_market.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_market.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_market.FlatAppearance.BorderSize = 0
        Me.btn_market.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_market.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_market.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_market.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_market.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_market.ForeColor = System.Drawing.Color.White
        Me.btn_market.Image = CType(resources.GetObject("btn_market.Image"), System.Drawing.Image)
        Me.btn_market.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_market.Location = New System.Drawing.Point(0, 117)
        Me.btn_market.Name = "btn_market"
        Me.btn_market.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_market.Size = New System.Drawing.Size(233, 48)
        Me.btn_market.TabIndex = 2
        Me.btn_market.Text = "Market"
        Me.btn_market.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_market.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_market.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.AccessibleName = ""
        Me.btn_home.BackColor = System.Drawing.Color.Teal
        Me.btn_home.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_home.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_home.FlatAppearance.BorderSize = 0
        Me.btn_home.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue
        Me.btn_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.btn_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.White
        Me.btn_home.Image = CType(resources.GetObject("btn_home.Image"), System.Drawing.Image)
        Me.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.Location = New System.Drawing.Point(0, 69)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Padding = New System.Windows.Forms.Padding(23, 0, 0, 0)
        Me.btn_home.Size = New System.Drawing.Size(233, 48)
        Me.btn_home.TabIndex = 1
        Me.btn_home.Text = "Dashboard"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel5.Controls.Add(Me.btn_management_message)
        Me.Panel5.Controls.Add(Me.btn_refresh)
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.lbl_current_tab)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Font = New System.Drawing.Font("Ebrima", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(233, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1117, 69)
        Me.Panel5.TabIndex = 20
        '
        'btn_management_message
        '
        Me.btn_management_message.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_management_message.AutoSize = True
        Me.btn_management_message.BackColor = System.Drawing.Color.Ivory
        Me.btn_management_message.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_management_message.FlatAppearance.BorderSize = 0
        Me.btn_management_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_management_message.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_management_message.ForeColor = System.Drawing.Color.White
        Me.btn_management_message.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_management_message.Location = New System.Drawing.Point(332, 11)
        Me.btn_management_message.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_management_message.Name = "btn_management_message"
        Me.btn_management_message.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_management_message.Size = New System.Drawing.Size(342, 50)
        Me.btn_management_message.TabIndex = 36
        Me.btn_management_message.UseVisualStyleBackColor = False
        Me.btn_management_message.Visible = False
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Image = CType(resources.GetObject("btn_refresh.Image"), System.Drawing.Image)
        Me.btn_refresh.Location = New System.Drawing.Point(992, 11)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(73, 52)
        Me.btn_refresh.TabIndex = 35
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.CadetBlue
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(896, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 52)
        Me.Button2.TabIndex = 34
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'lbl_current_tab
        '
        Me.lbl_current_tab.AutoSize = True
        Me.lbl_current_tab.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current_tab.ForeColor = System.Drawing.Color.Teal
        Me.lbl_current_tab.Location = New System.Drawing.Point(37, 22)
        Me.lbl_current_tab.Name = "lbl_current_tab"
        Me.lbl_current_tab.Size = New System.Drawing.Size(121, 28)
        Me.lbl_current_tab.TabIndex = 1
        Me.lbl_current_tab.Text = "Currenrt Tab"
        '
        'management_main_container
        '
        Me.management_main_container.BackColor = System.Drawing.Color.WhiteSmoke
        Me.management_main_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.management_main_container.Location = New System.Drawing.Point(233, 112)
        Me.management_main_container.Name = "management_main_container"
        Me.management_main_container.Size = New System.Drawing.Size(1117, 562)
        Me.management_main_container.TabIndex = 21
        '
        'systemtime
        '
        Me.systemtime.Enabled = True
        Me.systemtime.Interval = 1000
        '
        'Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.management_main_container)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.DateTimeStatusStrip.ResumeLayout(False)
        Me.DateTimeStatusStrip.PerformLayout()
        Me.UserBioStatusStrip.ResumeLayout(False)
        Me.UserBioStatusStrip.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UserBioStatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents login_name As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents login_position As ToolStripStatusLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_inventory As Button
    Friend WithEvents btn_calenders As Button
    Friend WithEvents btn_invoice As Button
    Friend WithEvents btn_work_orders As Button
    Friend WithEvents btn_market As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_statistics As Button
    Friend WithEvents btn_employees As Button
    Friend WithEvents btn_purcahse_orders As Button
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_current_tab As Label
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuickAccessToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FfToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents management_main_container As Panel
    Friend WithEvents DdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DocumentationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents systemtime As Timer
    Friend WithEvents DateTimeStatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents current_date As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As ToolStripStatusLabel
    Friend WithEvents current_time As ToolStripStatusLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_logout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_management_message As Button
End Class
