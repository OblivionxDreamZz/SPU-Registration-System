<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentPortal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnApplicationForm = New System.Windows.Forms.Button()
        Me.btnRegistrationForm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnApplicationForm
        '
        Me.btnApplicationForm.Location = New System.Drawing.Point(100, 94)
        Me.btnApplicationForm.Name = "btnApplicationForm"
        Me.btnApplicationForm.Size = New System.Drawing.Size(181, 61)
        Me.btnApplicationForm.TabIndex = 0
        Me.btnApplicationForm.Text = "Application Form"
        Me.btnApplicationForm.UseVisualStyleBackColor = True
        '
        'btnRegistrationForm
        '
        Me.btnRegistrationForm.Location = New System.Drawing.Point(491, 94)
        Me.btnRegistrationForm.Name = "btnRegistrationForm"
        Me.btnRegistrationForm.Size = New System.Drawing.Size(181, 61)
        Me.btnRegistrationForm.TabIndex = 1
        Me.btnRegistrationForm.Text = "Registration Form"
        Me.btnRegistrationForm.UseVisualStyleBackColor = True
        '
        'StudentPortal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRegistrationForm)
        Me.Controls.Add(Me.btnApplicationForm)
        Me.Name = "StudentPortal"
        Me.Text = "STUDENT_PORTAL"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnApplicationForm As Button
    Friend WithEvents btnRegistrationForm As Button
End Class
