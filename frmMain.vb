Imports Microsoft.Data.SqlClient
Public Class frmMain
    Dim con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateStudentCount()
        UpdateTeacherCount()
        UpdateDepartmentCount()
        UpdateFeeDepositCount()
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Dim obj = New Teachers
        obj.Show()
        Me.Hide()

    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim obj = New Students
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnFee_Click(sender As Object, e As EventArgs) Handles btnFee.Click
        Dim obj = New Fee
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        Dim obj = New Department
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim obj = New frmMain
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateStudentCount()
        Try
            ' Ensure the connection is open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            ' SQL Query to count the number of students
            Dim qr = "SELECT COUNT(*) FROM tblStudents"
            Dim cmd As New SqlCommand(qr, con)

            ' Execute the query and fetch the result
            Dim studentCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Display the student count in the label
            lblStudentCount.Text = studentCount.ToString()
        Catch ex As Exception
            ' Show an error message if something goes wrong
            MsgBox("Error fetching student count: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateTeacherCount()
        Try
            ' Ensure the connection is open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            ' SQL Query to count the number of students
            Dim qr = "SELECT COUNT(*) FROM tblTeachers8"
            Dim cmd As New SqlCommand(qr, con)

            ' Execute the query and fetch the result
            Dim departmentCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Display the student count in the label
            lblTeacherCount.Text = departmentCount.ToString()
        Catch ex As Exception
            ' Show an error message if something goes wrong
            MsgBox("Error fetching student count: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub UpdateDepartmentCount()
        Try
            ' Ensure the connection is open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            ' SQL Query to count the number of students
            Dim qr = "SELECT COUNT(*) FROM tblDepartment2"
            Dim cmd As New SqlCommand(qr, con)

            ' Execute the query and fetch the result
            Dim teacherCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Display the student count in the label
            Label4.Text = teacherCount.ToString()
        Catch ex As Exception
            ' Show an error message if something goes wrong
            MsgBox("Error fetching student count: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub
    Private Sub UpdateFeeDepositCount()
        Try
            ' Ensure the connection is open
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()

            ' SQL Query to count the number of students
            Dim qr = "SELECT COUNT(*) FROM tblFeeDeposit3"
            Dim cmd As New SqlCommand(qr, con)

            ' Execute the query and fetch the result
            Dim teacherCount As Integer = Convert.ToInt32(cmd.ExecuteScalar())

            ' Display the student count in the label
            lblFeeDepositCount.Text = teacherCount.ToString()
        Catch ex As Exception
            ' Show an error message if something goes wrong
            MsgBox("Error fetching student count: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim obj = New LoginPage
        obj.Show()
        Me.Hide()
    End Sub
End Class