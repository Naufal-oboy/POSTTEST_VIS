Imports MySqlConnector

Module DataModule

    Public Function GetAllLapangan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM lapangan ORDER BY id ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SearchLapangan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM lapangan WHERE nama LIKE @key OR lokasi LIKE @key OR pakai_ac LIKE @key"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Pencarian gagal: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanLapangan(id As String, nama As String, lok As String, harga As Integer, stat As String, ac As String) As Boolean
        Try
            Dim query As String = "INSERT INTO lapangan VALUES (@id, @nama, @lokasi, @harga, @status, @ac)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@lokasi", lok)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@status", stat)
                    cmd.Parameters.AddWithValue("@ac", ac)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MsgBox("Gagal Simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahLapangan(id As String, nama As String, lok As String, harga As Integer, stat As String, ac As String) As Boolean
        Try
            Dim query As String = "UPDATE lapangan SET nama=@nama, lokasi=@lokasi, harga=@harga, status=@status, pakai_ac=@ac WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@lokasi", lok)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@status", stat)
                    cmd.Parameters.AddWithValue("@ac", ac)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function HapusLapangan(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM lapangan WHERE id=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module