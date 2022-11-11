<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class select_plan
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
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LBPD = New System.Windows.Forms.Label()
        Me.LBIT = New System.Windows.Forms.Label()
        Me.LBPQ = New System.Windows.Forms.Label()
        Me.LBWI = New System.Windows.Forms.Label()
        Me.LBDATE = New System.Windows.Forms.Label()
        Me.LBMD = New System.Windows.Forms.Label()
        Me.LBAC = New System.Windows.Forms.Label()
        Me.LBRM = New System.Windows.Forms.Label()
        Me.NSTAFF = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListView_material = New System.Windows.Forms.ListView()
        Me.ITEM_CD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.QTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Use_QTY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel_scan_picking = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.scan_item_cd = New System.Windows.Forms.TextBox()
        Me.hide_supply_tag = New System.Windows.Forms.ListView()
        Me.sub_line = New System.Windows.Forms.Label()
        Me.line = New System.Windows.Forms.Label()
        Me.LB_SUB_LINE = New System.Windows.Forms.Label()
        Me.LB_LINE = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_scan_picking.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.PACKING_CONTROL.My.Resources.Resources.backplanlist
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.PACKING_CONTROL.My.Resources.Resources.backplanlist1
        Me.Button2.Location = New System.Drawing.Point(-11, 649)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 112)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGreen
        Me.Button1.BackgroundImage = Global.PACKING_CONTROL.My.Resources.Resources.nextplanlist
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(812, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 112)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LBPD
        '
        Me.LBPD.AutoSize = True
        Me.LBPD.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBPD.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBPD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBPD.Location = New System.Drawing.Point(55, 259)
        Me.LBPD.Name = "LBPD"
        Me.LBPD.Size = New System.Drawing.Size(115, 29)
        Me.LBPD.TabIndex = 10
        Me.LBPD.Text = "XXXXXX"
        '
        'LBIT
        '
        Me.LBIT.AutoSize = True
        Me.LBIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBIT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBIT.Location = New System.Drawing.Point(55, 370)
        Me.LBIT.Name = "LBIT"
        Me.LBIT.Size = New System.Drawing.Size(115, 29)
        Me.LBIT.TabIndex = 11
        Me.LBIT.Text = "XXXXXX"
        '
        'LBPQ
        '
        Me.LBPQ.AutoSize = True
        Me.LBPQ.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBPQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBPQ.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBPQ.Location = New System.Drawing.Point(444, 370)
        Me.LBPQ.Name = "LBPQ"
        Me.LBPQ.Size = New System.Drawing.Size(115, 29)
        Me.LBPQ.TabIndex = 12
        Me.LBPQ.Text = "XXXXXX"
        '
        'LBWI
        '
        Me.LBWI.AutoSize = True
        Me.LBWI.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBWI.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBWI.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBWI.Location = New System.Drawing.Point(55, 593)
        Me.LBWI.Name = "LBWI"
        Me.LBWI.Size = New System.Drawing.Size(115, 29)
        Me.LBWI.TabIndex = 13
        Me.LBWI.Text = "XXXXXX"
        '
        'LBDATE
        '
        Me.LBDATE.AutoSize = True
        Me.LBDATE.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBDATE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBDATE.Location = New System.Drawing.Point(444, 256)
        Me.LBDATE.Name = "LBDATE"
        Me.LBDATE.Size = New System.Drawing.Size(115, 29)
        Me.LBDATE.TabIndex = 14
        Me.LBDATE.Text = "XXXXXX"
        '
        'LBMD
        '
        Me.LBMD.AutoSize = True
        Me.LBMD.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBMD.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBMD.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBMD.Location = New System.Drawing.Point(55, 478)
        Me.LBMD.Name = "LBMD"
        Me.LBMD.Size = New System.Drawing.Size(115, 29)
        Me.LBMD.TabIndex = 15
        Me.LBMD.Text = "XXXXXX"
        '
        'LBAC
        '
        Me.LBAC.AutoSize = True
        Me.LBAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBAC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBAC.Location = New System.Drawing.Point(444, 478)
        Me.LBAC.Name = "LBAC"
        Me.LBAC.Size = New System.Drawing.Size(115, 29)
        Me.LBAC.TabIndex = 16
        Me.LBAC.Text = "XXXXXX"
        '
        'LBRM
        '
        Me.LBRM.AutoSize = True
        Me.LBRM.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.LBRM.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LBRM.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBRM.Location = New System.Drawing.Point(444, 590)
        Me.LBRM.Name = "LBRM"
        Me.LBRM.Size = New System.Drawing.Size(115, 29)
        Me.LBRM.TabIndex = 17
        Me.LBRM.Text = "XXXXXX"
        '
        'NSTAFF
        '
        Me.NSTAFF.AutoSize = True
        Me.NSTAFF.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NSTAFF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.NSTAFF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NSTAFF.Location = New System.Drawing.Point(267, 156)
        Me.NSTAFF.Name = "NSTAFF"
        Me.NSTAFF.Size = New System.Drawing.Size(96, 25)
        Me.NSTAFF.TabIndex = 19
        Me.NSTAFF.Text = "XXXXXX"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.PACKING_CONTROL.My.Resources.Resources.noporduct2
        Me.PictureBox1.Location = New System.Drawing.Point(7, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1005, 524)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'ListView_material
        '
        Me.ListView_material.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ITEM_CD, Me.QTY, Me.Use_QTY})
        Me.ListView_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView_material.HideSelection = False
        Me.ListView_material.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem3})
        Me.ListView_material.Location = New System.Drawing.Point(7, 119)
        Me.ListView_material.Name = "ListView_material"
        Me.ListView_material.Size = New System.Drawing.Size(1005, 524)
        Me.ListView_material.TabIndex = 21
        Me.ListView_material.UseCompatibleStateImageBehavior = False
        Me.ListView_material.View = System.Windows.Forms.View.Details
        '
        'ITEM_CD
        '
        Me.ITEM_CD.Text = "ITEM_CD"
        Me.ITEM_CD.Width = 418
        '
        'QTY
        '
        Me.QTY.Text = "QTY"
        Me.QTY.Width = 253
        '
        'Use_QTY
        '
        Me.Use_QTY.Text = "USE_QTY"
        Me.Use_QTY.Width = 329
        '
        'Panel_scan_picking
        '
        Me.Panel_scan_picking.Controls.Add(Me.Button3)
        Me.Panel_scan_picking.Controls.Add(Me.Label1)
        Me.Panel_scan_picking.Controls.Add(Me.scan_item_cd)
        Me.Panel_scan_picking.Location = New System.Drawing.Point(146, 156)
        Me.Panel_scan_picking.Name = "Panel_scan_picking"
        Me.Panel_scan_picking.Size = New System.Drawing.Size(701, 463)
        Me.Panel_scan_picking.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(214, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(256, 123)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SCAN SUPPLY TAG"
        '
        'scan_item_cd
        '
        Me.scan_item_cd.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scan_item_cd.Location = New System.Drawing.Point(85, 175)
        Me.scan_item_cd.Name = "scan_item_cd"
        Me.scan_item_cd.Size = New System.Drawing.Size(531, 80)
        Me.scan_item_cd.TabIndex = 0
        '
        'hide_supply_tag
        '
        Me.hide_supply_tag.HideSelection = False
        Me.hide_supply_tag.Location = New System.Drawing.Point(22, 12)
        Me.hide_supply_tag.Name = "hide_supply_tag"
        Me.hide_supply_tag.Size = New System.Drawing.Size(108, 93)
        Me.hide_supply_tag.TabIndex = 3
        Me.hide_supply_tag.UseCompatibleStateImageBehavior = False
        '
        'sub_line
        '
        Me.sub_line.AutoSize = True
        Me.sub_line.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.sub_line.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sub_line.ForeColor = System.Drawing.Color.White
        Me.sub_line.Location = New System.Drawing.Point(940, 85)
        Me.sub_line.Name = "sub_line"
        Me.sub_line.Size = New System.Drawing.Size(53, 20)
        Me.sub_line.TabIndex = 38
        Me.sub_line.Text = "XXXX"
        '
        'line
        '
        Me.line.AutoSize = True
        Me.line.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.line.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.line.ForeColor = System.Drawing.Color.White
        Me.line.Location = New System.Drawing.Point(940, 42)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(53, 20)
        Me.line.TabIndex = 37
        Me.line.Text = "XXXX"
        '
        'LB_SUB_LINE
        '
        Me.LB_SUB_LINE.AutoSize = True
        Me.LB_SUB_LINE.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LB_SUB_LINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_SUB_LINE.ForeColor = System.Drawing.Color.White
        Me.LB_SUB_LINE.Location = New System.Drawing.Point(844, 85)
        Me.LB_SUB_LINE.Name = "LB_SUB_LINE"
        Me.LB_SUB_LINE.Size = New System.Drawing.Size(91, 20)
        Me.LB_SUB_LINE.TabIndex = 36
        Me.LB_SUB_LINE.Text = "SUB LINE :"
        '
        'LB_LINE
        '
        Me.LB_LINE.AutoSize = True
        Me.LB_LINE.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LB_LINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_LINE.ForeColor = System.Drawing.Color.White
        Me.LB_LINE.Location = New System.Drawing.Point(882, 42)
        Me.LB_LINE.Name = "LB_LINE"
        Me.LB_LINE.Size = New System.Drawing.Size(53, 20)
        Me.LB_LINE.TabIndex = 35
        Me.LB_LINE.Text = "LINE :"
        '
        'select_plan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BackgroundImage = Global.PACKING_CONTROL.My.Resources.Resources.Plan_list52
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.sub_line)
        Me.Controls.Add(Me.line)
        Me.Controls.Add(Me.LB_SUB_LINE)
        Me.Controls.Add(Me.LB_LINE)
        Me.Controls.Add(Me.hide_supply_tag)
        Me.Controls.Add(Me.Panel_scan_picking)
        Me.Controls.Add(Me.ListView_material)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NSTAFF)
        Me.Controls.Add(Me.LBRM)
        Me.Controls.Add(Me.LBAC)
        Me.Controls.Add(Me.LBMD)
        Me.Controls.Add(Me.LBDATE)
        Me.Controls.Add(Me.LBWI)
        Me.Controls.Add(Me.LBPQ)
        Me.Controls.Add(Me.LBIT)
        Me.Controls.Add(Me.LBPD)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "select_plan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "select_plan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_scan_picking.ResumeLayout(False)
        Me.Panel_scan_picking.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LBPD As Label
    Friend WithEvents LBIT As Label
    Friend WithEvents LBPQ As Label
    Friend WithEvents LBWI As Label
    Friend WithEvents LBDATE As Label
    Friend WithEvents LBMD As Label
    Friend WithEvents LBAC As Label
    Friend WithEvents LBRM As Label
    Friend WithEvents NSTAFF As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListView_material As ListView
    Friend WithEvents ITEM_CD As ColumnHeader
    Friend WithEvents QTY As ColumnHeader
    Friend WithEvents Panel_scan_picking As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents scan_item_cd As TextBox
    Friend WithEvents Use_QTY As ColumnHeader
    Friend WithEvents hide_supply_tag As ListView
    Friend WithEvents sub_line As Label
    Friend WithEvents line As Label
    Friend WithEvents LB_SUB_LINE As Label
    Friend WithEvents LB_LINE As Label
End Class
