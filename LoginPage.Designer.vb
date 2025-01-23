<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPage))
        Label1 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        txtUser = New TextBox()
        txtPassword = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Javanese Text", 32F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(182, 2)
        Label1.Name = "Label1"
        Label1.Size = New Size(589, 98)
        Label1.TabIndex = 0
        Label1.Text = "School Management System"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(311, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(136, 54)
        Label3.TabIndex = 2
        Label3.Text = "Username"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkOrchid
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(937, 80)
        Panel1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(311, 192)
        Label2.Name = "Label2"
        Label2.Size = New Size(128, 54)
        Label2.TabIndex = 4
        Label2.Text = "Password"
        ' 
        ' txtUser
        ' 
        txtUser.Location = New Point(510, 115)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(313, 23)
        txtUser.TabIndex = 5
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(510, 207)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(313, 23)
        txtPassword.TabIndex = 6
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(657, 284)
        Button1.Name = "Button1"
        Button1.Size = New Size(81, 35)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Javanese Text", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(534, 284)
        Button2.Name = "Button2"
        Button2.Size = New Size(81, 35)
        Button2.TabIndex = 8
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(715, 236)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(108, 19)
        CheckBox1.TabIndex = 9
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        BackgroundImage = My.Resources.Resources._4th
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(937, 559)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtPassword)
        Controls.Add(txtUser)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "LoginPage"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginPage"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
