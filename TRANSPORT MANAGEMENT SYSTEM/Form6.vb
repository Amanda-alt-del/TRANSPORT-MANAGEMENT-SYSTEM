Imports MySql.Data.MySqlClient

Public Class ComboItem
    Public Property Text As String
    Public Property Value As Integer

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrivers()
        LoadVehicles()
        LoadTripLogs()
    End Sub

    Private Sub LoadDrivers()
        cmbDriver.Items.Clear()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT id, name FROM drivers", conn)
                Dim reader = cmd.ExecuteReader()
                While reader.Read()
                    cmbDriver.Items.Add(New ComboItem With {
                        .Text = reader("name").ToString(),
                        .Value = Convert.ToInt32(reader("id"))
                    })
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading drivers: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadVehicles()
        cmbVehicle.Items.Clear()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT vehicle_id, plate_number FROM vehicles", conn)
                Dim reader = cmd.ExecuteReader()
                While reader.Read()
                    Dim idString As String = reader("vehicle_id").ToString()
                    Dim plate As String = reader("plate_number").ToString()

                    If Integer.TryParse(idString, Nothing) Then
                        cmbVehicle.Items.Add(New ComboItem With {
                        .Text = plate,
                        .Value = Convert.ToInt32(idString)
                    })
                    Else
                        MessageBox.Show("Invalid vehicle_id found: '" & idString & "' for plate number: " & plate)
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading vehicles: " & ex.Message)
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbDriver.SelectedItem Is Nothing OrElse cmbVehicle.SelectedItem Is Nothing Then
            MessageBox.Show("Please select driver and vehicle.")
            Return
        End If

        Dim driverId As Integer = CType(cmbDriver.SelectedItem, ComboItem).Value
        Dim vehicleId As Integer = CType(cmbVehicle.SelectedItem, ComboItem).Value
        Dim startPoint As String = txtStartPoint.Text
        Dim destination As String = txtDestination.Text
        Dim tripDate As String = dtpTripDate.Value.ToString("yyyy-MM-dd")
        Dim status As String = cmbStatus.Text

        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")
                conn.Open()
                Dim query As String = "INSERT INTO trip_logs (id, vehicle_id, trip_date, start_point, destination, status) " &
                                      "VALUES (@driver, @vehicle, @date, @start, @dest, @status)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@driver", driverId)
                cmd.Parameters.AddWithValue("@vehicle", vehicleId)
                cmd.Parameters.AddWithValue("@date", tripDate)
                cmd.Parameters.AddWithValue("@start", startPoint)
                cmd.Parameters.AddWithValue("@dest", destination)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Trip log saved.")
            LoadTripLogs()
        Catch ex As Exception
            MessageBox.Show("Error saving trip log: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTripLogs()
        dgvTrips.Rows.Clear()
        Try
            Using conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")
                conn.Open()
                Dim query As String = "SELECT trip_id, trip_date, start_point, destination, status FROM trip_logs"
                Dim cmd As New MySqlCommand(query, conn)
                Dim reader = cmd.ExecuteReader()
                While reader.Read()
                    dgvTrips.Rows.Add(reader("trip_id"), reader("trip_date"), reader("start_point"), reader("destination"), reader("status"))
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading trips: " & ex.Message)
        End Try
    End Sub
End Class
