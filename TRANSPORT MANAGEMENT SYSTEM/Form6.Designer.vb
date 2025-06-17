<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cmbDriver = New ComboBox()
        cmbVehicle = New ComboBox()
        txtStartPoint = New TextBox()
        txtDestination = New TextBox()
        btnSave = New Button()
        btnDelete = New Button()
        dtpTripDate = New DateTimePicker()
        dgvTrips = New DataGridView()
        col_tripID = New DataGridViewTextBoxColumn()
        col_Date = New DataGridViewTextBoxColumn()
        col_Start = New DataGridViewTextBoxColumn()
        col_Destination = New DataGridViewTextBoxColumn()
        col_Status = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        cmbStatus = New ComboBox()
        CType(dgvTrips, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmbDriver
        ' 
        cmbDriver.FormattingEnabled = True
        cmbDriver.Location = New Point(12, 47)
        cmbDriver.Name = "cmbDriver"
        cmbDriver.Size = New Size(151, 28)
        cmbDriver.TabIndex = 0
        ' 
        ' cmbVehicle
        ' 
        cmbVehicle.FormattingEnabled = True
        cmbVehicle.Location = New Point(196, 47)
        cmbVehicle.Name = "cmbVehicle"
        cmbVehicle.Size = New Size(151, 28)
        cmbVehicle.TabIndex = 1
        ' 
        ' txtStartPoint
        ' 
        txtStartPoint.Location = New Point(873, 74)
        txtStartPoint.Name = "txtStartPoint"
        txtStartPoint.Size = New Size(145, 27)
        txtStartPoint.TabIndex = 2
        ' 
        ' txtDestination
        ' 
        txtDestination.Location = New Point(873, 141)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(145, 27)
        txtDestination.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(173, 161)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 53)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(374, 161)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 53)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dtpTripDate
        ' 
        dtpTripDate.Location = New Point(373, 48)
        dtpTripDate.Name = "dtpTripDate"
        dtpTripDate.Size = New Size(246, 27)
        dtpTripDate.TabIndex = 6
        ' 
        ' dgvTrips
        ' 
        dgvTrips.BackgroundColor = Color.White
        dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTrips.Columns.AddRange(New DataGridViewColumn() {col_tripID, col_Date, col_Start, col_Destination, col_Status})
        dgvTrips.Location = New Point(1, 235)
        dgvTrips.Name = "dgvTrips"
        dgvTrips.RowHeadersWidth = 51
        dgvTrips.Size = New Size(1041, 344)
        dgvTrips.TabIndex = 7
        ' 
        ' col_tripID
        ' 
        col_tripID.HeaderText = "Trip ID"
        col_tripID.MinimumWidth = 6
        col_tripID.Name = "col_tripID"
        col_tripID.Width = 125
        ' 
        ' col_Date
        ' 
        col_Date.HeaderText = "Date"
        col_Date.MinimumWidth = 6
        col_Date.Name = "col_Date"
        col_Date.Width = 125
        ' 
        ' col_Start
        ' 
        col_Start.HeaderText = "Start"
        col_Start.MinimumWidth = 6
        col_Start.Name = "col_Start"
        col_Start.Width = 125
        ' 
        ' col_Destination
        ' 
        col_Destination.HeaderText = "Destination"
        col_Destination.MinimumWidth = 6
        col_Destination.Name = "col_Destination"
        col_Destination.Width = 125
        ' 
        ' col_Status
        ' 
        col_Status.HeaderText = "Status"
        col_Status.MinimumWidth = 6
        col_Status.Name = "col_Status"
        col_Status.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 11
        Label1.Text = "Driver"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(196, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 12
        Label2.Text = "Vehicle"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(374, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 13
        Label3.Text = "Trip Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(873, 51)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 14
        Label4.Text = "Start Point"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(873, 118)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 15
        Label5.Text = "Destination"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(673, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 16
        Label6.Text = "Status"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Items.AddRange(New Object() {"completed", "ongoing"})
        cmbStatus.Location = New Point(673, 48)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(151, 28)
        cmbStatus.TabIndex = 17
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumPurple
        ClientSize = New Size(1041, 580)
        Controls.Add(cmbStatus)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvTrips)
        Controls.Add(dtpTripDate)
        Controls.Add(btnDelete)
        Controls.Add(btnSave)
        Controls.Add(txtDestination)
        Controls.Add(txtStartPoint)
        Controls.Add(cmbVehicle)
        Controls.Add(cmbDriver)
        Name = "Form6"
        Text = "Form6"
        CType(dgvTrips, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbDriver As ComboBox
    Friend WithEvents cmbVehicle As ComboBox
    Friend WithEvents txtStartPoint As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dtpTripDate As DateTimePicker
    Friend WithEvents dgvTrips As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents col_tripID As DataGridViewTextBoxColumn
    Friend WithEvents col_Date As DataGridViewTextBoxColumn
    Friend WithEvents col_Start As DataGridViewTextBoxColumn
    Friend WithEvents col_Destination As DataGridViewTextBoxColumn
    Friend WithEvents col_Status As DataGridViewTextBoxColumn
End Class
