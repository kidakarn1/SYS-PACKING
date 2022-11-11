Module Module1
    Dim V_part_FG = "NO_DATA"
    Dim V_wi As String = "NO_DATA"
    Dim V_qr As String = "NO_DATA"
    Dim V_QTY_PLAN As String = "NO_DATA"
    Dim V_ACT_PLAN As String = "NO_DATA"
    Dim V_REMAIN_PLAN As String = "NO_DATA"
    Dim V_MAN_ID As Integer = 0
    Dim V_TAG_SUPPLY As ArrayList = New ArrayList()
    Dim V_MAN_POWER As String = "0"
    Dim V_DATE_START As String = ""
    Dim V_get_mac_address As String = ""
    Dim V_LINE As String = "NO_DATA"
    Dim V_SUB_LINE As String = "NO_DATA"
    Public Sub set_default()
        V_TAG_SUPPLY = New ArrayList()
    End Sub
    Public Sub set_setting_sub_line(sub_line)
        V_SUB_LINE = sub_line
    End Sub
    Public Function get_setting_sub_line()
        Return V_SUB_LINE
    End Function
    Public Sub set_setting_line(line)
        V_LINE = line
    End Sub
    Public Function get_setting_line()
        Return V_LINE
    End Function

    Public Sub set_mac(mac_address As String)
        V_get_mac_address = mac_address
    End Sub
    Public Function get_mac()
        Return V_get_mac_address
    End Function
    Public Sub set_man_id(man_id As Integer)
        V_MAN_ID = man_id
    End Sub
    Public Function get_man_id()
        Return V_MAN_ID
    End Function
    Public Sub set_manpower(manpower As String)
        V_MAN_POWER = manpower
    End Sub
    Public Function get_manpower()
        Return V_MAN_POWER
    End Function
    Public Sub set_date_start(date_start As String)
        V_DATE_START = date_start
    End Sub
    Public Function get_date_start()
        Return V_DATE_START
    End Function
    Public Sub Set_Tag_supply(tag_supply)
        V_TAG_SUPPLY.Add(tag_supply)
    End Sub
    Public Function get_Tag_supply()
        Return V_TAG_SUPPLY
    End Function
    Public Sub set_QTY_PLAN(QTY_PLAN As String)
        V_QTY_PLAN = QTY_PLAN
    End Sub
    Public Sub set_ACT_PLAN(actual As String)
        V_ACT_PLAN = actual
    End Sub
    Public Sub set_Remain_PLAN(remain As String)
        V_REMAIN_PLAN = remain
    End Sub
    Public Function get_QTY_PLAN()
        Return V_QTY_PLAN
    End Function
    Public Function get_ACT_PLAN()
        Return V_ACT_PLAN
    End Function
    Public Function get_Remain_PLAN()
        Return V_REMAIN_PLAN
    End Function
    Public Sub set_part_fg(part_fg As String)
        V_part_FG = part_fg
    End Sub
    Public Function get_part_fg()
        Return V_part_FG
    End Function
    Public Sub set_qr_part(part_fg As String)
        V_part_FG = part_fg
    End Sub
    Public Function get_qr_part()
        Return V_part_FG
    End Function
    Public Sub set_wi(wi As String)
        V_wi = wi
    End Sub
    Public Function get_wi()
        Return V_wi
    End Function
End Module