Imports MySql.Data.MySqlClient
Module Codebot_GMS_Module
    Public sql_con As New MySqlConnection("server=localhost;user id=root;password=;database=codebot_gms_schema;sslMode=none;Allow Zero Datetime=True")
    Public sql_rdr As MySqlDataReader
    Public sql_dt As DataTable
    Public sql_da As MySqlDataAdapter
    Public sql_ds As DataSet
    Public sql_cmd As MySqlCommand
    Public message_ts As TimeSpan
    Public signup_id, signup_name, login_id, login_full_name, login_as, default_query, filter_query As String
    'LOADS FORMS INTO GMS_Main  
    Public Sub gms_main_form_loader(ByVal main_form As Form)
        main_form.TopLevel = False
        main_form.FormBorderStyle = FormBorderStyle.None
        main_form.WindowState = FormWindowState.Maximized
        GMS_Main.GMS_Main_panel.Controls.Add(main_form)
        main_form.Visible = False
        If main_form.Visible = False Then
            Management.Visible = False
            Auth.Visible = False
            main_form.Visible = True
        Else
            main_form.Visible = False
        End If
    End Sub
    'LOADS FROMS INTO Management BASED ON THE BUTTON CLICK IN THE MANAGEMENT FORM SIDEBAR
    Public Sub sidebar_form_loader(ByRef form As Form)
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Maximized
        Management.management_main_container.Controls.Add(form)
        form.Visible = False
        If form.Visible = False Then
            Management_Employees.Visible = False
            Management_Home.Visible = False
            Management_Employees_Add_New.Visible = False
            Management_Work_Order.Visible = False
            Management_Market.Visible = False
            Management_Calendar.Visible = False
            Management_Inventory.Visible = False
            Management_Inventory_Add_New.Visible = False
            Management_Work_Order_Add_New.Visible = False
            form.Visible = True
        Else
            form.Visible = False
        End If
    End Sub
    'LOADS FORMS INTO THE AUTH FORM 
    Public Sub auth_form_loader(ByRef auth_form As Form)
        auth_form.TopLevel = False
        auth_form.FormBorderStyle = FormBorderStyle.None
        auth_form.WindowState = FormWindowState.Maximized
        Auth.auth_left_panel.Controls.Add(auth_form)
        auth_form.Visible = False
        If auth_form.Visible = False Then
            Auth_Signup.Visible = False
            Auth_Login.Visible = False
            Auth_Password_Reset.Visible = False
            auth_form.Visible = True
        Else
            auth_form.Visible = False
        End If
    End Sub
    'DIPLAY POP UP MESSAGES 
    Public Sub message(ByRef btn_name As Button, ByRef message_type As String)
        If message_type = "warning" Then
            btn_name.Show()
            btn_name.BackColor = Color.LightPink
            btn_name.ForeColor = Color.Red
            Auth.message_timer.Enabled = True
            message_ts = New TimeSpan(0, 0, 3)
        ElseIf message_type = "success" Then
            btn_name.Show()
            btn_name.BackColor = Color.PaleGreen
            btn_name.ForeColor = Color.Green
            Auth.message_timer.Enabled = True
            message_ts = New TimeSpan(0, 0, 3)
        ElseIf message_type = "information" Then
            btn_name.Show()
            btn_name.BackColor = Color.LightBlue
            btn_name.ForeColor = Color.Blue
            Auth.message_timer.Enabled = True
            message_ts = New TimeSpan(0, 0, 3)
        End If
    End Sub
    'ADD COMBOX ITEMS
    Public Sub add_combobox_items(ByRef cmb_name As ComboBox, ByRef table As String, ByRef column As String)
        Try
            Dim sql_cmd As New MySqlCommand("SELECT * FROM " & table, sql_con)
            sql_con.Close()
            sql_con.Open()
            Dim sql_rdr As MySqlDataReader = sql_cmd.ExecuteReader()
            While sql_rdr.Read
                If filter_combobox(cmb_name, sql_rdr.Item(column).ToString) = False Then
                    cmb_name.Items.Add(sql_rdr.Item(column).ToString)
                End If
            End While
            sql_con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'ADD SEARCH SUGGESTIONS TO SEARCH TEXTBOXES
    Public Sub add_search_suggestion(ByRef txtb_name As TextBox, ByRef table As String, ByRef column As String)
        txtb_name.Clear()
        Try
            Dim sql_cmd As New MySqlCommand("SELECT " & column & " FROM " & table, sql_con)
            sql_con.Close()
            sql_con.Open()
            Dim sql_rdr As MySqlDataReader = sql_cmd.ExecuteReader()
            While sql_rdr.Read
                txtb_name.AutoCompleteCustomSource.Add(sql_rdr.Item(column).ToString)
            End While
            sql_con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'THIS PREVENTS REDUNDUNT DATA IN COMBOX ITMES 
    Public Function filter_combobox(ByRef cmb_name As ComboBox, ByRef filter_item As String) As Boolean
        Dim found As Boolean = False
        For Each item In cmb_name.Items
            If filter_item = item Then
                found = True
            End If
        Next
        Return found
    End Function
    'Public Function filter_textbox(ByRef txt_name As TextBox, ByRef filter_item As String) As Boolean
    '    Dim found As Boolean = False
    '    For Each item In txt_name.AutoCompleteCustomSource
    '        If filter_item = item Then
    '            found = True
    '        End If
    '    Next
    '    Return found
    'End Function


    'FILL THE DATAGRID WITH A DEFAULT INFORMATION
    Public Sub datagrid_fill_default(ByRef db_table As String, ByRef gridview_name As DataGridView)
        sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table, sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        gridview_name.DataSource = sql_dt
        datagrid_fill_color_effect(db_table, gridview_name)
        'datagrif_fill_column_resize(db_table, gridview_name)
    End Sub
    'FILL THE DATAGRID WITH INFORMATIONS BASE ON SOME FILTER VARIABLE
    Public Sub datagrid_fill_flter_with_variable(ByRef db_table As String, ByRef gridview_name As DataGridView, ByRef db_column As String, ByRef symbol As String, ByRef variable As String)
        sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table & " WHERE " & db_column & symbol & variable & "", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        gridview_name.DataSource = sql_dt
        datagrid_fill_color_effect(db_table, gridview_name)
        'datagrif_fill_column_resize(db_table, gridview_name)
    End Sub
    'FILL THE DATAGRID WITH INFORMATIONS BASED ON THE SELECTED TEXT FROM A COMBO BOX
    Public Sub datagrid_fill_filter(ByRef db_table As String, ByRef gridview_name As DataGridView, ByRef filter As String, ByRef filter_combox As ComboBox)
        sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table & " WHERE " & filter & " = '" & filter_combox.Text & "'", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        gridview_name.DataSource = sql_dt
        datagrid_fill_color_effect(db_table, gridview_name)
    End Sub
    'FILL THE DATAGRID WITH INFORMATIONS BASED ON THE TEXT FROM A TEXT BOX
    Public Sub datagrid_fill_filter_textbox(ByRef db_table As String, ByRef gridview_name As DataGridView, ByRef filter As String, ByRef filter_txt As TextBox)
        sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table & " WHERE " & filter & " = '" & filter_txt.Text & "'", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        gridview_name.DataSource = sql_dt
        datagrid_fill_color_effect(db_table, gridview_name)
    End Sub
    'FILL  THE HOME DATAGRID WITH THE PREFERED FILTER FOR THE WORK ORDDERS DUE TAB 
    Public Sub work_order_overdue_filter(ByRef variable As String)
        Management_Home.activebar_work_orders.Visible = True
        Management_Home.activebar_inventory.Visible = False
        sql_da = New MySqlDataAdapter("SELECT * FROM work_order_view WHERE Due_In < " & variable & " AND Progress_Status <>'" & "Done" & "' ", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Management_Home.HomeDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("work_order_view", Management_Home.HomeDataGridView)
        Management.lbl_current_tab.Text = "Dashboard | Work Oders Due"
    End Sub
    'APPLY COLOR EFFECTS TO ROWS IN THE DATAGRID BASED ON THE TABLE IT IS
    Public Sub datagrid_fill_color_effect(ByRef db_table As String, ByRef gridview_name As DataGridView)
        If db_table = "employee_view" Then
            For i As Integer = 0 To gridview_name.Rows.Count - 1 Step +1
                If gridview_name.Rows(i).Cells(7).Value.ToString = False Then
                    gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Coral
                Else
                    'gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.PaleGreen
                End If
            Next
        ElseIf db_table = "inventory" Then
            For i As Integer = 0 To gridview_name.Rows.Count - 1 Step +1
                If gridview_name.Rows(i).Cells(7).Value < 11 Then
                    gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Gold
                    If gridview_name.Rows(i).Cells(7).Value < 1 Then
                        gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Coral
                    End If
                End If
            Next
        ElseIf db_table = "work_order_view" Then
            For i As Integer = 0 To gridview_name.Rows.Count - 1 Step +1
                If gridview_name.Rows(i).Cells(4).Value < 6 Then
                    gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Gold

                    If gridview_name.Rows(i).Cells(4).Value < 1 Then
                        gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Coral
                    End If
                End If
            Next
        End If


    End Sub
    'FILL ALL COMBOBOXES WITH ITEMS AND FILL ALL FILTER TEXT BOXES WITH SEARCH SUGESTIONS
    Public Sub box_collections_fill()
        'Inventory
        Management_Inventory.cmb_inventory_location_filter.Items.Clear()
        Management_Inventory.cmb_inventory_category_filter.Items.Clear()
        Management_Inventory.txt_inventory_part_name_filter.Clear()
        Management_Inventory.cmb_inventory_location_filter.Items.Add("All Locations")
        Management_Inventory.cmb_inventory_category_filter.Items.Add("All Categories")
        Management_Inventory.cmb_inventory_location_filter.SelectedIndex() = 0
        Management_Inventory.cmb_inventory_category_filter.SelectedIndex() = 0
        add_search_suggestion(Management_Inventory.txt_inventory_part_name_filter, "inventory", "Part_Name")
        add_combobox_items(Management_Inventory.cmb_inventory_location_filter, "inventory", "Location")
        add_combobox_items(Management_Inventory.cmb_inventory_category_filter, "inventory", "Category")
        add_combobox_items(Management_Inventory_Add_New.txt_new_category, "inventory", "Category")
        'Employee
        Management_Employees.cmb_employee_position_filter.Items.Clear()
        Management_Employees.cmb_employee_position_filter.Items.Add("All Roles")
        Management_Employees.cmb_employee_position_filter.SelectedIndex() = 0
        add_search_suggestion(Management_Employees.txt_employee_number_filter, "employee_view", "Phone")
        add_search_suggestion(Management_Employees.txt_employee_name_filter, "employee_view", "Name")
        add_combobox_items(Management_Employees.cmb_employee_position_filter, "employee_view", "Role")
        add_combobox_items(Management_Employees_Add_New.txt_new_position, "employee_view", "Role")
    End Sub
    'RESIZE THE COLUMNS IN THE DATAGRID TABLE BASED ON WHAT TABLE IT IS
    Public Sub datagrif_fill_column_resize(ByRef db_table As String, ByRef gridview_name As DataGridView)
        If db_table = "employee_view" Then
            gridview_name.Columns(0).Width = 140   'ID
            gridview_name.Columns(1).Width = 230   'Full name
            gridview_name.Columns(2).Width = 240   '
            gridview_name.Columns(3).Width = 100   '
            gridview_name.Columns(4).Width = 50    '
            gridview_name.Columns(5).Width = 200   '
            gridview_name.Columns(6).Width = 70    '
            gridview_name.Columns(7).Visible = False   'Active
            'gridview_name.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        ElseIf db_table = "inventory" Then
            gridview_name.Columns(0).Width = 50    'ID
            gridview_name.Columns(1).Width = 100   'Category
            gridview_name.Columns(2).Width = 170   'Part Name 
            gridview_name.Columns(3).Width = 130   'Part Number
            'gridview_name.Columns(4).Width = 210   'Alternative
            gridview_name.Columns(5).Width = 110   'Location
            gridview_name.Columns(6).Width = 200   'Model/Type
            gridview_name.Columns(7).Width = 60   'Stock
            gridview_name.Columns(8).Width = 80   'Unit cost
        End If
    End Sub
End Module
