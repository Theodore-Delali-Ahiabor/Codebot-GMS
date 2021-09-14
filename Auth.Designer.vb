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
        Me.components = New System.ComponentModel.Container()
        Me.auth_left_panel = New System.Windows.Forms.Panel()
        Me.btn_auth_message = New System.Windows.Forms.Button()
        Me.auth_right_panel = New System.Windows.Forms.Panel()
        Me.Left_Panel_Main = New System.Windows.Forms.Panel()
        Me.message_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Left_Panel_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'auth_left_panel
        '
        Me.auth_left_panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.auth_left_panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.auth_left_panel.Location = New System.Drawing.Point(0, 47)
        Me.auth_left_panel.Name = "auth_left_panel"
        Me.auth_left_panel.Size = New System.Drawing.Size(475, 672)
        Me.auth_left_panel.TabIndex = 8
        '
        'btn_auth_message
        '
        Me.btn_auth_message.AutoSize = True
        Me.btn_auth_message.BackColor = System.Drawing.Color.LightCoral
        Me.btn_auth_message.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_auth_message.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_auth_message.FlatAppearance.BorderSize = 0
        Me.btn_auth_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_auth_message.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_auth_message.ForeColor = System.Drawing.Color.Snow
        Me.btn_auth_message.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_auth_message.Location = New System.Drawing.Point(0, 0)
        Me.btn_auth_message.Name = "btn_auth_message"
        Me.btn_auth_message.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btn_auth_message.Size = New System.Drawing.Size(472, 47)
        Me.btn_auth_message.TabIndex = 7
        Me.btn_auth_message.TabStop = False
        Me.btn_auth_message.UseVisualStyleBackColor = False
        Me.btn_auth_message.Visible = False
        '
        'auth_right_panel
        '
        Me.auth_right_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.auth_right_panel.BackgroundImage = Global.Codebot_GMS.My.Resources.Resources.smiling_mechanic_with_arms_crossed_spanner
        Me.auth_right_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.auth_right_panel.Location = New System.Drawing.Point(471, 0)
        Me.auth_right_panel.Name = "auth_right_panel"
        Me.auth_right_panel.Size = New System.Drawing.Size(879, 719)
        Me.auth_right_panel.TabIndex = 9
        '
        'Left_Panel_Main
        '
        Me.Left_Panel_Main.Controls.Add(Me.auth_left_panel)
        Me.Left_Panel_Main.Controls.Add(Me.btn_auth_message)
        Me.Left_Panel_Main.Dock = System.Windows.Forms.DockStyle.Left
        Me.Left_Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Left_Panel_Main.Name = "Left_Panel_Main"
        Me.Left_Panel_Main.Size = New System.Drawing.Size(472, 719)
        Me.Left_Panel_Main.TabIndex = 10
        '
        'message_timer
        '
        Me.message_timer.Interval = 1000
        '
        'Auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1350, 719)
        Me.Controls.Add(Me.Left_Panel_Main)
        Me.Controls.Add(Me.auth_right_panel)
        Me.Name = "Auth"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auth"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Left_Panel_Main.ResumeLayout(False)
        Me.Left_Panel_Main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents auth_left_panel As Panel
    Friend WithEvents auth_right_panel As Panel
    Friend WithEvents Left_Panel_Main As Panel
    Friend WithEvents message_timer As Timer
    Public WithEvents btn_auth_message As Button
End Class
