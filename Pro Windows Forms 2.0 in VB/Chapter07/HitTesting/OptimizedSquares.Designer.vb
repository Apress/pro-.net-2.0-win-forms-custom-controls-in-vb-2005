<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptimizedSquares
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
        Me.lblCount = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCount.Location = New System.Drawing.Point(0, 340)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Padding = New System.Windows.Forms.Padding(2)
        Me.lblCount.Size = New System.Drawing.Size(429, 21)
        Me.lblCount.TabIndex = 2
        '
        'OptimizedSquares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 361)
        Me.Controls.Add(Me.lblCount)
        Me.Name = "OptimizedSquares"
        Me.Text = "OptimizedSquares"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblCount As System.Windows.Forms.Label
End Class
