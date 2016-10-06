<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoProgressTest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.cmdStop = New System.Windows.Forms.Button
        Me.cmdStart = New System.Windows.Forms.Button
        Me.AutoProgress1 = New ProgressControl.AutoProgress
        Me.SuspendLayout()
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(120, 124)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 23)
        Me.cmdStop.TabIndex = 3
        Me.cmdStop.Text = "Stop"
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(38, 124)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(75, 23)
        Me.cmdStart.TabIndex = 2
        Me.cmdStart.Text = "Start"
        '
        'AutoProgress1
        '
        Me.AutoProgress1.Location = New System.Drawing.Point(38, 21)
        Me.AutoProgress1.Name = "AutoProgress1"
        Me.AutoProgress1.PercentPerSecond = 5
        Me.AutoProgress1.Size = New System.Drawing.Size(157, 48)
        Me.AutoProgress1.TabIndex = 4
        '
        'AutoProgressTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 168)
        Me.Controls.Add(Me.AutoProgress1)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdStart)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AutoProgressTest"
        Me.Text = "AutoProgressTest"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdStop As System.Windows.Forms.Button
    Private WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents AutoProgress1 As ProgressControl.AutoProgress
End Class
