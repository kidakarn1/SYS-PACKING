Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class select_plan
    Dim wi As String = "NO_DATA"
    Public PART_FG As String = "NO_DATA"
    Dim x As ListViewItem
    Dim i As Integer = 1
    Dim shift As String = "NO_DATA"
    'Public staff As New scan_staff()
    Private Sub select_plan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        line.Text = Module1.get_setting_line
        sub_line.Text = Module1.get_setting_sub_line
        dowload_plan()
        NSTAFF.Text = scan_staff.LB1.Text
        Panel_scan_picking.Visible = False
        ListView_material.Visible = False
        hide_supply_tag.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        scan_staff.Show()
        Me.Close()
    End Sub
    Private Sub dowload_plan()
        Me.Refresh()
        Dim api = New api()
        Dim plandata = api.Load_data("http://192.168.161.102/api_system/Api_packing/plan_packing?SUB_LINE=" & Module1.get_setting_sub_line())
        If plandata <> "0" Then
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(plandata)
            Dim plan_date As String
            Dim item_cd As String
            Dim plan_qty As String
            Dim model As String
            For Each item As Object In dict
                plan_date = item("d").ToString()
                item_cd = item("item_cd").ToString()
                plan_qty = item("qty").ToString()
                model = item("MODEL").ToString()
                wi = item("wi1").ToString()
                PART_FG = item_cd
                set_part_fg(PART_FG)
            Next
            If wi <> "" Then
                Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
                LBDATE.Text = todaysdate
                LBPD.Text = plan_date
                LBIT.Text = item_cd
                LBPQ.Text = plan_qty
                LBWI.Text = wi
                LBMD.Text = model
                Dim result_data = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/GET_DATA_REMAIN_PACKING?wi=" & wi)
                If result_data <> "0" Then
                    Dim dict_reuslt As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data)
                    For Each item As Object In dict_reuslt
                        LBAC.Text = CDbl(Val(item("act_qty").ToString()))
                        LBRM.Text = CDbl(Val(item("plan_qty").ToString())) - CDbl(Val(item("act_qty").ToString()))
                    Next
                Else
                    LBAC.Text = "0"
                    LBRM.Text = "0"
                End If
                Module1.set_QTY_PLAN(LBPQ.Text)
                Module1.set_ACT_PLAN(LBAC.Text)
                Module1.set_Remain_PLAN(LBRM.Text)
                PictureBox1.Visible = False
                set_child_wi(wi, "0")
            Else
                PictureBox1.Visible = True
                Button1.Visible = False
            End If
        Else
            PictureBox1.Visible = True
            Button1.Visible = False
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim time As DateTime = DateTime.Now
        Dim format As String = "yyyy-MM-dd HH:mm:ss"
        Dim date_now = time.ToString(format)
        Dim time_detail As DateTime = DateTime.Now
        Dim format_time_detail As String = "HH:mm:ss"
        Dim now_time_detail = time_detail.ToString(format_time_detail)
        Dim date_start_string As String = date_now
        Module1.set_date_start(date_start_string)
        Dim i As Integer = 0
        Dim check_data As Integer = 1
        For Each items As ListViewItem In ListView_material.Items
            If check_data = 1 Then
                If CDbl(Val(items.SubItems(1).Text)) = CDbl(Val(items.SubItems(2).Text)) Then
                Else
                    check_data = 0
                End If
                i += 1
            End If
        Next
        If check_data = 1 Then
            work_actual.Show()
            Me.Hide()
        Else
            set_wi(LBWI.Text)
            ListView_material.Visible = True
            Panel_scan_picking.Visible = True
            scan_item_cd.Focus()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel_scan_picking.Visible = False
    End Sub
    Private Sub TextBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles scan_item_cd.PreviewKeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Enter
                Dim api = New api()
                Dim arr_split = scan_item_cd.Text.Split(" ")
                Dim check_data As Integer = 0
                If wi = arr_split(2) Then
                    Dim check_tag_loop = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_CHECK_DATA/check_scan_tag_of_picking?qr_code=" & scan_item_cd.Text)
                    If check_tag_loop = "0" Then
                        Dim i As Integer = 0
                        For Each items As ListViewItem In ListView_material.Items
                            If arr_split(3) = items.SubItems.Item(0).Text Then
                                insert_PACK_TAG_SCAN(scan_item_cd.Text)
                                items.SubItems(2).Text = CDbl(Val(items.SubItems(2).Text)) + CDbl(Val(arr_split(19)))
                                hide_supply_tag.Items.Add(scan_item_cd.Text)
                                If CDbl(Val(arr_split(19))) > 0 Then
                                    Module1.Set_Tag_supply(scan_item_cd.Text)
                                End If
                                scan_item_cd.Text = ""
                                scan_item_cd.Focus()
                                Panel_scan_picking.Visible = False
                                check_data = 1
                            End If
                            i += 1
                        Next
                        If check_data = 0 Then
                            MsgBox("PART NO นี้ไม่ใช่งานที่ PACKING กรุณาตรวจสอบ PART NO")
                        End If
                        scan_item_cd.Text = ""
                        scan_item_cd.Focus()
                    Else
                        MsgBox("สแกนซ้ำ")
                        scan_item_cd.Text = ""
                        scan_item_cd.Focus()
                    End If
                Else
                    MsgBox("กรุณาตรวจสอบ TAG เนื่องจาก WI ไม่ตรงกัน")
                    scan_item_cd.Text = ""
                    scan_item_cd.Focus()
                End If
        End Select
    End Sub
    Public Sub set_child_wi(wi, qty)
        ListView_material.Items.Clear()
        Dim api = New api()
        Dim result_data = api.Load_data("http://192.168.161.102/api_system/Api_packing/C_get_data_wi?WI=" & wi)
        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(result_data)
        For Each item As Object In dict2
            x = New ListViewItem(item("ITEM_CD").ToString())
            If CDbl(Val(Module1.get_Remain_PLAN())) <> "0" Then
                x.SubItems.Add(Module1.get_Remain_PLAN())
            Else
                x.SubItems.Add(item("QTY").ToString())
            End If
            x.SubItems.Add("0")
            ListView_material.Items.Add(x)
        Next
    End Sub
    Public Sub insert_PACK_TAG_SCAN(qr_code)
        Dim api = New api()
        Dim plandata = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/INSERT_DATA_PACKING/INSERT_PACK_TAG_SCAN?qr_code=" & qr_code & "&user_id=" & scan_staff.LBUSER.Text)
    End Sub
End Class