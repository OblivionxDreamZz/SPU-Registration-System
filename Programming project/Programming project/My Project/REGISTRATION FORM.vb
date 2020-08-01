Public Class RegistrationForm
    Dim a As Integer = 0


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click




        Try
            If Not txtUsername.Text = "" Then
                a += 1
            End If

            If Not txtPassword.Text = "" Then
                a += 1

            End If

            If a = 2 Then
                My.Settings.Username = txtUsername.Text
                My.Settings.Password = txtPassword.Text
                My.Settings.Save()
            End If


        Catch ex As Exception
            MessageBox.Show("Error", "Please complete the registration form to procced")
        End Try

        MessageBox.Show("Please Verify Regestraion")
        Form5.Show()

    End Sub
End Class