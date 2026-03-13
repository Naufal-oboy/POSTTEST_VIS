Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PicKartu.ImageLocation = Foto
        PicKartu.SizeMode = PictureBoxSizeMode.StretchImage

        LblNama.Text = "Nama : " & Nama
        LblUmur.Text = "Umur : " & Umur & " Tahun"
        LblJK.Text = "Gender : " & JenisKelamin
        LblTelp.Text = "No. Telp : " & Telepon
        LblLahir.Text = "Lahir : " & TglLahir
        LblHobi.Text = "Hobby : " & Hobi
        LblAlamat.Text = "Alamat : " & Alamat
    End Sub
End Class