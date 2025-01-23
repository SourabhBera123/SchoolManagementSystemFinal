Imports Microsoft.Data.SqlClient
Public Class LoginPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
        con.Open()
        Dim query As String = "SELECT COUNT(*) FROM tblusers WHERE username=@username AND password=@password"
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@username", txtUser.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        Dim count As Integer = Convert.ToInt64(cmd.ExecuteScalar)
        con.Close()
        If count > 0 Then
            MessageBox.Show("Login Successful", "info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim fmain As New frmMain
            frmMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login Error!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not CheckBox1.Checked
    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class