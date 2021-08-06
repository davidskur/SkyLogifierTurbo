Public Class LoginDialog

    Private _tempUser As User
    Public Event LoginRequested(user As User)

    Private Sub OnTextBox_TextChanged(sender As Object, e As EventArgs) Handles tbUsername.TextChanged, tbPassword.TextChanged
        Dim username, password As String
        username = tbUsername.Text
        password = tbPassword.Text
        If Not String.IsNullOrWhiteSpace(username) AndAlso Not String.IsNullOrWhiteSpace(password) Then
            btnLogIn.Enabled = True
        Else
            btnLogIn.Enabled = False
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        _tempUser = New User(tbUsername.Text, tbPassword.Text)
        RaiseEvent LoginRequested(_tempUser)
        Me.Close()
    End Sub

End Class