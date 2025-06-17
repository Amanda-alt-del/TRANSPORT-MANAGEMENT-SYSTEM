<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        cboDriver = New ComboBox()
        cboVehicle = New ComboBox()
        dtpTripDate = New DateTimePicker()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        dgvAssignments = New DataGridView()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtStartPoint = New TextBox()
        txtDestination = New TextBox()
        txtStatus = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        txtAssignmentID = New TextBox()
        Label8 = New Label()
        btnBack = New Button()
        CType(dgvAssignments, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(561, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Driver"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 1
        Label2.Text = "Vehicle"
        ' 
        ' cboDriver
        ' 
        cboDriver.FormattingEnabled = True
        cboDriver.Location = New Point(689, 108)
        cboDriver.Name = "cboDriver"
        cboDriver.Size = New Size(250, 28)
        cboDriver.TabIndex = 2
        ' 
        ' cboVehicle
        ' 
        cboVehicle.FormattingEnabled = True
        cboVehicle.Location = New Point(120, 100)
        cboVehicle.Name = "cboVehicle"
        cboVehicle.Size = New Size(250, 28)
        cboVehicle.TabIndex = 3
        ' 
        ' dtpTripDate
        ' 
        dtpTripDate.Location = New Point(689, 233)
        dtpTripDate.Name = "dtpTripDate"
        dtpTripDate.Size = New Size(250, 27)
        dtpTripDate.TabIndex = 4
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Purple
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(195, 293)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 5
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Purple
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(631, 293)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Purple
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(428, 293)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' dgvAssignments
        ' 
        dgvAssignments.BackgroundColor = Color.White
        dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAssignments.Location = New Point(3, 343)
        dgvAssignments.Name = "dgvAssignments"
        dgvAssignments.RowHeadersWidth = 51
        dgvAssignments.Size = New Size(948, 410)
        dgvAssignments.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(552, 238)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 9
        Label3.Text = "Date"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 20)
        Label4.TabIndex = 10
        Label4.Text = "Start Point"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(552, 176)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 20)
        Label5.TabIndex = 11
        Label5.Text = "Destination"
        ' 
        ' txtStartPoint
        ' 
        txtStartPoint.Location = New Point(120, 169)
        txtStartPoint.Name = "txtStartPoint"
        txtStartPoint.Size = New Size(250, 27)
        txtStartPoint.TabIndex = 12
        ' 
        ' txtDestination
        ' 
        txtDestination.Location = New Point(689, 173)
        txtDestination.Name = "txtDestination"
        txtDestination.Size = New Size(250, 27)
        txtDestination.TabIndex = 13
        ' 
        ' txtStatus
        ' 
        txtStatus.Location = New Point(120, 231)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(250, 27)
        txtStatus.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 15
        Label6.Text = "Status"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(3, 53)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 20)
        Label7.TabIndex = 16
        Label7.Text = "Assignment ID"
        ' 
        ' txtAssignmentID
        ' 
        txtAssignmentID.Location = New Point(120, 53)
        txtAssignmentID.Name = "txtAssignmentID"
        txtAssignmentID.Size = New Size(94, 27)
        txtAssignmentID.TabIndex = 17
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DeepSkyBlue
        Label8.Location = New Point(361, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(193, 31)
        Label8.TabIndex = 18
        Label8.Text = "Assignment Form"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(845, 308)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 19
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumPurple
        ClientSize = New Size(951, 750)
        Controls.Add(btnBack)
        Controls.Add(Label8)
        Controls.Add(txtAssignmentID)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtStatus)
        Controls.Add(txtDestination)
        Controls.Add(txtStartPoint)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(dgvAssignments)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(dtpTripDate)
        Controls.Add(cboVehicle)
        Controls.Add(cboDriver)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        CType(dgvAssignments, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDriver As ComboBox
    Friend WithEvents cboVehicle As ComboBox
    Friend WithEvents dtpTripDate As DateTimePicker
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvAssignments As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStartPoint As TextBox
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAssignmentID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnBack As Button
End Class
