<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleDraw
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
        Me.chkRepaint = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'chkRepaint
        '
        Me.chkRepaint.AutoSize = True
        Me.chkRepaint.Checked = True
        Me.chkRepaint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRepaint.Location = New System.Drawing.Point(38, 24)
        Me.chkRepaint.Name = "chkRepaint"
        Me.chkRepaint.Size = New System.Drawing.Size(137, 17)
        Me.chkRepaint.TabIndex = 1
        Me.chkRepaint.Text = "Update when repainted"
        '
        'SimpleDraw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.chkRepaint)
        Me.Name = "SimpleDraw"
        Me.Text = "SimpleDraw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chkRepaint As System.Windows.Forms.CheckBox
End Class
