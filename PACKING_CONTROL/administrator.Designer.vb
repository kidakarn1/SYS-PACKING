<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class administrator
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
        Me.TXTUSERID = New System.Windows.Forms.TextBox()
        Me.Scan_card = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.Scan_card, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTUSERID
        '
        Me.TXTUSERID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTUSERID.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.TXTUSERID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTUSERID.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.25!)
        Me.TXTUSERID.ForeColor = System.Drawing.Color.White
        Me.TXTUSERID.Location = New System.Drawing.Point(551, 382)
        Me.TXTUSERID.Name = "TXTUSERID"
        Me.TXTUSERID.Size = New System.Drawing.Size(261, 58)
        Me.TXTUSERID.TabIndex = 26
        Me.TXTUSERID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Scan_card
        '
        Me.Scan_card.BackColor = System.Drawing.Color.Transparent
        Me.Scan_card.BackgroundImage = Global.PACKING_CONTROL.My.Resources.Resources.scanstaff11
        Me.Scan_card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Scan_card.Location = New System.Drawing.Point(152, 78)
        Me.Scan_card.Name = "Scan_card"
        Me.Scan_card.Size = New System.Drawing.Size(699, 591)
        Me.Scan_card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Scan_card.TabIndex = 25
        Me.Scan_card.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PACKING_CONTROL.My.Resources.Resources.adduser11
        Me.PictureBox1.Location = New System.Drawing.Point(93, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(403, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.PACKING_CONTROL.My.Resources.Resources.viewdatarnew11
        Me.PictureBox2.Location = New System.Drawing.Point(530, 190)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(402, 488)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox3.Location = New System.Drawing.Point(813, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(124, 136)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 29
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.PACKING_CONTROL.My.Resources.Resources.deuser11
        Me.PictureBox4.Location = New System.Drawing.Point(93, 472)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(403, 219)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.PACKING_CONTROL.My.Resources.Resources.administrator4
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.TXTUSERID)
        Me.Controls.Add(Me.Scan_card)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "administrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "administrator"
        CType(Me.Scan_card, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTUSERID As TextBox
    Friend WithEvents Scan_card As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
