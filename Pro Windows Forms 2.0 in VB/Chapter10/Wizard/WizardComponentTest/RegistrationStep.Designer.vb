<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationStep
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.optNever = New System.Windows.Forms.RadioButton
        Me.optLater = New System.Windows.Forms.RadioButton
        Me.optRegisterToday = New System.Windows.Forms.RadioButton
        Me.SuspendLayout()
        '
        'optNever
        '
        Me.optNever.AutoSize = True
        Me.optNever.Location = New System.Drawing.Point(15, 57)
        Me.optNever.Name = "optNever"
        Me.optNever.Size = New System.Drawing.Size(109, 17)
        Me.optNever.TabIndex = 5
        Me.optNever.Text = "Stop nagging me!"
        '
        'optLater
        '
        Me.optLater.AutoSize = True
        Me.optLater.Location = New System.Drawing.Point(15, 37)
        Me.optLater.Name = "optLater"
        Me.optLater.Size = New System.Drawing.Size(102, 17)
        Me.optLater.TabIndex = 4
        Me.optLater.Text = "Remind me later"
        '
        'optRegisterToday
        '
        Me.optRegisterToday.AutoSize = True
        Me.optRegisterToday.Location = New System.Drawing.Point(15, 17)
        Me.optRegisterToday.Name = "optRegisterToday"
        Me.optRegisterToday.Size = New System.Drawing.Size(183, 17)
        Me.optRegisterToday.TabIndex = 3
        Me.optRegisterToday.Text = "Register today (discount applies)"
        '
        'RegistrationStep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.optNever)
        Me.Controls.Add(Me.optLater)
        Me.Controls.Add(Me.optRegisterToday)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "RegistrationStep"
        Me.Size = New System.Drawing.Size(219, 94)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents optNever As System.Windows.Forms.RadioButton
    Private WithEvents optLater As System.Windows.Forms.RadioButton
    Private WithEvents optRegisterToday As System.Windows.Forms.RadioButton

End Class
