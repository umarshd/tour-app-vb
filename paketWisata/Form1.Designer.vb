<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectTujuanWisata = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bintang3 = New System.Windows.Forms.RadioButton()
        Me.bintang4 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.printNamaHotel = New System.Windows.Forms.TextBox()
        Me.printBiayaPerMalam = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputLamaMenginap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inputJumlahPeserta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tourGuide = New System.Windows.Forms.CheckBox()
        Me.transportasi = New System.Windows.Forms.CheckBox()
        Me.printTotalBiaya = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tujuan Wisata"
        '
        'selectTujuanWisata
        '
        Me.selectTujuanWisata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectTujuanWisata.FormattingEnabled = True
        Me.selectTujuanWisata.Location = New System.Drawing.Point(33, 69)
        Me.selectTujuanWisata.Name = "selectTujuanWisata"
        Me.selectTujuanWisata.Size = New System.Drawing.Size(221, 28)
        Me.selectTujuanWisata.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(306, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jenis Hotel"
        '
        'bintang3
        '
        Me.bintang3.AutoSize = True
        Me.bintang3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bintang3.Location = New System.Drawing.Point(53, 144)
        Me.bintang3.Name = "bintang3"
        Me.bintang3.Size = New System.Drawing.Size(95, 24)
        Me.bintang3.TabIndex = 4
        Me.bintang3.TabStop = True
        Me.bintang3.Text = "Bintang 3"
        Me.bintang3.UseVisualStyleBackColor = True
        '
        'bintang4
        '
        Me.bintang4.AutoSize = True
        Me.bintang4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bintang4.Location = New System.Drawing.Point(53, 174)
        Me.bintang4.Name = "bintang4"
        Me.bintang4.Size = New System.Drawing.Size(95, 24)
        Me.bintang4.TabIndex = 5
        Me.bintang4.TabStop = True
        Me.bintang4.Text = "Bintang 4"
        Me.bintang4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nama Hotel"
        '
        'printNamaHotel
        '
        Me.printNamaHotel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printNamaHotel.Location = New System.Drawing.Point(194, 214)
        Me.printNamaHotel.Name = "printNamaHotel"
        Me.printNamaHotel.Size = New System.Drawing.Size(211, 26)
        Me.printNamaHotel.TabIndex = 7
        '
        'printBiayaPerMalam
        '
        Me.printBiayaPerMalam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBiayaPerMalam.Location = New System.Drawing.Point(194, 246)
        Me.printBiayaPerMalam.Name = "printBiayaPerMalam"
        Me.printBiayaPerMalam.Size = New System.Drawing.Size(211, 26)
        Me.printBiayaPerMalam.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Biaya Per Malam"
        '
        'inputLamaMenginap
        '
        Me.inputLamaMenginap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputLamaMenginap.Location = New System.Drawing.Point(194, 278)
        Me.inputLamaMenginap.Name = "inputLamaMenginap"
        Me.inputLamaMenginap.Size = New System.Drawing.Size(73, 26)
        Me.inputLamaMenginap.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lama Menginap"
        '
        'inputJumlahPeserta
        '
        Me.inputJumlahPeserta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputJumlahPeserta.Location = New System.Drawing.Point(194, 310)
        Me.inputJumlahPeserta.Name = "inputJumlahPeserta"
        Me.inputJumlahPeserta.Size = New System.Drawing.Size(73, 26)
        Me.inputJumlahPeserta.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Jumlah Peserta"
        '
        'tourGuide
        '
        Me.tourGuide.AutoSize = True
        Me.tourGuide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tourGuide.Location = New System.Drawing.Point(33, 364)
        Me.tourGuide.Name = "tourGuide"
        Me.tourGuide.Size = New System.Drawing.Size(107, 24)
        Me.tourGuide.TabIndex = 14
        Me.tourGuide.Text = "Tour Guide"
        Me.tourGuide.UseVisualStyleBackColor = True
        '
        'transportasi
        '
        Me.transportasi.AutoSize = True
        Me.transportasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.transportasi.Location = New System.Drawing.Point(194, 364)
        Me.transportasi.Name = "transportasi"
        Me.transportasi.Size = New System.Drawing.Size(116, 24)
        Me.transportasi.TabIndex = 15
        Me.transportasi.Text = "Transportasi"
        Me.transportasi.UseVisualStyleBackColor = True
        '
        'printTotalBiaya
        '
        Me.printTotalBiaya.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printTotalBiaya.Location = New System.Drawing.Point(194, 405)
        Me.printTotalBiaya.Name = "printTotalBiaya"
        Me.printTotalBiaya.Size = New System.Drawing.Size(211, 26)
        Me.printTotalBiaya.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Total Biaya"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(290, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Hari"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(290, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Orang"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 457)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.printTotalBiaya)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.transportasi)
        Me.Controls.Add(Me.tourGuide)
        Me.Controls.Add(Me.inputJumlahPeserta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inputLamaMenginap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.printBiayaPerMalam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.printNamaHotel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bintang4)
        Me.Controls.Add(Me.bintang3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.selectTujuanWisata)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents selectTujuanWisata As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bintang3 As System.Windows.Forms.RadioButton
    Friend WithEvents bintang4 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents printNamaHotel As System.Windows.Forms.TextBox
    Friend WithEvents printBiayaPerMalam As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inputLamaMenginap As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents inputJumlahPeserta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tourGuide As System.Windows.Forms.CheckBox
    Friend WithEvents transportasi As System.Windows.Forms.CheckBox
    Friend WithEvents printTotalBiaya As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
