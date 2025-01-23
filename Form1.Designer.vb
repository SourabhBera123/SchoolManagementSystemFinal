<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Kokila", 54F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(75, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 261)
        Label1.TabIndex = 0
        Label1.Text = "School Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources._3976555
        PictureBox1.Location = New Point(587, 98)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(252, 231)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Javanese Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(84, 438)
        Label2.Name = "Label2"
        Label2.Size = New Size(251, 47)
        Label2.TabIndex = 2
        Label2.Text = "Loading Please Wait...."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Javanese Text", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(739, 434)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 54)
        Label3.TabIndex = 3
        Label3.Text = "000%"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(84, 412)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(737, 23)
        ProgressBar1.TabIndex = 4
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 50
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._27dfd6b55602f6da042af85a7a4b2225
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(937, 559)
        Controls.Add(ProgressBar1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School  Management System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer

End Class
