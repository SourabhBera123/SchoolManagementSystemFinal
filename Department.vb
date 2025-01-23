Imports Microsoft.Data.SqlClient

Public Class Department

    Dim con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
    Dim ID = 0

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbName.SelectedIndex = -1 Or txtDesc.Text = "" Or txtDur.Text = "" Then
            MsgBox("Please fill in all required fields.")
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim qr = "INSERT INTO tblDepartment2 (DeptName, DeptDesc, DeptDuration) VALUES (@Name, @Description, @Duration)"
            Using cmd As New SqlCommand(qr, con)
                cmd.Parameters.AddWithValue("@Name", cmbName.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Description", txtDesc.Text)
                cmd.Parameters.AddWithValue("@Duration", txtDur.Text)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Department details saved successfully.")
            DisplayTeacher()
            Reset()
        Catch ex As Exception
            MsgBox("Error saving department: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub DisplayTeacher()
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim qr = "SELECT DeptID, DeptName, DeptDesc, DeptDuration FROM tblDepartment2"
            Dim cmd As New SqlCommand(qr, con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim ds As New DataSet()
            adp.Fill(ds)
            DGVDept.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox("Error displaying data: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub Reset()
        cmbName.SelectedIndex = -1
        txtDesc.Text = ""
        txtDur.Text = ""
        ID = 0
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbName.SelectedIndex = -1 Or txtDesc.Text = "" Or txtDur.Text = "" Or ID = 0 Then
            MsgBox("Missing Information or No Department Selected!")
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim qr = "UPDATE tblDepartment2 SET DeptName = @Name, DeptDesc = @Description, DeptDuration = @Duration WHERE DeptID = @ID"
            Using cmd As New SqlCommand(qr, con)
                cmd.Parameters.AddWithValue("@Name", cmbName.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Description", txtDesc.Text)
                cmd.Parameters.AddWithValue("@Duration", txtDur.Text)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Department details updated successfully.")
            DisplayTeacher()
            Reset()
        Catch ex As Exception
            MsgBox("Error updating department: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ID = 0 Then
            MsgBox("Please Select Which Department Details To Delete")
        Else
            Try
                If con.State = ConnectionState.Open Then con.Close()
                con.Open()

                Dim qr = "DELETE FROM tblDepartment2 WHERE DeptID = @ID"
                Using cmd As New SqlCommand(qr, con)
                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Department details deleted successfully.")
                DisplayTeacher()
                Reset()
            Catch ex As Exception
                MsgBox("Error deleting department: " & ex.Message)
            Finally
                If con.State = ConnectionState.Open Then con.Close()
            End Try
        End If
    End Sub

    Private Sub DGVDept_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDept.CellContentClick
        Try
            Dim row As DataGridViewRow = DGVDept.Rows(e.RowIndex)
            cmbName.SelectedItem = row.Cells("DeptName").Value.ToString()
            txtDesc.Text = row.Cells("DeptDesc").Value.ToString()
            txtDur.Text = row.Cells("DeptDuration").Value.ToString()
            ID = Convert.ToInt32(row.Cells("DeptID").Value)
        Catch ex As Exception
            MsgBox("Error selecting data: " & ex.Message)
        End Try
    End Sub

    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTeacher()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim obj = New Department
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim obj = New Fee
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj = New Students
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj = New Teachers
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New frmMain
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim obj = New LoginPage
        obj.Show()
        Me.Hide()
    End Sub
End Class
