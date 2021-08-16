Public Class Management
    Public Sub Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Codehbot Garage Management System"
        sidebar_active(btn_home)
        sidebar_form_loader(Management_Home)
    End Sub
    Public Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Home)
    End Sub
    Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_market.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Market)
    End Sub
    Public Sub btn_work_orders_Click(sender As Object, e As EventArgs) Handles btn_work_orders.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Work_Order)
    End Sub

    Public Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        sidebar_active(sender)
    End Sub

    Public Sub btn_inventory_Click(sender As Object, e As EventArgs) Handles btn_inventory.Click
        sidebar_active(sender)
    End Sub

    Private Sub btn_purcahse_orders_Click(sender As Object, e As EventArgs) Handles btn_purcahse_orders.Click
        sidebar_active(sender)
    End Sub

    Public Sub btn_employees_Click(sender As Object, e As EventArgs) Handles btn_employees.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Employees)
        datagrid_fill("employee", Management_Employees.EmployeesDataGridView)
    End Sub

    Public Sub btn_statistics_Click(sender As Object, e As EventArgs) Handles btn_statistics.Click
        sidebar_active(sender)
    End Sub
    Private Sub btn_calenders_Click(sender As Object, e As EventArgs) Handles btn_calenders.Click
        sidebar_active(sender)
        sidebar_form_loader(Management_Calendar)
    End Sub
    Public Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        gms_main_form_loader(Auth)
        Auth_Login.txt_login_username.Clear()
        Auth_Login.txt_login_password.Clear()
        Auth_Login.txt_login_username.Focus()
        Auth.btn_auth_message.Text = "You Logged Out Successfuly"
        Auth.btn_auth_message.Show()
        message(Auth.btn_auth_message, "success")
    End Sub
    Public Sub sidebar_active(ByVal btn As Button)
        While btn.BackColor = Color.Teal
            btn_home.BackColor = Color.Teal
            btn_market.BackColor = Color.Teal
            btn_calenders.BackColor = Color.Teal
            btn_employees.BackColor = Color.Teal
            btn_inventory.BackColor = Color.Teal
            btn_purcahse_orders.BackColor = Color.Teal
            btn_work_orders.BackColor = Color.Teal
            btn_statistics.BackColor = Color.Teal
            btn_invoice.BackColor = Color.Teal
            btn.BackColor = Color.CadetBlue
            lbl_current_tab.Text = btn.Text
        End While
    End Sub
    Public Sub systemtime_Tick(sender As Object, e As EventArgs) Handles systemtime.Tick
        current_date.Text = Date.Now.ToShortDateString
        current_time.Text = TimeOfDay
    End Sub

    Private Sub btn_management_message_Click(sender As Object, e As EventArgs) Handles btn_management_message.Click
        btn_management_message.Hide()
    End Sub
End Class