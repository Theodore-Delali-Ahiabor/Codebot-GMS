Imports System.IO
Imports System.Security.Cryptography
Imports System.Net.Mail
Module GMS_Module
    Public sql_con As New MySqlConnection("server=localhost;user id=root;password=;database=codebot_gms_schema;sslMode=none;Allow Zero Datetime=True")
    Public sql_rdr As MySqlDataReader
    Public sql_dt As DataTable
    Public sql_da As MySqlDataAdapter
    Public sql_ds As DataSet
    Public sql_cmd As MySqlCommand
    Public message_ts, invalid_login_ts As TimeSpan
    Public signup_id, signup_name, login_id, login_first_name, login_full_name, login_as, default_query, filter_query, img_path, sql_stmt, null As String
    Public invalid_login As Integer = 0
    Public arr_image() As Byte
    Public open_image_file_dialog As New OpenFileDialog()
    Public mstream As New MemoryStream()
    Public triple_des As New TripleDESCryptoServiceProvider
    Public email_delevery_status As Integer = 0

    '-------------------------
    'LOADS FORMS INTO GMS_Main  
    '-------------------------
    Public Sub gms_main_form_loader(ByVal main_form As Form)
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Main Form Load Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    '------------------------------------------------------------------------------------
    'LOADS FROMS INTO Management BASED ON THE BUTTON CLICK IN THE MANAGEMENT FORM SIDEBAR
    '------------------------------------------------------------------------------------
    Public Sub sidebar_form_loader(ByRef form As Form)
        Try
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            form.WindowState = FormWindowState.Maximized
            Management.management_main_container.Controls.Add(form)
            form.Visible = False
            If form.Visible = False Then
                Management_Employees.Visible = False
                Management_Dashboard.Visible = False
                Management_Employees_Add_New.Visible = False
                Management_Work_Order.Visible = False
                Management_Calendar.Visible = False
                Management_Inventory.Visible = False
                Management_Inventory_Add_New.Visible = False
                Management_Work_Order_Add_New.Visible = False
                Management_Invoice.Visible = False
                Management_Invoice_Add_New.Visible = False
                Management_Feedbacks.Visible = False
                form.Visible = True
            Else
                form.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sidebar Form Load Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '------------------------------
    'LOADS FORMS INTO THE AUTH FORM 
    '------------------------------
    Public Sub auth_form_loader(ByRef auth_form As Form)
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Authentication Form Load Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '----------------------
    'DIPLAY POP UP MESSAGES
    '----------------------
    Public Sub message(ByRef message_type As String, ByRef message_text As String)
        message_ts = New TimeSpan(0, 0, 10)
        GMS_Message.Opacity = 0.9
        Try
            If message_type = "warning" Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation)
                With GMS_Message
                    .Enabled = True
                    .BackColor = Color.LightPink
                    .message_text.BackColor = Color.LightPink
                    .message_text.Text = message_text
                    .message_icon.Image = .message_warning_icon.Image
                    .Show()
                    .message_timer.Enabled = True
                End With

            ElseIf message_type = "success" Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Question)
                With GMS_Message
                    .BackColor = Color.PaleGreen
                    .message_text.BackColor = Color.PaleGreen
                    .message_text.Text = message_text
                    .message_icon.Image = .message_success_icon.Image
                    .Show()
                    .message_timer.Enabled = True
                End With
            ElseIf message_type = "information" Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
                With GMS_Message
                    .BackColor = Color.LightBlue
                    .message_text.BackColor = Color.LightBlue
                    .message_text.Text = message_text
                    .message_icon.Image = .message_information_icon.Image
                    .Show()
                    .message_timer.Enabled = True
                End With
            ElseIf message_type = "error" Then
                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Hand)
                With GMS_Message
                    .BackColor = Color.LightYellow
                    .message_text.BackColor = Color.LightYellow
                    .message_text.Text = message_text
                    .message_icon.Image = .message_error_icon.Image
                    .Show()
                    .message_timer.Enabled = True
                End With
            End If
            GMS_Message.message_icon.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message Display Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '----------------
    'ADD COMBOX ITEMS
    '----------------
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
            MessageBox.Show(ex.Message, "Combox Items Add Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '------------------------------------------
    'ADD SEARCH SUGGESTIONS TO SEARCH TEXTBOXES
    '------------------------------------------
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
            MessageBox.Show(ex.Message, "Search Suggestions Add Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '--------------------------------------------
    'THIS PREVENTS REDUNDUNT DATA IN COMBOX ITMES 
    '--------------------------------------------
    Public Function filter_combobox(ByRef cmb_name As ComboBox, ByRef filter_item As String) As Boolean
        Dim found As Boolean = False
        For Each item In cmb_name.Items
            If filter_item = item Then
                found = True
            End If
        Next
        Return found
    End Function
    '----------------------------------------------------------------------------------------
    'FILL THE DATAGRID WITH A DEFAULT INFORMATION WITH THE DEFAULT ORDERING FROM THE DATABASE
    '----------------------------------------------------------------------------------------
    Public Sub datagrid_fill(ByRef db_table As String, ByRef gridview_name As DataGridView)
        Try
            sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table, sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            gridview_name.DataSource = sql_dt
            datagrid_fill_color_effect(db_table, gridview_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Display Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '----------------------------------------------------------------------------------
    'FILL THE DATAGRID WITH A DEFAULT INFORMATION ODERING BY THE ID IN DESCENDING ORDER
    '----------------------------------------------------------------------------------
    Public Sub datagrid_fill_default(ByRef db_table As String, ByRef gridview_name As DataGridView)
        Try
            sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table & " ORDER BY ID DESC", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            gridview_name.DataSource = sql_dt
            datagrid_fill_color_effect(db_table, gridview_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Display Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '----------------------------------------------------------------
    'FILL THE DATAGRID WITH INFORMATIONS BASE ON SOME FILTER VARIABLE
    '----------------------------------------------------------------
    Public Sub datagrid_fill_flter_with_variable(ByRef db_table As String, ByRef gridview_name As DataGridView, ByRef db_column As String, ByRef symbol As String, ByRef variable As String)
        Try
            sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table & " WHERE " & db_column & symbol & variable & " ORDER BY ID DESC", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            gridview_name.DataSource = sql_dt
            datagrid_fill_color_effect(db_table, gridview_name)
            datagrid_fill_column_resize(db_table, gridview_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Query Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '-------------------------------------------------------------------------------
    'FILL THE DATAGRID WITH INFORMATIONS BASED ON THE SELECTED TEXT FROM A COMBO BOX
    '------------------------------------------------------------------------------
    Public Sub datagrid_fill_filter(ByRef db_table As String, ByRef gridview_name As DataGridView, ByRef db_column As String, ByRef filter_combox As ComboBox)
        Try
            sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table & " WHERE " & db_column & " = '" & filter_combox.Text & "' ORDER BY ID DESC", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            gridview_name.DataSource = sql_dt
            datagrid_fill_color_effect(db_table, gridview_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Filter Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '---------------------------------------------------------------------
    'FILL THE DATAGRID WITH INFORMATIONS BASED ON THE TEXT FROM A TEXT BOX
    '---------------------------------------------------------------------
    Public Sub datagrid_fill_filter_textbox(ByRef db_table As String, ByRef gridview_name As DataGridView, ByRef db_column As String, ByRef filter_txt As TextBox)
        Try
            sql_da = New MySqlDataAdapter("SELECT * FROM " & db_table & " WHERE " & db_column & " = '" & filter_txt.Text & "' ORDER BY ID DESC", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            gridview_name.DataSource = sql_dt
            datagrid_fill_color_effect(db_table, gridview_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Search Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '-----------------------------------------------------------------------------------------------------------------------------
    'FILL THE HOME DATAGRID WITH THE PREFERED FILTER FOR THE WORK ORDDERS DUE WHERE PROGRESS STATUS IS NOT TERMINATED OR COMPLETED
    '-----------------------------------------------------------------------------------------------------------------------------
    Public Sub work_order_overdue_filter(ByRef variable As String)
        Try
            Management_Dashboard.activebar_work_orders.Visible = True
            Management_Dashboard.activebar_inventory.Visible = False
            Management_Dashboard.activebar_events.Visible = False
            Management_Dashboard.activebar_payments.Visible = False
            sql_da = New MySqlDataAdapter("SELECT * FROM `work_order_view` WHERE `Due_In` < " & variable & " AND `Progress_Status` <> '" & "Completed" & "' AND `Progress_Status` <> '" & "Terminated" & "' ORDER BY ID DESC ", sql_con)
            sql_dt = New DataTable
            sql_dt.Clear()
            sql_da.Fill(sql_dt)
            Management_Dashboard.DashboardDataGridView.DataSource = sql_dt
            datagrid_fill_color_effect("work_order_view", Management_Dashboard.DashboardDataGridView)
            datagrid_fill_column_resize("work_order_view", Management_Dashboard.DashboardDataGridView)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Work Order Overdue Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '-------------------------------------------------------------
    'RETRIEVES CALENDAR EVENTS BASED ON WHICH USER ADDED THE EVENT
    '-------------------------------------------------------------
    Public Sub upcoming_calendar_events(ByRef symbol As String, ByRef variable As String)
        Management_Dashboard.activebar_work_orders.Visible = False
        Management_Dashboard.activebar_inventory.Visible = False
        Management_Dashboard.activebar_payments.Visible = False
        Management_Dashboard.activebar_events.Visible = True
        sql_da = New MySqlDataAdapter("SELECT * FROM `events_view` WHERE `Due_In` " & symbol & " " & variable & " AND `Added_By` = '" & login_id & "' ORDER BY ID DESC", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        Management_Dashboard.DashboardDataGridView.DataSource = sql_dt
        datagrid_fill_color_effect("events_view", Management_Dashboard.DashboardDataGridView)
        datagrid_fill_column_resize("events_view", Management_Dashboard.DashboardDataGridView)
    End Sub
    '--------------------------------------------------
    'CLEAR THE DEFAULT ROW SELECTION IN A DATAFRID VIEW
    '--------------------------------------------------
    Public Sub clear_gridview_default_selection(ByRef gridview_name As DataGridView)
        Try
            If gridview_name.Rows.Count > 0 Then
                gridview_name.Rows(0).Selected = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Default Selection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '--------------------------------------------------------------------
    'APPLY COLOR EFFECTS TO ROWS IN THE DATAGRID BASED ON THE TABLE IT IS
    '--------------------------------------------------------------------
    Public Sub datagrid_fill_color_effect(ByRef db_table As String, ByRef gridview_name As DataGridView)
        Try
            If gridview_name.Rows.Count > 0 Then
                If db_table = "employee_view" Then
                    For i As Integer = 0 To gridview_name.Rows.Count - 1 Step +1
                        If gridview_name.Rows(i).Cells(7).Value.ToString = False Then
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Coral
                        Else
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Honeydew
                        End If
                    Next
                End If
                If db_table = "inventory_view" Then
                    For i As Integer = 0 To gridview_name.Rows.Count - 1 Step +1
                        If gridview_name.Rows(i).Cells(7).Value < 11 Then
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Gold
                            If gridview_name.Rows(i).Cells(7).Value < 1 Then
                                gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Coral
                            End If
                        Else
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Honeydew
                        End If
                    Next
                End If
                If db_table = "work_order_view" Then
                    For i As Integer = 0 To gridview_name.Rows.Count - 1 Step +1
                        If gridview_name.Rows(i).Cells(5).Value = "Pending Start" Then
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Silver
                            If gridview_name.Rows(i).Cells(4).Value < 8 Then
                                gridview_name.Rows(i).Cells(4).Style.BackColor = Color.Gold
                                If gridview_name.Rows(i).Cells(4).Value = 0 Then
                                    gridview_name.Rows(i).Cells(4).Style.BackColor = Color.Green
                                ElseIf gridview_name.Rows(i).Cells(4).Value < 0 Then
                                    gridview_name.Rows(i).Cells(4).Style.BackColor = Color.Coral
                                End If
                            End If
                        ElseIf gridview_name.Rows(i).Cells(5).Value = "In Progress" Then
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                            If gridview_name.Rows(i).Cells(4).Value < 8 Then
                                gridview_name.Rows(i).Cells(4).Style.BackColor = Color.Gold
                                If gridview_name.Rows(i).Cells(4).Value = 0 Then
                                    gridview_name.Rows(i).Cells(4).Style.BackColor = Color.Green
                                ElseIf gridview_name.Rows(i).Cells(4).Value < 0 Then
                                    gridview_name.Rows(i).Cells(4).Style.BackColor = Color.Coral
                                End If
                            End If
                        ElseIf gridview_name.Rows(i).Cells(5).Value = "Completed" Then
                            gridview_name.Rows(i).Cells(4).Value = 0
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Honeydew
                        ElseIf gridview_name.Rows(i).Cells(5).Value = "Terminated" Then
                            gridview_name.Rows(i).Cells(4).Value = 0
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Black
                            gridview_name.Rows(i).DefaultCellStyle.ForeColor = Color.White
                        End If
                    Next
                End If
                If db_table = "events_view" Then
                    For i As Integer = 0 To gridview_name.Rows.Count - 1 Step +1
                        If gridview_name.Rows(i).Cells(1).Value < 8 Then
                            gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Gold
                            If gridview_name.Rows(i).Cells(1).Value = 0 Then
                                gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.LightGreen
                            ElseIf gridview_name.Rows(i).Cells(1).Value < 0 Then
                                gridview_name.Rows(i).DefaultCellStyle.BackColor = Color.Coral
                            End If
                        End If
                    Next
                End If
            End If
            clear_gridview_default_selection(gridview_name)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Datagridview Color Effect Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '------------------------------------------------------------------------------------
    'FILL ALL COMBOBOXES WITH ITEMS AND FILL ALL FILTER TEXT BOXES WITH SEARCH SUGESTIONS
    '------------------------------------------------------------------------------------
    Public Sub box_collections_fill()
        Try
            'Inventory
            Management_Inventory.cmb_inventory_location_filter.Items.Clear()
            Management_Inventory.cmb_inventory_category_filter.Items.Clear()
            Management_Inventory.txt_inventory_part_name_filter.Clear()
            Management_Inventory.cmb_inventory_location_filter.Items.Add("All Locations")
            Management_Inventory.cmb_inventory_category_filter.Items.Add("All Categories")
            Management_Inventory.cmb_inventory_location_filter.SelectedIndex() = 0
            Management_Inventory.cmb_inventory_category_filter.SelectedIndex() = 0
            add_search_suggestion(Management_Inventory.txt_inventory_part_name_filter, "inventory", "Description")
            add_combobox_items(Management_Inventory.cmb_inventory_location_filter, "inventory", "Location")
            add_combobox_items(Management_Inventory.cmb_inventory_category_filter, "inventory", "Category")
            add_combobox_items(Management_Inventory_Add_New.txt_new_category, "inventory", "Category")
            'Employee
            Management_Employees.cmb_employee_position_filter.Items.Clear()
            Management_Employees.cmb_employee_position_filter.Items.Add("All Roles")
            Management_Employees.cmb_employee_position_filter.SelectedIndex() = 0
            add_search_suggestion(Management_Employees.txt_employee_name_filter, "employee_view", "Name")
            add_combobox_items(Management_Employees.cmb_employee_position_filter, "employee_view", "Role")
            add_combobox_items(Management_Employees_Add_New.txt_new_position, "employee_view", "Role")
            'work order
            Management_Work_Order.cmb_work_order_status_filter.Items.Clear()
            Management_Work_Order.cmb_work_order_status_filter.Items.Add("All")
            Management_Work_Order.cmb_work_order_status_filter.SelectedIndex() = 0
            add_search_suggestion(Management_Work_Order.txt_work_order_automobile_name_filter, "work_order_view", "ID")
            add_combobox_items(Management_Work_Order.cmb_work_order_status_filter, "work_order_view", "Progress_Status")
            'invoice
            Management_Invoice.cmb_payment_status_filter.Items.Clear()
            Management_Invoice.cmb_payment_status_filter.Items.Add("All")
            Management_Invoice.cmb_payment_status_filter.SelectedIndex = 0
            add_combobox_items(Management_Invoice.cmb_payment_status_filter, "invoice", "Payment_Status")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Box Collection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    '------------------------------------------------------------------
    'RESIZE THE COLUMNS IN THE DATAGRID TABLE BASED ON WHAT TABLE IT IS
    '------------------------------------------------------------------
    Public Sub datagrid_fill_column_resize(ByRef db_table As String, ByRef gridview_name As DataGridView)
        Try
            Select Case db_table
                Case "employee_view"
                    gridview_name.Columns(2).Width = 240   '
                    gridview_name.Columns(3).Width = 100   '
                    gridview_name.Columns(4).Width = 50    '
                    gridview_name.Columns(5).Width = 200   '
                    gridview_name.Columns(6).Width = 70    '
                    gridview_name.Columns(7).Visible = False   'Active
                Case "inventory_view"
                    gridview_name.Columns(0).Width = 50    'ID
                    gridview_name.Columns(1).Width = 100   'Category
                    gridview_name.Columns(2).Width = 170   'Part Name 
                    gridview_name.Columns(3).Width = 130   'Part Number
                    'gridview_name.Columns(4).Width = 210   'Alternative
                    gridview_name.Columns(5).Width = 110   'Location
                    gridview_name.Columns(6).Width = 200   'Model/Type
                    gridview_name.Columns(7).Width = 60   'Stock
                    gridview_name.Columns(8).Width = 80   'Unit cost
                Case "work_order_view"
                    gridview_name.Columns(0).Width = 100
                    gridview_name.Columns(1).Width = 225
                    gridview_name.Columns(2).Width = 300
                    gridview_name.Columns(3).Width = 225
                    gridview_name.Columns(4).Width = 100
                    'gridview_name.Columns(4).HeaderText = "Due In / Days"
                    gridview_name.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    gridview_name.Columns(5).Width = 135
                Case "events_view"
                    gridview_name.Columns(0).Width = 100
                    gridview_name.Columns(1).Width = 100
                    gridview_name.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    gridview_name.Columns(2).Width = 200
                    'gridview_name.Columns.(3).Width = auto
                    gridview_name.Columns(4).Visible = False
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "DataGridView Collumn Resize Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    '-----------------------------------------
    'TO CONTROL USER ACCESS TO THE APPLICATION
    '-----------------------------------------
    Public Sub Access_Control(ByRef role As String)
        With Management
            gms_main_form_loader(Management)
            .btn_dashboard_Click(Management.btn_dashboard, EventArgs.Empty)
            .login_position.Text = login_as
            .login_name.Text = login_full_name

            If role = "Administrator" Or role = "Supervisor" Or role = "Manager" Or role = "Management Engineer" Or role = "Supervising Engineer" Then

                'Give user administrative privilages
                Management_Dashboard.low_inventory_panel.Visible = True
                .btn_employees.Visible = True
                .btn_inventory.Visible = True
                .btn_statistics.Visible = True
                .btn_feedbacks.Visible = True

            Else

                'Give other user privilages 
                Management_Dashboard.low_inventory_panel.Visible = False
                .btn_employees.Visible = False
                .btn_inventory.Visible = False
                .btn_statistics.Visible = False
                .btn_feedbacks.Visible = False

            End If
            message("success", "Welcome " + login_first_name + ", you logged-in successfully")
        End With
    End Sub
    '-------------------------------------
    'CHECKING FOR INTERET CONNECTION STATE
    '-------------------------------------
    Public Function CheckForInternetConnection() As Boolean
        Try
            Return My.Computer.Network.Ping("www.google.com")
        Catch
            Return False
        End Try
    End Function
    '----------
    'SEND EMAIL
    '----------
    Public Sub send_email(ByRef subject As String, ByRef reciepint As String, ByRef message_body As String)
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
            email_delevery_status = 0
            Try
                '
                Smtp_Server.UseDefaultCredentials = False
                Smtp_Server.Credentials = New Net.NetworkCredential("allprojectstemporaryemail@gmail.com", "@Welcome98")
                Smtp_Server.Port = 587
                Smtp_Server.EnableSsl = True
                Smtp_Server.Host = "smtp.gmail.com"
                '
                e_mail = New MailMessage()
                e_mail.From = New MailAddress("allprojectstemporaryemail@gmail.com")
                e_mail.To.Add(reciepint)
                e_mail.Subject = "HTU-JMTC " + subject
                e_mail.IsBodyHtml = False
                e_mail.Body = message_body
                Smtp_Server.Send(e_mail)
                email_delevery_status = 1
            Catch ex As Exception
                MessageBox.Show(ex.Message, "SMTP Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                email_delevery_status = 0
            End Try
    End Sub
    '----------------------
    ' SEND WHATSAPP MESSAGE
    '----------------------
    Public Sub send_whatsapp(ByRef reciepint As String, ByRef message As String)
        Try
            Dim web As New WebBrowser
            web.Navigate("whatsapp://send?phone=+233" & reciepint & "&text=" & message & "")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Whatsapp Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SendKeys.Send("{ENTER}")
        End Try

    End Sub
    '-------------------------------------------------
    'ENCRIPT A USER PASSWORD FROM THE Simple3Des CLASS
    '-------------------------------------------------
    Public Function Encoding(ByRef password As String)
        Dim wrapper As New Simple3Des()
        'Return the Encrypted password
        Return wrapper.EncryptData(password)
    End Function
    '-------------------------------------------------
    'DECRIPT A USER PASSWORD FROM THE Simple3Des CLASS
    '-------------------------------------------------
    Public Function Decoding(ByRef password As String)
        Dim wrapper As New Simple3Des()
        ' Return then Decrypted Password
        Return wrapper.DecryptData(password)
    End Function
    '----------------------------------------
    'A Simple3Des ENCODING AND DECODING CLASS
    '----------------------------------------
    Public NotInheritable Class Simple3Des
        Private TripleDes As New TripleDESCryptoServiceProvider
        'a private method that creates a byte array of a specified length from the hash of the specified key.
        Private Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
            Dim sha1 As New SHA1CryptoServiceProvider

            ' Hash the key.
            Dim keyBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
            Dim hash() As Byte = sha1.ComputeHash(keyBytes)

            ' Truncate or pad the hash.
            ReDim Preserve hash(length - 1)
            Return hash
        End Function

        'constructor to initialize the 3DES cryptographic service provider.
        Sub New()
            ' Initialize the crypto provider.
            TripleDes.Key = TruncateHash("Codebot_GMS", TripleDes.KeySize \ 8)
            TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
        End Sub

        Public Function EncryptData(ByRef plaintext As String) As String

            ' Convert the plaintext string to a byte array.
            Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the encoder to write to the stream.
            Dim encStream As New CryptoStream(ms,
                TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
            encStream.FlushFinalBlock()

            ' Convert the encrypted stream to a printable string.
            Return Convert.ToBase64String(ms.ToArray)
        End Function

        Public Function DecryptData(ByRef encryptedtext As String) As String

            ' Convert the encrypted text string to a byte array.
            Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

            ' Create the stream.
            Dim ms As New System.IO.MemoryStream
            ' Create the decoder to write to the stream.
            Dim decStream As New CryptoStream(ms, TripleDes.CreateDecryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

            ' Use the crypto stream to write the byte array to the stream.
            decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
            decStream.FlushFinalBlock()

            ' Convert the plaintext stream to a string.
            Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
        End Function
    End Class
End Module
