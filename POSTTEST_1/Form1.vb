Public Class Form1

    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0
    Dim ipk As Double = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim ips As Double
        If Double.TryParse(txtIPS.Text, ips) Then

            totalIP = totalIP + ips
            jumlahSemester = jumlahSemester + 1
            ipk = totalIP / jumlahSemester
            txtIPK.Text = ipk.ToString("0.00")

            If ipk >= 2.0 And ipk <= 2.75 Then
                lblPredikat.Text = "Cukup"
            ElseIf ipk >= 2.76 And ipk <= 3.0 Then
                lblPredikat.Text = "Memuaskan"
            ElseIf ipk >= 3.01 Then
                lblPredikat.Text = "Sangat Memuaskan"
            Else
                lblPredikat.Text = "-"
            End If
            txtIPS.Clear()
            txtIPS.Focus()

        Else
            MessageBox.Show("Input harus berupa angka!")
        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        ipk = 0

        txtIPS.Clear()
        txtIPK.Clear()
        lblPredikat.Text = ""

        txtIPS.Focus()

    End Sub

End Class
