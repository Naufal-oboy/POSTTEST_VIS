Imports MySqlConnector

Module ConnectionModule
    Public Function GetConnection() As MySqlConnection
        Dim str As String = "server=localhost;user id=root;password=;database=dblapangan"
        Return New MySqlConnection(str)
    End Function
End Module