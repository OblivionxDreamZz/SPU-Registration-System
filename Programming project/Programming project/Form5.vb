Public Class Form5
    Dim a As Integer

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        If txtUsername2.Text = My.Settings.Username Then
            a += 1

        End If

        If txtPassword2.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            MessageBox.Show("Your Registration was successful", "Welcom to University", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form6.Show()

        Else
            MessageBox.Show("Invalid Entry", "Invalid Password or Username", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class