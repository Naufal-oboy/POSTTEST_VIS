Imports System.Diagnostics.Eventing

Public Class Form1
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        HanyaHuruf(e)
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtId.KeyPress
        HanyaAngka(e)
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim tanya As DialogResult = MessageBox.Show("Yakin ingin keluar aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.png;*.jpeg"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PbProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Or TxtId.Text = "" Or CmbGenre.SelectedIndex = -1 Or Not MtxtNoTelp.MaskCompleted Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim hobiList As String = ""
        Dim adaHobi As Boolean = False
        For Each cb As CheckBox In GbAktivitas.Controls.OfType(Of CheckBox)()
            If cb.Checked Then
                hobiList &= cb.Text & ", "
                adaHobi = True
            End If
        Next

        If Not adaHobi Then
            MessageBox.Show("Pilih minimal satu aktivitas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim cetak As DialogResult = MessageBox.Show("Apakah anda ingin mencetak kartu?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cetak = DialogResult.Yes Then
            Dim peran As String = ""
            If RbKetua.Checked Then
                peran = "Ketua"
            ElseIf RbAdmin.Checked Then
                peran = "Admin"
            ElseIf RbCoach.Checked Then
                peran = "Coach"
            ElseIf RbProPlayer.Checked Then
                peran = "Pro Player"
            ElseIf RbAnggota.Checked Then
                peran = "Anggota"
            Else
                MessageBox.Show("Silahkan pilih peran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Form2.Lblnama.Text = "Nama" & TxtNama.Text
            Form2.LblID.Text = "ID: " & TxtId.Text
            Form2.LblGenre.Text = "Genre: " & CmbGenre.Text
            Form2.LblRole.Text = "Role: " & peran
            Form2.LblAktivitas.Text = "Aktivitas :" & hobiList.TrimEnd(", ".ToCharArray())
            Form2.LblKontak.Text = "Kontak : " & MtxtNoTelp.Text

            If PbProfil.Image IsNot Nothing Then
                Form2.PbKartu.Image = PbProfil.Image
            End If

            Form2.ShowDialog()
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim jk As String = ""
            If RbLaki.Checked Then jk = "Laki-laki" Else jk = "Perempuan"

            Dim tgl As String = DtpLahir.Value.ToString("dd-MM-yyyy")

            Dim peran As String = ""
            If RbKetua.Checked Then
                peran = "Ketua"
            ElseIf RbAdmin.Checked Then
                peran = "Admin"
            ElseIf RbCoach.Checked Then
                peran = "Coach"
            ElseIf RbProPlayer.Checked Then
                peran = "Pro Player"
            Else
                peran = "Anggota"
            End If

            Dim hobi As String = ""
            For Each cb As CheckBox In GbAktivitas.Controls.OfType(Of CheckBox)()
                If cb.Checked Then
                    hobi &= cb.Text & ";"
                End If
            Next
            If hobi = "" Then hobi = "-"

            Dim hasil As String
            hasil = TxtNama.Text & "," &
                    TxtId.Text & "," &
                    CmbGenre.Text & "," &
                    peran & "," &
                    MtxtNoTelp.Text & "," &
                    jk & "," &
                    tgl & "," &
                    TxtEmail.Text & "," &
                    TxtAlamat.Text & "," &
                    hobi & "," &
                    PbProfil.ImageLocation

            IO.File.WriteAllText(SaveFileDialog1.FileName, hasil)
            MsgBox("Seluruh Data Berhasil Disimpan!")
        End If
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If TxtNama.Text = "" Then
            MessageBox.Show("Belum ada data untuk ditampilkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Form2.ShowDialog()
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim mentah As String = IO.File.ReadAllText(OpenFileDialog1.FileName)

            Dim baris() As String = mentah.Split(","c)

            If baris.Length >= 10 Then
                TxtNama.Text = baris(0)
                TxtId.Text = baris(1)
                CmbGenre.Text = baris(2)

                Dim peran As String = baris(3)
                RbKetua.Checked = peran = "Ketua"
                RbAdmin.Checked = peran = "Admin"
                RbAnggota.Checked = peran = "Anggota"
                RbCoach.Checked = peran = "Coach"
                RbProPlayer.Checked = peran = "Pro Player"

                MtxtNoTelp.Text = baris(4)
                If baris(5) = "Laki-laki" Then RbLaki.Checked = True Else RbPerempuan.Checked = True

                DtpLahir.Value = Date.ParseExact(baris(6), "dd-MM-yyyy", Nothing)

                TxtEmail.Text = baris(7)
                TxtAlamat.Text = baris(8)

                Dim hobiTerambil As String = baris(9)

                For Each cb As CheckBox In GbAktivitas.Controls.OfType(Of CheckBox)()
                    If hobiTerambil.Contains(cb.Text) Then
                        cb.Checked = True
                    Else
                        cb.Checked = False
                    End If
                Next
                If baris.Length > 10 AndAlso IO.File.Exists(baris(10)) Then
                    PbProfil.ImageLocation = baris(10)
                End If

                MsgBox("Data Berhasil Dimuat!")
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class