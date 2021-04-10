Public Class Form2
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If NR_Dok.Text = "" Or Miejsce_wystawienia.Text = "" Or Nazwa_K.Text = "" Or Adres_K.Text = "" Or Kod_K.Text = "" Or Miejscowość_K.Text = "" Or Forma_platnosci.Text = "" Or NIP.Text = "" Then
            If NR_Dok.Text = "" Then
                NR_Dok.BackColor = Color.Red
            End If

            If Miejsce_wystawienia.Text = "" Then
                Miejsce_wystawienia.BackColor = Color.Red
            End If

            If Nazwa_K.Text = "" Then
                Nazwa_K.BackColor = Color.Red
            End If

            If Adres_K.Text = "" Then
                Adres_K.BackColor = Color.Red
            End If

            If Kod_K.Text = "" Then
                Kod_K.BackColor = Color.Red
            End If

            If Miejscowość_K.Text = "" Then
                Miejscowość_K.BackColor = Color.Red
            End If
            If NIP.Text = "" Then
                NIP.BackColor = Color.Red
            End If

            If Rodzaj_Dok.SelectedItem = "" Then
                MsgBox("Pole Rodzaj nie może być puste !!")
            End If
        Else
            Dim rowId As Integer = Form1.DataGridView1.Rows.Add()
            Dim row As DataGridViewRow = Form1.DataGridView1.Rows(rowId)
            row.Cells("Column2").Value = Rodzaj_Dok.Text
            row.Cells("Column3").Value = NR_Dok.Text
            row.Cells("Column4").Value = Data_W.Value.ToString("dd-MM-yyyy")
            row.Cells("Column5").Value = Nazwa_K.Text
            row.Cells("Column6").Value = Forma_platnosci.SelectedItem
            row.Cells("Column7").Value = Kwota.Text
            row.Cells("Column8").Value = NIP.Text

            Close()
        End If
    End Sub

    Private Sub NR_Dok_TextChanged(sender As Object, e As EventArgs) Handles NR_Dok.TextChanged
        NR_Dok.BackColor = Color.White
    End Sub

    Private Sub Miejsce_wystawienia_TextChanged(sender As Object, e As EventArgs) Handles Miejsce_wystawienia.TextChanged
        Miejsce_wystawienia.BackColor = Color.White
    End Sub

    Private Sub Nazwa_K_TextChanged(sender As Object, e As EventArgs) Handles Nazwa_K.TextChanged
        Nazwa_K.BackColor = Color.White
    End Sub

    Private Sub Adres_K_TextChanged(sender As Object, e As EventArgs) Handles Adres_K.TextChanged
        Adres_K.BackColor = Color.White
    End Sub

    Private Sub Kod_K_TextChanged(sender As Object, e As EventArgs) Handles Kod_K.TextChanged
        Kod_K.BackColor = Color.White
    End Sub

    Private Sub Miejscowość_K_TextChanged(sender As Object, e As EventArgs) Handles Miejscowość_K.TextChanged
        Miejscowość_K.BackColor = Color.White
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form4.FV.Checked = True Then
            If Rodzaj_Dok.Items.Contains("Faktura VAT") Then
            Else
                Rodzaj_Dok.Items.Add("Faktura VAT")
            End If
        Else
            Rodzaj_Dok.Items.Remove("Faktura VAT")
        End If

        If Form4.Par.Checked = True Then
            If Rodzaj_Dok.Items.Contains("Paragon") Then
            Else
                Rodzaj_Dok.Items.Add("Paragon")
            End If
        Else
            Rodzaj_Dok.Items.Remove("Paragon")
        End If

        If Form4.FVM.Checked = True Then
            If Rodzaj_Dok.Items.Contains("Faktura VAT-Marża") Then
            Else
                Rodzaj_Dok.Items.Add("Faktura VAT-Marża")
            End If
        Else
            Rodzaj_Dok.Items.Remove("Faktura VAT-Marża")
        End If

        If Form4.KF.Checked = True Then
            If Rodzaj_Dok.Items.Contains("Korekta Faktury") Then
            Else
                Rodzaj_Dok.Items.Add("Korekta Faktury")
            End If
        Else
            Rodzaj_Dok.Items.Remove("Korekta Faktury")
        End If

        If Form4.FZ.Checked = True Then
            If Rodzaj_Dok.Items.Contains("Faktura Zbiorcza") Then
            Else
                Rodzaj_Dok.Items.Add("Faktura Zbiorcza")
            End If
        Else
            Rodzaj_Dok.Items.Remove("Faktura Zbiorcza")
        End If

        If Form4.FD.Checked = True Then
            If Rodzaj_Dok.Items.Contains("Faktura Detaliczna") Then
            Else
                Rodzaj_Dok.Items.Add("Faktura Detaliczna")
            End If
        Else
            Rodzaj_Dok.Items.Remove("Faktura Detaliczna")
        End If

        Nr_konta.Text = Form4.nr_Rach_S.Text
        Forma_platnosci.SelectedItem = "Gotówka"
        Rodzaj_Dok.SelectedItem = "Faktura VAT"
        Data_D.Value = DateTime.Now
        Data_W.Value = DateTime.Now
        Data_P.Value = DateTime.Now
    End Sub
    Private Sub Kod_K_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Kod_K.KeyPress
        If e.KeyChar = "-"c Then
            e.Handled = (CType(sender, TextBox).Text.IndexOf("-"c) <> -1)
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
        End If
    End Sub
    Private Sub Nr_konta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Nr_konta.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub NIP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NIP.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NIP_TextChanged(sender As Object, e As EventArgs) Handles NIP.TextChanged
        NIP.BackColor = Color.White
    End Sub

End Class