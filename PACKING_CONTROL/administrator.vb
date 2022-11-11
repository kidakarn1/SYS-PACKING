Imports System.Data.SqlClient
'Imports System.Data.SQLite
Imports System.Collections.Generic
Imports System.Data
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading
Imports System.Web.Script.Serialization
Public Class administrator
    Private Sub administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTUSERID.Select()
        Scan_card.Show()
        PictureBox3.Visible = False
    End Sub
    Public Sub dowload_user()
        Dim api = New api()
        If PictureBox3.Visible = False Then
            If api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg") IsNot Nothing Then
                PictureBox3.Image = api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg")
            End If
        End If
    End Sub
    Private Sub TXTUSERID_TextChanged(sender As Object, e As EventArgs) Handles TXTUSERID.TextChanged
        Dim api = New api()
        Dim Count As String = 0
        If TXTUSERID.Text.Length >= 5 Then
            Application.DoEvents()
            dowload_user()
            Dim users1 = api.Load_data("http://192.168.161.102/api_system/api_packing/user_master?USER=" & TXTUSERID.Text)
            Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(users1)
            Dim id As String
            Dim fn As String
            Dim ln As String
            Dim dp As String
            For Each item As Object In dict
                id = item("emp_id").ToString()
                fn = item("firstname").ToString()
                ln = item("lastname").ToString()
                dp = item("department").ToString()
            Next
            If dp = "ADMIN" Then
                Dim users = api.Load_data("http://192.168.161.102/api_system/api_packing/user_master?USER=" & TXTUSERID.Text)
                PictureBox3.Visible = True
                TXTUSERID.Text = " "
                TXTUSERID.Focus()
                TXTUSERID.Hide()
                Scan_card.Hide()
                Me.Show()
            Else
                MsgBox("User id incorrect")
                TXTUSERID.Text = " "
                TXTUSERID.Focus()
                TXTUSERID.Select()
                Scan_card.Show()
                Me.Show()
            End If
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        select_menu.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        manage_user.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        delete_user.show()
        Me.Hide()
    End Sub
End Class