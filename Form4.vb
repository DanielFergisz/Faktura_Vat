Public Class Form4
    Private Sub FV_CheckedChanged(sender As Object, e As EventArgs) Handles FV.CheckedChanged
        If FV.Checked = True Then
            Form2.Rodzaj_Dok.Items.Add("Faktura VAT")
        Else
            Form2.Rodzaj_Dok.Items.Remove("Faktura VAT")
        End If
    End Sub

    Private Sub Par_CheckedChanged(sender As Object, e As EventArgs) Handles Par.CheckedChanged
        If Par.Checked = True Then
            Form2.Rodzaj_Dok.Items.Add("Paragon")
        Else
            Form2.Rodzaj_Dok.Items.Remove("Paragon")
        End If
    End Sub

    Private Sub FVM_CheckedChanged(sender As Object, e As EventArgs) Handles FVM.CheckedChanged
        If FVM.Checked = True Then
            Form2.Rodzaj_Dok.Items.Add("Faktura VAT-Marża")
        Else
            Form2.Rodzaj_Dok.Items.Remove("Faktura VAT-Marża")
        End If
    End Sub

    Private Sub KF_CheckedChanged(sender As Object, e As EventArgs) Handles KF.CheckedChanged
        If KF.Checked = True Then
            Form2.Rodzaj_Dok.Items.Add("Korekta Faktury")
        Else
            Form2.Rodzaj_Dok.Items.Remove("Korekta Faktury")
        End If
    End Sub

    Private Sub FZ_CheckedChanged(sender As Object, e As EventArgs) Handles FZ.CheckedChanged
        If FZ.Checked = True Then
            Form2.Rodzaj_Dok.Items.Add("Faktura Zbiorcza")
        Else
            Form2.Rodzaj_Dok.Items.Remove("Faktura Zbiorcza")
        End If
    End Sub

    Private Sub FD_CheckedChanged(sender As Object, e As EventArgs) Handles FD.CheckedChanged
        If FD.Checked = True Then
            Form2.Rodzaj_Dok.Items.Add("Faktura Detaliczna")
        Else
            Form2.Rodzaj_Dok.Items.Remove("Faktura Detaliczna")
        End If
    End Sub

    Private Sub Zamknij_U_Click(sender As Object, e As EventArgs) Handles Zamknij_U.Click
        Hide()
    End Sub

    Private Sub NIP_S_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NIP_S.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub Regon_S_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Regon_S.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then

            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Kod_S_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Kod_S.KeyPress
        If e.KeyChar = "-"c Then
            e.Handled = (CType(sender, TextBox).Text.IndexOf("-"c) <> -1)
        ElseIf e.KeyChar <> ControlChars.Back Then
            e.Handled = ("0123456789".IndexOf(e.KeyChar) = -1)
        End If
    End Sub
End Class