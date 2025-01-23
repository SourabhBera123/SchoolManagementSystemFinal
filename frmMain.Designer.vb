<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button6 = New Button()
        btnTeacher = New Button()
        btnDepartment = New Button()
        btnStudent = New Button()
        btnFee = New Button()
        btnDashboard = New Button()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        lblStudentCount = New Label()
        PictureBox3 = New PictureBox()
        Panel4 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Panel5 = New Panel()
        lblTeacherCount = New Label()
        PictureBox4 = New PictureBox()
        Panel6 = New Panel()
        Label6 = New Label()
        Panel7 = New Panel()
        Label4 = New Label()
        PictureBox5 = New PictureBox()
        Panel8 = New Panel()
        Label8 = New Label()
        Panel9 = New Panel()
        lblFeeDepositCount = New Label()
        PictureBox6 = New PictureBox()
        Panel10 = New Panel()
        Label10 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        SuspendLayout()
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrchid
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(128, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(809, 51)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.Controls.Add(Button6)
        Panel2.Controls.Add(btnTeacher)
        Panel2.Controls.Add(btnDepartment)
        Panel2.Controls.Add(btnStudent)
        Panel2.Controls.Add(btnFee)
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(130, 559)
        Panel2.TabIndex = 5
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
        ' btnTeacher
        ' 
        btnTeacher.BackColor = Color.SeaGreen
        btnTeacher.BackgroundImage = My.Resources.Resources.pngwing_com
        btnTeacher.BackgroundImageLayout = ImageLayout.Zoom
        btnTeacher.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTeacher.Location = New Point(9, 194)
        btnTeacher.Name = "btnTeacher"
        btnTeacher.Size = New Size(118, 43)
        btnTeacher.TabIndex = 11
        btnTeacher.Text = "Teachers"
        btnTeacher.UseVisualStyleBackColor = False
        ' 
        ' btnDepartment
        ' 
        btnDepartment.BackColor = Color.SeaGreen
        btnDepartment.BackgroundImage = My.Resources.Resources.department_1642357
        btnDepartment.BackgroundImageLayout = ImageLayout.Zoom
        btnDepartment.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDepartment.Location = New Point(9, 403)
        btnDepartment.Name = "btnDepartment"
        btnDepartment.Size = New Size(118, 43)
        btnDepartment.TabIndex = 9
        btnDepartment.Text = "Department"
        btnDepartment.UseVisualStyleBackColor = False
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = Color.SeaGreen
        btnStudent.BackgroundImage = My.Resources.Resources._10206manstudent_110643
        btnStudent.BackgroundImageLayout = ImageLayout.Zoom
        btnStudent.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnStudent.Location = New Point(9, 262)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(118, 43)
        btnStudent.TabIndex = 8
        btnStudent.Text = "Students"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' btnFee
        ' 
        btnFee.BackColor = Color.SeaGreen
        btnFee.BackgroundImage = My.Resources.Resources.pngwing_com_1
        btnFee.BackgroundImageLayout = ImageLayout.Zoom
        btnFee.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFee.Location = New Point(9, 330)
        btnFee.Name = "btnFee"
        btnFee.Size = New Size(118, 43)
        btnFee.TabIndex = 10
        btnFee.Text = "Fee Deposit"
        btnFee.UseVisualStyleBackColor = False
        ' 
        ' btnDashboard
        ' 
        btnDashboard.BackColor = Color.SeaGreen
        btnDashboard.BackgroundImage = My.Resources.Resources.ic_dashboard_128_28270
        btnDashboard.BackgroundImageLayout = ImageLayout.Zoom
        btnDashboard.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDashboard.Location = New Point(9, 124)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(118, 43)
        btnDashboard.TabIndex = 7
        btnDashboard.Text = "Dashboard"
        btnDashboard.UseVisualStyleBackColor = False
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
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.GradientInactiveCaption
        Panel3.Controls.Add(lblStudentCount)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(221, 124)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(219, 185)
        Panel3.TabIndex = 6
        ' 
        ' lblStudentCount
        ' 
        lblStudentCount.AutoSize = True
        lblStudentCount.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStudentCount.Location = New Point(88, 141)
        lblStudentCount.Name = "lblStudentCount"
        lblStudentCount.Size = New Size(35, 36)
        lblStudentCount.TabIndex = 27
        lblStudentCount.Text = "00"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BorderStyle = BorderStyle.Fixed3D
        PictureBox3.Image = My.Resources.Resources.pngwing_com__1_
        PictureBox3.Location = New Point(52, 52)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(114, 74)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.MediumSeaGreen
        Panel4.Controls.Add(Label3)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(219, 46)
        Panel4.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(52, -1)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 47)
        Label3.TabIndex = 12
        Label3.Text = "Students"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Javanese Text", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(166, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 54)
        Label2.TabIndex = 10
        Label2.Text = "Dashboard"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.ic_dashboard_128_282702
        PictureBox2.Location = New Point(135, 57)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.GradientInactiveCaption
        Panel5.Controls.Add(lblTeacherCount)
        Panel5.Controls.Add(PictureBox4)
        Panel5.Controls.Add(Panel6)
        Panel5.Location = New Point(612, 124)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(219, 185)
        Panel5.TabIndex = 12
        ' 
        ' lblTeacherCount
        ' 
        lblTeacherCount.AutoSize = True
        lblTeacherCount.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTeacherCount.Location = New Point(88, 141)
        lblTeacherCount.Name = "lblTeacherCount"
        lblTeacherCount.Size = New Size(35, 36)
        lblTeacherCount.TabIndex = 27
        lblTeacherCount.Text = "00"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BorderStyle = BorderStyle.Fixed3D
        PictureBox4.Image = My.Resources.Resources._10218manteacher_110672
        PictureBox4.Location = New Point(59, 49)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(114, 74)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 26
        PictureBox4.TabStop = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.MediumSeaGreen
        Panel6.Controls.Add(Label6)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(219, 46)
        Panel6.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(52, -1)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 47)
        Label6.TabIndex = 12
        Label6.Text = "Teachers"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = SystemColors.GradientInactiveCaption
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(PictureBox5)
        Panel7.Controls.Add(Panel8)
        Panel7.Location = New Point(221, 341)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(219, 185)
        Panel7.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(88, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 36)
        Label4.TabIndex = 27
        Label4.Text = "00"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BorderStyle = BorderStyle.Fixed3D
        PictureBox5.Image = My.Resources.Resources.department_16423571
        PictureBox5.Location = New Point(52, 52)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(114, 74)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 26
        PictureBox5.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.MediumSeaGreen
        Panel8.Controls.Add(Label8)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(219, 46)
        Panel8.TabIndex = 0
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(36, -1)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 47)
        Label8.TabIndex = 12
        Label8.Text = "Departments"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = SystemColors.GradientInactiveCaption
        Panel9.Controls.Add(lblFeeDepositCount)
        Panel9.Controls.Add(PictureBox6)
        Panel9.Controls.Add(Panel10)
        Panel9.Location = New Point(612, 341)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(219, 185)
        Panel9.TabIndex = 28
        ' 
        ' lblFeeDepositCount
        ' 
        lblFeeDepositCount.AutoSize = True
        lblFeeDepositCount.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFeeDepositCount.Location = New Point(88, 141)
        lblFeeDepositCount.Name = "lblFeeDepositCount"
        lblFeeDepositCount.Size = New Size(35, 36)
        lblFeeDepositCount.TabIndex = 27
        lblFeeDepositCount.Text = "00"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BorderStyle = BorderStyle.Fixed3D
        PictureBox6.Image = My.Resources.Resources.coin_money_icon_icons_com_51091
        PictureBox6.Location = New Point(59, 52)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(114, 74)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 26
        PictureBox6.TabStop = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.MediumSeaGreen
        Panel10.Controls.Add(Label10)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(219, 46)
        Panel10.TabIndex = 0
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(36, -1)
        Label10.Name = "Label10"
        Label10.Size = New Size(149, 47)
        Label10.TabIndex = 12
        Label10.Text = "Fee Deposits"
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(937, 559)
        Controls.Add(Panel9)
        Controls.Add(Panel7)
        Controls.Add(Panel5)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Homepage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnTeacher As Button
    Friend WithEvents btnDepartment As Button
    Friend WithEvents btnStudent As Button
    Friend WithEvents btnFee As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblStudentCount As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblTeacherCount As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblFeeDepositCount As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
End Class
