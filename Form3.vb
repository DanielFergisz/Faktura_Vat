Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Anuluj.Click
        Close()
    End Sub

    Private Sub C_netto_TextChanged(sender As Object, e As EventArgs) Handles C_netto.TextChanged
        C_netto.BackColor = Color.White

        If C_netto.Text <> "" Then
            If vat.Text = "23" Then
                C_brutto.Text = C_netto.Text * 1.23 * Ilosc.Text
            End If
        Else
            C_brutto.Text = ""
        End If

    End Sub

    Private Sub Dodaj_Click(sender As Object, e As EventArgs) Handles Dodaj.Click
        If Ilosc.Text = "" Or Nazwa_usługi.Text = "" Or C_netto.Text = "" Then
            If Ilosc.Text = "" Then
                Ilosc.BackColor = Color.Red
            End If

            If Nazwa_usługi.Text = "" Then
                Nazwa_usługi.BackColor = Color.Red
            End If

            If C_netto.Text = "" Then
                C_netto.BackColor = Color.Red
            End If
        Else
            Dim rowId As Integer = Form2.DataGridView1.Rows.Add()
            Dim row As DataGridViewRow = Form2.DataGridView1.Rows(rowId)
            row.Cells("Column2").Value = Nazwa_usługi.Text
            row.Cells("Column3").Value = C_netto.Text
            row.Cells("Column4").Value = Ilosc.Text
            row.Cells("Column5").Value = C_netto.Text * Ilosc.Text
            row.Cells("Column6").Value = vat.Text
            row.Cells("Column7").Value = C_brutto.Text - (C_netto.Text * Ilosc.Text)
            row.Cells("Column8").Value = C_brutto.Text

            If Form2.DataGridView1.RowCount > 1 Then
                Dim Kw As Double = 0

                For index As Integer = 0 To Form2.DataGridView1.RowCount - 1
                    Kw += Form2.DataGridView1.Rows(index).Cells(6).Value
                Next
                Form2.Kwota.Text = Kw.ToString("## ##0.00")
            End If

            Close()
            End If
    End Sub

    Private Sub Ilosc_TextChanged(sender As Object, e As EventArgs) Handles Ilosc.TextChanged
        If C_netto.Text <> "" Then
            If vat.Text = "23" Then
                C_brutto.Text = C_netto.Text * 1.23 * Ilosc.Text
            End If
        Else
            C_brutto.Text = ""
        End If
    End Sub

    Private Sub C_netto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C_netto.KeyPress
        If e.KeyChar = ","c Then
            e.Handled = (CType(sender, TextBox).Text.IndexOf(","c) <> -1)
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
        End If
    End Sub
    Private Sub Ilosc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Ilosc.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub Nazwa_usługi_TextChanged(sender As Object, e As EventArgs) Handles Nazwa_usługi.TextChanged
        Nazwa_usługi.BackColor = Color.White
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class