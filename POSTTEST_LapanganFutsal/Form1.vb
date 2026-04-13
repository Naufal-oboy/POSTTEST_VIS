Public Class Form1

    Sub RefreshGrid()
        DgvLapangan.DataSource = GetAllLapangan()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        CmbLokasi.Items.AddRange({"Lantai 1", "Lantai 2"})
        CmbStatus.Items.AddRange({"Tersedia", "Tidak Tersedia"})
        CmbAC.Items.AddRange({"Ya", "Tidak"})
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If IsEmpty(TxtID, TxtNama, TxtHarga, CmbLokasi, CmbStatus, CmbAC) Then
            MessageBox.Show("Semua data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If SimpanLapangan(TxtID.Text, TxtNama.Text, CmbLokasi.Text, Val(TxtHarga.Text), CmbStatus.Text, CmbAC.Text) Then
            MessageBox.Show("Data Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
            BtnReset.PerformClick()
        End If
    End Sub

    Private Sub dgvLapangan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLapangan.CellClick
        Try
            Dim i As Integer = DgvLapangan.CurrentRow.Index
            TxtID.Text = DgvLapangan.Rows(i).Cells(0).Value.ToString
            TxtNama.Text = DgvLapangan.Rows(i).Cells(1).Value.ToString
            CmbLokasi.Text = DgvLapangan.Rows(i).Cells(2).Value.ToString
            TxtHarga.Text = DgvLapangan.Rows(i).Cells(3).Value.ToString
            CmbStatus.Text = DgvLapangan.Rows(i).Cells(4).Value.ToString
            CmbAC.Text = DgvLapangan.Rows(i).Cells(5).Value.ToString

            TxtID.ReadOnly = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        If UbahLapangan(TxtID.Text, TxtNama.Text, CmbLokasi.Text, Val(TxtHarga.Text), CmbStatus.Text, CmbAC.Text) Then
            MessageBox.Show("Data Berhasil Diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RefreshGrid()
            BtnReset.PerformClick()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Dim konfirmasi As DialogResult = MessageBox.Show("Hapus Lapangan ID: " & TxtID.Text & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusLapangan(TxtID.Text) Then
                RefreshGrid()
                BtnReset.PerformClick()
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        DgvLapangan.DataSource = SearchLapangan(TxtCari.Text)
    End Sub

    Private Sub txtHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtHarga.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        TxtID.Clear()
        TxtNama.Clear()
        TxtHarga.Clear()
        CmbLokasi.SelectedIndex = -1
        CmbStatus.SelectedIndex = -1
        CmbAC.SelectedIndex = -1
        TxtID.ReadOnly = False
        TxtID.Focus()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub CmbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbStatus.SelectedIndexChanged

    End Sub
End Class