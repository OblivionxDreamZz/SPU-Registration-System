Public Class ApplicationForm
    Private Sub ApplicationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Application_formDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Application_formDataSet.Table1)





    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click


        'Declaration
        Dim GradeAverage As Byte
        GradeAverage = Convert.ToByte(txtGradeAverage.Text)

        'If Statements


        If GradeAverage >= 50 Then

            MessageBox.Show("You Meet The Requirements to register", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            RegistrationForm.Show()
            Table1BindingSource.AddNew()
        ElseIf GradeAverage < 50 Then
            MessageBox.Show("You Do Not Meet The Minimume Requirements", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            Table1BindingSource.AddNew()
        End If

        On Error GoTo SaveErr
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(Application_formDataSet.Table1)
        MessageBox.Show("Data entered has been saved successfully")
SaveErr:
        Exit Sub

        Table1BindingSource.AddNew()

    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        RegistrationForm.Show()

    End Sub

    Private Sub Table1BindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles Table1BindingSource.CurrentChanged

    End Sub
End Class