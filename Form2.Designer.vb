<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rodzaj_Dok = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Data_D = New System.Windows.Forms.DateTimePicker()
        Me.Data_W = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Miejsce_wystawienia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NR_Dok = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NIP = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Miejscowość_K = New System.Windows.Forms.TextBox()
        Me.Kod_K = New System.Windows.Forms.TextBox()
        Me.Adres_K = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Nazwa_K = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Nr_konta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Data_P = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Forma_platnosci = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Kwota = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rodzaj_Dok)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Data_D)
        Me.GroupBox1.Controls.Add(Me.Data_W)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Miejsce_wystawienia)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NR_Dok)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dane dokumentu"
        '
        'Rodzaj_Dok
        '
        Me.Rodzaj_Dok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Rodzaj_Dok.FormattingEnabled = True
        Me.Rodzaj_Dok.Location = New System.Drawing.Point(60, 28)
        Me.Rodzaj_Dok.Margin = New System.Windows.Forms.Padding(2)
        Me.Rodzaj_Dok.Name = "Rodzaj_Dok"
        Me.Rodzaj_Dok.Size = New System.Drawing.Size(134, 21)
        Me.Rodzaj_Dok.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 30)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Rodzaj:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Data dostawy:"
        '
        'Data_D
        '
        Me.Data_D.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_D.Location = New System.Drawing.Point(112, 131)
        Me.Data_D.Name = "Data_D"
        Me.Data_D.Size = New System.Drawing.Size(82, 20)
        Me.Data_D.TabIndex = 6
        Me.Data_D.Value = New Date(2021, 4, 10, 0, 0, 0, 0)
        '
        'Data_W
        '
        Me.Data_W.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Data_W.Location = New System.Drawing.Point(112, 105)
        Me.Data_W.Name = "Data_W"
        Me.Data_W.Size = New System.Drawing.Size(82, 20)
        Me.Data_W.TabIndex = 5
        Me.Data_W.Value = New Date(2021, 4, 10, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data wystawienia:"
        '
        'Miejsce_wystawienia
        '
        Me.Miejsce_wystawienia.Location = New System.Drawing.Point(90, 79)
        Me.Miejsce_wystawienia.Name = "Miejsce_wystawienia"
        Me.Miejsce_wystawienia.Size = New System.Drawing.Size(104, 20)
        Me.Miejsce_wystawienia.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Miejscowość:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numer:"
        '
        'NR_Dok
        '
        Me.NR_Dok.Location = New System.Drawing.Point(60, 54)
        Me.NR_Dok.Name = "NR_Dok"
        Me.NR_Dok.Size = New System.Drawing.Size(134, 20)
        Me.NR_Dok.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NIP)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Miejscowość_K)
        Me.GroupBox2.Controls.Add(Me.Kod_K)
        Me.GroupBox2.Controls.Add(Me.Adres_K)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Nazwa_K)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 167)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kontrahent"
        '
        'NIP
        '
        Me.NIP.Location = New System.Drawing.Point(112, 142)
        Me.NIP.MaxLength = 10
        Me.NIP.Name = "NIP"
        Me.NIP.Size = New System.Drawing.Size(143, 20)
        Me.NIP.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(78, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "NIP:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Kod pocztowy / Miejscowość:"
        '
        'Miejscowość_K
        '
        Me.Miejscowość_K.Location = New System.Drawing.Point(79, 114)
        Me.Miejscowość_K.Name = "Miejscowość_K"
        Me.Miejscowość_K.Size = New System.Drawing.Size(176, 20)
        Me.Miejscowość_K.TabIndex = 5
        '
        'Kod_K
        '
        Me.Kod_K.Location = New System.Drawing.Point(6, 114)
        Me.Kod_K.MaxLength = 6
        Me.Kod_K.Name = "Kod_K"
        Me.Kod_K.Size = New System.Drawing.Size(67, 20)
        Me.Kod_K.TabIndex = 4
        '
        'Adres_K
        '
        Me.Adres_K.Location = New System.Drawing.Point(6, 73)
        Me.Adres_K.Name = "Adres_K"
        Me.Adres_K.Size = New System.Drawing.Size(249, 20)
        Me.Adres_K.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Ulica, nr budynku i lokalu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nazwa kontrahenta:"
        '
        'Nazwa_K
        '
        Me.Nazwa_K.Location = New System.Drawing.Point(6, 34)
        Me.Nazwa_K.Name = "Nazwa_K"
        Me.Nazwa_K.Size = New System.Drawing.Size(249, 20)
        Me.Nazwa_K.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.Nr_konta)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Data_P)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Forma_platnosci)
        Me.GroupBox3.Location = New System.Drawing.Point(485, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 144)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Płatność"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(115, 121)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Zapłacono"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Nr_konta
        '
        Me.Nr_konta.Location = New System.Drawing.Point(13, 93)
        Me.Nr_konta.MaxLength = 26
        Me.Nr_konta.Name = "Nr_konta"
        Me.Nr_konta.Size = New System.Drawing.Size(181, 20)
        Me.Nr_konta.TabIndex = 5
        Me.Nr_konta.Text = "12345678901234567890123456"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Numer konta:"
        '
        'Data_P
        '
        Me.Data_P.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_P.Location = New System.Drawing.Point(101, 45)
        Me.Data_P.Name = "Data_P"
        Me.Data_P.Size = New System.Drawing.Size(93, 20)
        Me.Data_P.TabIndex = 3
        Me.Data_P.Value = New Date(2021, 4, 10, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Termin płatności:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Forma płatności:"
        '
        'Forma_platnosci
        '
        Me.Forma_platnosci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Forma_platnosci.FormattingEnabled = True
        Me.Forma_platnosci.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Forma_platnosci.Items.AddRange(New Object() {"Gotówka", "Karta", "Pobranie", "Przelew"})
        Me.Forma_platnosci.Location = New System.Drawing.Point(101, 18)
        Me.Forma_platnosci.Name = "Forma_platnosci"
        Me.Forma_platnosci.Size = New System.Drawing.Size(93, 21)
        Me.Forma_platnosci.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Dodaj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(93, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Edytuj"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(174, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Usuń"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 214)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(673, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(519, 385)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Zapisz"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(600, 385)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Anuluj"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Kwota)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 372)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Kwota do zapłaty [zł]"
        '
        'Kwota
        '
        Me.Kwota.AutoSize = True
        Me.Kwota.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Kwota.Location = New System.Drawing.Point(109, 19)
        Me.Kwota.Name = "Kwota"
        Me.Kwota.Size = New System.Drawing.Size(40, 17)
        Me.Kwota.TabIndex = 0
        Me.Kwota.Text = "0,00"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox8)
        Me.GroupBox5.Location = New System.Drawing.Point(260, 372)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(213, 48)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Osoba wystawiająca dokument"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(16, 19)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(182, 20)
        Me.TextBox8.TabIndex = 0
        Me.TextBox8.Text = "Testowa Osoba"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nazwa towaru / usługi"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 137
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cena netto [zł]"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 78
        '
        'Column4
        '
        Me.Column4.HeaderText = "Ilość"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 40
        '
        'Column5
        '
        Me.Column5.HeaderText = "Wartość netto [zł]"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 110
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column6.HeaderText = "VAT [%]"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 65
        '
        'Column7
        '
        Me.Column7.HeaderText = "Kwota VAT"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 88
        '
        'Column8
        '
        Me.Column8.HeaderText = "Wartość brutto [zł]"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 109
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 432)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dodawanie nowej faktury"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Data_W As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Miejsce_wystawienia As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NR_Dok As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Data_D As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Nazwa_K As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Miejscowość_K As TextBox
    Friend WithEvents Kod_K As TextBox
    Friend WithEvents Adres_K As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Forma_platnosci As ComboBox
    Friend WithEvents Data_P As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Nr_konta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Kwota As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents NIP As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Rodzaj_Dok As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
