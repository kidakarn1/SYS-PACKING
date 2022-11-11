Imports System.Data.SqlClient
'Imports System.Data.SQLite
Imports System.Collections.Generic
Imports System.Data
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading
Imports System.Web.Script.Serialization
'Imports System.Net.netwoerkInformation
Public Class scan_staff
    Public Property Api As Object
    Public staff As select_plan
    Public i As Integer = 1
    Dim arr_user_id As ArrayList = New ArrayList()
    Dim G_WI As String = ""
    Private get_man_id As Integer = 0
    Private Sub scan_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'add_user()
        TXTUSERID.Select()
        Scan_card.Show()
        line.Text = Module1.get_setting_line
        sub_line.Text = Module1.get_setting_sub_line
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        LBDATE.Text = todaysdate
        Imguser.Visible = False
        LBUSER.Visible = False
        Panel1.Visible = False
        Imguser1.Visible = False
        Panel2.Visible = False
        LBUSER1.Visible = False
        Imguser2.Visible = False
        Panel3.Visible = False
        LBUSER2.Visible = False
        Imguser3.Visible = False
        Panel4.Visible = False
        LBUSER3.Visible = False
        Panel5.Visible = False
        LB1.Visible = False 
    End Sub
    Public Sub dowload_user()
        Dim api = New api()
        If Panel1.Visible = False Then
            If Api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg") IsNot Nothing Then
                Imguser.Image = api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg")
            End If
        ElseIf Panel2.Visible = False Then
            If api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg") IsNot Nothing Then
                Imguser1.Image = api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg")
            End If
        ElseIf Panel3.Visible = False Then
            If api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg") IsNot Nothing Then
                Imguser2.Image = api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg")
            End If
        ElseIf Panel4.Visible = False Then
            If api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg") IsNot Nothing Then
                Imguser3.Image = api.DownloadImage("http://192.168.82.23/member/photo/" & TXTUSERID.Text & ".jpg")
            End If
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Scan_card.Hide()
            TXTUSERID.Hide()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If LBUSER.Text = " " Then
            Application.DoEvents()
            dowload_user()
            MsgBox("Please Scan Employee Card")
            TXTUSERID.Text = " "
            TXTUSERID.Focus()
            TXTUSERID.Hide()
            Scan_card.Hide()
            Me.Show()
        Else
            Dim i As Integer = 0
            For Each value As String In arr_user_id
                If value <> "" Then
                    Dim api = New api()
                    Dim users = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/INSERT_DATA_PACKING/add_user?user=" & value & "&datetime_start=" & "2021-09-16 22:22:22" & "&wi=" & G_WI & "&man_id=" & CDbl(Val(get_man_id)) + 1)
                    Dim data_man_id_naja As Integer = CDbl(Val(get_man_id)) + 1
                    set_man_id(data_man_id_naja)
                    i += 1
                End If
                Module1.set_manpower(i)
            Next
            Dim staff As select_plan = New select_plan()
            staff.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        select_menu.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TXTUSERID.Clear()
        TXTUSERID.Select()
        TXTUSERID.Show()
        TXTUSERID.Focus()
        Scan_card.Show()
    End Sub

    Private Sub Scan_card_Click_1(sender As Object, e As EventArgs) Handles Scan_card.Click
        TXTUSERID.Select()
    End Sub
    Private Sub Panel1_MouseClick(sender As Object, e As MouseEventArgs) Handles Panel1.MouseClick
        LBUSERLOG1.Text = LBUSER.Text
        Panel5.Show()
        i = 1
        'LBUSERLOG1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        arr_user_id(i - 1) = ""
        clear_user(i)
        Panel5.Hide()
    End Sub
    Public Sub clear_user(index)
        Dim api = New api()
        Dim show_user As String = "NO_DATA"
        Dim coron As String = ":"
        Try
            Dim arr_data = LB1.Text.Split(" : ")
            show_user = arr_data(index)
        Catch ex As Exception
            show_user = LB1.Text
        End Try
        LBUSERLOG1.Text = show_user 'LBUSER.Text
        If index = 1 Then
            Panel1.Visible = False
            LBUSER.Text = ""
            LB1.Text = LBUSER.Text & coron & LBUSER1.Text & coron & LBUSER2.Text & coron & LBUSER3.Text
        ElseIf index = 2 Then
            Panel2.Visible = False
            LBUSER1.Text = ""
            LB1.Text = LBUSER.Text & coron & LBUSER1.Text & coron & LBUSER2.Text & coron & LBUSER3.Text
        ElseIf index = 3 Then
            Panel3.Visible = False
            LBUSER2.Text = ""
            LB1.Text = LBUSER.Text & coron & LBUSER1.Text & coron & LBUSER2.Text & coron & LBUSER3.Text
        ElseIf index = 4 Then
            Panel4.Visible = False
            LBUSER3.Text = ""
            LB1.Text = LBUSER.Text & coron & LBUSER1.Text & coron & LBUSER2.Text & coron & LBUSER3.Text
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel5.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        LBUSERLOG1.Text = LBUSER3.Text
        Panel5.Show()
        i = 4
    End Sub

    Private Sub Panel2_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseClick, Panel2.MouseClick
        LBUSERLOG1.Text = LBUSER1.Text
        Panel5.Show()
        i = 2
    End Sub

    Private Sub Panel3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseClick, Panel3.MouseClick
        LBUSERLOG1.Text = LBUSER2.Text
        Panel5.Show()
        i = 3
    End Sub
    Private Sub Panel4_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseClick, Panel4.MouseClick
        LBUSERLOG1.Text = LBUSER3.Text
        Panel5.Show()
        i = 4
    End Sub
    Private Sub Panel2_MouseClick_1(sender As Object, e As MouseEventArgs)
        LBUSERLOG1.Text = LBUSER1.Text
        Panel5.Show()
        i = 2
    End Sub

    Private Sub TXTUSERID_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
    Private Sub Panel6_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel6.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel6.VerticalScroll.Value = e.NewValue
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles TXTUSERID.KeyDown
        Select Case e.KeyCode
            Case System.Windows.Forms.Keys.Enter
                Dim api = New api()
                Dim Count As String = 0
                If Trim(TXTUSERID.Text.Length) >= 5 Then
                    Application.DoEvents()
                    dowload_user()
                    Dim users1 = api.Load_data("http://192.168.161.102/api_system/api_packing/user_master?USER=" & Trim(TXTUSERID.Text))
                    Dim dict As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(users1)
                    Dim id As String
                    Dim fn As String
                    Dim ln As String
                    Dim coron As String = ":"
                    For Each item As Object In dict
                        id = item("emp_id").ToString()
                        fn = item("firstname").ToString()
                        ln = item("lastname").ToString()
                    Next
                    If Trim(TXTUSERID.Text) = LBUSER.Text Then
                        alert_user()
                    ElseIf Trim(TXTUSERID.Text) = LBUSER1.Text Then
                        alert_user()
                    ElseIf Trim(TXTUSERID.Text) = LBUSER2.Text Then
                        alert_user()
                    ElseIf Trim(TXTUSERID.Text) = LBUSER3.Text Then
                        alert_user()
                    Else
                        If Trim(TXTUSERID.Text) = id Then
                            arr_user_id.Add(Trim(TXTUSERID.Text))
                            LBSTAFF.Text = Count
                            Dim plandata = api.Load_data("http://192.168.161.102/api_system/Api_packing/plan_packing?SUB_LINE=" & sub_line.Text)
                            If plandata <> "0" Then
                                Dim dict2 As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(plandata)
                                Dim WI As String = ""
                                For Each item As Object In dict2
                                    WI = item("wi1").ToString()
                                Next
                                If WI <> "" Then
                                    G_WI = WI
                                    Dim get_man_id2 = api.Load_data("http://192.168.161.102/PACKING_CONTROL_PH10/PACK_GET_DATA/get_logs?wi=" & WI)
                                    get_man_id = get_man_id2
                                    If Panel1.Visible = False Then
                                        LBSTAFF.Text = Count + 1
                                        Dim users = api.Load_data("http://192.168.161.102/api_system/api_packing/user_master?USER=" & Trim(TXTUSERID.Text))
                                        Imguser.Visible = True
                                        LBUSER.Visible = True
                                        Panel1.Visible = True
                                        LBUSER.Text = Trim(TXTUSERID.Text)
                                        LNFN.Text = fn
                                        LBLN.Text = ln
                                        LB1.Text = LBUSER.Text
                                        TXTUSERID.Text = " "
                                        TXTUSERID.Focus()
                                        TXTUSERID.Hide()
                                        Scan_card.Hide()
                                        Me.Show()
                                    ElseIf Panel2.Visible = False Then
                                        LBSTAFF.Text = Count + 2
                                        Dim users = api.Load_data("http://192.168.161.102/api_system/api_packing/user_master?USER=" & Trim(TXTUSERID.Text))
                                        Imguser1.Visible = True
                                        LBUSER1.Visible = True
                                        Panel2.Visible = True
                                        coron = ":"
                                        LBUSER1.Text = Trim(TXTUSERID.Text)
                                        LBFN1.Text = fn
                                        LBLN1.Text = ln
                                        LB1.Text = LBUSER.Text + coron + LBUSER1.Text
                                        TXTUSERID.Text = " "
                                        TXTUSERID.Focus()
                                        TXTUSERID.Hide()
                                        Scan_card.Hide()
                                        Me.Show()
                                    ElseIf Panel3.Visible = False Then
                                        LBSTAFF.Text = Count + 3
                                        Dim users = api.Load_data("http://192.168.161.102/api_system/api_packing/user_master?USER=" & Trim(TXTUSERID.Text))
                                        Imguser2.Visible = True
                                        LBUSER2.Visible = True
                                        Panel3.Visible = True
                                        LBUSER2.Text = TXTUSERID.Text
                                        LBFN2.Text = fn
                                        LBLN2.Text = ln
                                        LB1.Text = LBUSER.Text + " : " + LBUSER1.Text + " : " + LBUSER2.Text
                                        TXTUSERID.Text = " "
                                        TXTUSERID.Focus()
                                        TXTUSERID.Hide()
                                        Scan_card.Hide()
                                        Me.Show()
                                    ElseIf Panel4.Visible = False Then
                                        LBSTAFF.Text = Count + 4
                                        Dim users = api.Load_data("http://192.168.161.102/api_system/api_packing/user_master?USER=" & TXTUSERID.Text)
                                        Imguser3.Visible = True
                                        LBUSER3.Visible = True
                                        Panel4.Visible = True
                                        LBUSER3.Text = Trim(TXTUSERID.Text)
                                        LBFN3.Text = fn
                                        LBLN3.Text = ln
                                        LB1.Text = LBUSER.Text + " : " + LBUSER1.Text + " : " + LBUSER2.Text + " : " + LBUSER3.Text
                                        TXTUSERID.Text = " "
                                        TXTUSERID.Focus()
                                        TXTUSERID.Hide()
                                        Scan_card.Hide()
                                        Me.Show()
                                    End If
                                Else
                                    MsgBox("User id incorrect")
                                    TXTUSERID.Text = " "
                                    TXTUSERID.Focus()
                                    TXTUSERID.Select()
                                    Scan_card.Show()
                                    Me.Show()
                                End If
                            Else
                                MsgBox("NO PLAN")
                                TXTUSERID.Text = " "
                                TXTUSERID.Focus()
                                TXTUSERID.Select()
                            End If

                        End If
                        End If
                End If
        End Select
    End Sub
    Public Sub alert_user()
        MsgBox("ใส่รหัสพนักงานนี้ไปแล้ว")
        TXTUSERID.Text = " "
        TXTUSERID.Focus()
        TXTUSERID.Select()
    End Sub
    Public Sub add_user()
        Dim r As String = "NO_DATA"
        Dim api = New api()

    End Sub


End Class