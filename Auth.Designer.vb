<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Auth
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.auth_right_panel = New System.Windows.Forms.Panel()
        Me.auth_left_panel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'auth_right_panel
        '
        Me.auth_right_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.auth_right_panel.BackgroundImage = Global.Codebot_GMS.My.Resources.Resources.smiling_mechanic_with_arms_crossed_spanner_edit
        Me.auth_right_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.auth_right_panel.Location = New System.Drawing.Point(474, 0)
        Me.auth_right_panel.Name = "auth_right_panel"
        Me.auth_right_panel.Size = New System.Drawing.Size(880, 719)
        Me.auth_right_panel.TabIndex = 9
        '
        'auth_left_panel
        '
        Me.auth_left_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.auth_left_panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.auth_left_panel.Location = New System.Drawing.Point(-1, 0)
        Me.auth_left_panel.Name = "auth_left_panel"
        Me.auth_left_panel.Size = New System.Drawing.Size(480, 719)
        Me.auth_left_panel.TabIndex = 8
        '
        'Auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1350, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.auth_left_panel)
        Me.Controls.Add(Me.auth_right_panel)
        Me.Name = "Auth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auth"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents auth_right_panel As Panel
    Friend WithEvents auth_left_panel As Panel
End Class
