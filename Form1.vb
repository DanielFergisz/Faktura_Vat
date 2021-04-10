Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Ustawienia_Click(sender As Object, e As EventArgs) Handles Ustawienia.Click
        Form4.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form4.FV.Checked = True
    End Sub
End Class
