Public Class LoginForm
    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        LoginProcess()
    End Sub

    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            LoginProcess()
        End If
    End Sub
    Private Sub Username_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Username.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            LoginProcess()
        End If
    End Sub
    Private Sub LoginProcess()
        Dim user_name As String = Username.Text
        Dim user_password As String = Password.Text

        ' Validation
        If loginValidation(user_name, user_password) Then
            Dim dashboard As New Dashboard()
            dashboard.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Function loginValidation(username As String, password As String) As Boolean
        If username = "kiran" AndAlso password = "kiran" Then
            Return True
        End If
        Return False
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Username.Text = ""
        Password.Text = ""
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class