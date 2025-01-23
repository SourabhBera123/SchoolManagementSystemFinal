Imports Microsoft.Data.SqlClient

Public Class Teachers
    Dim con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
    Dim ID = 0

    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayTeacher()
    End Sub

    Private Sub DisplayTeacher()
        Try
            Using con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
                con.Open()
                Dim qr = "SELECT TID, TName, TGender, TDOB, TPhone, TDept, TAddress, TPhoto FROM tblTeachers9"
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
                    If Not IsDBNull(row("TPhoto")) Then
                        Dim imageBytes As Byte() = CType(row("TPhoto"), Byte())
                        Using ms As New IO.MemoryStream(imageBytes)
                            row("ImageColumn") = Image.FromStream(ms)
                        End Using
                    Else
                        row("ImageColumn") = Nothing
                    End If
                Next

                ' Disable automatic column generation
                DGVTeacher.AutoGenerateColumns = False

                ' Clear existing columns in DataGridView
                DGVTeacher.Columns.Clear()

                ' Add the columns you want to display
                DGVTeacher.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "TID",
                .HeaderText = "Teacher ID",
                .DataPropertyName = "TID"
            })
                DGVTeacher.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "TName",
                .HeaderText = "Name",
                .DataPropertyName = "TName"
            })
                DGVTeacher.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "TGender",
                .HeaderText = "Gender",
                .DataPropertyName = "TGender"
            })
                DGVTeacher.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "TDOB",
                .HeaderText = "Date of Birth",
                .DataPropertyName = "TDOB"
            })
                DGVTeacher.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "TPhone",
                .HeaderText = "Phone",
                .DataPropertyName = "TPhone"
            })
                DGVTeacher.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "TDept",
                .HeaderText = "Department",
                .DataPropertyName = "TDept"
            })
                DGVTeacher.Columns.Add(New DataGridViewTextBoxColumn() With {
                .Name = "TAddress",
                .HeaderText = "Address",
                .DataPropertyName = "TAddress"
            })
                Dim imgColumn As New DataGridViewImageColumn() With {
                .Name = "ImageColumn",
                .HeaderText = "Teacher Picture",
                .DataPropertyName = "ImageColumn",
                .ImageLayout = DataGridViewImageCellLayout.Zoom
            }
                DGVTeacher.Columns.Add(imgColumn)

                ' Bind the DataTable to the DataGridView
                DGVTeacher.DataSource = ds.Tables(0)

                ' Adjust column and row sizes
                DGVTeacher.Columns("ImageColumn").Width = 100
                DGVTeacher.RowTemplate.Height = 100
            End Using
        Catch ex As Exception
            MessageBox.Show("Error displaying data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Reset()
        txtTeachername.Text = ""
        txtAddress.Text = ""
        txtMobile.Text = ""
        cmbDepartment.SelectedIndex = -1
        cmbGender.SelectedIndex = -1
        dtpDOB.Value = DateTime.Now
        picTeacher.Image = Nothing
        ID = 0
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtTeachername.Text = "" Or txtAddress.Text = "" Or txtMobile.Text = "" Or cmbDepartment.SelectedIndex = -1 Or cmbGender.SelectedIndex = -1 Then
            MsgBox("Missing Information!")
            Exit Sub
        End If

        Try
            Dim imageData As Byte() = Nothing

            ' Convert image to byte array if it exists
            If picTeacher.Image IsNot Nothing Then
                Using ms As New IO.MemoryStream()
                    picTeacher.Image.Save(ms, picTeacher.Image.RawFormat)
                    imageData = ms.ToArray()
                End Using
            End If

            Using con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
                con.Open()
                Dim qr = "INSERT INTO tblTeachers9 (TName, TGender, TDOB, TPhone, TDept, TAddress, TPhoto) VALUES (@Name, @Gender, @DOB, @Phone, @Dept, @Address, @Photo)"
                Using cmd As New SqlCommand(qr, con)
                    cmd.Parameters.AddWithValue("@Name", txtTeachername.Text)
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                    cmd.Parameters.AddWithValue("@Phone", txtMobile.Text)
                    cmd.Parameters.AddWithValue("@Dept", cmbDepartment.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                    cmd.Parameters.AddWithValue("@Photo", If(imageData, DBNull.Value))
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MsgBox("Teacher Details Saved Successfully")
            DisplayTeacher()
            Reset()
        Catch ex As Exception
            MsgBox("Error saving data: " & ex.Message)
        End Try
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtTeachername.Text = "" Or txtAddress.Text = "" Or txtMobile.Text = "" Or cmbDepartment.SelectedIndex = -1 Or cmbGender.SelectedIndex = -1 Or ID = 0 Then
            MsgBox("Missing Information or No Teacher Selected!")
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Open Then
                con.Close() ' Ensure connection is closed before opening it again
            End If
            con.Open()
            Dim qr = "UPDATE tblTeachers9 SET TName = @Name, TGender = @Gender, TDOB = @DOB, TPhone = @Phone, TDept = @Dept, TAddress = @Address WHERE TID = @ID"
            Using cmd As New SqlCommand(qr, con)
                cmd.Parameters.AddWithValue("@Name", txtTeachername.Text)
                cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@DOB", dtpDOB.Value.Date)
                cmd.Parameters.AddWithValue("@Phone", txtMobile.Text)
                cmd.Parameters.AddWithValue("@Dept", cmbDepartment.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text)
                cmd.Parameters.AddWithValue("@ID", ID)
                cmd.ExecuteNonQuery()
            End Using
            MsgBox("Teacher Details Updated Successfully")
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ID = 0 Then
            MsgBox("Please Select Which Teacher Details To Delete")
        Else
            Try
                If con.State = ConnectionState.Open Then
                    con.Close() ' Ensure connection is closed before opening it again
                End If
                con.Open()
                Dim qr = "DELETE FROM tblTeachers9 WHERE TID = @ID"
                Using cmd As New SqlCommand(qr, con)
                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.ExecuteNonQuery()
                End Using
                MsgBox("Teacher Details Deleted Successfully")
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub DGVTeacher_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTeacher.CellContentClick
        If e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow = DGVTeacher.Rows(e.RowIndex)
            txtTeachername.Text = row.Cells("TName").Value.ToString()
            cmbGender.SelectedItem = row.Cells("TGender").Value.ToString()
            dtpDOB.Value = Convert.ToDateTime(row.Cells("TDOB").Value)
            txtMobile.Text = row.Cells("TPhone").Value.ToString()
            cmbDepartment.SelectedItem = row.Cells("TDept").Value.ToString()
            txtAddress.Text = row.Cells("TAddress").Value.ToString()
            ID = Convert.ToInt32(row.Cells("TID").Value)

            ' Load image from database
            Using con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")
                con.Open()
                Dim qr = "SELECT TPhoto FROM tblTeachers9 WHERE TID = @ID"
                Using cmd As New SqlCommand(qr, con)
                    cmd.Parameters.AddWithValue("@ID", ID)
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


    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim ofd As New OpenFileDialog With {
        .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*"
    }

        If ofd.ShowDialog() = DialogResult.OK Then
            picTeacher.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        picTeacher.Image = Nothing
    End Sub
End Class
