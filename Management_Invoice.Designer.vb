﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management_Invoice))
        Me.cmb_payment_status_filter = New System.Windows.Forms.ComboBox()
        Me.txt_invoice_id_filter = New System.Windows.Forms.TextBox()
        Me.InvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_terminate_work_order = New System.Windows.Forms.Button()
        Me.btn_complete_work_order = New System.Windows.Forms.Button()
        Me.btn_start_work_order = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_add_new_invoice = New System.Windows.Forms.Button()
        CType(Me.InvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_payment_status_filter
        '
        Me.cmb_payment_status_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_payment_status_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_payment_status_filter.FormattingEnabled = True
        Me.cmb_payment_status_filter.Location = New System.Drawing.Point(865, 32)
        Me.cmb_payment_status_filter.Margin = New System.Windows.Forms.Padding(10)
        Me.cmb_payment_status_filter.Name = "cmb_payment_status_filter"
        Me.cmb_payment_status_filter.Size = New System.Drawing.Size(222, 29)
        Me.cmb_payment_status_filter.TabIndex = 66
        '
        'txt_invoice_id_filter
        '
        Me.txt_invoice_id_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_invoice_id_filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_invoice_id_filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_invoice_id_filter.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice_id_filter.Location = New System.Drawing.Point(630, 32)
        Me.txt_invoice_id_filter.Name = "txt_invoice_id_filter"
        Me.txt_invoice_id_filter.Size = New System.Drawing.Size(222, 29)
        Me.txt_invoice_id_filter.TabIndex = 68
        '
        'InvoiceDataGridView
        '
        Me.InvoiceDataGridView.AllowUserToAddRows = False
        Me.InvoiceDataGridView.AllowUserToDeleteRows = False
        Me.InvoiceDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvoiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.InvoiceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.InvoiceDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.InvoiceDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.InvoiceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.InvoiceDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.InvoiceDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.InvoiceDataGridView.EnableHeadersVisualStyles = False
        Me.InvoiceDataGridView.GridColor = System.Drawing.Color.Silver
        Me.InvoiceDataGridView.Location = New System.Drawing.Point(14, 75)
        Me.InvoiceDataGridView.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.InvoiceDataGridView.MultiSelect = False
        Me.InvoiceDataGridView.Name = "InvoiceDataGridView"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ebrima", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.InvoiceDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.InvoiceDataGridView.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvoiceDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.InvoiceDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.InvoiceDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.InvoiceDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.InvoiceDataGridView.RowTemplate.Height = 38
        Me.InvoiceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InvoiceDataGridView.Size = New System.Drawing.Size(1073, 417)
        Me.InvoiceDataGridView.TabIndex = 64
        '
        'btn_terminate_work_order
        '
        Me.btn_terminate_work_order.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_terminate_work_order.BackColor = System.Drawing.Color.Black
        Me.btn_terminate_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_terminate_work_order.FlatAppearance.BorderSize = 0
        Me.btn_terminate_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_terminate_work_order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_terminate_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_terminate_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_terminate_work_order.Location = New System.Drawing.Point(288, 505)
        Me.btn_terminate_work_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_terminate_work_order.Name = "btn_terminate_work_order"
        Me.btn_terminate_work_order.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.btn_terminate_work_order.Size = New System.Drawing.Size(138, 46)
        Me.btn_terminate_work_order.TabIndex = 72
        Me.btn_terminate_work_order.Text = "TERMINATE"
        Me.btn_terminate_work_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_terminate_work_order.UseVisualStyleBackColor = False
        '
        'btn_complete_work_order
        '
        Me.btn_complete_work_order.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_complete_work_order.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_complete_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_complete_work_order.FlatAppearance.BorderSize = 0
        Me.btn_complete_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_complete_work_order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_complete_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_complete_work_order.Image = CType(resources.GetObject("btn_complete_work_order.Image"), System.Drawing.Image)
        Me.btn_complete_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_complete_work_order.Location = New System.Drawing.Point(126, 505)
        Me.btn_complete_work_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_complete_work_order.Name = "btn_complete_work_order"
        Me.btn_complete_work_order.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_complete_work_order.Size = New System.Drawing.Size(138, 46)
        Me.btn_complete_work_order.TabIndex = 71
        Me.btn_complete_work_order.Text = "COMPLETE"
        Me.btn_complete_work_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_complete_work_order.UseVisualStyleBackColor = False
        '
        'btn_start_work_order
        '
        Me.btn_start_work_order.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_start_work_order.BackColor = System.Drawing.Color.LightGreen
        Me.btn_start_work_order.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_start_work_order.FlatAppearance.BorderSize = 0
        Me.btn_start_work_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start_work_order.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start_work_order.ForeColor = System.Drawing.Color.White
        Me.btn_start_work_order.Image = CType(resources.GetObject("btn_start_work_order.Image"), System.Drawing.Image)
        Me.btn_start_work_order.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_start_work_order.Location = New System.Drawing.Point(14, 505)
        Me.btn_start_work_order.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_start_work_order.Name = "btn_start_work_order"
        Me.btn_start_work_order.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.btn_start_work_order.Size = New System.Drawing.Size(96, 46)
        Me.btn_start_work_order.TabIndex = 70
        Me.btn_start_work_order.Text = "PAYED"
        Me.btn_start_work_order.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_start_work_order.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_search_80
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label3.Location = New System.Drawing.Point(627, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5)
        Me.Label3.Size = New System.Drawing.Size(131, 27)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Invoice ID       "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(862, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(183, 27)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Payment Status       "
        '
        'btn_add_new_invoice
        '
        Me.btn_add_new_invoice.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_add_new_invoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add_new_invoice.FlatAppearance.BorderSize = 0
        Me.btn_add_new_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_new_invoice.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_new_invoice.ForeColor = System.Drawing.Color.White
        Me.btn_add_new_invoice.Image = CType(resources.GetObject("btn_add_new_invoice.Image"), System.Drawing.Image)
        Me.btn_add_new_invoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_add_new_invoice.Location = New System.Drawing.Point(12, 12)
        Me.btn_add_new_invoice.Name = "btn_add_new_invoice"
        Me.btn_add_new_invoice.Padding = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.btn_add_new_invoice.Size = New System.Drawing.Size(105, 41)
        Me.btn_add_new_invoice.TabIndex = 65
        Me.btn_add_new_invoice.Text = "    New"
        Me.btn_add_new_invoice.UseVisualStyleBackColor = False
        '
        'Management_Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1101, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_terminate_work_order)
        Me.Controls.Add(Me.btn_complete_work_order)
        Me.Controls.Add(Me.btn_start_work_order)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_payment_status_filter)
        Me.Controls.Add(Me.btn_add_new_invoice)
        Me.Controls.Add(Me.txt_invoice_id_filter)
        Me.Controls.Add(Me.InvoiceDataGridView)
        Me.Name = "Management_Invoice"
        Me.Text = "Management_Invoice"
        CType(Me.InvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_payment_status_filter As ComboBox
    Friend WithEvents btn_add_new_invoice As Button
    Friend WithEvents txt_invoice_id_filter As TextBox
    Friend WithEvents InvoiceDataGridView As DataGridView
    Friend WithEvents btn_complete_work_order As Button
    Friend WithEvents btn_start_work_order As Button
    Friend WithEvents btn_terminate_work_order As Button
End Class
