<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fee))
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
        Label6 = New Label()
        dtpFee = New DateTimePicker()
        btnCancel = New Button()
        btnPay = New Button()
        txtAmt = New TextBox()
        txtStdudent = New TextBox()
        txtStdID = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Label8 = New Label()
        cmbPay = New ComboBox()
        Label7 = New Label()
        dgvFeeDetails = New DataGridView()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvFeeDetails, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.TabIndex = 11
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
        Panel1.TabIndex = 10
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(784, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 36)
        Label6.TabIndex = 59
        Label6.Text = "Date"
        ' 
        ' dtpFee
        ' 
        dtpFee.Location = New Point(784, 188)
        dtpFee.Name = "dtpFee"
        dtpFee.Size = New Size(118, 23)
        dtpFee.TabIndex = 58
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(438, 239)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(80, 33)
        btnCancel.TabIndex = 57
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnPay
        ' 
        btnPay.BackColor = Color.LightGreen
        btnPay.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPay.Location = New Point(614, 239)
        btnPay.Name = "btnPay"
        btnPay.Size = New Size(75, 33)
        btnPay.TabIndex = 56
        btnPay.Text = "Pay"
        btnPay.UseVisualStyleBackColor = False
        ' 
        ' txtAmt
        ' 
        txtAmt.Location = New Point(487, 187)
        txtAmt.Name = "txtAmt"
        txtAmt.Size = New Size(105, 23)
        txtAmt.TabIndex = 55
        ' 
        ' txtStdudent
        ' 
        txtStdudent.Location = New Point(288, 187)
        txtStdudent.Name = "txtStdudent"
        txtStdudent.Size = New Size(161, 23)
        txtStdudent.TabIndex = 54
        ' 
        ' txtStdID
        ' 
        txtStdID.Location = New Point(160, 188)
        txtStdID.Name = "txtStdID"
        txtStdID.Size = New Size(99, 23)
        txtStdID.TabIndex = 53
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(487, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 36)
        Label5.TabIndex = 52
        Label5.Text = "Amount"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(288, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 36)
        Label4.TabIndex = 51
        Label4.Text = "Student Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(156, 149)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 36)
        Label2.TabIndex = 50
        Label2.Text = "Student ID"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.coin_money_icon_icons1
        PictureBox2.Location = New Point(140, 67)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(39, 32)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 139
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Javanese Text", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(171, 64)
        Label3.Name = "Label3"
        Label3.Size = New Size(159, 54)
        Label3.TabIndex = 138
        Label3.Text = "Fee Deposit"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(630, 149)
        Label8.Name = "Label8"
        Label8.Size = New Size(132, 36)
        Label8.TabIndex = 140
        Label8.Text = "Payment Mode"
        ' 
        ' cmbPay
        ' 
        cmbPay.FormattingEnabled = True
        cmbPay.Items.AddRange(New Object() {"Cash", "Online", "Card", "Cheque"})
        cmbPay.Location = New Point(639, 187)
        cmbPay.Name = "cmbPay"
        cmbPay.Size = New Size(87, 23)
        cmbPay.TabIndex = 141
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ActiveCaptionText
        Label7.Font = New Font("Javanese Text", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(487, 298)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 36)
        Label7.TabIndex = 60
        Label7.Text = "Payment List"
        ' 
        ' dgvFeeDetails
        ' 
        dgvFeeDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvFeeDetails.BorderStyle = BorderStyle.Fixed3D
        dgvFeeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvFeeDetails.Location = New Point(156, 347)
        dgvFeeDetails.Name = "dgvFeeDetails"
        dgvFeeDetails.Size = New Size(746, 200)
        dgvFeeDetails.TabIndex = 61
        ' 
        ' Fee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(937, 559)
        Controls.Add(cmbPay)
        Controls.Add(Label8)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(dgvFeeDetails)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(dtpFee)
        Controls.Add(btnCancel)
        Controls.Add(btnPay)
        Controls.Add(txtAmt)
        Controls.Add(txtStdudent)
        Controls.Add(txtStdID)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Fee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fee"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvFeeDetails, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFee As DateTimePicker
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPay As Button
    Friend WithEvents txtAmt As TextBox
    Friend WithEvents txtStdudent As TextBox
    Friend WithEvents txtStdID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbPay As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvFeeDetails As DataGridView
End Class
