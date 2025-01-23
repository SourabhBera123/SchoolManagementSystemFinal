Imports Microsoft.Data.SqlClient
Public Class Fee
    ' Database connection string
    Dim con As New SqlConnection("Data Source=SOURABH\SQLEXPRESS03;Initial Catalog=SchoolsysDB;Integrated Security=True;Trust Server Certificate=True")

    ' Form load event
    Private Sub Fee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFeeDetails() ' Load payment details into DataGridView on form load
    End Sub

    ' Method to load payment details into DataGridView
    Private Sub LoadFeeDetails()
        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim qrFetch As String = "SELECT ID, StdID, Amount, PaymentMode, Date FROM tblFeeDeposit3"
            Dim adapter As New SqlDataAdapter(qrFetch, con)
            Dim table As New DataTable()

            adapter.Fill(table) ' Fill the DataTable with fetched data
            dgvFeeDetails.DataSource = table ' Bind the DataTable to the DataGridView
        Catch ex As Exception
            MsgBox("Error loading fee details: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    ' Pay button click event
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If txtStdID.Text = "" Or txtAmt.Text = "" Or cmbPay.SelectedIndex = -1 Then
            MsgBox("Please fill in all required fields.")
            Exit Sub
        End If

        Dim studentID As Integer
        Dim paymentAmount As Decimal

        ' Validate Student ID
        If Not Integer.TryParse(txtStdID.Text, studentID) Then
            MsgBox("Invalid Student ID. Please enter a valid number.")
            Exit Sub
        End If

        ' Validate Payment Amount
        If Not Decimal.TryParse(txtAmt.Text, paymentAmount) Then
            MsgBox("Invalid Payment Amount. Please enter a valid numeric value.")
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            ' Check Current Fee Balance
            Dim currentFees As Decimal
            Dim qrCheck As String = "SELECT StdFees FROM tblStudents7 WHERE StdID = @StudentID"
            Using cmdCheck As New SqlCommand(qrCheck, con)
                cmdCheck.Parameters.AddWithValue("@StudentID", studentID)
                Dim result = cmdCheck.ExecuteScalar()

                If result Is Nothing Then
                    MsgBox("Student ID not found!")
                    Exit Sub
                End If

                currentFees = Convert.ToDecimal(result)
            End Using

            ' Validate Payment Against Fee Balance
            If paymentAmount > currentFees Then
                MsgBox("Payment exceeds the outstanding fee balance!")
                Exit Sub
            End If

            ' Deduct Payment from Fee Balance
            Dim qrUpdate As String = "UPDATE tblStudents7 SET StdFees = StdFees - @Amount WHERE StdID = @StudentID"
            Using cmdUpdate As New SqlCommand(qrUpdate, con)
                cmdUpdate.Parameters.AddWithValue("@Amount", paymentAmount)
                cmdUpdate.Parameters.AddWithValue("@StudentID", studentID)
                cmdUpdate.ExecuteNonQuery()
            End Using

            ' Log Payment into tblFeeDeposit3
            Dim qrLog As String = "INSERT INTO tblFeeDeposit3 (StdID, Amount, PaymentMode, Date) VALUES (@StudentID, @Amount, @Type, @Date)"
            Using cmdLog As New SqlCommand(qrLog, con)
                cmdLog.Parameters.AddWithValue("@StudentID", studentID)
                cmdLog.Parameters.AddWithValue("@Amount", paymentAmount)
                cmdLog.Parameters.AddWithValue("@Type", cmbPay.SelectedItem.ToString())
                cmdLog.Parameters.AddWithValue("@Date", dtpFee.Value.Date)
                cmdLog.ExecuteNonQuery()
            End Using

            MsgBox("Payment successfully recorded!")
            ResetFeeDepositForm() ' Reset form fields
            LoadFeeDetails() ' Refresh DataGridView with updated data
        Catch ex As Exception
            MsgBox("Error during payment: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    ' Method to reset form fields
    Private Sub ResetFeeDepositForm()
        txtStdID.Text = ""
        txtStdudent.Text = ""
        cmbPay.SelectedIndex = -1
        txtAmt.Text = ""
        dtpFee.Value = DateTime.Now
    End Sub

    ' Auto-fill student name when Student ID is entered
    Private Sub txtStdID_Leave(sender As Object, e As EventArgs) Handles txtStdID.Leave
        If txtStdID.Text = "" Then Exit Sub
        Dim studentID As Integer
        If Not Integer.TryParse(txtStdID.Text, studentID) Then
            MsgBox("Invalid Student ID. Please enter a valid number.")
            Exit Sub
        End If

        Try
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Dim qr As String = "SELECT StdName FROM tblStudents7 WHERE StdID = @StudentID"
            Using cmd As New SqlCommand(qr, con)
                cmd.Parameters.AddWithValue("@StudentID", studentID)
                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    txtStdudent.Text = result.ToString()
                Else
                    MsgBox("Student ID not found!")
                    txtStdudent.Text = ""
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error fetching student name: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
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
End Class
