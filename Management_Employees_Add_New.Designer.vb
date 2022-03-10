<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Management_Employees_Add_New
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
        Me.txt_new_active = New System.Windows.Forms.ComboBox()
        Me.txt_new_birth_date = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_new_married = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_new_gender = New System.Windows.Forms.ComboBox()
        Me.txt_new_salary = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_new_id = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_new_position = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_new_physical_address = New System.Windows.Forms.TextBox()
        Me.txt_new_number = New System.Windows.Forms.TextBox()
        Me.txt_new_email = New System.Windows.Forms.TextBox()
        Me.txt_new_last_name = New System.Windows.Forms.TextBox()
        Me.txt_new_other_names = New System.Windows.Forms.TextBox()
        Me.txt_new_first_name = New System.Windows.Forms.TextBox()
        Me.btn_new_user_select_image = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.employee_clear_image = New System.Windows.Forms.Label()
        Me.pb_new_user_image = New System.Windows.Forms.PictureBox()
        Me.btn_new_user_cancel = New System.Windows.Forms.Button()
        Me.btn_new_user_save = New System.Windows.Forms.Button()
        CType(Me.pb_new_user_image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_new_active
        '
        Me.txt_new_active.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_active.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_active.FormattingEnabled = True
        Me.txt_new_active.Items.AddRange(New Object() {"Yes", "No"})
        Me.txt_new_active.Location = New System.Drawing.Point(758, 322)
        Me.txt_new_active.MaxDropDownItems = 2
        Me.txt_new_active.MaxLength = 3
        Me.txt_new_active.Name = "txt_new_active"
        Me.txt_new_active.Size = New System.Drawing.Size(154, 33)
        Me.txt_new_active.TabIndex = 63
        '
        'txt_new_birth_date
        '
        Me.txt_new_birth_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_birth_date.Checked = False
        Me.txt_new_birth_date.CustomFormat = ""
        Me.txt_new_birth_date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.txt_new_birth_date.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_birth_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_new_birth_date.Location = New System.Drawing.Point(395, 402)
        Me.txt_new_birth_date.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.txt_new_birth_date.Name = "txt_new_birth_date"
        Me.txt_new_birth_date.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_birth_date.TabIndex = 58
        Me.txt_new_birth_date.Value = New Date(2019, 9, 18, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(819, 293)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 28)
        Me.Label16.TabIndex = 84
        Me.Label16.Text = "*"
        '
        'txt_new_married
        '
        Me.txt_new_married.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_married.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_married.FormattingEnabled = True
        Me.txt_new_married.Items.AddRange(New Object() {"No", "Yes"})
        Me.txt_new_married.Location = New System.Drawing.Point(934, 239)
        Me.txt_new_married.MaxDropDownItems = 2
        Me.txt_new_married.MaxLength = 3
        Me.txt_new_married.Name = "txt_new_married"
        Me.txt_new_married.Size = New System.Drawing.Size(154, 33)
        Me.txt_new_married.TabIndex = 62
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(930, 215)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 18)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Married ?"
        '
        'txt_new_gender
        '
        Me.txt_new_gender.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_gender.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_gender.FormattingEnabled = True
        Me.txt_new_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.txt_new_gender.Location = New System.Drawing.Point(758, 239)
        Me.txt_new_gender.MaxDropDownItems = 2
        Me.txt_new_gender.MaxLength = 6
        Me.txt_new_gender.Name = "txt_new_gender"
        Me.txt_new_gender.Size = New System.Drawing.Size(154, 33)
        Me.txt_new_gender.TabIndex = 61
        '
        'txt_new_salary
        '
        Me.txt_new_salary.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_salary.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_salary.Location = New System.Drawing.Point(759, 156)
        Me.txt_new_salary.Name = "txt_new_salary"
        Me.txt_new_salary.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_salary.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(396, 301)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 18)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Physical Address / Area"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(551, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 28)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "*"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(819, 207)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(20, 28)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "*"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(790, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 28)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "*"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(479, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 28)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(102, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 28)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "*"
        '
        'Label35
        '
        Me.Label35.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(19, 218)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(22, 18)
        Me.Label35.TabIndex = 76
        Me.Label35.Text = "ID"
        '
        'Label34
        '
        Me.Label34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(756, 134)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(97, 18)
        Me.Label34.TabIndex = 75
        Me.Label34.Text = "Salary (GHC)"
        '
        'txt_new_id
        '
        Me.txt_new_id.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_id.Enabled = False
        Me.txt_new_id.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_id.Location = New System.Drawing.Point(22, 239)
        Me.txt_new_id.MaxLength = 12
        Me.txt_new_id.Name = "txt_new_id"
        Me.txt_new_id.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_id.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(756, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 18)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Role"
        '
        'txt_new_position
        '
        Me.txt_new_position.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_position.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_position.FormattingEnabled = True
        Me.txt_new_position.Location = New System.Drawing.Point(758, 76)
        Me.txt_new_position.MaxLength = 25
        Me.txt_new_position.Name = "txt_new_position"
        Me.txt_new_position.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_position.TabIndex = 59
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(758, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 18)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Active ?"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(396, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 18)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Birth_Date"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(760, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 18)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(397, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 18)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Email Address"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(396, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 18)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Mobile Phone Number"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(398, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 18)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 381)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Other Name(s)"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 298)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "First Name"
        '
        'txt_new_physical_address
        '
        Me.txt_new_physical_address.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_physical_address.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_physical_address.Location = New System.Drawing.Point(399, 322)
        Me.txt_new_physical_address.MaxLength = 50
        Me.txt_new_physical_address.Name = "txt_new_physical_address"
        Me.txt_new_physical_address.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_physical_address.TabIndex = 57
        '
        'txt_new_number
        '
        Me.txt_new_number.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_number.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_number.Location = New System.Drawing.Point(398, 239)
        Me.txt_new_number.MaxLength = 10
        Me.txt_new_number.Name = "txt_new_number"
        Me.txt_new_number.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_number.TabIndex = 56
        '
        'txt_new_email
        '
        Me.txt_new_email.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_email.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_email.Location = New System.Drawing.Point(399, 155)
        Me.txt_new_email.MaxLength = 50
        Me.txt_new_email.Name = "txt_new_email"
        Me.txt_new_email.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_email.TabIndex = 55
        '
        'txt_new_last_name
        '
        Me.txt_new_last_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_last_name.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_last_name.Location = New System.Drawing.Point(399, 76)
        Me.txt_new_last_name.MaxLength = 35
        Me.txt_new_last_name.Name = "txt_new_last_name"
        Me.txt_new_last_name.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_last_name.TabIndex = 54
        '
        'txt_new_other_names
        '
        Me.txt_new_other_names.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_other_names.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_other_names.Location = New System.Drawing.Point(23, 402)
        Me.txt_new_other_names.MaxLength = 35
        Me.txt_new_other_names.Name = "txt_new_other_names"
        Me.txt_new_other_names.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_other_names.TabIndex = 53
        '
        'txt_new_first_name
        '
        Me.txt_new_first_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_first_name.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_first_name.Location = New System.Drawing.Point(23, 319)
        Me.txt_new_first_name.MaxLength = 35
        Me.txt_new_first_name.Name = "txt_new_first_name"
        Me.txt_new_first_name.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_first_name.TabIndex = 52
        '
        'btn_new_user_select_image
        '
        Me.btn_new_user_select_image.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_user_select_image.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_new_user_select_image.FlatAppearance.BorderSize = 0
        Me.btn_new_user_select_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_user_select_image.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_user_select_image.Location = New System.Drawing.Point(234, 176)
        Me.btn_new_user_select_image.Name = "btn_new_user_select_image"
        Me.btn_new_user_select_image.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.btn_new_user_select_image.Size = New System.Drawing.Size(97, 33)
        Me.btn_new_user_select_image.TabIndex = 86
        Me.btn_new_user_select_image.Text = "Select Image"
        Me.btn_new_user_select_image.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(243, 156)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 17)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Max: 10KiB"
        '
        'employee_clear_image
        '
        Me.employee_clear_image.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.employee_clear_image.AutoSize = True
        Me.employee_clear_image.Cursor = System.Windows.Forms.Cursors.Hand
        Me.employee_clear_image.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employee_clear_image.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_delete_24
        Me.employee_clear_image.Location = New System.Drawing.Point(71, 62)
        Me.employee_clear_image.Name = "employee_clear_image"
        Me.employee_clear_image.Padding = New System.Windows.Forms.Padding(5)
        Me.employee_clear_image.Size = New System.Drawing.Size(30, 34)
        Me.employee_clear_image.TabIndex = 93
        Me.employee_clear_image.Text = "  "
        Me.employee_clear_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pb_new_user_image
        '
        Me.pb_new_user_image.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pb_new_user_image.BackColor = System.Drawing.Color.White
        Me.pb_new_user_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_new_user_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_new_user_image.InitialImage = Global.Codebot_GMS.My.Resources.Resources.Employee_Blue_4
        Me.pb_new_user_image.Location = New System.Drawing.Point(107, 62)
        Me.pb_new_user_image.Name = "pb_new_user_image"
        Me.pb_new_user_image.Size = New System.Drawing.Size(110, 147)
        Me.pb_new_user_image.TabIndex = 85
        Me.pb_new_user_image.TabStop = False
        '
        'btn_new_user_cancel
        '
        Me.btn_new_user_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_new_user_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_user_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_user_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_new_user_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_user_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_user_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_user_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_user_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_user_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_user_cancel.Location = New System.Drawing.Point(566, 525)
        Me.btn_new_user_cancel.Name = "btn_new_user_cancel"
        Me.btn_new_user_cancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_new_user_cancel.Size = New System.Drawing.Size(141, 42)
        Me.btn_new_user_cancel.TabIndex = 67
        Me.btn_new_user_cancel.Text = "CANCEL  "
        Me.btn_new_user_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_user_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_user_save
        '
        Me.btn_new_user_save.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_new_user_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_user_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_user_save.FlatAppearance.BorderSize = 0
        Me.btn_new_user_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_user_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_user_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_user_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_user_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_user_save.Location = New System.Drawing.Point(405, 525)
        Me.btn_new_user_save.Name = "btn_new_user_save"
        Me.btn_new_user_save.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_new_user_save.Size = New System.Drawing.Size(129, 42)
        Me.btn_new_user_save.TabIndex = 65
        Me.btn_new_user_save.Text = "SAVE"
        Me.btn_new_user_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_user_save.UseVisualStyleBackColor = False
        '
        'Management_Employees_Add_New
        '
        Me.AcceptButton = Me.btn_new_user_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.btn_new_user_cancel
        Me.ClientSize = New System.Drawing.Size(1121, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.employee_clear_image)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.btn_new_user_select_image)
        Me.Controls.Add(Me.pb_new_user_image)
        Me.Controls.Add(Me.txt_new_active)
        Me.Controls.Add(Me.txt_new_birth_date)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txt_new_married)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txt_new_gender)
        Me.Controls.Add(Me.txt_new_salary)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_new_user_cancel)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txt_new_id)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_new_position)
        Me.Controls.Add(Me.btn_new_user_save)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_new_physical_address)
        Me.Controls.Add(Me.txt_new_number)
        Me.Controls.Add(Me.txt_new_email)
        Me.Controls.Add(Me.txt_new_last_name)
        Me.Controls.Add(Me.txt_new_other_names)
        Me.Controls.Add(Me.txt_new_first_name)
        Me.Name = "Management_Employees_Add_New"
        Me.Text = "Management_Employees_Add_New"
        CType(Me.pb_new_user_image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_new_active As ComboBox
    Friend WithEvents txt_new_birth_date As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_new_married As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_new_gender As ComboBox
    Friend WithEvents txt_new_salary As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_new_user_cancel As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txt_new_id As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_new_position As ComboBox
    Friend WithEvents btn_new_user_save As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_new_physical_address As TextBox
    Friend WithEvents txt_new_number As TextBox
    Friend WithEvents txt_new_email As TextBox
    Friend WithEvents txt_new_last_name As TextBox
    Friend WithEvents txt_new_other_names As TextBox
    Friend WithEvents txt_new_first_name As TextBox
    Friend WithEvents pb_new_user_image As PictureBox
    Friend WithEvents btn_new_user_select_image As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents employee_clear_image As Label
End Class
