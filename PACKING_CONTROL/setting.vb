Imports System.Web.Script.Serialization
Public Class setting
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        select_menu.Show()
        Me.Close()
    End Sub

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim api = New api()
        Dim check_mac_address = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/LOAD_DATA_GATE?mac_address=" & Module1.get_mac)
        If check_mac_address <> "0" Then
            Dim get_data = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/GET_LINE")
            Dim dict_reuslt As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(get_data)
            Dim get_data_mas_name = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/Get_SUB_LINE_LOAD?mac_address=" & Module1.get_mac)
            Dim result_i As Integer = 0
            Dim i As Integer = 0
            For Each item As Object In dict_reuslt
                If item("LINE_CD").ToString() = get_data_mas_name Then
                    result_i = i
                End If
                cmd_line.Items.Add(item("LINE_CD").ToString())
                i += 1
            Next
            cmd_line.SelectedIndex = result_i
        Else
            MsgBox("mac = " & Module1.get_mac())
        End If
    End Sub
    Public Sub set_sub_line_cd()
        cmd_sub_line.Text = ""
        cmd_sub_line.Items.Clear()
        Dim j As Integer = 0
        Dim result_j As Integer = 0
        Dim api = New api()
        Dim get_sub_line = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/Get_sub_line_master?line=" & cmd_line.Text)
        Dim get_data_CHECK_LOG_SUB_LINE_PACKING = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/Get_SUB_LINE?mac_address=" & Module1.get_mac)
        If get_sub_line <> "0" Then
            Dim dict_reuslt_sub_line As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(get_sub_line)
            For Each item As Object In dict_reuslt_sub_line
                If item("Mas_sub_name").ToString() = get_data_CHECK_LOG_SUB_LINE_PACKING Then
                    result_j = j
                End If
                cmd_sub_line.Items.Add(item("Mas_sub_name").ToString())
                j += 1
            Next
            cmd_sub_line.SelectedIndex = result_j
        End If
    End Sub

    Private Sub cmd_line_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmd_line.SelectedIndexChanged
        set_sub_line_cd()
        LBLINE_CD.Text = cmd_line.Text
        LBSUBLINE.Text = cmd_sub_line.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim api = New api()
        Dim insert_dta = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/INSERT_DATA_PACKING/INSERT_DATA_LOG_SET_SUBLINE?mac=" & Module1.get_mac & "&line=" & cmd_line.Text & "&sub_line=" & cmd_sub_line.Text & "&user_id=K0071")
        Module1.set_setting_line(cmd_line.Text)
        Module1.set_setting_sub_line(cmd_sub_line.Text)
        MsgBox("COMPLETED")
        select_menu.Show()
        Me.Close()
    End Sub

    Private Sub cmd_sub_line_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmd_sub_line.SelectedIndexChanged
        LBSUBLINE.Text = cmd_sub_line.Text
    End Sub
End Class