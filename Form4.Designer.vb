<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.FD = New System.Windows.Forms.CheckBox()
        Me.FZ = New System.Windows.Forms.CheckBox()
        Me.KF = New System.Windows.Forms.CheckBox()
        Me.FVM = New System.Windows.Forms.CheckBox()
        Me.Par = New System.Windows.Forms.CheckBox()
        Me.FV = New System.Windows.Forms.CheckBox()
        Me.Zamknij_U = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Regon_S = New System.Windows.Forms.TextBox()
        Me.NIP_S = New System.Windows.Forms.TextBox()
        Me.Miejscowosc_S = New System.Windows.Forms.TextBox()
        Me.Kod_S = New System.Windows.Forms.TextBox()
        Me.Adres_S = New System.Windows.Forms.TextBox()
        Me.Nazwa_S = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FD)
        Me.GroupBox1.Controls.Add(Me.FZ)
        Me.GroupBox1.Controls.Add(Me.KF)
        Me.GroupBox1.Controls.Add(Me.FVM)
        Me.GroupBox1.Controls.Add(Me.Par)
        Me.GroupBox1.Controls.Add(Me.FV)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 189)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rodzaj dokumentu"
        '
        'FD
        '
        Me.FD.AutoSize = True
        Me.FD.Location = New System.Drawing.Point(16, 144)
        Me.FD.Name = "FD"
        Me.FD.Size = New System.Drawing.Size(115, 17)
        Me.FD.TabIndex = 5
        Me.FD.Text = "Faktura Detaliczna"
        Me.FD.UseVisualStyleBackColor = True
        '
        'FZ
        '
        Me.FZ.AutoSize = True
        Me.FZ.Location = New System.Drawing.Point(16, 121)
        Me.FZ.Name = "FZ"
        Me.FZ.Size = New System.Drawing.Size(106, 17)
        Me.FZ.TabIndex = 4
        Me.FZ.Text = "Faktura Zbiorcza"
        Me.FZ.UseVisualStyleBackColor = True
        '
        'KF
        '
        Me.KF.AutoSize = True
        Me.KF.Location = New System.Drawing.Point(16, 98)
        Me.KF.Name = "KF"
        Me.KF.Size = New System.Drawing.Size(101, 17)
        Me.KF.TabIndex = 3
        Me.KF.Text = "Korekta Faktury"
        Me.KF.UseVisualStyleBackColor = True
        '
        'FVM
        '
        Me.FVM.AutoSize = True
        Me.FVM.Location = New System.Drawing.Point(16, 75)
        Me.FVM.Name = "FVM"
        Me.FVM.Size = New System.Drawing.Size(118, 17)
        Me.FVM.TabIndex = 2
        Me.FVM.Text = "Faktura VAT-Marża"
        Me.FVM.UseVisualStyleBackColor = True
        '
        'Par
        '
        Me.Par.AutoSize = True
        Me.Par.Location = New System.Drawing.Point(16, 52)
        Me.Par.Name = "Par"
        Me.Par.Size = New System.Drawing.Size(66, 17)
        Me.Par.TabIndex = 1
        Me.Par.Text = "Paragon"
        Me.Par.UseVisualStyleBackColor = True
        '
        'FV
        '
        Me.FV.AutoSize = True
        Me.FV.Enabled = False
        Me.FV.Location = New System.Drawing.Point(16, 29)
        Me.FV.Name = "FV"
        Me.FV.Size = New System.Drawing.Size(86, 17)
        Me.FV.TabIndex = 0
        Me.FV.Text = "Faktura VAT"
        Me.FV.UseVisualStyleBackColor = True
        '
        'Zamknij_U
        '
        Me.Zamknij_U.Location = New System.Drawing.Point(430, 217)
        Me.Zamknij_U.Name = "Zamknij_U"
        Me.Zamknij_U.Size = New System.Drawing.Size(99, 32)
        Me.Zamknij_U.TabIndex = 1
        Me.Zamknij_U.Text = "Zamknij"
        Me.Zamknij_U.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Regon_S)
        Me.GroupBox2.Controls.Add(Me.NIP_S)
        Me.GroupBox2.Controls.Add(Me.Miejscowosc_S)
        Me.GroupBox2.Controls.Add(Me.Kod_S)
        Me.GroupBox2.Controls.Add(Me.Adres_S)
        Me.GroupBox2.Controls.Add(Me.Nazwa_S)
        Me.GroupBox2.Location = New System.Drawing.Point(176, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(353, 189)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dane sprzedawcy"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "REGON:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NIP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Kod / Miejscowość:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Adres:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nazwa:"
        '
        'Regon_S
        '
        Me.Regon_S.Location = New System.Drawing.Point(118, 153)
        Me.Regon_S.MaxLength = 9
        Me.Regon_S.Name = "Regon_S"
        Me.Regon_S.Size = New System.Drawing.Size(229, 20)
        Me.Regon_S.TabIndex = 5
        '
        'NIP_S
        '
        Me.NIP_S.Location = New System.Drawing.Point(118, 127)
        Me.NIP_S.MaxLength = 10
        Me.NIP_S.Name = "NIP_S"
        Me.NIP_S.Size = New System.Drawing.Size(229, 20)
        Me.NIP_S.TabIndex = 4
        '
        'Miejscowosc_S
        '
        Me.Miejscowosc_S.Location = New System.Drawing.Point(193, 101)
        Me.Miejscowosc_S.Name = "Miejscowosc_S"
        Me.Miejscowosc_S.Size = New System.Drawing.Size(154, 20)
        Me.Miejscowosc_S.TabIndex = 3
        '
        'Kod_S
        '
        Me.Kod_S.Location = New System.Drawing.Point(118, 101)
        Me.Kod_S.MaxLength = 6
        Me.Kod_S.Name = "Kod_S"
        Me.Kod_S.Size = New System.Drawing.Size(69, 20)
        Me.Kod_S.TabIndex = 2
        '
        'Adres_S
        '
        Me.Adres_S.Location = New System.Drawing.Point(118, 75)
        Me.Adres_S.Name = "Adres_S"
        Me.Adres_S.Size = New System.Drawing.Size(229, 20)
        Me.Adres_S.TabIndex = 1
        '
        'Nazwa_S
        '
        Me.Nazwa_S.Location = New System.Drawing.Point(118, 26)
        Me.Nazwa_S.Multiline = True
        Me.Nazwa_S.Name = "Nazwa_S"
        Me.Nazwa_S.Size = New System.Drawing.Size(229, 43)
        Me.Nazwa_S.TabIndex = 0
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 261)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Zamknij_U)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ustawienia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FVM As CheckBox
    Friend WithEvents Par As CheckBox
    Friend WithEvents FV As CheckBox
    Friend WithEvents FD As CheckBox
    Friend WithEvents FZ As CheckBox
    Friend WithEvents KF As CheckBox
    Friend WithEvents Zamknij_U As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Regon_S As TextBox
    Friend WithEvents NIP_S As TextBox
    Friend WithEvents Miejscowosc_S As TextBox
    Friend WithEvents Kod_S As TextBox
    Friend WithEvents Adres_S As TextBox
    Friend WithEvents Nazwa_S As TextBox
End Class
