﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Management_Calendar_Add_New_Event
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_new_description = New System.Windows.Forms.TextBox()
        Me.txt_new_caption = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_new_date = New System.Windows.Forms.TextBox()
        Me.btn_new_event_cancel = New System.Windows.Forms.Button()
        Me.btn_new_event_save = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Location = New System.Drawing.Point(72, 230)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 18)
        Me.Label15.TabIndex = 124
        Me.Label15.Text = "Description"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(177, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 28)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "*"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(75, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 18)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Date"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(73, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 18)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Caption / Title"
        '
        'txt_new_description
        '
        Me.txt_new_description.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_description.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_description.Location = New System.Drawing.Point(75, 251)
        Me.txt_new_description.MaxLength = 500
        Me.txt_new_description.Multiline = True
        Me.txt_new_description.Name = "txt_new_description"
        Me.txt_new_description.Size = New System.Drawing.Size(308, 119)
        Me.txt_new_description.TabIndex = 119
        '
        'txt_new_caption
        '
        Me.txt_new_caption.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_caption.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_caption.Location = New System.Drawing.Point(74, 176)
        Me.txt_new_caption.MaxLength = 25
        Me.txt_new_caption.Name = "txt_new_caption"
        Me.txt_new_caption.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_caption.TabIndex = 118
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(161, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 28)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "*"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(120, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 28)
        Me.Label3.TabIndex = 122
        Me.Label3.Text = "*"
        '
        'txt_new_date
        '
        Me.txt_new_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_new_date.Enabled = False
        Me.txt_new_date.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_new_date.Location = New System.Drawing.Point(75, 100)
        Me.txt_new_date.MaxLength = 25
        Me.txt_new_date.Name = "txt_new_date"
        Me.txt_new_date.Size = New System.Drawing.Size(308, 33)
        Me.txt_new_date.TabIndex = 118
        '
        'btn_new_event_cancel
        '
        Me.btn_new_event_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_event_cancel.BackColor = System.Drawing.Color.LightCoral
        Me.btn_new_event_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_event_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_new_event_cancel.FlatAppearance.BorderSize = 0
        Me.btn_new_event_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_event_cancel.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_event_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_new_event_cancel.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_cancel_24
        Me.btn_new_event_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_event_cancel.Location = New System.Drawing.Point(239, 391)
        Me.btn_new_event_cancel.Name = "btn_new_event_cancel"
        Me.btn_new_event_cancel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_event_cancel.Size = New System.Drawing.Size(123, 41)
        Me.btn_new_event_cancel.TabIndex = 126
        Me.btn_new_event_cancel.Text = "CANCEL"
        Me.btn_new_event_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_event_cancel.UseVisualStyleBackColor = False
        '
        'btn_new_event_save
        '
        Me.btn_new_event_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new_event_save.BackColor = System.Drawing.Color.LightGreen
        Me.btn_new_event_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new_event_save.FlatAppearance.BorderSize = 0
        Me.btn_new_event_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new_event_save.Font = New System.Drawing.Font("Ebrima", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_event_save.ForeColor = System.Drawing.Color.White
        Me.btn_new_event_save.Image = Global.Codebot_GMS.My.Resources.Resources.icons8_save_24
        Me.btn_new_event_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_new_event_save.Location = New System.Drawing.Point(95, 391)
        Me.btn_new_event_save.Name = "btn_new_event_save"
        Me.btn_new_event_save.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.btn_new_event_save.Size = New System.Drawing.Size(123, 41)
        Me.btn_new_event_save.TabIndex = 125
        Me.btn_new_event_save.Text = "SAVE"
        Me.btn_new_event_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_new_event_save.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(106, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(243, 46)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Calendar Event"
        '
        'Management_Calendar_Add_New_Event
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.CancelButton = Me.btn_new_event_cancel
        Me.ClientSize = New System.Drawing.Size(464, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_new_event_cancel)
        Me.Controls.Add(Me.btn_new_event_save)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_new_description)
        Me.Controls.Add(Me.txt_new_date)
        Me.Controls.Add(Me.txt_new_caption)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(550, 220)
        Me.Name = "Management_Calendar_Add_New_Event"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Management_Calendar_Add_New_Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_new_description As TextBox
    Friend WithEvents txt_new_caption As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_new_event_cancel As Button
    Friend WithEvents btn_new_event_save As Button
    Friend WithEvents txt_new_date As TextBox
    Friend WithEvents Label4 As Label
End Class
