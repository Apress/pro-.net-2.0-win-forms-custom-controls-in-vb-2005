<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressTest
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
        Me.components = New System.ComponentModel.Container
        Me.tmrIncrementBar = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStart = New System.Windows.Forms.Button
        Me.status = New ProgressControl.Progress
        Me.SuspendLayout()
        '
        'tmrIncrementBar
        '
        Me.tmrIncrementBar.Interval = 1000
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(100, 159)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(92, 24)
        Me.cmdStart.TabIndex = 2
        Me.cmdStart.Text = "Start"
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(12, 12)
        Me.status.Maximum = 100
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(268, 88)
        Me.status.Step = 10
        Me.status.TabIndex = 3
        Me.status.Value = 0
        '
        'ProgressTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 195)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.cmdStart)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ProgressTest"
        Me.Text = "ProgressTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrIncrementBar As System.Windows.Forms.Timer
    Private WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents status As ProgressControl.Progress
End Class
