<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Edytuj = New System.Windows.Forms.Button()
        Me.Drukuj = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Korekta = New System.Windows.Forms.Button()
        Me.Usun = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Ustawienia = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Dodaj Fakturę"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Edytuj
        '
        Me.Edytuj.Enabled = False
        Me.Edytuj.Location = New System.Drawing.Point(122, 12)
        Me.Edytuj.Name = "Edytuj"
        Me.Edytuj.Size = New System.Drawing.Size(104, 32)
        Me.Edytuj.TabIndex = 1
        Me.Edytuj.Text = "Edytuj"
        Me.Edytuj.UseVisualStyleBackColor = True
        '
        'Drukuj
        '
        Me.Drukuj.Enabled = False
        Me.Drukuj.Location = New System.Drawing.Point(450, 12)
        Me.Drukuj.Name = "Drukuj"
        Me.Drukuj.Size = New System.Drawing.Size(104, 32)
        Me.Drukuj.TabIndex = 2
        Me.Drukuj.Text = "Drukuj"
        Me.Drukuj.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(741, 364)
        Me.DataGridView1.TabIndex = 3
        '
        'Column2
        '
        Me.Column2.HeaderText = "Rodzaj dokumentu"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Numer dokumentu"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "Data wystwienia"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "NIP"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 96
        '
        'Column5
        '
        Me.Column5.HeaderText = "Nazwa kontrahenta"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 175
        '
        'Column6
        '
        Me.Column6.HeaderText = "Forma płatności"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 80
        '
        'Column7
        '
        Me.Column7.HeaderText = "Do zapłaty [zł]"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 95
        '
        'Korekta
        '
        Me.Korekta.Enabled = False
        Me.Korekta.Location = New System.Drawing.Point(231, 12)
        Me.Korekta.Name = "Korekta"
        Me.Korekta.Size = New System.Drawing.Size(104, 32)
        Me.Korekta.TabIndex = 4
        Me.Korekta.Text = "Korekta"
        Me.Korekta.UseVisualStyleBackColor = True
        '
        'Usun
        '
        Me.Usun.Enabled = False
        Me.Usun.Location = New System.Drawing.Point(340, 12)
        Me.Usun.Name = "Usun"
        Me.Usun.Size = New System.Drawing.Size(104, 32)
        Me.Usun.TabIndex = 5
        Me.Usun.Text = "Usuń"
        Me.Usun.UseVisualStyleBackColor = True
        '
        'Ustawienia
        '
        Me.Ustawienia.Location = New System.Drawing.Point(650, 10)
        Me.Ustawienia.Margin = New System.Windows.Forms.Padding(2)
        Me.Ustawienia.Name = "Ustawienia"
        Me.Ustawienia.Size = New System.Drawing.Size(104, 32)
        Me.Ustawienia.TabIndex = 6
        Me.Ustawienia.Text = "Ustawienia"
        Me.Ustawienia.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(765, 423)
        Me.Controls.Add(Me.Ustawienia)
        Me.Controls.Add(Me.Usun)
        Me.Controls.Add(Me.Korekta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Drukuj)
        Me.Controls.Add(Me.Edytuj)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Faktura_Vat v1.00"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Edytuj As Button
    Friend WithEvents Drukuj As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Korekta As Button
    Friend WithEvents Usun As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Ustawienia As Button
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
