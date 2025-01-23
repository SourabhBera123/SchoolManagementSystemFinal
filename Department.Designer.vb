<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Department))
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
        btnDelete = New Button()
        btnUpdate = New Button()
        btnReset = New Button()
        btnSave = New Button()
        DGVDept = New DataGridView()
        Label6 = New Label()
        txtDur = New TextBox()
        txtDesc = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        cmbName = New ComboBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(DGVDept, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.TabIndex = 13
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
        Panel1.TabIndex = 12
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
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(282, 258)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(80, 47)
        btnDelete.TabIndex = 47
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Khaki
        btnUpdate.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(581, 258)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(81, 47)
        btnUpdate.TabIndex = 46
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Gold
        btnReset.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.Location = New Point(432, 258)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 47)
        btnReset.TabIndex = 45
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightGreen
        btnSave.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.Location = New Point(720, 260)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 47)
        btnSave.TabIndex = 44
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' DGVDept
        ' 
        DGVDept.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVDept.BorderStyle = BorderStyle.Fixed3D
        DGVDept.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVDept.Location = New Point(167, 375)
        DGVDept.Name = "DGVDept"
        DGVDept.Size = New Size(730, 172)
        DGVDept.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ActiveCaptionText
        Label6.Font = New Font("Javanese Text", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(467, 337)
        Label6.Name = "Label6"
        Label6.Size = New Size(147, 36)
        Label6.TabIndex = 42
        Label6.Text = "Department List"
        ' 
        ' txtDur
        ' 
        txtDur.Location = New Point(698, 161)
        txtDur.Name = "txtDur"
        txtDur.Size = New Size(173, 23)
        txtDur.TabIndex = 41
        ' 
        ' txtDesc
        ' 
        txtDesc.Location = New Point(441, 161)
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(173, 63)
        txtDesc.TabIndex = 40
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(698, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(199, 36)
        Label5.TabIndex = 38
        Label5.Text = "Department's Duration"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(441, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(208, 36)
        Label4.TabIndex = 37
        Label4.Text = "Department Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(197, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 36)
        Label2.TabIndex = 36
        Label2.Text = "Department's Name"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.department_16423572
        PictureBox2.Location = New Point(136, 69)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 141
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Javanese Text", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(167, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 54)
        Label3.TabIndex = 140
        Label3.Text = "Department"
        ' 
        ' cmbName
        ' 
        cmbName.FormattingEnabled = True
        cmbName.Items.AddRange(New Object() {"Pre-Primary", "Maths", "Science", "Commerce", "Sports", "Music", "Litreature"})
        cmbName.Location = New Point(197, 161)
        cmbName.Name = "cmbName"
        cmbName.Size = New Size(165, 23)
        cmbName.TabIndex = 142
        ' 
        ' Department
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(937, 559)
        Controls.Add(cmbName)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnReset)
        Controls.Add(btnSave)
        Controls.Add(DGVDept)
        Controls.Add(Label6)
        Controls.Add(txtDur)
        Controls.Add(txtDesc)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Department"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Department"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DGVDept, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents DGVDept As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDur As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbName As ComboBox
End Class
