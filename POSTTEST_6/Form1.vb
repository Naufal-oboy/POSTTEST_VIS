Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbLokasi.Items.Clear()
        CmbLokasi.Items.AddRange(New Object() {"lantai 1", "lantai 2"})

        CmbStatus.Items.Clear()
        CmbStatus.Items.AddRange(New Object() {"Tersedia", "Booking", "Perbaikan"})

        CmbAC.Items.Clear()
        CmbAC.Items.AddRange(New Object() {"Pakai AC", "Tanpa AC"})

        RefreshSemuaData()
    End Sub

    Private Sub RefreshSemuaData()
        Try
            ' LANGSUNG TEMBAK DATA KE DATAGRIDVIEW
            DgvLapangan.DataSource = DataModule.LoadData("SELECT * FROM lapangan")
            DgvTransaksi.DataSource = DataModule.LoadData("SELECT * FROM transaksi")

            ' ComboBox Lapangan
            CmbLapangan.DataSource = DataModule.AmbilDaftarLapangan()
            CmbLapangan.DisplayMember = "nama"
            CmbLapangan.ValueMember = "id"
            CmbLapangan.SelectedIndex = -1
        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If Not CekValidasi(ErrorProvider1, TxtIdLapangan, TxtNama, TxtHargaLapangan, CmbLokasi, CmbStatus, CmbAC) Then
            MessageBox.Show("Ada isian yang masih kosong! Cek tanda merah di form.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            If DataModule.SimpanLapangan(TxtIdLapangan.Text, TxtNama.Text, CmbLokasi.Text, Val(TxtHargaLapangan.Text), CmbStatus.Text, CmbAC.Text) Then
                MessageBox.Show("Data Lapangan Tersimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshSemuaData() : BtnReset.PerformClick()
            Else
                MessageBox.Show("Gagal menyimpan! Kemungkinan ID sudah ada atau koneksi database bermasalah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If Not CekValidasi(ErrorProvider1, TxtIdLapangan, TxtNama, TxtHargaLapangan) Then Exit Sub
        Try
            If DataModule.UbahLapangan(TxtIdLapangan.Text, TxtNama.Text, CmbLokasi.Text, Val(TxtHargaLapangan.Text), CmbStatus.Text, CmbAC.Text) Then
                MessageBox.Show("Data Lapangan Diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshSemuaData() : BtnReset.PerformClick()
            Else
                MessageBox.Show("Gagal mengubah! Pastikan data sudah dipilih dari tabel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mengubah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        If MessageBox.Show("Yakin Hapus Lapangan?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                If DataModule.HapusData("lapangan", "id", TxtIdLapangan.Text) Then
                    MessageBox.Show("Data Dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshSemuaData() : BtnReset.PerformClick()
                Else
                    MessageBox.Show("Gagal menghapus! Pastikan data sudah dipilih dari tabel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error saat menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtIdLapangan.Clear() : TxtNama.Clear() : TxtHargaLapangan.Clear()
        CmbLokasi.SelectedIndex = -1 : CmbStatus.SelectedIndex = -1 : CmbAC.SelectedIndex = -1
        TxtIdLapangan.ReadOnly = False
        ErrorProvider1.Clear()
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        Dim pencarian As String = TxtCari.Text
        Dim query As String = $"SELECT * FROM lapangan WHERE nama LIKE '%{pencarian}%' OR id LIKE '%{pencarian}%'"
        DgvLapangan.DataSource = DataModule.LoadData(query)
    End Sub



    Private Sub DgvLapangan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLapangan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvLapangan.Rows(e.RowIndex)
            TxtIdLapangan.Text = row.Cells("id").Value.ToString()
            TxtNama.Text = row.Cells("nama").Value.ToString()
            CmbLokasi.Text = row.Cells("lokasi").Value.ToString()
            TxtHargaLapangan.Text = row.Cells("harga").Value.ToString()
            CmbStatus.Text = row.Cells("status").Value.ToString()
            CmbAC.Text = row.Cells("pakai_ac").Value.ToString()
            TxtIdLapangan.ReadOnly = True
        End If
    End Sub

    ' =========================================================
    ' TAB 2: KELOLA TRANSAKSI
    ' =========================================================

    Private Sub BtnSimpanTransaksi_Click(sender As Object, e As EventArgs) Handles BtnSimpanTransaksi.Click
        If Not CekValidasi(ErrorProvider1, TxtIdTransaksi, TxtNamaPelanggan, CmbLapangan, TxtDurasi, TxtTotalBayar) Then Exit Sub
        Try
            Dim tgl As String = DtpTanggal.Value.ToString("yyyy-MM-dd")
            ' Ambil ID lapangan dari SelectedValue, bukan .Text (karena DisplayMember = nama)
            Dim idLapangan As String = If(CmbLapangan.SelectedValue IsNot Nothing, CmbLapangan.SelectedValue.ToString(), "")
            If DataModule.SimpanTransaksi(TxtIdTransaksi.Text, idLapangan, TxtNamaPelanggan.Text, tgl, Val(TxtDurasi.Text), Val(TxtTotalBayar.Text)) Then
                MessageBox.Show("Transaksi Tersimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshSemuaData() : BtnResetTransaksi.PerformClick()
            Else
                MessageBox.Show("Gagal menyimpan transaksi! Kemungkinan ID sudah ada atau lapangan tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat menyimpan transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUbahTransaksi_Click(sender As Object, e As EventArgs) Handles BtnUbahTransaksi.Click
        If Not CekValidasi(ErrorProvider1, TxtIdTransaksi, TxtNamaPelanggan) Then Exit Sub
        Try
            Dim tgl As String = DtpTanggal.Value.ToString("yyyy-MM-dd")
            Dim idLapangan As String = If(CmbLapangan.SelectedValue IsNot Nothing, CmbLapangan.SelectedValue.ToString(), "")
            If DataModule.UbahTransaksi(TxtIdTransaksi.Text, idLapangan, TxtNamaPelanggan.Text, tgl, Val(TxtDurasi.Text), Val(TxtTotalBayar.Text)) Then
                MessageBox.Show("Transaksi Diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshSemuaData() : BtnResetTransaksi.PerformClick()
            Else
                MessageBox.Show("Gagal mengubah transaksi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saat mengubah transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnHapusTransaksi_Click(sender As Object, e As EventArgs) Handles BtnHapusTransaksi.Click
        If MessageBox.Show("Yakin Hapus Transaksi?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                If DataModule.HapusData("transaksi", "id_transaksi", TxtIdTransaksi.Text) Then
                    MessageBox.Show("Transaksi Dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    RefreshSemuaData() : BtnResetTransaksi.PerformClick()
                Else
                    MessageBox.Show("Gagal menghapus transaksi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error saat menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnResetTransaksi_Click(sender As Object, e As EventArgs) Handles BtnResetTransaksi.Click
        TxtIdTransaksi.Clear() : TxtNamaPelanggan.Clear() : TxtDurasi.Clear() : TxtTotalBayar.Clear()
        CmbLapangan.SelectedIndex = -1
        DtpTanggal.Value = Now
        TxtIdTransaksi.ReadOnly = False
        ErrorProvider1.Clear()
    End Sub

    Private Sub TxtCariTransaksi_TextChanged(sender As Object, e As EventArgs) Handles TxtCariTransaksi.TextChanged
        Dim pencarian As String = TxtCariTransaksi.Text
        Dim query As String = $"SELECT * FROM transaksi WHERE nama_pelanggan LIKE '%{pencarian}%' OR id_transaksi LIKE '%{pencarian}%'"
        DgvTransaksi.DataSource = DataModule.LoadData(query)
    End Sub

    Private Sub DgvTransaksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTransaksi.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvTransaksi.Rows(e.RowIndex)
            TxtIdTransaksi.Text = row.Cells("id_transaksi").Value.ToString()
            CmbLapangan.SelectedValue = row.Cells("id").Value.ToString()
            TxtNamaPelanggan.Text = row.Cells("nama_pelanggan").Value.ToString()
            DtpTanggal.Value = Convert.ToDateTime(row.Cells("tgl_sewa").Value)
            TxtDurasi.Text = row.Cells("durasi").Value.ToString()
            TxtTotalBayar.Text = row.Cells("total_bayar").Value.ToString()
            TxtIdTransaksi.ReadOnly = True
        End If
    End Sub

    Private Sub BtnCetakTransaksi_Click(sender As Object, e As EventArgs) Handles BtnCetakTransaksi.Click
        If TxtIdTransaksi.Text = "" Then
            MessageBox.Show("Pilih transaksi dari tabel terlebih dahulu sebelum mencetak!")
            Exit Sub
        End If
        Dim printPreview As New PrintPreviewDialog()
        printPreview.Document = PrintDocument1
        printPreview.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontTeks As New Font("Arial", 12, FontStyle.Regular)
        Dim yPos As Integer = 100
        Dim marginKiri As Integer = 50

        e.Graphics.DrawString("--- STRUK PENYEWAAN LAPANGAN ---", fontJudul, Brushes.Black, marginKiri, 50)
        e.Graphics.DrawString("ID Transaksi   : " & TxtIdTransaksi.Text, fontTeks, Brushes.Black, marginKiri, yPos)
        e.Graphics.DrawString("Nama Pelanggan : " & TxtNamaPelanggan.Text, fontTeks, Brushes.Black, marginKiri, yPos + 30)
        e.Graphics.DrawString("ID Lapangan    : " & CmbLapangan.Text, fontTeks, Brushes.Black, marginKiri, yPos + 60)
        e.Graphics.DrawString("Tanggal Sewa   : " & DtpTanggal.Value.ToString("dd-MM-yyyy"), fontTeks, Brushes.Black, marginKiri, yPos + 90)
        e.Graphics.DrawString("Durasi Main    : " & TxtDurasi.Text & " Jam", fontTeks, Brushes.Black, marginKiri, yPos + 120)
        e.Graphics.DrawString("---------------------------------", fontTeks, Brushes.Black, marginKiri, yPos + 150)
        e.Graphics.DrawString("Total Bayar    : Rp " & TxtTotalBayar.Text, fontJudul, Brushes.Black, marginKiri, yPos + 180)
    End Sub

    Private Sub CmbLapangan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLapangan.SelectedIndexChanged
        ' Event handler siap dikembangkan jika diperlukan
    End Sub

    Private Sub DgvLapangan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLapangan.CellContentClick

    End Sub

    Private Sub TxtNamaPelanggan_TextChanged(sender As Object, e As EventArgs) Handles TxtNamaPelanggan.TextChanged

    End Sub
End Class