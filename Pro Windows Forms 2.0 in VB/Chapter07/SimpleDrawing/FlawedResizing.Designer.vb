<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FlawedResizing
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
        Me.chkResizeRedraw = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'chkResizeRedraw
        '
        Me.chkResizeRedraw.AutoSize = True
        Me.chkResizeRedraw.Location = New System.Drawing.Point(99, 125)
        Me.chkResizeRedraw.Name = "chkResizeRedraw"
        Me.chkResizeRedraw.Size = New System.Drawing.Size(95, 17)
        Me.chkResizeRedraw.TabIndex = 1
        Me.chkResizeRedraw.Text = "ResizeRedraw"
        '
        'FlawedResizing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.chkResizeRedraw)
        Me.Name = "FlawedResizing"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "FlawedResizing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chkResizeRedraw As System.Windows.Forms.CheckBox
End Class
