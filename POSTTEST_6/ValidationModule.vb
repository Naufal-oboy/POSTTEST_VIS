Module ValidationModule

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Function CekValidasi(ep As ErrorProvider, ParamArray controls() As Control) As Boolean
        Dim status As Boolean = True

        If ep IsNot Nothing Then ep.Clear()

        For Each ctrl In controls
            If String.IsNullOrWhiteSpace(ctrl.Text) Then
                If ep IsNot Nothing Then ep.SetError(ctrl, "Harus diisi!")
                status = False

                ' --- JURUS DETEKTIF: Paksa program sebutkan nama kotaknya! ---
                MessageBox.Show("Sistem menganggap kotak ini kosong: " & ctrl.Name, "Ketemu Biang Keroknya!")

            End If
        Next

        Return status
    End Function

End Module