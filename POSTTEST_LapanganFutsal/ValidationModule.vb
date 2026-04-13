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

    Public Function CekValidasi(ep As ErrorProvider, ParamArray controls() As Control) As Boolean
        Dim status As Boolean = True
        ep.Clear() ' 

        For Each ctrl In controls
            If String.IsNullOrWhiteSpace(ctrl.Text) Then
                ep.SetError(ctrl, "Bagian ini tidak boleh kosong!")
                status = False
            End If
        Next
        Return status
    End Function


End Module