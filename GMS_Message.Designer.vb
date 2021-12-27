<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GMS_Message
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
        Me.message_text = New System.Windows.Forms.RichTextBox()
        Me.message_warning_icon = New System.Windows.Forms.PictureBox()
        Me.message_information_icon = New System.Windows.Forms.PictureBox()
        Me.message_error_icon = New System.Windows.Forms.PictureBox()
        Me.message_success_icon = New System.Windows.Forms.PictureBox()
        Me.message_icon = New System.Windows.Forms.PictureBox()
        Me.message_timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.message_warning_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.message_information_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.message_error_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.message_success_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.message_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'message_text
        '
        Me.message_text.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.message_text.BackColor = System.Drawing.SystemColors.Control
        Me.message_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.message_text.Cursor = System.Windows.Forms.Cursors.Hand
        Me.message_text.Font = New System.Drawing.Font("Ebrima", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_text.HideSelection = False
        Me.message_text.Location = New System.Drawing.Point(82, 20)
        Me.message_text.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.message_text.Name = "message_text"
        Me.message_text.ReadOnly = True
        Me.message_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.message_text.ShortcutsEnabled = False
        Me.message_text.Size = New System.Drawing.Size(342, 48)
        Me.message_text.TabIndex = 2
        Me.message_text.TabStop = False
        Me.message_text.Text = ""
        '
        'message_warning_icon
        '
        Me.message_warning_icon.Image = Global.Codebot_GMS.My.Resources.Resources.warning_shield_48px
        Me.message_warning_icon.Location = New System.Drawing.Point(223, 77)
        Me.message_warning_icon.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.message_warning_icon.Name = "message_warning_icon"
        Me.message_warning_icon.Size = New System.Drawing.Size(33, 11)
        Me.message_warning_icon.TabIndex = 0
        Me.message_warning_icon.TabStop = False
        Me.message_warning_icon.Visible = False
        '
        'message_information_icon
        '
        Me.message_information_icon.Image = Global.Codebot_GMS.My.Resources.Resources.information_48px
        Me.message_information_icon.Location = New System.Drawing.Point(176, 77)
        Me.message_information_icon.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.message_information_icon.Name = "message_information_icon"
        Me.message_information_icon.Size = New System.Drawing.Size(33, 11)
        Me.message_information_icon.TabIndex = 0
        Me.message_information_icon.TabStop = False
        Me.message_information_icon.Visible = False
        '
        'message_error_icon
        '
        Me.message_error_icon.Image = Global.Codebot_GMS.My.Resources.Resources.error_48px
        Me.message_error_icon.Location = New System.Drawing.Point(129, 77)
        Me.message_error_icon.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.message_error_icon.Name = "message_error_icon"
        Me.message_error_icon.Size = New System.Drawing.Size(33, 11)
        Me.message_error_icon.TabIndex = 0
        Me.message_error_icon.TabStop = False
        Me.message_error_icon.Visible = False
        '
        'message_success_icon
        '
        Me.message_success_icon.Image = Global.Codebot_GMS.My.Resources.Resources.checked_48px
        Me.message_success_icon.Location = New System.Drawing.Point(82, 77)
        Me.message_success_icon.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.message_success_icon.Name = "message_success_icon"
        Me.message_success_icon.Size = New System.Drawing.Size(33, 11)
        Me.message_success_icon.TabIndex = 0
        Me.message_success_icon.TabStop = False
        Me.message_success_icon.Visible = False
        '
        'message_icon
        '
        Me.message_icon.Location = New System.Drawing.Point(20, 20)
        Me.message_icon.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.message_icon.Name = "message_icon"
        Me.message_icon.Size = New System.Drawing.Size(48, 48)
        Me.message_icon.TabIndex = 0
        Me.message_icon.TabStop = False
        '
        'message_timer
        '
        Me.message_timer.Interval = 1000
        '
        'GMS_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 88)
        Me.ControlBox = False
        Me.Controls.Add(Me.message_text)
        Me.Controls.Add(Me.message_warning_icon)
        Me.Controls.Add(Me.message_information_icon)
        Me.Controls.Add(Me.message_error_icon)
        Me.Controls.Add(Me.message_success_icon)
        Me.Controls.Add(Me.message_icon)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Copperplate Gothic Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(500, 10)
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Name = "GMS_Message"
        Me.Opacity = 0.9R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Message"
        Me.TopMost = True
        CType(Me.message_warning_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.message_information_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.message_error_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.message_success_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.message_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents message_icon As PictureBox
    Friend WithEvents message_text As RichTextBox
    Friend WithEvents message_success_icon As PictureBox
    Friend WithEvents message_error_icon As PictureBox
    Friend WithEvents message_information_icon As PictureBox
    Friend WithEvents message_warning_icon As PictureBox
    Friend WithEvents message_timer As Timer
End Class
