Public Class Form1

    Private Sub listTujuanWisata()
        selectTujuanWisata.Items.Add("Bali - Nusa Dua")
        selectTujuanWisata.Items.Add("Bali - Bedugul Tanah Lot")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listTujuanWisata()
    End Sub

    Private Sub bintang3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bintang3.CheckedChanged
        If (selectTujuanWisata.Text = "Bali - Nusa Dua") Then
            printNamaHotel.Text = "Mahogani Hotel"
            printBiayaPerMalam.Text = 204000
        End If
    End Sub

    Private Sub bintang4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bintang4.CheckedChanged
        If (selectTujuanWisata.Text = "Bali - Nusa Dua") Then
            printNamaHotel.Text = "The Lerina Hotel"
            printBiayaPerMalam.Text = 270000
        End If
    End Sub

    Private Sub totalBiaya()
        Dim biayaHotel As Single
        Dim biayaPaketWisata As Single
        Dim tambahan As Single
        If (selectTujuanWisata.Text = "Bali - Nusa Dua") Then
            biayaPaketWisata = 1193000 * inputJumlahPeserta.Text
        End If
        If (tourGuide.Checked = True) Then
            tambahan = tambahan + 400000 * inputLamaMenginap.Text
        End If
        If (transportasi.Checked = True) Then
            tambahan = tambahan + 300000 * inputLamaMenginap.Text
        End If
        biayaHotel = CDec(printBiayaPerMalam.Text) * CDec(inputLamaMenginap.Text) * CDec(inputJumlahPeserta.Text)
        printTotalBiaya.Text = (biayaHotel + biayaPaketWisata + tambahan).ToString
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        totalBiaya()
    End Sub
End Class
