Imports MySql.Data.MySqlClient

Public Class Form4
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")

    Private Sub LoadVehicles()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM vehicles"
            Dim cmd As New MySqlCommand(query, conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvVehicles.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading vehicles: " & ex.Message)
        End Try
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            conn.Open()

            Dim query As String = "INSERT INTO vehicles (plate_number, capacity, vehicle_type, status) VALUES (@plate, @capacity, @vehicle_type, @status)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@plate", txtPlateNumber.Text)
            cmd.Parameters.AddWithValue("@capacity", txtCapacity.Text)
            cmd.Parameters.AddWithValue("@vehicle_type", txtVehicleType.Text)
            cmd.Parameters.AddWithValue("@status", txtStatus.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Vehicle added successfully!")
            conn.Close()

            LoadVehicles()
        Catch ex As Exception
            MessageBox.Show("Error adding vehicle: " & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            conn.Open()
            Dim query As String = "UPDATE vehicles SET vehicle_type = @vehicleType, plate_number = @plateNumber, capacity = @capacity, status = @status WHERE vehicle_id = @vehicleID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@vehicleID", txtVehicleID.Text)
            cmd.Parameters.AddWithValue("@vehicleType", txtVehicleType.Text)
            cmd.Parameters.AddWithValue("@plateNumber", txtPlateNumber.Text)
            cmd.Parameters.AddWithValue("@capacity", txtCapacity.Text)
            cmd.Parameters.AddWithValue("@status", txtStatus.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Vehicle updated successfully!")
            LoadVehicles()
        Catch ex As Exception
            MessageBox.Show("Error updating vehicle: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvVehicles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVehicles.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvVehicles.Rows(e.RowIndex)
            txtVehicleID.Text = row.Cells("vehicle_id").Value.ToString()
            txtVehicleType.Text = row.Cells("vehicle_type").Value.ToString()
            txtPlateNumber.Text = row.Cells("plate_number").Value.ToString()
            txtCapacity.Text = row.Cells("capacity").Value.ToString()
            txtStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            conn.Open()
            Dim query As String = "DELETE FROM vehicles WHERE vehicle_id = @vehicleID"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@vehicleID", txtVehicleID.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Vehicle deleted successfully!")
            LoadVehicles()
        Catch ex As Exception
            MessageBox.Show("Error deleting vehicle: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvVehicles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVehicles.CellContentClick

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class