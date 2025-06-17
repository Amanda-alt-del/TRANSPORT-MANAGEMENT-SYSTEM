<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        btnLogOut = New Button()
        btnTripLogs = New Button()
        btnAssignment = New Button()
        btnVehicles = New Button()
        btnDrivers = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        lblTotalDrivers = New Label()
        Label2 = New Label()
        Panel4 = New Panel()
        lblTotalVehicles = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.MediumPurple
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnLogOut)
        Panel1.Controls.Add(btnTripLogs)
        Panel1.Controls.Add(btnAssignment)
        Panel1.Controls.Add(btnVehicles)
        Panel1.Controls.Add(btnDrivers)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(170, 824)
        Panel1.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(34, 692)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 23)
        Label7.TabIndex = 9
        Label7.Text = "Trip Logs"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(34, 525)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 23)
        Label6.TabIndex = 8
        Label6.Text = "Assignment"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(46, 367)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 23)
        Label5.TabIndex = 7
        Label5.Text = "Vehicles"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(46, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 23)
        Label3.TabIndex = 6
        Label3.Text = "Drivers"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), Image)
        btnLogOut.Location = New Point(34, 741)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(92, 49)
        btnLogOut.TabIndex = 5
        btnLogOut.UseVisualStyleBackColor = True
        ' 
        ' btnTripLogs
        ' 
        btnTripLogs.Image = CType(resources.GetObject("btnTripLogs.Image"), Image)
        btnTripLogs.Location = New Point(19, 575)
        btnTripLogs.Name = "btnTripLogs"
        btnTripLogs.Size = New Size(126, 93)
        btnTripLogs.TabIndex = 4
        btnTripLogs.UseVisualStyleBackColor = True
        ' 
        ' btnAssignment
        ' 
        btnAssignment.Image = CType(resources.GetObject("btnAssignment.Image"), Image)
        btnAssignment.Location = New Point(22, 417)
        btnAssignment.Name = "btnAssignment"
        btnAssignment.Size = New Size(126, 92)
        btnAssignment.TabIndex = 3
        btnAssignment.UseVisualStyleBackColor = True
        ' 
        ' btnVehicles
        ' 
        btnVehicles.Image = CType(resources.GetObject("btnVehicles.Image"), Image)
        btnVehicles.Location = New Point(22, 253)
        btnVehicles.Name = "btnVehicles"
        btnVehicles.Size = New Size(126, 93)
        btnVehicles.TabIndex = 2
        btnVehicles.UseVisualStyleBackColor = True
        ' 
        ' btnDrivers
        ' 
        btnDrivers.Image = CType(resources.GetObject("btnDrivers.Image"), Image)
        btnDrivers.ImageAlign = ContentAlignment.TopCenter
        btnDrivers.Location = New Point(22, 96)
        btnDrivers.Name = "btnDrivers"
        btnDrivers.Size = New Size(126, 93)
        btnDrivers.TabIndex = 1
        btnDrivers.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.MediumPurple
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(170, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1022, 97)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 28)
        Label1.TabIndex = 0
        Label1.Text = "Dashboard"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblTotalDrivers)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(254, 356)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(248, 239)
        Panel3.TabIndex = 2
        ' 
        ' lblTotalDrivers
        ' 
        lblTotalDrivers.AutoSize = True
        lblTotalDrivers.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalDrivers.ForeColor = Color.Red
        lblTotalDrivers.Location = New Point(103, 133)
        lblTotalDrivers.Name = "lblTotalDrivers"
        lblTotalDrivers.Size = New Size(32, 35)
        lblTotalDrivers.TabIndex = 1
        lblTotalDrivers.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(30, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(185, 33)
        Label2.TabIndex = 0
        Label2.Text = "Total Drivers"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(lblTotalVehicles)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(872, 356)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(248, 239)
        Panel4.TabIndex = 3
        ' 
        ' lblTotalVehicles
        ' 
        lblTotalVehicles.AutoSize = True
        lblTotalVehicles.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalVehicles.ForeColor = Color.Red
        lblTotalVehicles.Location = New Point(104, 133)
        lblTotalVehicles.Name = "lblTotalVehicles"
        lblTotalVehicles.Size = New Size(32, 35)
        lblTotalVehicles.TabIndex = 1
        lblTotalVehicles.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(24, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(212, 35)
        Label4.TabIndex = 0
        Label4.Text = "Total Vehicles"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(1192, 824)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVehicles As Button
    Friend WithEvents btnDrivers As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnTripLogs As Button
    Friend WithEvents btnAssignment As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalDrivers As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalVehicles As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
