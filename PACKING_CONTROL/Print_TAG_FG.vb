Public Class Print_TAG_FG
    Public Tag_supply_remain As String = "NO_DATA"
    Public G_PART_NO As String = "NO_DATA"
    Public G_PART_NAME As String = "NO_DATA"
    Public G_WI As String = "NO_DATA"
    Public G_QTY As String = "NO_DATA"
    Public G_LINE As String = "NO_DATA"
    Public G_SUB_LINE As String = "NO_DATA"
    Public G_LOT_NO As String = "NO_DATA"
    Public G_SEQ_NO As String = "NO_DATA"
    Public G_DATE As String = "NO_DATA"
    Public G_USER As String = "NO_DATA"
    Public G_QR_TAG_FG As String = "NO_DATA"
    Private Sub Print_supply_remain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub load_data(QR_TAG_FG, part_no, part_name, sub_line, qty, lot_no, seq_no, pack_date)
        G_QR_TAG_FG = QR_TAG_FG
        G_PART_NO = part_no
        G_PART_NAME = part_name
        G_QTY = qty
        G_SUB_LINE = sub_line
        G_LOT_NO = lot_no
        G_SEQ_NO = seq_no
        G_DATE = pack_date
        PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim aPen = New Pen(Color.Black)
        '       aPen.Width = 3.0F  'border 
        Dim qrcode As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
        Dim qr = G_QR_TAG_FG
        qrcode.QRCodeScale = 10
        Dim test As String = "NO_DATA"
        Dim bitmap_qr_box As Bitmap = qrcode.Encode(qr)
        Dim bitmap_qr_product As Bitmap = qrcode.Encode(qr)
        e.Graphics.DrawString("  FG TAG ", Label1.Font, Brushes.Black, 10, 10)
        Dim blueBrush As New SolidBrush(Color.Blue)
        Dim redBrush As New SolidBrush(Color.Red)
        Dim greenBrush As New SolidBrush(Color.Green)
        ' Create a rectangle
        Dim rect As New Rectangle(20, 20, 200, 100)
        ' The text to be drawn
        Dim drawString As [String] = "Hello GDI+ World!"
        ' Create a Font
        Dim drawFont As New Font("Verdana", 14)
        Dim drawFont_qty As New Font("Verdana", 18)
        Dim drawFont2 As New Font("Verdana", 10)

        Dim x_supply_Tag As Single = 173.0F
        Dim y_supply_Tag As Single = 300.0F


        Dim x_part_no As Single = 150.0F 'แนวนอน Y ติดลบยิ่งลง'
        Dim y_part_no As Single = 50.0F   'แนวตั้ง X'

        Dim x_part_name As Single = 120.0F
        Dim y_part_name As Single = 145.0F

        Dim x_part_qty As Single = 80.0F
        Dim y_part_qty As Single = 145.0F

        Dim x_part_line As Single = 53.0F
        Dim y_part_line As Single = 145.0F

        Dim x_part_lot As Single = 25.0F
        Dim y_part_lot As Single = 50.0F

        Dim x_part_box As Single = 25.0F
        Dim y_part_box As Single = 210.0F

        Dim x_part_date As Single = 1.0F
        Dim y_part_date As Single = 50.0F
        ' String format
        Dim drawFormat As New StringFormat
        ' Set string format flag to direction vertical
        ' which draws text vertical
        drawFormat.FormatFlags = StringFormatFlags.DirectionVertical
        ' Draw string
        ' e.Graphics.DrawString("Drawing text", New Font("Tahoma", 14), greenBrush, rect.Location.X, rect.Location.Y)
        'e.Graphics.DrawString("/t/t/t/t", New Font("Arial", 12), redBrush, 10, 140)
        e.Graphics.DrawString("PACKING TAG ", drawFont2, blueBrush, x_supply_Tag, y_supply_Tag, drawFormat)
        e.Graphics.DrawString("Part No : " & G_PART_NO, drawFont, blueBrush, x_part_no, y_part_no, drawFormat)
        e.Graphics.DrawString("Part Name : " & G_PART_NAME, drawFont2, blueBrush, x_part_name, y_part_name, drawFormat)
        e.Graphics.DrawString("QTY : " & G_QTY, drawFont, blueBrush, x_part_qty, y_part_qty, drawFormat)
        e.Graphics.DrawString("Sub Line : " & G_SUB_LINE, drawFont2, blueBrush, x_part_line, y_part_line, drawFormat)
        e.Graphics.DrawString("Lot No : " & G_LOT_NO, drawFont2, blueBrush, x_part_lot, y_part_lot, drawFormat)
        e.Graphics.DrawString("Seq No : " & G_SEQ_NO, drawFont2, blueBrush, x_part_box, y_part_box, drawFormat)
        e.Graphics.DrawString("Packing Date : " & G_DATE, drawFont2, blueBrush, x_part_date, y_part_date, drawFormat)
        e.Graphics.DrawImage(bitmap_qr_box, 55, 55, 85, 85) 'Top
    End Sub


    Friend Shared Sub load_data(text1 As String, v1 As String, v2 As Object, text2 As String, v3 As String, text3 As String)
        Throw New NotImplementedException()
    End Sub
End Class