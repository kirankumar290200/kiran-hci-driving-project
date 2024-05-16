Imports System.Net

Public Class InstructorForm

    Public Sub New()
        InitializeComponent()
        InitializeDataGridView()
    End Sub

    Private Sub InitializeDataGridView()
        ' Define DataGridView columns
        With InstructorGridView.Columns
            .Add("Name", "Name")
            .Add("Pone", "Phone")
            .Add("Gender", "Gender")
            .Add("Address", "Address")
        End With

        InstructorGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        InstructorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        InstructorGridView.AllowUserToAddRows = False
    End Sub


    Private Sub InstructorSaveBtn_Click(sender As Object, e As EventArgs) Handles InstructorSaveBtn.Click
        If String.IsNullOrWhiteSpace(InstructorName.Text) OrElse
           String.IsNullOrWhiteSpace(InstructorNumber.Text) OrElse
           String.IsNullOrWhiteSpace(InstructorGender.SelectedItem?.ToString()) OrElse
           String.IsNullOrWhiteSpace(InstructorDateOfBirth.Text) Then
            MessageBox.Show("All * fields are required.")
        ElseIf Not IsPhoneNumberValid(InstructorNumber.Text) Then
            MessageBox.Show("Invalid Contact Number. Please enter a valid numeric value.")
        ElseIf Not IsNameValid(InstructorName.Text) Then
            MessageBox.Show("Invalid Name. Please enter a valid name without just spaces or special characters.")
        Else
            Try
                Dim TName As String = InstructorName.Text
                Dim TContact As String = InstructorNumber.Text
                Dim TGender As String = InstructorGender.SelectedItem.ToString()
                Dim TAddress As String = InstructorAddress.Text
                InstructorGridView.Rows.Add(TName, TContact, TGender, TAddress)
                ClearFormFields()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ClearFormFields()
        InstructorName.Text = ""
        InstructorNumber.Text = ""
        InstructorGender.SelectedIndex = -1
        InstructorAddress.Text = ""
    End Sub

    Private Function IsPhoneNumberValid(phoneNumber As String) As Boolean
        Return phoneNumber.All(Function(c) Char.IsDigit(c))
    End Function

    Private Function IsNameValid(name As String) As Boolean
        Return name.Any(Function(c) Char.IsLetterOrDigit(c))
    End Function
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

    Private Sub InstructorCancel_Click(sender As Object, e As EventArgs) Handles InstructorCancel.Click
        ClearFormFields()
    End Sub

    Private Sub InstructorSearchTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InstructorSearchTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim searchText As String = InstructorSearchTxt.Text.ToLower()
            If String.IsNullOrWhiteSpace(searchText) Then
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataGridViewRow In InstructorGridView.Rows
                    row.Visible = True
                Next
                Return
            End If
            For Each row As DataGridViewRow In InstructorGridView.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
            For Each row As DataGridViewRow In InstructorGridView.Rows
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New StudentForm()
        Obj.Show()
        Me.Hide()
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

    Private Sub InstructorGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles InstructorGridView.CellContentClick

    End Sub
End Class