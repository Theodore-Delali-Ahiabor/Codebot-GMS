<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Me.btn_save_img = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_retrieve_img = New System.Windows.Forms.Button()
        Me.btn_browse_img = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save_img
        '
        Me.btn_save_img.Location = New System.Drawing.Point(51, 266)
        Me.btn_save_img.Name = "btn_save_img"
        Me.btn_save_img.Size = New System.Drawing.Size(135, 37)
        Me.btn_save_img.TabIndex = 0
        Me.btn_save_img.Text = "Save"
        Me.btn_save_img.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(51, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(227, 206)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btn_retrieve_img
        '
        Me.btn_retrieve_img.Location = New System.Drawing.Point(223, 266)
        Me.btn_retrieve_img.Name = "btn_retrieve_img"
        Me.btn_retrieve_img.Size = New System.Drawing.Size(135, 37)
        Me.btn_retrieve_img.TabIndex = 0
        Me.btn_retrieve_img.Text = "Retrieev"
        Me.btn_retrieve_img.UseVisualStyleBackColor = True
        '
        'btn_browse_img
        '
        Me.btn_browse_img.Location = New System.Drawing.Point(364, 266)
        Me.btn_browse_img.Name = "btn_browse_img"
        Me.btn_browse_img.Size = New System.Drawing.Size(135, 37)
        Me.btn_browse_img.TabIndex = 0
        Me.btn_browse_img.Text = "Browse"
        Me.btn_browse_img.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(322, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(299, 206)
        Me.DataGridView1.TabIndex = 2
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 339)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_browse_img)
        Me.Controls.Add(Me.btn_retrieve_img)
        Me.Controls.Add(Me.btn_save_img)
        Me.Name = "Test"
        Me.Text = "Test"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_save_img As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_retrieve_img As Button
    Friend WithEvents btn_browse_img As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
