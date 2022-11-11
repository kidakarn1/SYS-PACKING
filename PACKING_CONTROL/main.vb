
Public Class main

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        select_menu.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        select_menu.Show()
        Timer1.Stop()
        Me.Hide()
    End Sub
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
