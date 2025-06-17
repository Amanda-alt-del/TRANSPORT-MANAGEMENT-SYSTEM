Imports MySql.Data.MySqlClient

Public Class DatabaseHelper
    Private Shared connectionString As String = "server=localhost;userid=root;password=;database=transport_system;"

    Public Shared Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed: " & ex.Message)
        End Try
        Return conn
    End Function
End Class

