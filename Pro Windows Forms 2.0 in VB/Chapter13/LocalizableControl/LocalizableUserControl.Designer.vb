<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocalizableUserControl
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
        Me.lblNonLocalizable = New System.Windows.Forms.Label
        Me.lblLocalizable = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblNonLocalizable
        '
        Me.lblNonLocalizable.AutoSize = True
        Me.lblNonLocalizable.Location = New System.Drawing.Point(23, 62)
        Me.lblNonLocalizable.Name = "lblNonLocalizable"
        Me.lblNonLocalizable.Size = New System.Drawing.Size(78, 13)
        Me.lblNonLocalizable.TabIndex = 3
        Me.lblNonLocalizable.Text = "nonLocalizable"
        '
        'lblLocalizable
        '
        Me.lblLocalizable.AutoSize = True
        Me.lblLocalizable.Location = New System.Drawing.Point(23, 26)
        Me.lblLocalizable.Name = "lblLocalizable"
        Me.lblLocalizable.Size = New System.Drawing.Size(56, 13)
        Me.lblLocalizable.TabIndex = 2
        Me.lblLocalizable.Text = "localizable"
        '
        'LocalizableUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblNonLocalizable)
        Me.Controls.Add(Me.lblLocalizable)
        Me.Name = "LocalizableUserControl"
        Me.Size = New System.Drawing.Size(317, 223)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblNonLocalizable As System.Windows.Forms.Label
    Private WithEvents lblLocalizable As System.Windows.Forms.Label

End Class
