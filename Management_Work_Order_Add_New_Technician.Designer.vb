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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TechnicianDataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_technician_select_select = New System.Windows.Forms.Button()
        Me.btn_technician_select_cancel = New System.Windows.Forms.Button()
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.TechnicianDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TechnicianDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.TechnicianDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.TechnicianDataGridView.EnableHeadersVisualStyles = False
        Me.TechnicianDataGridView.GridColor = System.Drawing.Color.Silver
        Me.TechnicianDataGridView.Location = New System.Drawing.Point(48, 46)
        Me.TechnicianDataGridView.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TechnicianDataGridView.Name = "TechnicianDataGridView"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.TechnicianDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.TechnicianDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TechnicianDataGridView.RowTemplate.Height = 38
        Me.TechnicianDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TechnicianDataGridView.Size = New System.Drawing.Size(936, 386)
        Me.TechnicianDataGridView.TabIndex = 36
        Me.TechnicianDataGridView.VirtualMode = True
        '
        'btn_technician_select_select
        '
        Me.btn_technician_select_select.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_technician_select_select.BackColor = System.Drawing.Color.LightGreen
        Me.btn_technician_select_select.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_technician_select_select.FlatAppearance.BorderSize = 0
        Me.btn_technician_select_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_technician_select_select.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_technician_select_select.ForeColor = System.Drawing.Color.White
        Me.btn_technician_select_select.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_checkmark_24
        Me.btn_technician_select_select.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_technician_select_select.Location = New System.Drawing.Point(348, 459)
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
        Me.btn_technician_select_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_technician_select_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_technician_select_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_technician_select_cancel.FlatAppearance.BorderSize = 0
        Me.btn_technician_select_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_technician_select_cancel.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_technician_select_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_technician_select_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_technician_select_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_technician_select_cancel.Location = New System.Drawing.Point(487, 459)
        Me.btn_technician_select_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_technician_select_cancel.Name = "btn_technician_select_cancel"
        Me.btn_technician_select_cancel.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_technician_select_cancel.Size = New System.Drawing.Size(128, 38)
        Me.btn_technician_select_cancel.TabIndex = 39
        Me.btn_technician_select_cancel.Text = "CANCEL"
        Me.btn_technician_select_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_technician_select_cancel.UseVisualStyleBackColor = False
        '
        'Management_Work_Order_Add_New_Technician
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 521)
        Me.Controls.Add(Me.btn_technician_select_select)
        Me.Controls.Add(Me.btn_technician_select_cancel)
        Me.Controls.Add(Me.TechnicianDataGridView)
        Me.Location = New System.Drawing.Point(280, 150)
        Me.Name = "Management_Work_Order_Add_New_Technician"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Work_Order_Add_New_Technician"
        Me.TopMost = True
        CType(Me.TechnicianDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_technician_select_select As Button
    Friend WithEvents btn_technician_select_cancel As Button
    Friend WithEvents TechnicianDataGridView As DataGridView
End Class
