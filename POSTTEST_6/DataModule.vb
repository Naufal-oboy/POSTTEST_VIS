Imports MySqlConnector

Module DataModule
    Public Function LoadData(query As String) As DataTable
        Dim dt As New DataTable
        Using conn = ConnectionModule.GetConnection()
            Dim da As New MySqlDataAdapter(query, conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function AmbilDaftarLapangan() As DataTable
        Dim dt As New DataTable
        Using conn = ConnectionModule.GetConnection()
            Dim da As New MySqlDataAdapter("SELECT id, nama FROM lapangan", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Function SimpanLapangan(id As String, nama As String, lok As String, harga As Integer, stat As String, ac As String) As Boolean
        Using conn = ConnectionModule.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO lapangan (id, nama, lokasi, harga, status, pakai_ac) VALUES (@id, @nama, @lokasi, @harga, @status, @ac)", conn)
            cmd.Parameters.AddWithValue("@id", id) : cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@lokasi", lok) : cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@status", stat) : cmd.Parameters.AddWithValue("@ac", ac)
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function UbahLapangan(id As String, nama As String, lok As String, harga As Integer, stat As String, ac As String) As Boolean
        Using conn = ConnectionModule.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE lapangan SET nama=@nama, lokasi=@lokasi, harga=@harga, status=@status, pakai_ac=@ac WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@id", id) : cmd.Parameters.AddWithValue("@nama", nama)
            cmd.Parameters.AddWithValue("@lokasi", lok) : cmd.Parameters.AddWithValue("@harga", harga)
            cmd.Parameters.AddWithValue("@status", stat) : cmd.Parameters.AddWithValue("@ac", ac)
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function HapusData(namaTabel As String, namaKolomID As String, id As String) As Boolean
        Using conn = ConnectionModule.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand($"DELETE FROM {namaTabel} WHERE {namaKolomID}=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function


    Public Function SimpanTransaksi(idT As String, idL As String, nama As String, tgl As String, durasi As Integer, total As Integer) As Boolean
        Using conn = ConnectionModule.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO transaksi (id_transaksi, id, nama_pelanggan, tgl_sewa, durasi, total_bayar) VALUES (@idT, @idL, @nama, @tgl, @durasi, @total)", conn)
            cmd.Parameters.AddWithValue("@idT", idT) : cmd.Parameters.AddWithValue("@idL", idL)
            cmd.Parameters.AddWithValue("@nama", nama) : cmd.Parameters.AddWithValue("@tgl", tgl)
            cmd.Parameters.AddWithValue("@durasi", durasi) : cmd.Parameters.AddWithValue("@total", total)
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    Public Function UbahTransaksi(idT As String, idL As String, nama As String, tgl As String, durasi As Integer, total As Integer) As Boolean
        Using conn = ConnectionModule.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE transaksi SET id=@idL, nama_pelanggan=@nama, tgl_sewa=@tgl, durasi=@durasi, total_bayar=@total WHERE id_transaksi=@idT", conn)
            cmd.Parameters.AddWithValue("@idT", idT) : cmd.Parameters.AddWithValue("@idL", idL)
            cmd.Parameters.AddWithValue("@nama", nama) : cmd.Parameters.AddWithValue("@tgl", tgl)
            cmd.Parameters.AddWithValue("@durasi", durasi) : cmd.Parameters.AddWithValue("@total", total)
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function
End Module