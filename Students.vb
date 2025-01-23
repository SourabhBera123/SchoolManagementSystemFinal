Imports Microsoft.Data.SqlClient
Public Class Students
    Dim con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
    Dim ID = 0
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

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ID = 0 Then
            MsgBox("Please Select Which Student Details To Delete")
        Else
            Try
                If con.State = ConnectionState.Open Then
                    con.Close() ' Ensure connection is closed before opening it again
                End If
                con.Open()
                Dim qr = "DELETE FROM tblStudents7 WHERE StdID = @ID"
                Using cmd As New SqlCommand(qr, con)
                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Student Details Deleted Successfully")
                DisplayTeacher()
                Reset()
            Catch ex As Exception
                MsgBox("Error deleting data: " & ex.Message)
            Finally
                If con.State = ConnectionState.Open Then
                    con.Close() ' Ensure connection is closed after the operation
                End If
            End Try
        End If
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTeacher()
    End Sub

    Private Sub DisplayTeacher()
        Try
            Using con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
                con.Open()
                Dim qr = "SELECT StdID, StdName, StdGender, StdDOB, StdPhone, StdClass, StdAddress, StdFees, StdPhoto FROM tblStudents7"
                Dim cmd As New SqlCommand(qr, con)
                Dim adp As New SqlDataAdapter(cmd)
                Dim ds As New DataSet()
                adp.Fill(ds)

                ' Add a column to store images in the DataTable
                If Not ds.Tables(0).Columns.Contains("ImageColumn") Then
                    ds.Tables(0).Columns.Add("ImageColumn", GetType(Image))
                End If

                ' Convert TPicture (binary) to Image and add it to the new column
                For Each row As DataRow In ds.Tables(0).Rows
                    If Not IsDBNull(row("StdPhoto")) Then
                        Dim imageBytes As Byte() = CType(row("StdPhoto"), Byte())
                        Using ms As New IO.MemoryStream(imageBytes)
                            row("ImageColumn") = Image.FromStream(ms)
                        End Using
                    Else
                        row("ImageColumn") = Nothing
                    End If
                Next

                ' Disable automatic column generation
                DGVStudents.AutoGenerateColumns = False

                ' Clear existing columns in DataGridView
                DGVStudents.Columns.Clear()

                ' Add the columns you want to display
                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdID",
                .HeaderText = "Student ID",
                .DataPropertyName = "StdID"
            })
                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdName",
                .HeaderText = "Name",
                .DataPropertyName = "StdName"
            })
                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdGender",
                .HeaderText = "Gender",
                .DataPropertyName = "StdGender"
            })
                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdDOB",
                .HeaderText = "Date of Birth",
                .DataPropertyName = "StdDOB"
            })
                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdPhone",
                .HeaderText = "Phone No.",
                .DataPropertyName = "StdPhone"
            })
                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdClass",
                .HeaderText = "Class",
                .DataPropertyName = "StdClass"
            })
                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdAddress",
                .HeaderText = "Address",
                .DataPropertyName = "StdAddress"
            })

                DGVStudents.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "StdFees",
                .HeaderText = "Fees",
                .DataPropertyName = "StdFees"
            })
                Dim imgColumn As New DataGridViewImageColumn() With {
                .Name = "ImageColumn",
                .HeaderText = "Student Picture",
                .DataPropertyName = "ImageColumn",
                .ImageLayout = DataGridViewImageCellLayout.Zoom
            }
                DGVStudents.Columns.Add(imgColumn)

                ' Bind the DataTable to the DataGridView
                DGVStudents.DataSource = ds.Tables(0)

                ' Adjust column and row sizes
                DGVStudents.Columns("ImageColumn").Width = 100
                DGVStudents.RowTemplate.Height = 100
            End Using
        Catch ex As Exception
            MessageBox.Show("Error displaying data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reset()
        txtStudent.Text = ""
        txtAddress.Text = ""
        txtMobile.Text = ""
        txtFee.Text = ""
        cmbClass.SelectedIndex = -1
        cmbGender.SelectedIndex = -1
        dtpDOB.Value = DateTime.Now
        picTeacher.Image = Nothing
        ID = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtStudent.Text = "" Or txtAddress.Text = "" Or txtMobile.Text = "" Or txtFee.Text = "" Or cmbClass.SelectedIndex = -1 Or cmbGender.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
            Exit Sub
        End If

        Try
            Dim imageData As Byte() = Nothing

            If picTeacher.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    picTeacher.Image.Save(ms, picTeacher.Image.RawFormat)
                    imageData = ms.ToArray()
                End Using
            End If

            Using con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
                con.Open()
                Dim qr = "INSERT INTO tblStudents7 (StdName, StdGender, StdDOB, StdPhone, StdClass, StdAddress, StdFees, StdPhoto) VALUES (@Name, @Gender, @DOB, @Phone, @Class, @Address, @Fees, @Photo)"
                Using cmd As New SqlCommand(qr, con)
                    cmd.Parameters.AddWithValue("@Name", txtStudent.Text)
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                    cmd.Parameters.AddWithValue("@Phone", txtMobile.Text)
                    cmd.Parameters.AddWithValue("@Class", cmbClass.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Fees", txtFee.Text)
                    cmd.Parameters.AddWithValue("@Photo", If(imagedata, DBNull.Value))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Student Details Saved Successfully")
            DisplayTeacher()
            Reset()
        Catch ex As Exception
            MsgBox("Error saving data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtStudent.Text = "" Or txtAddress.Text = "" Or txtMobile.Text = "" Or txtFee.Text = "" Or cmbClass.SelectedIndex = -1 Or cmbGender.SelectedIndex = -1 Or ID = 0 Then
            MsgBox("Missing Information or No Student Selected!")
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Open Then
                con.Close() ' Ensure connection is closed before opening it again
            End If
            con.Open()
            Dim qr = "UPDATE tblStudents7 SET StdName = @Name, StdGender = @Gender, StdDOB = @DOB, StdPhone = @Phone, StdClas = @Class, StdAddress = @Address, StdFees = @Fees WHERE TID = @ID"
            Using cmd As New SqlCommand(qr, con)
                cmd.Parameters.AddWithValue("@Name", txtStudent.Text)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                cmd.Parameters.AddWithValue("@Phone", txtMobile.Text)
                cmd.Parameters.AddWithValue("@Class", cmbClass.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@Fees", txtFee.Text)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Student Details Updated Successfully")
            DisplayTeacher()
            Reset()
        Catch ex As Exception
            MsgBox("Error updating data: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close() ' Ensure connection is closed after the operation
            End If
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVStudents.CellContentClick
        If e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow = DGVStudents.Rows(e.RowIndex)
            txtStudent.Text = row.Cells("StdName").Value.ToString()
            cmbGender.SelectedItem = row.Cells("StdGender").Value.ToString()
            dtpDOB.Value = Convert.ToDateTime(row.Cells("StdDOB").Value)
            txtMobile.Text = row.Cells("StdPhone").Value.ToString()
            cmbClass.SelectedItem = row.Cells("StdClass").Value.ToString()
            txtAddress.Text = row.Cells("StdAddress").Value.ToString()
            txtFee.Text = row.Cells("StdFees").Value.ToString()
            ID = Convert.ToInt32(row.Cells("StdID").Value)
            ' Load image from database
            Using con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
                con.Open()
                Dim qr = "SELECT StdPhoto FROM tblStudents7 WHERE StdID = @ID"
                Using cmd As New SqlCommand(qr, con)
                    cmd.Parameters.AddWithValue("@StdID", ID)
                    Dim imageData As Byte() = CType(cmd.ExecuteScalar(), Byte())
                    If imageData IsNot Nothing Then
                        Using ms As New IO.MemoryStream(imageData)
                            picTeacher.Image = Image.FromStream(ms)
                        End Using
                    Else
                        picTeacher.Image = Nothing ' No image available
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error selecting data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim obj = New LoginPage
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ofd As New OpenFileDialog With {
        .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
    }

        If ofd.ShowDialog() = DialogResult.OK Then
            picTeacher.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub
End Class