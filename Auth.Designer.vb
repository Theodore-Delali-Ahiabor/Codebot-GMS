﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Auth))
        Me.auth_left_panel = New System.Windows.Forms.Panel()
        Me.btn_message = New System.Windows.Forms.Button()
        Me.auth_message_timer = New System.Windows.Forms.Timer(Me.components)
        Me.auth_right_panel = New System.Windows.Forms.Panel()
        Me.Left_Panel_Main = New System.Windows.Forms.Panel()
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
        'btn_message
        '
        Me.btn_message.AutoSize = True
        Me.btn_message.BackColor = System.Drawing.Color.LightCoral
        Me.btn_message.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_message.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_message.FlatAppearance.BorderSize = 0
        Me.btn_message.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_message.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_message.ForeColor = System.Drawing.Color.Snow
        Me.btn_message.Location = New System.Drawing.Point(0, 0)
        Me.btn_message.Name = "btn_message"
        Me.btn_message.Size = New System.Drawing.Size(472, 47)
        Me.btn_message.TabIndex = 7
        Me.btn_message.TabStop = False
        Me.btn_message.UseVisualStyleBackColor = False
        Me.btn_message.Visible = False
        '
        'auth_message_timer
        '
        Me.auth_message_timer.Interval = 1000
        '
        'auth_right_panel
        '
        Me.auth_right_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.auth_right_panel.BackgroundImage = CType(resources.GetObject("auth_right_panel.BackgroundImage"), System.Drawing.Image)
        Me.auth_right_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.auth_right_panel.Location = New System.Drawing.Point(471, 0)
        Me.auth_right_panel.Name = "auth_right_panel"
        Me.auth_right_panel.Size = New System.Drawing.Size(879, 719)
        Me.auth_right_panel.TabIndex = 9
        '
        'Left_Panel_Main
        '
        Me.Left_Panel_Main.Controls.Add(Me.auth_left_panel)
        Me.Left_Panel_Main.Controls.Add(Me.btn_message)
        Me.Left_Panel_Main.Dock = System.Windows.Forms.DockStyle.Left
        Me.Left_Panel_Main.Location = New System.Drawing.Point(0, 0)
        Me.Left_Panel_Main.Name = "Left_Panel_Main"
        Me.Left_Panel_Main.Size = New System.Drawing.Size(472, 719)
        Me.Left_Panel_Main.TabIndex = 10
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
    Friend WithEvents btn_message As Button
    Friend WithEvents auth_message_timer As Timer
    Friend WithEvents auth_right_panel As Panel
    Friend WithEvents Left_Panel_Main As Panel
End Class