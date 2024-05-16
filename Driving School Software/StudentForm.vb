Public Class StudentForm

    Public Sub New()
        InitializeComponent()
        InitializeDataGridView()
    End Sub

    Private Sub InitializeDataGridView()
        ' Define DataGridView columns
        With StudentGridView.Columns
            .Add("Name", "Name")
            .Add("Pone", "Phone")
            .Add("Gender", "Gender")
            .Add("Address", "Address")
        End With

        StudentGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        StudentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        StudentGridView.AllowUserToAddRows = False
    End Sub
    Private Sub StudentSaveBtn_Click(sender As Object, e As EventArgs) Handles StudentSaveBtn.Click
        If String.IsNullOrWhiteSpace(StudentName.Text) OrElse
           String.IsNullOrWhiteSpace(StudentNumber.Text) OrElse
           String.IsNullOrWhiteSpace(StudentGender.SelectedItem?.ToString()) OrElse
           String.IsNullOrWhiteSpace(StudentDateOfBirth.Text) Then
            MessageBox.Show("All * fields are required.")
        ElseIf Not IsPhoneNumberValid(StudentNumber.Text) Then
            MessageBox.Show("Invalid phone number. Please enter a valid numeric value.")
        ElseIf Not IsNameValid(StudentName.Text) Then
            MessageBox.Show("Invalid Name. Please enter a valid name without just spaces or special characters.")
        Else
            Try
                Dim TName As String = StudentName.Text
                Dim TContact As String = StudentNumber.Text
                Dim TGender As String = StudentGender.SelectedItem.ToString()
                Dim TAddress As String = StudentAddress.Text
                StudentGridView.Rows.Add(TName, TContact, TGender, TAddress)
                ClearFormFields()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ClearFormFields()
        StudentName.Text = ""
        StudentNumber.Text = ""
        StudentGender.SelectedIndex = -1
        StudentAddress.Text = ""
    End Sub

    Private Function IsPhoneNumberValid(phoneNumber As String) As Boolean
        Return phoneNumber.All(Function(c) Char.IsDigit(c))
    End Function

    Private Function IsNameValid(name As String) As Boolean
        Return name.Any(Function(c) Char.IsLetterOrDigit(c))
    End Function

    Private Sub InstructorCancel_Click(sender As Object, e As EventArgs) Handles StudentCancel.Click
        ClearFormFields()
    End Sub

    Private Sub InstructorSearchTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StudentSearchTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim searchText As String = StudentSearchTxt.Text.ToLower()
            If String.IsNullOrWhiteSpace(searchText) Then
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataGridViewRow In StudentGridView.Rows
                    row.Visible = True
                Next
                Return
            End If
            For Each row As DataGridViewRow In StudentGridView.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
            For Each row As DataGridViewRow In StudentGridView.Rows
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

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New LoginForm()
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

    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint

    End Sub
End Class