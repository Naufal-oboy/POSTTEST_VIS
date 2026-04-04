Module Module1
    Public Sub HanyaAngka(ByVal e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
            MessageBox.Show("Inputan harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Public Sub HanyaHuruf(ByVal e As KeyPressEventArgs)
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar)) Then
            e.Handled = True
            MessageBox.Show("Inputan harus berupa huruf!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Module
