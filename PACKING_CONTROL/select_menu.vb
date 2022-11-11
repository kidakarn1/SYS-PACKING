Imports System.Net.NetworkInformation
Imports System.Threading
Imports System.Net.netwoerkInformation
Public Class select_menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Module1.get_mac <> "" Then
            scan_staff.Show()
            Me.Hide()
        Else
            setting.Show()
            Me.Hide()
        End If
        'Dim a As String = "SUP K1PS01 5100220930 MD343566                787  K0071 53387 53388  17082021 091031"
        'Dim s_a = a.Substring(32)
        'Dim arr_data = s_a.Split(" ")
        'MsgBox(arr_data(16))
        'Dim result_new_qr
        'Dim i As Integer = 0
        'arr_data(16) = 900
        'Dim r As String = a.Substring(0, 46) & arr_data(16) & a.Substring(52)
        'MsgBox("r = " & r)
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Shell("shutdown -s -t 00")
        'Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        administrator.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        setting.Show()
        Me.Hide()
    End Sub

    Private Sub select_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMacAddress()
        Dim api = New api()
        Dim get_data_mas_name = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/Get_SUB_LINE_LOAD?mac_address=" & Module1.get_mac)
        Dim get_data_CHECK_LOG_SUB_LINE_PACKING = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/Get_SUB_LINE?mac_address=" & Module1.get_mac)
        Module1.set_setting_line(get_data_mas_name)
        Module1.set_setting_sub_line(get_data_CHECK_LOG_SUB_LINE_PACKING)
    End Sub
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Module1.set_mac(nics(1).GetPhysicalAddress.ToString)
        Return nics(1).GetPhysicalAddress.ToString
    End Function

End Class