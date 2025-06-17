Imports MySql.Data.MySqlClient

Public Class Form5
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            conn.Open()
            Dim query As String = "INSERT INTO assignments (driver_id, vehicle_id, start_point, destination, trip_date, status) VALUES (@driverID, @vehicleID, @startPoint, @destination, @tripDate, @status)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@driverID", cboDriver.SelectedValue)
            cmd.Parameters.AddWithValue("@vehicleID", cboVehicle.SelectedValue)
            cmd.Parameters.AddWithValue("@startPoint", txtStartPoint.Text)
            cmd.Parameters.AddWithValue("@destination", txtDestination.Text)
            cmd.Parameters.AddWithValue("@tripDate", dtpTripDate.Value)
            cmd.Parameters.AddWithValue("@status", txtStatus.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Assignment added successfully!")
            LoadAssignments()
        Catch ex As Exception
            MessageBox.Show("Error adding assignment: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadAssignments()
        Try
            conn.Close()
            Dim query As String = "SELECT * FROM assignments"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvAssignments.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading assignments: " & ex.Message)
        End Try
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            conn.Close()
            Dim query As String = "UPDATE assignments SET driver_id = @driverID, vehicle_id = @vehicleID, start_point = @startPoint, destination = @destination, trip_date = @tripDate, status = @status WHERE assignment_id = @assignmentID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@assignmentID", txtAssignmentID.Text)
            cmd.Parameters.AddWithValue("@driverID", cboDriver.SelectedValue)
            cmd.Parameters.AddWithValue("@vehicleID", cboVehicle.SelectedValue)
            cmd.Parameters.AddWithValue("@startPoint", txtStartPoint.Text)
            cmd.Parameters.AddWithValue("@destination", txtDestination.Text)
            cmd.Parameters.AddWithValue("@tripDate", dtpTripDate.Value)
            cmd.Parameters.AddWithValue("@status", txtStatus.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Assignment updated successfully!")
            LoadAssignments()
        Catch ex As Exception
            MessageBox.Show("Error updating assignment: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            conn.Open()
            Dim query As String = "DELETE FROM assignments WHERE assignment_id = @assignmentID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@assignmentID", txtAssignmentID.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Assignment deleted successfully!")
            LoadAssignments()
        Catch ex As Exception
            MessageBox.Show("Error deleting assignment: " & ex.Message)
        End Try
    End Sub


    Private Sub LoadDrivers()
        Try
            conn.Open()
            Dim query As String = "SELECT id, name FROM drivers"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cboDriver.DataSource = table
            cboDriver.DisplayMember = "name"
            cboDriver.ValueMember = "id"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading drivers: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadVehicles()
        Try
            conn.Close()
            Dim query As String = "SELECT vehicle_id, plate_number FROM vehicles"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            cboVehicle.DataSource = table
            cboVehicle.DisplayMember = "plate_number"
            cboVehicle.ValueMember = "vehicle_id"
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading vehicles: " & ex.Message)
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrivers()
        LoadVehicles()
        LoadAssignments()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class