<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Students))
        Panel2 = New Panel()
        Button6 = New Button()
        Button5 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button4 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        txtAddress = New TextBox()
        Label9 = New Label()
        btnDelete = New Button()
        btnUpdate = New Button()
        btnReset = New Button()
        btnSave = New Button()
        txtFee = New TextBox()
        Label10 = New Label()
        cmbClass = New ComboBox()
        Label8 = New Label()
        cmbGender = New ComboBox()
        DGVStudents = New DataGridView()
        Label7 = New Label()
        Label6 = New Label()
        dtpDOB = New DateTimePicker()
        txtMobile = New TextBox()
        txtStudent = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Button7 = New Button()
        btnUpload = New Button()
        picTeacher = New PictureBox()
        Label11 = New Label()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DGVStudents, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(picTeacher, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(Button5)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(130, 559)
        Panel2.TabIndex = 9
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.SeaGreen
        Button6.Font = New Font("Javanese Text", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(9, 490)
        Button6.Name = "Button6"
        Button6.Size = New Size(87, 36)
        Button6.TabIndex = 8
        Button6.Text = "Logout"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.SeaGreen
        Button5.BackgroundImage = My.Resources.Resources.pngwing_com
        Button5.BackgroundImageLayout = ImageLayout.Zoom
        Button5.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(9, 194)
        Button5.Name = "Button5"
        Button5.Size = New Size(118, 43)
        Button5.TabIndex = 11
        Button5.Text = "Teachers"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SeaGreen
        Button3.BackgroundImage = My.Resources.Resources.department_1642357
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(9, 403)
        Button3.Name = "Button3"
        Button3.Size = New Size(118, 43)
        Button3.TabIndex = 9
        Button3.Text = "Department"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SeaGreen
        Button2.BackgroundImage = My.Resources.Resources._10206manstudent_110643
        Button2.BackgroundImageLayout = ImageLayout.Zoom
        Button2.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(9, 262)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 43)
        Button2.TabIndex = 8
        Button2.Text = "Students"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.SeaGreen
        Button4.BackgroundImage = My.Resources.Resources.pngwing_com_1
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(9, 330)
        Button4.Name = "Button4"
        Button4.Size = New Size(118, 43)
        Button4.TabIndex = 10
        Button4.Text = "Fee Deposit"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SeaGreen
        Button1.BackgroundImage = My.Resources.Resources.ic_dashboard_128_28270
        Button1.BackgroundImageLayout = ImageLayout.Zoom
        Button1.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(9, 124)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 43)
        Button1.TabIndex = 7
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlText
        PictureBox1.Image = My.Resources.Resources._3986707_building_education_school_school_icon_112987
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(127, 77)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrchid
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(128, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(809, 51)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Javanese Text", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(174, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(483, 80)
        Label1.TabIndex = 0
        Label1.Text = "School Management System"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(652, 144)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(122, 68)
        txtAddress.TabIndex = 98
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(652, 109)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 32)
        Label9.TabIndex = 97
        Label9.Text = "Address"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(261, 262)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(80, 33)
        btnDelete.TabIndex = 95
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Khaki
        btnUpdate.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(592, 262)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(81, 33)
        btnUpdate.TabIndex = 94
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Gold
        btnReset.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(423, 262)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 33)
        btnReset.TabIndex = 93
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightGreen
        btnSave.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(751, 262)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 33)
        btnSave.TabIndex = 92
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtFee
        ' 
        txtFee.Location = New Point(493, 214)
        txtFee.Name = "txtFee"
        txtFee.Size = New Size(99, 23)
        txtFee.TabIndex = 91
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(493, 180)
        Label10.Name = "Label10"
        Label10.Size = New Size(78, 32)
        Label10.TabIndex = 90
        Label10.Text = "Fee Amt."
        ' 
        ' cmbClass
        ' 
        cmbClass.FormattingEnabled = True
        cmbClass.Items.AddRange(New Object() {"PPI", "PPII", "PPIII", "Class I", "Class II", "Class III", "Class IV", "Class V", "Class VI", "Class VII", "Class VIII", "Class IX", "Class X", "Class XI(Maths)", "Class XI(Bio)", "Class XI(Commerce)", "Class XI(Arts)", "Class XII(Maths)", "Class XII(Bio)", "Class XII(Arts)", "Class XII(Commerce)"})
        cmbClass.Location = New Point(328, 214)
        cmbClass.Name = "cmbClass"
        cmbClass.Size = New Size(99, 23)
        cmbClass.TabIndex = 89
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(328, 179)
        Label8.Name = "Label8"
        Label8.Size = New Size(51, 32)
        Label8.TabIndex = 88
        Label8.Text = "Class"
        ' 
        ' cmbGender
        ' 
        cmbGender.FormattingEnabled = True
        cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        cmbGender.Location = New Point(151, 214)
        cmbGender.Name = "cmbGender"
        cmbGender.Size = New Size(115, 23)
        cmbGender.TabIndex = 87
        ' 
        ' DGVStudents
        ' 
        DGVStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVStudents.BorderStyle = BorderStyle.Fixed3D
        DGVStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVStudents.Location = New Point(151, 357)
        DGVStudents.Name = "DGVStudents"
        DGVStudents.Size = New Size(758, 190)
        DGVStudents.TabIndex = 86
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ActiveCaptionText
        Label7.Font = New Font("Javanese Text", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(476, 318)
        Label7.Name = "Label7"
        Label7.Size = New Size(128, 36)
        Label7.TabIndex = 85
        Label7.Text = "Student's List"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(328, 112)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 32)
        Label6.TabIndex = 84
        Label6.Text = "DOB"
        ' 
        ' dtpDOB
        ' 
        dtpDOB.Location = New Point(328, 144)
        dtpDOB.Name = "dtpDOB"
        dtpDOB.Size = New Size(139, 23)
        dtpDOB.TabIndex = 83
        ' 
        ' txtMobile
        ' 
        txtMobile.Location = New Point(493, 147)
        txtMobile.Name = "txtMobile"
        txtMobile.Size = New Size(129, 23)
        txtMobile.TabIndex = 82
        ' 
        ' txtStudent
        ' 
        txtStudent.Location = New Point(151, 144)
        txtStudent.Name = "txtStudent"
        txtStudent.Size = New Size(150, 23)
        txtStudent.TabIndex = 81
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(489, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 32)
        Label5.TabIndex = 80
        Label5.Text = "Mobile no."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(151, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 32)
        Label4.TabIndex = 79
        Label4.Text = "Gender"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Javanese Text", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(151, 109)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 32)
        Label2.TabIndex = 78
        Label2.Text = "Student Name"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.pngwing1
        PictureBox2.Location = New Point(136, 57)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 137
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Javanese Text", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(167, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 54)
        Label3.TabIndex = 136
        Label3.Text = "Students"
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button7.Font = New Font("Javanese Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(826, 215)
        Button7.Name = "Button7"
        Button7.Size = New Size(66, 25)
        Button7.TabIndex = 143
        Button7.Text = "Clear"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' btnUpload
        ' 
        btnUpload.BackColor = Color.Silver
        btnUpload.Font = New Font("Javanese Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpload.Location = New Point(826, 184)
        btnUpload.Name = "btnUpload"
        btnUpload.Size = New Size(66, 25)
        btnUpload.TabIndex = 142
        btnUpload.Text = "Upload"
        btnUpload.UseVisualStyleBackColor = False
        ' 
        ' picTeacher
        ' 
        picTeacher.BorderStyle = BorderStyle.Fixed3D
        picTeacher.Location = New Point(793, 104)
        picTeacher.Name = "picTeacher"
        picTeacher.Size = New Size(122, 79)
        picTeacher.TabIndex = 141
        picTeacher.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(802, 65)
        Label11.Name = "Label11"
        Label11.Size = New Size(102, 36)
        Label11.TabIndex = 140
        Label11.Text = "Upload Pic"
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(937, 559)
        Controls.Add(Button7)
        Controls.Add(btnUpload)
        Controls.Add(picTeacher)
        Controls.Add(Label11)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(txtAddress)
        Controls.Add(Label9)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnReset)
        Controls.Add(btnSave)
        Controls.Add(txtFee)
        Controls.Add(Label10)
        Controls.Add(cmbClass)
        Controls.Add(Label8)
        Controls.Add(cmbGender)
        Controls.Add(DGVStudents)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(dtpDOB)
        Controls.Add(txtMobile)
        Controls.Add(txtStudent)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DGVStudents, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(picTeacher, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFee As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents DGVStudents As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtStudent As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents btnUpload As Button
    Friend WithEvents picTeacher As PictureBox
    Friend WithEvents Label11 As Label
End Class
