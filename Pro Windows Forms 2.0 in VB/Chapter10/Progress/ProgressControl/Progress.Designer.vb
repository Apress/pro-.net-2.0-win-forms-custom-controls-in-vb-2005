<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Progress
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.lblProgress = New System.Windows.Forms.Label
        Me.Bar = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'lblProgress
        '
        Me.lblProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProgress.Location = New System.Drawing.Point(3, 45)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(152, 16)
        Me.lblProgress.TabIndex = 5
        Me.lblProgress.Text = "0% Done"
        Me.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Bar
        '
        Me.Bar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Bar.Location = New System.Drawing.Point(3, 5)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(154, 32)
        Me.Bar.TabIndex = 4
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblProgress)
        Me.Controls.Add(Me.Bar)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(161, 67)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProgress As System.Windows.Forms.Label
    Friend WithEvents Bar As System.Windows.Forms.ProgressBar

End Class
