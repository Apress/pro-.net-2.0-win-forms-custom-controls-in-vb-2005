<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnedForm
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
        Me.lblState = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(27, 34)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(184, 56)
        Me.lblState.TabIndex = 3
        '
        'OwnedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 124)
        Me.Controls.Add(Me.lblState)
        Me.Name = "OwnedForm"
        Me.Text = "OwnedForm"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lblState As System.Windows.Forms.Label
End Class
