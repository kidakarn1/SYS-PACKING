<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setting
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmd_line = New System.Windows.Forms.ComboBox()
        Me.cmd_sub_line = New System.Windows.Forms.ComboBox()
        Me.LBLINE_CD = New System.Windows.Forms.Label()
        Me.LBSUBLINE = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.PACKING_CONTROL.My.Resources.Resources.back_reprint1
        Me.Button3.Location = New System.Drawing.Point(48, 583)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 149)
        Me.Button3.TabIndex = 21
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.PACKING_CONTROL.My.Resources.Resources.save1
        Me.Button1.Location = New System.Drawing.Point(48, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 149)
        Me.Button1.TabIndex = 22
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmd_line
        '
        Me.cmd_line.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.cmd_line.FormattingEnabled = True
        Me.cmd_line.Location = New System.Drawing.Point(589, 35)
        Me.cmd_line.Name = "cmd_line"
        Me.cmd_line.Size = New System.Drawing.Size(397, 69)
        Me.cmd_line.TabIndex = 23
        '
        'cmd_sub_line
        '
        Me.cmd_sub_line.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.cmd_sub_line.FormattingEnabled = True
        Me.cmd_sub_line.Location = New System.Drawing.Point(589, 129)
        Me.cmd_sub_line.Name = "cmd_sub_line"
        Me.cmd_sub_line.Size = New System.Drawing.Size(397, 69)
        Me.cmd_sub_line.TabIndex = 24
        '
        'LBLINE_CD
        '
        Me.LBLINE_CD.AutoSize = True
        Me.LBLINE_CD.BackColor = System.Drawing.Color.Transparent
        Me.LBLINE_CD.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBLINE_CD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBLINE_CD.Location = New System.Drawing.Point(404, 399)
        Me.LBLINE_CD.Name = "LBLINE_CD"
        Me.LBLINE_CD.Size = New System.Drawing.Size(149, 29)
        Me.LBLINE_CD.TabIndex = 25
        Me.LBLINE_CD.Text = "XXXXXXXX"
        '
        'LBSUBLINE
        '
        Me.LBSUBLINE.AutoSize = True
        Me.LBSUBLINE.BackColor = System.Drawing.Color.Transparent
        Me.LBSUBLINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBSUBLINE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBSUBLINE.Location = New System.Drawing.Point(404, 561)
        Me.LBSUBLINE.Name = "LBSUBLINE"
        Me.LBSUBLINE.Size = New System.Drawing.Size(149, 29)
        Me.LBSUBLINE.TabIndex = 26
        Me.LBSUBLINE.Text = "XXXXXXXX"
        '
        'setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BackgroundImage = Global.PACKING_CONTROL.My.Resources.Resources.settine_page
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.LBSUBLINE)
        Me.Controls.Add(Me.LBLINE_CD)
        Me.Controls.Add(Me.cmd_sub_line)
        Me.Controls.Add(Me.cmd_line)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "setting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmd_line As ComboBox
    Friend WithEvents cmd_sub_line As ComboBox
    Friend WithEvents LBLINE_CD As Label
    Friend WithEvents LBSUBLINE As Label
End Class
