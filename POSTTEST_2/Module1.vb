Module Module1
    Public daftarBuku(99) As String
    Public jumlahBuku As Integer = 0

    Public Function HitungBuku() As Integer
        Return jumlahBuku
    End Function

    Public Sub TambahData(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku) = judul & " (" & genre & ")"
            jumlahBuku += 1
        End If
    End Sub

    Public Sub HapusData(ByVal cari As String, ByRef sukses As Boolean)
        sukses = False
        For i As Integer = 0 To jumlahBuku - 1
            If daftarBuku(i).ToLower().StartsWith(cari.ToLower() & " (") Then
                For j As Integer = i To jumlahBuku - 2
                    daftarBuku(j) = daftarBuku(j + 1)
                Next
                jumlahBuku -= 1
                sukses = True
                Exit Sub
            End If
        Next
    End Sub
End Module
