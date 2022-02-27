<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Work_Order_Add_New_Services
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_new_services_cancel = New System.Windows.Forms.Button()
        Me.btn_new_services_save = New System.Windows.Forms.Button()
        Me.ServicesDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.ServicesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(392, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(276, 46)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "ENTER  SERVICES"
        '
        'btn_new_services_cancel
        '
        Me.btn_new_services_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_services_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_services_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_services_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_new_services_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_services_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_services_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_services_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_services_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_services_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_services_cancel.Location = New System.Drawing.Point(551, 467)
        Me.btn_new_services_cancel.Name = "btn_new_services_cancel"
        Me.btn_new_services_cancel.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_new_services_cancel.Size = New System.Drawing.Size(123, 42)
        Me.btn_new_services_cancel.TabIndex = 134
        Me.btn_new_services_cancel.Text = "CANCEL  "
        Me.btn_new_services_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_services_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_services_save
        '
        Me.btn_new_services_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_services_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_services_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_services_save.FlatAppearance.BorderSize = 0
        Me.btn_new_services_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_services_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_services_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_services_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_services_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_services_save.Location = New System.Drawing.Point(409, 467)
        Me.btn_new_services_save.Name = "btn_new_services_save"
        Me.btn_new_services_save.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_new_services_save.Size = New System.Drawing.Size(123, 42)
        Me.btn_new_services_save.TabIndex = 133
        Me.btn_new_services_save.Text = "SAVE"
        Me.btn_new_services_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_services_save.UseVisualStyleBackColor = False
        '
        'ServicesDataGridView
        '
        Me.ServicesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ServicesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ServicesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ServicesDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ServicesDataGridView.CausesValidation = False
        Me.ServicesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServicesDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ServicesDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.ServicesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ServicesDataGridView.EnableHeadersVisualStyles = False
        Me.ServicesDataGridView.GridColor = System.Drawing.Color.Silver
        Me.ServicesDataGridView.Location = New System.Drawing.Point(43, 58)
        Me.ServicesDataGridView.MultiSelect = False
        Me.ServicesDataGridView.Name = "ServicesDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServicesDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ServicesDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServicesDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ServicesDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServicesDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.ServicesDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.ServicesDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ServicesDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ServicesDataGridView.RowTemplate.Height = 38
        Me.ServicesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ServicesDataGridView.Size = New System.Drawing.Size(941, 392)
        Me.ServicesDataGridView.TabIndex = 135
        Me.ServicesDataGridView.VirtualMode = True
        '
        'Management_Work_Order_Add_New_Services
        '
        Me.AcceptButton = Me.btn_new_services_save
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.btn_new_services_cancel
        Me.ClientSize = New System.Drawing.Size(1029, 521)
        Me.Controls.Add(Me.ServicesDataGridView)
        Me.Controls.Add(Me.btn_new_services_cancel)
        Me.Controls.Add(Me.btn_new_services_save)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(280, 150)
        Me.Name = "Management_Work_Order_Add_New_Services"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Work_Order_Add_New_Services"
        CType(Me.ServicesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label12 As Label
    Friend WithEvents btn_new_services_cancel As Button
    Friend WithEvents btn_new_services_save As Button
    Friend WithEvents ServicesDataGridView As DataGridView
End Class
