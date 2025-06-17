Imports MySql.Data.MySqlClient

Public Class Form1

    Private connectionString As String = "server=localhost;user id=root;password=;database=transport"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Text = ""
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim conn As New MySqlConnection(connectionString)

        Try
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE username=@username AND password=@password", conn)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                lblStatus.Text = "Login successful!"
                lblStatus.ForeColor = Color.Green
                reader.Close()
                conn.Close()

                Me.Hide()
                Form2.Show()
            Else
                lblStatus.Text = "Invalid username or password."
                lblStatus.ForeColor = Color.Red
                reader.Close()
                conn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message)
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub
End Class
