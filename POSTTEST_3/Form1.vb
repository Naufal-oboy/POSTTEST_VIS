Public Class Form1
    Private Sub HanyaAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUmur.KeyPress, TxtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles BtnGambar.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Foto = OpenFileDialog1.FileName
            PicGambar.ImageLocation = Foto
            PicGambar.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        If TxtNama.Text = "" Or TxtUmur.Text = "" Or TxtTelepon.Text = "" Or TxtAlamat.Text = "" Then
            MsgBox("Inputan tidak boleh kosong")
            Return
        End If

        If Foto = "" Then
            MsgBox("Inputan tidak boleh kosong (Foto belum ada)")
            Return
        End If

        Dim jk As String = ""
        If RbCowo.Checked Then
            jk = "Laki-laki"
        ElseIf RbCewek.Checked Then
            jk = "Perempuan"
        Else
            MsgBox("Inputan tidak boleh kosong (Jenis Kelamin)")
            Return
        End If

        Dim listHobi As String = ""
        Dim adaHobi As Boolean = False

        For Each ctrl As Control In GbHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    listHobi &= chk.Text & ", "
                    adaHobi = True
                End If
            End If
        Next

        If Not adaHobi Then
            MsgBox("Inputan tidak boleh kosong (Pilih minimal 1 Hobby)")
            Return
        End If

        Nama = TxtNama.Text
        Umur = TxtUmur.Text
        Telepon = TxtTelepon.Text
        Alamat = TxtAlamat.Text
        TglLahir = DtpLahir.Value.ToString("dd MMMM yyyy")
        JenisKelamin = jk
        Hobi = listHobi.TrimEnd(", ".ToCharArray())

        Form2.Show()
    End Sub
End Class
