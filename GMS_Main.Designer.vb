<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMS_Main
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
        Me.GMS_Main_panel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'GMS_Main_panel
        '
        Me.GMS_Main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GMS_Main_panel.Location = New System.Drawing.Point(0, 0)
        Me.GMS_Main_panel.Name = "GMS_Main_panel"
        Me.GMS_Main_panel.Size = New System.Drawing.Size(1350, 719)
        Me.GMS_Main_panel.TabIndex = 0
        '
        'GMS_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1350, 719)
        Me.Controls.Add(Me.GMS_Main_panel)
        Me.Name = "GMS_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GMS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GMS_Main_panel As Panel
End Class
