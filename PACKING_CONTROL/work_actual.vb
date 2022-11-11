Imports System.Net
Imports System.IO
Imports System.Web.Script.Serialization
Public Class work_actual
    Dim shift As String = "NO_DATA"
    Private Sub work_actual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        select_plan.Close()
        Panel_Cal.Visible = False
        'LB_ACT.Text = "550"
        LB_DRIFT.Text = "0"
        test.Visible = False
        get_date_now()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        select_plan.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reprint.Show()
        Me.Hide()
    End Sub
    Public Sub set_default()
        CE.Text = ""
    End Sub
    Public Sub get_date_now()
        Dim api = New api()
        Dim check_date As String = "NO_DATA"
        Dim get_date_now = api.Load_data("http://192.168.161.102/QGATE_PH10/GET_FA_TAG_SCAN/get_date_now")
        Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(get_date_now)
        For Each item As Object In dict2
            CE.Text = item("d").ToString()
        Next
        Dim result_LOT = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/GETLOT_TBKKFATHAILAND?lot_dt=" & CE.Text)
        LB_LOT.Text = result_LOT
        LB_PART_NO.Text = get_part_fg()
        LB_PLAN_QTY.Text = Module1.get_QTY_PLAN()
        LB_ACT.Text = Module1.get_ACT_PLAN()
        LB_DRIFT.Text = Module1.get_Remain_PLAN
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TimeOfDay.ToString("HH:mm:ss") >= "08:00:00" And TimeOfDay.ToString("HH:mm:ss") <= "20:00:00" Then
            LB_SHIFT.Text = "A"
        Else
            LB_SHIFT.Text = "B"
        End If
        test.Text = CDbl(Val(test.Text)) + 1
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If CDbl(Val(TextBox1.Text)) <= CDbl(Val(LB_PLAN_QTY.Text)) Then
            Panel_Cal.Visible = False
            LB_ACT.Text = TextBox1.Text
            If CDbl(Val(LB_PLAN_QTY.Text)) = 0 Then

            Else
                LB_DRIFT.Text = CDbl(Val(LB_PLAN_QTY.Text)) - CDbl(Val(LB_ACT.Text))
            End If
            TextBox1.Text = ""
        Else
            MsgBox("QTY ACTUAL มากกว่า QTY PLAN")
        End If
        TextBox1.Focus()
    End Sub

    Private Sub N1_Click(sender As Object, e As EventArgs) Handles N1.Click
        TextBox1.Text &= "1"
    End Sub

    Private Sub N2_Click(sender As Object, e As EventArgs) Handles N2.Click
        TextBox1.Text &= "2"
    End Sub

    Private Sub N3_Click(sender As Object, e As EventArgs) Handles N3.Click
        TextBox1.Text &= "3"
    End Sub

    Private Sub N4_Click(sender As Object, e As EventArgs) Handles N4.Click
        TextBox1.Text &= "4"
    End Sub

    Private Sub N5_Click(sender As Object, e As EventArgs) Handles N5.Click
        TextBox1.Text &= "5"
    End Sub

    Private Sub N6_Click(sender As Object, e As EventArgs) Handles N6.Click
        TextBox1.Text &= "6"
    End Sub

    Private Sub N7_Click(sender As Object, e As EventArgs) Handles N7.Click
        TextBox1.Text &= "7"
    End Sub

    Private Sub N8_Click(sender As Object, e As EventArgs) Handles N8.Click
        TextBox1.Text &= "8"
    End Sub

    Private Sub N9_Click(sender As Object, e As EventArgs) Handles N9.Click
        TextBox1.Text &= "9"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub N0_Click(sender As Object, e As EventArgs) Handles N0.Click
        TextBox1.Text &= "0"
    End Sub

    Private Sub N00_Click(sender As Object, e As EventArgs)
        TextBox1.Text &= "00"
    End Sub
    Private Sub LB_ACT_Click(sender As Object, e As EventArgs) Handles LB_ACT.Click
        Panel_Cal.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim delete As String = TextBox1.Text
        Dim delete_text() As Char = delete
        Dim length_data As Integer = Len(delete_text) - 1
        Dim text As String = ""
        For i As Integer = 0 To length_data Step +1
            If i <= length_data - 1 Then
                text &= delete_text(i)
            End If
        Next
        TextBox1.Text = text
    End Sub
    Public Function covert_date(check_date As String)
        Dim year As String = check_date.Substring(0, 4)
        Dim mounth As String = check_date.Substring(5, 2)
        Dim day As String = check_date.Substring(8, 2)
        Dim result_data As String = year & mounth & day
        Return result_data
    End Function
    Private Sub B_close_lot_Click(sender As Object, e As EventArgs) Handles B_close_lot.Click
        Dim time As DateTime = DateTime.Now
        Dim format As String = "yyyy-MM-dd HH:mm:ss"
        Dim date_now = time.ToString(format)
        Dim time_detail As DateTime = DateTime.Now
        Dim format_time_detail As String = "HH:mm:ss"
        Dim now_time_detail = time_detail.ToString(format_time_detail)
        Dim wi As String = Module1.get_wi()
        Dim line_cd As String = Module1.get_setting_line
        Dim item_cd As String = Module1.get_part_fg()
        Dim plan_qty As String = LB_PLAN_QTY.Text
        Dim act_qty As String = LB_ACT.Text
        Dim seq_no As String = "001"
        Dim shift_prd As String = "A"
        Dim prd_st_date As String = Module1.get_date_start
        Dim prd_st_time As String = "08:00:00"
        Dim prd_end_dat As String = now_time_detail
        Dim prd_end_tim As String = "17:00:00"
        Dim lot_no As String = LB_LOT.Text

        Dim comp_flg As String = "0"
        If CDbl(Val(LB_PLAN_QTY.Text)) = CDbl(Val(LB_ACT.Text)) Then
            comp_flg = "1"
        Else
            comp_flg = "0"
        End If
        Dim transfer_fl As String = "0"
        Dim del_flg As String = "0"
        Dim updated_date As String = "2021-09-01"
        Dim prd_flg As String = "0"
        Dim close_lot_flg As String = "1"
        Dim api = New api()
        seq_no = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/get_seq?wi=" & get_wi())
        Dim instacetion_time As Integer = CDbl(Val(test.Text)) / 10
        Dim result_data = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/INSERT_DATA_PACKING/insert_data_act?wi=" & get_wi() & "&line_cd=" & line_cd & "&item_cd=" & item_cd & "&plan_qty=" & plan_qty & "&act_qty=" & act_qty & "&seq_no=" & seq_no & "&shift_prd=" & LB_SHIFT.Text & "&prd_st_dat=" & prd_st_date & "&prd_st_time=" & prd_st_time & "&prd_end_dat=" & prd_end_dat & "&prd_end_tim=" & prd_end_tim & "&lot_no=" & lot_no & "&comp_flg=" & comp_flg & "&transfer_fl=" & transfer_fl & "&del_flg=" & del_flg & "&updated_date=" & updated_date & "&prd_flg=" & prd_flg & "&close_lot_flg=" & close_lot_flg & "&MAN_REF=" & Module1.get_man_id & "&USE_TIME=" & instacetion_time & "&man_power=" & Module1.get_manpower)
        Dim i As Integer = 0
        If CDbl(Val(LB_PLAN_QTY.Text)) > CDbl(Val(LB_ACT.Text)) Then
            For Each item As Object In Module1.get_Tag_supply
                Dim result_supply = set_supply(item, LB_DRIFT.Text)
                Dim arr_result_tag = result_supply.split()
                Print_supply_remain.load_data(result_supply, arr_result_tag(3), "NO_DATA", arr_result_tag(2), LB_DRIFT.Text, arr_result_tag(1), "PC&L")
                Dim re_new_qr As String = "GB" & Module1.get_setting_line & covert_date(CE.Text) & covert_seq(seq_no) & set_digit_part_no(LB_PART_NO.Text) & covert_date(CE.Text) & set_digit_covert_qty(LB_ACT.Text) & LB_LOT.Text & "                         " & covert_date(CE.Text) & covert_seq(seq_no) & "51001"
                Print_TAG_FG.load_data(re_new_qr, LB_PART_NO.Text, "NO_DATA", Module1.get_setting_sub_line(), LB_ACT.Text, LB_LOT.Text, seq_no, CE.Text)
            Next
            Module1.set_default()
        ElseIf CDbl(Val(LB_PLAN_QTY.Text)) = CDbl(Val(LB_ACT.Text)) Then
            Dim INSPECTION_TIME = (CDbl(Val(test.Text)) / 10)
            result_data = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/INSERT_DATA_PACKING/update_flg_dev?wi=" & get_wi() & "&line_cd=" & line_cd & "&item_cd=" & item_cd & "&plan_qty=" & plan_qty & "&act_qty=" & act_qty & "&seq_no=" & seq_no & "&shift_prd=" & shift_prd & "&prd_st_dat=" & prd_st_date & "&prd_st_time=" & prd_st_time & "&prd_end_dat=" & prd_end_dat & "&prd_end_tim=" & prd_end_tim & "&lot_no=" & lot_no & "&comp_flg=" & comp_flg & "&transfer_fl=" & transfer_fl & "&del_flg=" & del_flg & "&updated_date=" & updated_date & "&prd_flg=" & prd_flg & "&close_lot_flg=" & close_lot_flg)
            Dim re_new_qr As String = "GB" & Module1.get_setting_line & covert_date(CE.Text) & covert_seq(seq_no) & set_digit_part_no(LB_PART_NO.Text) & covert_date(CE.Text) & set_digit_covert_qty(LB_ACT.Text) & LB_LOT.Text & "                         " & covert_date(CE.Text) & covert_seq(seq_no) & "51001"
            Print_TAG_FG.load_data(re_new_qr, LB_PART_NO.Text, "NO_DATA", Module1.get_setting_sub_line(), LB_ACT.Text, LB_LOT.Text, seq_no, CE.Text)
            MsgBox("COMPLETED!")
        End If
        select_plan.ListView_material.Visible = False
        select_plan.Show()
        Me.Close()
        Module1.set_Remain_PLAN(0)
    End Sub
    Public Function set_digit_part_no(part_no)
        Dim lenth_part_no = 25 - Len(part_no)
        Dim space_baer As String
        For index As Integer = 1 To lenth_part_no
            space_baer &= " "
        Next
        Dim result = part_no & space_baer
        Return result
    End Function
    Public Function set_digit_covert_qty(part_qty)
        Dim lenth_part_no = 6 - Len(part_qty)
        Dim space_baer As String
        For index As Integer = 1 To lenth_part_no
            space_baer &= " "
        Next
        Dim result = space_baer & part_qty
        Return result
    End Function

    Public Function set_supply(qr_supply As String, data_drift As String)
        Dim a As String = qr_supply
        Dim s_a = a.Substring(32)
        Dim arr_data = s_a.Split(" ")
        Dim arr_data2 = s_a.Split(" ")
        Dim arr_s = qr_supply.Split(" ")
        arr_s(16) = Trim(data_drift)
        Dim r As String
        Dim digit As Integer = Len(LB_ACT.Text)
        'If Len(Trim(data_drift)) = 1 Then
        ' r = a.Substring(0, 48) & arr_data(16) & " " & a.Substring(50)
        ' ElseIf Len(Trim(data_drift)) = 2 Then
        ' r = a.Substring(0, 48) & arr_data(16) & " " & a.Substring(51)
        ' ElseIf Len(Trim(data_drift)) = 3 Then
        ' r = a.Substring(0, 48) & arr_data(16) & " " & a.Substring(52)
        ' Else
        ' r = a.Substring(0, 48) & arr_data(16) & a.Substring(52)
        ' End If
        Dim total_len As String
        Dim space As String
        If Len(arr_s(3)) >= 11 Then
            space = " "
        ElseIf Len(arr_s(3)) = 10 Then
            space = "  "
        ElseIf Len(arr_s(3)) = 9 Then
            space = "   "
        ElseIf Len(arr_s(3)) = 8 Then
            space = "    "
        ElseIf Len(arr_s(3)) = 7 Then
            space = "     "
        ElseIf Len(arr_s(3)) = 6 Then
            space = "      "
        ElseIf Len(arr_s(3)) = 5 Then
            space = "       "
        ElseIf Len(arr_s(3)) = 4 Then
            space = "        "
        ElseIf Len(arr_s(3)) = 3 Then
            space = "         "
        ElseIf Len(arr_s(3)) = 2 Then
            space = "          "
        ElseIf Len(arr_s(3)) = 1 Then
            space = "           "
        End If
        total_len = arr_s(0) & " " & arr_s(1) & " " & arr_s(2) & " " & arr_s(3) & space
        Dim digit_test As Integer = Len(a) - Len(total_len)
        Dim result As String = ""
        If Len(Trim(data_drift)) = 1 Then '9
            'r = a.Substring(0, 48) & arr_data(16) & "    " & a.Substring(53)
            r = arr_s(0) & " " & arr_s(1) & " " & arr_s(2) & " " & arr_s(3) & "                " & arr_s(16) & "    " & a.Substring(digit_test)
        ElseIf Len(Trim(data_drift)) = 2 Then '99
            r = arr_s(0) & " " & arr_s(1) & " " & arr_s(2) & " " & arr_s(3) & "                " & arr_s(16) & "   " & a.Substring(digit_test)
            ' r = a.Substring(0, 48) & arr_data(16) & "  " & a.Substring(52)
        ElseIf Len(Trim(data_drift)) = 3 Then '999
            r = arr_s(0) & " " & arr_s(1) & " " & arr_s(2) & " " & arr_s(3) & "                " & arr_s(16) & "  " & a.Substring(digit_test)
            ' r = a.Substring(0, 48) & arr_data(16) & " " & a.Substring(52)
        Else '> 999
            ' r = a.Substring(0, 48) & arr_data(16) & a.Substring(52)
            r = arr_s(0) & " " & arr_s(1) & " " & arr_s(2) & " " & arr_s(3) & "                " & arr_s(16) & " " & a.Substring(digit_test)
        End If
        Return r
    End Function
    Public Function covert_seq(PARA_SEQ)
        Dim SEQ As String = ""
        If PARA_SEQ <= 9 Then
            SEQ = "00" & PARA_SEQ
        ElseIf PARA_SEQ <= 99 Then
            SEQ = "0" & PARA_SEQ
        Else
            SEQ = PARA_SEQ
        End If
        Return SEQ
    End Function
End Class