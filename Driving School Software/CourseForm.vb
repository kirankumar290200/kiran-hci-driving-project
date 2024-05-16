Public Class CourseForm

    Public Sub New()
        InitializeComponent()
        InitializeDataGridView()
    End Sub
    Private Sub InitializeDataGridView()
        With CourseGridView.Columns
            .Add("Name", "Name")
            .Add("Duration", "Duration")
            .Add("Fee", "Fee (£)")
        End With

        CourseGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        CourseGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CourseGridView.AllowUserToAddRows = False

        Dim courses As New List(Of (Name As String, Duration As String, Fee As Decimal)) From
    {
        ("Introductory", "2.5 Month", 200),
        ("Standard", "3.5 Months", 250),
        ("Pass Plus", "4 Months", 450),
        ("Driving Test", "6 Months", 600)
    }
        For Each course In courses
            CourseGridView.Rows.Add(course.Name, course.Duration, course.Fee)
        Next
    End Sub

    Private Sub CourseSearchTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CourseSearchTxt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim searchText As String = CourseSearchTxt.Text.ToLower()
            If String.IsNullOrWhiteSpace(searchText) Then
                MessageBox.Show("Please enter a search term.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Information)
                For Each row As DataGridViewRow In CourseGridView.Rows
                    row.Visible = True
                Next
                Return
            End If
            For Each row As DataGridViewRow In CourseGridView.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
            For Each row As DataGridViewRow In CourseGridView.Rows
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj As New CourseForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim Obj As New LoginForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub CourseGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CourseGridView.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim Obj As New BookingForm()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub CourseSearchTxt_TextChanged(sender As Object, e As EventArgs) Handles CourseSearchTxt.TextChanged

    End Sub
End Class