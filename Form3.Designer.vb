<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.C_brutto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vat = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ilosc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C_netto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nazwa_usługi = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dodaj = New System.Windows.Forms.Button()
        Me.Anuluj = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C_brutto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.vat)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Ilosc)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.C_netto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(312, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametry sprzedaży"
        '
        'C_brutto
        '
        Me.C_brutto.Location = New System.Drawing.Point(105, 105)
        Me.C_brutto.Name = "C_brutto"
        Me.C_brutto.ReadOnly = True
        Me.C_brutto.Size = New System.Drawing.Size(109, 20)
        Me.C_brutto.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Cena brutto [zł]:"
        '
        'vat
        '
        Me.vat.Enabled = False
        Me.vat.FormattingEnabled = True
        Me.vat.Items.AddRange(New Object() {"23", "8", "6", "0", "zw.", "oo.", "np.", "7", "4"})
        Me.vat.Location = New System.Drawing.Point(105, 78)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(109, 21)
        Me.vat.TabIndex = 5
        Me.vat.Text = "23"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "VAT [%]:"
        '
        'Ilosc
        '
        Me.Ilosc.Location = New System.Drawing.Point(105, 50)
        Me.Ilosc.Name = "Ilosc"
        Me.Ilosc.Size = New System.Drawing.Size(109, 20)
        Me.Ilosc.TabIndex = 3
        Me.Ilosc.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ilość:"
        '
        'C_netto
        '
        Me.C_netto.Location = New System.Drawing.Point(105, 24)
        Me.C_netto.Name = "C_netto"
        Me.C_netto.Size = New System.Drawing.Size(109, 20)
        Me.C_netto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cena netto [zł]:"
        '
        'Nazwa_usługi
        '
        Me.Nazwa_usługi.Location = New System.Drawing.Point(23, 23)
        Me.Nazwa_usługi.Name = "Nazwa_usługi"
        Me.Nazwa_usługi.Size = New System.Drawing.Size(283, 140)
        Me.Nazwa_usługi.TabIndex = 1
        Me.Nazwa_usługi.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nazwa towaru lub usługi:"
        '
        'Dodaj
        '
        Me.Dodaj.Location = New System.Drawing.Point(376, 185)
        Me.Dodaj.Name = "Dodaj"
        Me.Dodaj.Size = New System.Drawing.Size(75, 23)
        Me.Dodaj.TabIndex = 2
        Me.Dodaj.Text = "Dodaj"
        Me.Dodaj.UseVisualStyleBackColor = True
        '
        'Anuluj
        '
        Me.Anuluj.Location = New System.Drawing.Point(457, 185)
        Me.Anuluj.Name = "Anuluj"
        Me.Anuluj.Size = New System.Drawing.Size(75, 23)
        Me.Anuluj.TabIndex = 3
        Me.Anuluj.Text = "Anuluj"
        Me.Anuluj.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 218)
        Me.Controls.Add(Me.Anuluj)
        Me.Controls.Add(Me.Dodaj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nazwa_usługi)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dodawanie pozycji"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Nazwa_usługi As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Dodaj As Button
    Friend WithEvents Anuluj As Button
    Friend WithEvents vat As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Ilosc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents C_netto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents C_brutto As TextBox
    Friend WithEvents Label5 As Label
End Class
