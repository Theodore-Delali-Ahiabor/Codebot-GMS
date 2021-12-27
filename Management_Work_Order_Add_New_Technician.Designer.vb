<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Work_Order_Add_New_Technician
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
        Me.TechnicianDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_technician_select_select = New System.Windows.Forms.Button()
        Me.btn_technician_select_cancel = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.TechnicianDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TechnicianDataGridView
        '
        Me.TechnicianDataGridView.AllowUserToAddRows = False
        Me.TechnicianDataGridView.AllowUserToDeleteRows = False
        Me.TechnicianDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TechnicianDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TechnicianDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.TechnicianDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.TechnicianDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.TechnicianDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TechnicianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TechnicianDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.TechnicianDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TechnicianDataGridView.EnableHeadersVisualStyles = False
        Me.TechnicianDataGridView.GridColor = System.Drawing.Color.Silver
        Me.TechnicianDataGridView.Location = New System.Drawing.Point(48, 95)
        Me.TechnicianDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TechnicianDataGridView.Name = "TechnicianDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TechnicianDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.RowTemplate.Height = 38
        Me.TechnicianDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TechnicianDataGridView.Size = New System.Drawing.Size(936, 353)
        Me.TechnicianDataGridView.TabIndex = 36
        Me.TechnicianDataGridView.VirtualMode = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(44, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(486, 21)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "-Press and Hold Ctr on your keyboard to perform Multiple Selections"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(45, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "HINT"
        '
        'btn_technician_select_select
        '
        Me.btn_technician_select_select.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_technician_select_select.BackColor = System.Drawing.Color.LightGreen
        Me.btn_technician_select_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_technician_select_select.FlatAppearance.BorderSize = 0
        Me.btn_technician_select_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_technician_select_select.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_technician_select_select.ForeColor = System.Drawing.Color.White
        Me.btn_technician_select_select.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_checkmark_24
        Me.btn_technician_select_select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_technician_select_select.Location = New System.Drawing.Point(393, 470)
        Me.btn_technician_select_select.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_technician_select_select.Name = "btn_technician_select_select"
        Me.btn_technician_select_select.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_technician_select_select.Size = New System.Drawing.Size(113, 38)
        Me.btn_technician_select_select.TabIndex = 38
        Me.btn_technician_select_select.Text = "SELECT"
        Me.btn_technician_select_select.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_technician_select_select.UseVisualStyleBackColor = False
        '
        'btn_technician_select_cancel
        '
        Me.btn_technician_select_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_technician_select_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_technician_select_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_technician_select_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_technician_select_cancel.FlatAppearance.BorderSize = 0
        Me.btn_technician_select_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_technician_select_cancel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_technician_select_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_technician_select_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_technician_select_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_technician_select_cancel.Location = New System.Drawing.Point(532, 470)
        Me.btn_technician_select_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_technician_select_cancel.Name = "btn_technician_select_cancel"
        Me.btn_technician_select_cancel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_technician_select_cancel.Size = New System.Drawing.Size(128, 38)
        Me.btn_technician_select_cancel.TabIndex = 39
        Me.btn_technician_select_cancel.Text = "CANCEL"
        Me.btn_technician_select_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_technician_select_cancel.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Ink Free", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(335, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(380, 49)
        Me.Label12.TabIndex = 131
        Me.Label12.Text = "Select Technician(s)"
        '
        'Management_Work_Order_Add_New_Technician
        '
        Me.AcceptButton = Me.btn_technician_select_select
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.btn_technician_select_cancel
        Me.ClientSize = New System.Drawing.Size(1029, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_technician_select_select)
        Me.Controls.Add(Me.btn_technician_select_cancel)
        Me.Controls.Add(Me.TechnicianDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(280, 150)
        Me.Name = "Management_Work_Order_Add_New_Technician"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Work_Order_Add_New_Technician"
        Me.TopMost = True
        CType(Me.TechnicianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_technician_select_select As Button
    Friend WithEvents btn_technician_select_cancel As Button
    Friend WithEvents TechnicianDataGridView As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
End Class
