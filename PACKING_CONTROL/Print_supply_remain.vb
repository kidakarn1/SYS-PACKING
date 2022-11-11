Public Class Print_supply_remain
    Public Tag_supply_remain As String = "NO_DATA"
    Public G_PART_NO As String = "NO_DATA"
    Public G_PART_NAME As String = "NO_DATA"
    Public G_WI As String = "NO_DATA"
    Public G_QTY As String = "NO_DATA"
    Public G_LINE As String = "NO_DATA"
    Public G_USER As String = "NO_DATA"
    Private Sub Print_supply_remain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.Print()
    End Sub
    Public Sub load_data(tag_supply, part_no, part_name, wi, qty, line, user)
        Tag_supply_remain = tag_supply
        G_PART_NO = part_no
        G_PART_NAME = part_name
        G_WI = wi
        G_QTY = qty
        G_LINE = line
        G_USER = user
        PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim aPen = New Pen(Color.Black)
        '       aPen.Width = 3.0F  'border 
        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Dim qr = Tag_supply_remain
        qrcode.QRCodeScale = 10
        Dim test As String = "NO_DATA"
        Dim bitmap_qr_box As Bitmap = qrcode.Encode(qr)
        Dim bitmap_qr_product As Bitmap = qrcode.Encode(qr)
        e.Graphics.DrawString(" REMAIN ", Label1.Font, Brushes.Black, 10, 10)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim greenBrush As New SolidBrush(Color.Green)
        ' Create a rectangle
        Dim rect As New Rectangle(20, 20, 200, 100)
        ' The text to be drawn
        Dim drawString As [String] = "Hello GDI+ World!"
        ' Create a Font
        Dim drawFont As New Font("Verdana", 14)
        Dim drawFont2 As New Font("Verdana", 8)

        Dim x_supply_Tag As Single = 173.0F
        Dim y_supply_Tag As Single = 300.0F


        Dim x_part_no As Single = 165.0F
        Dim y_part_no As Single = 60.0F

        Dim x_part_name As Single = 140.0F
        Dim y_part_name As Single = 60.0F

        Dim x_part_wi As Single = 110.0F
        Dim y_part_wi As Single = 60.0F

        Dim x_part_qty As Single = 85.0F
        Dim y_part_qty As Single = 60.0F

        Dim x_part_line As Single = 60.0F
        Dim y_part_line As Single = 60.0F

        Dim x_part_user As Single = 35.0F
        Dim y_part_user As Single = 60.0F

        Dim x_part_date As Single = 10.0F
        Dim y_part_date As Single = 60.0F
        ' String format
        Dim drawFormat As New StringFormat
        ' Set string format flag to direction vertical
        ' which draws text vertical
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical
        ' Draw string
        ' e.Graphics.DrawString("Drawing text", New Font("Tahoma", 14), greenBrush, rect.Location.X, rect.Location.Y)
        'e.Graphics.DrawString("/t/t/t/t", New Font("Arial", 12), redBrush, 10, 140)

        e.Graphics.DrawString("Supply Tag ", drawFont2, blueBrush, x_supply_Tag, y_supply_Tag, drawFormat)
        e.Graphics.DrawString("Part No : " & G_PART_NO, drawFont, blueBrush, x_part_no, y_part_no, drawFormat)
        e.Graphics.DrawString("Part Name : " & G_PART_NAME, drawFont, blueBrush, x_part_name, y_part_name, drawFormat)
        e.Graphics.DrawString("WI Plan : " & G_WI, drawFont, blueBrush, x_part_wi, y_part_wi, drawFormat)
        e.Graphics.DrawString("Supply QTY : " & G_QTY & " PCS.", drawFont, blueBrush, x_part_qty, y_part_qty, drawFormat)
        e.Graphics.DrawString("Line : " & G_LINE, drawFont, blueBrush, x_part_line, y_part_line, drawFormat)
        e.Graphics.DrawString("User : " & G_USER, drawFont, blueBrush, x_part_user, y_part_user, drawFormat)
        e.Graphics.DrawString("Date :  - ", drawFont, blueBrush, x_part_date, y_part_date, drawFormat)
        e.Graphics.DrawImage(bitmap_qr_box, 0, 300, 75, 75) 'buttom right
    End Sub
End Class