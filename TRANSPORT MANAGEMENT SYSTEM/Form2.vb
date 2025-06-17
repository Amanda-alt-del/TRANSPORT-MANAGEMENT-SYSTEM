Imports MySql.Data.MySqlClient

Public Class Form2
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardCounts()
    End Sub

    Private Sub LoadDashboardCounts()

        Try
            conn.Open()

            Dim cmdDrivers As New MySqlCommand("SELECT COUNT(*) FROM drivers", conn)
            Dim countDrivers As Integer = Convert.ToInt32(cmdDrivers.ExecuteScalar())
            lblTotalDrivers.Text = countDrivers.ToString()

            Dim cmdVehicles As New MySqlCommand("SELECT COUNT(*) FROM vehicles", conn)
            Dim countVehicles As Integer = Convert.ToInt32(cmdVehicles.ExecuteScalar())
            lblTotalVehicles.Text = countVehicles.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading dashboard counts: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnVehicles_Click(sender As Object, e As EventArgs) Handles btnVehicles.Click
        Form4.Show()
    End Sub

    Private Sub btnDrivers_Click(sender As Object, e As EventArgs) Handles btnDrivers.Click
        Form3.Show()
    End Sub

    Private Sub btnAssignment_Click(sender As Object, e As EventArgs) Handles btnAssignment.Click
        Form5.Show()
    End Sub

    Private Sub btnTripLogs_Click(sender As Object, e As EventArgs) Handles btnTripLogs.Click
        Form6.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
