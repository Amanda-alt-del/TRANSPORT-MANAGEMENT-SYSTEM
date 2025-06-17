Imports MySql.Data.MySqlClient

Public Class Form3
    Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")

    Private Sub btnAddDriver_Click(sender As Object, e As EventArgs)
        Try
            conn.Open()
            Dim query = "INSERT INTO drivers (name, license_no, phone, address) VALUES (@name, @license, @phone, @address)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@license", txtLicenseNo.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Driver added successfully!")


            LoadDrivers()
        Catch ex As Exception
            MessageBox.Show("Error adding driver: " & ex.Message)
        End Try
    End Sub



    Private Sub LoadDrivers()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")

        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM drivers", conn)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvDrivers.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading drivers: " & ex.Message)
        End Try
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrivers()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvDrivers.SelectedRows.Count > 0 Then
            Dim driverId As Integer = Convert.ToInt32(dgvDrivers.SelectedRows(0).Cells("id").Value)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM drivers WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@id", driverId)
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Driver deleted successfully!")
                LoadDrivers()
            Catch ex As Exception
                MessageBox.Show("Error deleting driver: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a driver to delete.")
        End If
    End Sub

    Private Sub dgvDrivers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDrivers.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvDrivers.Rows(e.RowIndex)
            txtName.Text = row.Cells("name").Value.ToString()
            txtLicenseNo.Text = row.Cells("license_no").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
            txtAddress.Text = row.Cells("address").Value.ToString()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvDrivers.SelectedRows.Count > 0 Then
            Dim driverId As Integer = Convert.ToInt32(dgvDrivers.SelectedRows(0).Cells("id").Value)
            Try
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE drivers SET name = @name, license_no = @license, phone = @phone, address = @address WHERE id = @id", conn)
                cmd.Parameters.AddWithValue("@name", txtName.Text)
                cmd.Parameters.AddWithValue("@license", txtLicenseNo.Text)
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
                cmd.Parameters.AddWithValue("@address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@id", driverId)
                cmd.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Driver updated successfully!")
                LoadDrivers()
            Catch ex As Exception
                MessageBox.Show("Error updating driver: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("Please select a driver to update.")
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password=;database=transport")
        Try
            conn.Open()
            Dim query As String = "INSERT INTO drivers (name, license_no, phone, address) VALUES (@name, @license, @phone, @address)"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@name", txtName.Text)
            cmd.Parameters.AddWithValue("@license", txtLicenseNo.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Driver added successfully!")
            LoadDrivers()
        Catch ex As Exception
            MessageBox.Show("Error adding driver: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class

