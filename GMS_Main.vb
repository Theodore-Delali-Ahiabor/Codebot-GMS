Public Class GMS_Main
    Private Sub GMS_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql_da = New MySqlDataAdapter("SELECT * FROM `service_center` WHERE ID = '" & 1 & "'", sql_con)
        sql_dt = New DataTable
        sql_dt.Clear()
        sql_da.Fill(sql_dt)
        If sql_dt.Rows.Count() > 0 Then
            gms_main_form_loader(Auth)
        Else
            Management_Service_Center.btn_save.Text = "SAVE"
            Management_Service_Center.ShowDialog()
        End If

    End Sub
End Class