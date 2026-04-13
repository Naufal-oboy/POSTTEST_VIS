Module ValidationModule
    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Public Function IsEmpty(ParamArray controls() As Control) As Boolean
        For Each ctrl In controls
            If String.IsNullOrWhiteSpace(ctrl.Text) Then
                Return True
            End If
        Next
        Return False
    End Function
End Module