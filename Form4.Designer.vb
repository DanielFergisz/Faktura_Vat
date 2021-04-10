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
        Me.GroupBox1.SuspendLayout()
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
        Me.Zamknij_U.Location = New System.Drawing.Point(295, 169)
        Me.Zamknij_U.Name = "Zamknij_U"
        Me.Zamknij_U.Size = New System.Drawing.Size(99, 32)
        Me.Zamknij_U.TabIndex = 1
        Me.Zamknij_U.Text = "Zamknij"
        Me.Zamknij_U.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 213)
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
End Class
