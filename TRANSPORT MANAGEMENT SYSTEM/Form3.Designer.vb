<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblDriverName = New Label()
        lblLicenceNumber = New Label()
        lblPhoneNumber = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtLicenseNo = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        btnEdit = New Button()
        btnDelete = New Button()
        dgvDrivers = New DataGridView()
        btnSave = New Button()
        Label1 = New Label()
        btnAdd = New Button()
        btnBack = New Button()
        CType(dgvDrivers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblDriverName
        ' 
        lblDriverName.AutoSize = True
        lblDriverName.ForeColor = Color.Black
        lblDriverName.Location = New Point(12, 65)
        lblDriverName.Name = "lblDriverName"
        lblDriverName.Size = New Size(93, 20)
        lblDriverName.TabIndex = 0
        lblDriverName.Text = "Driver Name"
        ' 
        ' lblLicenceNumber
        ' 
        lblLicenceNumber.AutoSize = True
        lblLicenceNumber.ForeColor = Color.Black
        lblLicenceNumber.Location = New Point(251, 65)
        lblLicenceNumber.Name = "lblLicenceNumber"
        lblLicenceNumber.Size = New Size(116, 20)
        lblLicenceNumber.TabIndex = 1
        lblLicenceNumber.Text = "LIcence Number"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.ForeColor = Color.Black
        lblPhoneNumber.Location = New Point(519, 65)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(108, 20)
        lblPhoneNumber.TabIndex = 2
        lblPhoneNumber.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(811, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 3
        Label4.Text = "Adress"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(12, 99)
        txtName.Name = "txtName"
        txtName.Size = New Size(125, 27)
        txtName.TabIndex = 4
        ' 
        ' txtLicenseNo
        ' 
        txtLicenseNo.Location = New Point(251, 99)
        txtLicenseNo.Name = "txtLicenseNo"
        txtLicenseNo.Size = New Size(125, 27)
        txtLicenseNo.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(519, 99)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(125, 27)
        txtPhone.TabIndex = 6
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(811, 99)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(125, 27)
        txtAddress.TabIndex = 7
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.Purple
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(457, 174)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(94, 39)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Purple
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(675, 174)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 39)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' dgvDrivers
        ' 
        dgvDrivers.BackgroundColor = Color.White
        dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDrivers.Location = New Point(-2, 219)
        dgvDrivers.Name = "dgvDrivers"
        dgvDrivers.RowHeadersWidth = 51
        dgvDrivers.Size = New Size(1080, 492)
        dgvDrivers.TabIndex = 11
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Purple
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(217, 174)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(102, 39)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.DeepSkyBlue
        Label1.Location = New Point(361, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 27)
        Label1.TabIndex = 13
        Label1.Text = "Manage Drivers"
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.Purple
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(74, 174)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(102, 39)
        btnAdd.TabIndex = 14
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(984, 167)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 53)
        btnBack.TabIndex = 15
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumPurple
        ClientSize = New Size(1075, 712)
        Controls.Add(btnBack)
        Controls.Add(btnAdd)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(dgvDrivers)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtLicenseNo)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblLicenceNumber)
        Controls.Add(lblDriverName)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(dgvDrivers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblDriverName As Label
    Friend WithEvents lblLicenceNumber As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtLicenseNo As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvDrivers As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnBack As Button
End Class
