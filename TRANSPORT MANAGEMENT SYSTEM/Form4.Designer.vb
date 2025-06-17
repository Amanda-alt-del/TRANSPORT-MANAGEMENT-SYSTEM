<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtVehicleID = New TextBox()
        txtVehicleType = New TextBox()
        txtPlateNumber = New TextBox()
        txtCapacity = New TextBox()
        txtStatus = New TextBox()
        btnAdd = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        Label6 = New Label()
        dgvVehicles = New DataGridView()
        btnBack = New Button()
        CType(dgvVehicles, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 20)
        Label1.TabIndex = 0
        Label1.Text = "Vehicle ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(655, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 20)
        Label2.TabIndex = 1
        Label2.Text = "Type"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(225, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 20)
        Label3.TabIndex = 2
        Label3.Text = "Plate Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(454, 64)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 3
        Label4.Text = "Capacity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(854, 64)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 20)
        Label5.TabIndex = 4
        Label5.Text = "Status"
        ' 
        ' txtVehicleID
        ' 
        txtVehicleID.Location = New Point(12, 96)
        txtVehicleID.Name = "txtVehicleID"
        txtVehicleID.Size = New Size(125, 27)
        txtVehicleID.TabIndex = 5
        ' 
        ' txtVehicleType
        ' 
        txtVehicleType.Location = New Point(655, 96)
        txtVehicleType.Name = "txtVehicleType"
        txtVehicleType.Size = New Size(136, 27)
        txtVehicleType.TabIndex = 6
        ' 
        ' txtPlateNumber
        ' 
        txtPlateNumber.Location = New Point(225, 96)
        txtPlateNumber.Name = "txtPlateNumber"
        txtPlateNumber.Size = New Size(125, 27)
        txtPlateNumber.TabIndex = 7
        ' 
        ' txtCapacity
        ' 
        txtCapacity.Location = New Point(454, 96)
        txtCapacity.Name = "txtCapacity"
        txtCapacity.Size = New Size(125, 27)
        txtCapacity.TabIndex = 8
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(854, 96)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(125, 27)
        txtStatus.TabIndex = 9
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Purple
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(243, 175)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 48)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Purple
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(454, 175)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 48)
        btnEdit.TabIndex = 11
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Purple
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(655, 175)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 48)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.MediumPurple
        Label6.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DeepSkyBlue
        Label6.Location = New Point(364, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(200, 27)
        Label6.TabIndex = 15
        Label6.Text = "Manage Vehicles"
        ' 
        ' dgvVehicles
        ' 
        dgvVehicles.BackgroundColor = Color.White
        dgvVehicles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVehicles.Location = New Point(2, 259)
        dgvVehicles.Name = "dgvVehicles"
        dgvVehicles.RowHeadersWidth = 51
        dgvVehicles.Size = New Size(977, 452)
        dgvVehicles.TabIndex = 14
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(888, 221)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(91, 32)
        btnBack.TabIndex = 16
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumPurple
        ClientSize = New Size(982, 723)
        Controls.Add(btnBack)
        Controls.Add(Label6)
        Controls.Add(dgvVehicles)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAdd)
        Controls.Add(txtStatus)
        Controls.Add(txtCapacity)
        Controls.Add(txtPlateNumber)
        Controls.Add(txtVehicleType)
        Controls.Add(txtVehicleID)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(dgvVehicles, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVehicleID As TextBox
    Friend WithEvents txtVehicleType As TextBox
    Friend WithEvents txtPlateNumber As TextBox
    Friend WithEvents txtCapacity As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvVehicles As DataGridView
    Friend WithEvents btnBack As Button
End Class
