Public Class BookingForm
    Public Sub New()
        InitializeComponent()
        InitializeDataGridView()
    End Sub

    Private Sub InitializeDataGridView()
        With PaymentGridView.Columns
            .Add("Student", "Learner")
            .Add("Course", "Course")
            .Add("Amount", "Amount (£)")
            .Add("PaymentDate", "Paid Date")
        End With
        PaymentGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        PaymentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        PaymentGridView.AllowUserToAddRows = False
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New Dashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj As New InstructorForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New StudentForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj As New CourseForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj As New BookingForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New LoginForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PaymentSaveBtn_Click(sender As Object, e As EventArgs) Handles PaymentSaveBtn.Click
        If String.IsNullOrWhiteSpace(PaymentStudentName.Text) OrElse
      String.IsNullOrWhiteSpace(PaymentCourse.Text) OrElse
      String.IsNullOrWhiteSpace(PaymentAmount.Text) OrElse
      String.IsNullOrWhiteSpace(PaymentDate.Text) Then
            MessageBox.Show("All * fields are required.")
        ElseIf Not Decimal.TryParse(PaymentAmount.Text, Nothing) OrElse Decimal.Parse(PaymentAmount.Text) <= 0 Then
            MessageBox.Show("Invalid payment amount. Please enter a valid positive number.")
            Return
        ElseIf Not IsNameValid(PaymentStudentName.Text) Then
            MessageBox.Show("Invalid Name. Please enter a valid name without just spaces or special characters.")
        Else
            Try
                Dim PStudentName As String = PaymentStudentName.Text
                Dim PAmount As String = PaymentAmount.Text
                Dim PCourse As String = PaymentCourse.Text
                Dim pDateString As String = Me.PaymentDate.Text
                Dim paymentDate As DateTime = DateTime.Parse(pDateString)
                Dim formattedPaymentDate As String = paymentDate.ToString("dd/MM/yyyy")

                PaymentGridView.Rows.Add(PStudentName, PCourse, PAmount, formattedPaymentDate)

                ClearFormFields()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub ClearFormFields()
        PaymentStudentName.Text = ""
        PaymentCourse.Text = ""
        PaymentAmount.Text = ""
        PaymentDate.Text = ""
    End Sub

    Private Function IsNameValid(name As String) As Boolean
        Return name.Any(Function(c) Char.IsLetterOrDigit(c))
    End Function

    Private Sub PaymentCancel_Click(sender As Object, e As EventArgs) Handles PaymentCancel.Click
        ClearFormFields()
    End Sub
    Private Sub PaymentSearchTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PaymentSearchTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim searchText As String = PaymentSearchTxt.Text.ToLower()
            If String.IsNullOrWhiteSpace(searchText) Then
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataGridViewRow In PaymentGridView.Rows
                    row.Visible = True
                Next
                Return
            End If
            For Each row As DataGridViewRow In PaymentGridView.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
            For Each row As DataGridViewRow In PaymentGridView.Rows
                If Not row.IsNewRow Then
                    Dim isVisible As Boolean = False
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing AndAlso cell.Value.ToString().ToLower().Contains(searchText) Then
                            isVisible = True
                            Exit For
                        End If
                    Next
                    row.Visible = isVisible
                End If
            Next
        End If
    End Sub
End Class