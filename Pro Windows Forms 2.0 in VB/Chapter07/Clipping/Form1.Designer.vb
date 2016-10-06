<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.chkClipping = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'chkClipping
        '
        Me.chkClipping.AutoSize = True
        Me.chkClipping.Checked = True
        Me.chkClipping.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClipping.Location = New System.Drawing.Point(12, 348)
        Me.chkClipping.Name = "chkClipping"
        Me.chkClipping.Size = New System.Drawing.Size(85, 17)
        Me.chkClipping.TabIndex = 1
        Me.chkClipping.Text = "Use Clipping"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 377)
        Me.Controls.Add(Me.chkClipping)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents chkClipping As System.Windows.Forms.CheckBox

End Class
