<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoProgress
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
        Me.components = New System.ComponentModel.Container
        Me.Bar = New System.Windows.Forms.ProgressBar
        Me.tmrIncrementBar = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Bar
        '
        Me.Bar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bar.Location = New System.Drawing.Point(0, 0)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(157, 48)
        Me.Bar.TabIndex = 3
        '
        'tmrIncrementBar
        '
        '
        'AutoProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Bar)
        Me.Name = "AutoProgress"
        Me.Size = New System.Drawing.Size(157, 48)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrIncrementBar As System.Windows.Forms.Timer

End Class
