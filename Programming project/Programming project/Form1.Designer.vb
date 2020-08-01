<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.btnStudent = New System.Windows.Forms.Button()
        Me.btnAddministration = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStudent
        '
        Me.btnStudent.Location = New System.Drawing.Point(317, 121)
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(140, 68)
        Me.btnStudent.TabIndex = 0
        Me.btnStudent.Text = "&Student"
        Me.btnStudent.UseVisualStyleBackColor = True
        '
        'btnAddministration
        '
        Me.btnAddministration.Location = New System.Drawing.Point(317, 246)
        Me.btnAddministration.Name = "btnAddministration"
        Me.btnAddministration.Size = New System.Drawing.Size(140, 69)
        Me.btnAddministration.TabIndex = 1
        Me.btnAddministration.Text = "&Administration"
        Me.btnAddministration.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAddministration)
        Me.Controls.Add(Me.btnStudent)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStudent As Button
    Friend WithEvents btnAddministration As Button
End Class
