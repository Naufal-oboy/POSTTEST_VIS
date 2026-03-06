Public Class Form1
    Private Sub TampilList()
        LstBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            LstBuku.Items.Add(daftarBuku(i))
        Next
        Me.Text = "Posttest 2 - Total: " & HitungBuku()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If TxtNamaTambah.Text <> "" And TxtGenre.Text <> "" Then
            TambahData(TxtNamaTambah.Text, TxtGenre.Text)
            TampilList()
            TxtNamaTambah.Clear()
            TxtGenre.Clear()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim cek As Boolean = False

        If TxtNamaHapus.Text <> "" Then
            HapusData(TxtNamaHapus.Text, cek)

            If cek = True Then
                MsgBox("Buku berhasil dihapus!")
                TampilList()
            Else
                MsgBox("Buku tidak ditemukan!")
            End If
            TxtNamaHapus.Clear()
        End If
    End Sub
End Class