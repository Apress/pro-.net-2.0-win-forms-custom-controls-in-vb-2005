<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PopImageButtonTest
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
        Me.popImageButton3 = New AnimatedButtons.PopImageButton
        Me.popImageButton2 = New AnimatedButtons.PopImageButton
        Me.popImageButton1 = New AnimatedButtons.PopImageButton
        Me.SuspendLayout()
        '
        'popImageButton3
        '
        Me.popImageButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.popImageButton3.Image = Global.AnimatedButtons.My.Resources.Resources.HotTrackButton3
        Me.popImageButton3.Location = New System.Drawing.Point(51, 121)
        Me.popImageButton3.Name = "popImageButton3"
        Me.popImageButton3.PaintFocusCue = True
        Me.popImageButton3.Size = New System.Drawing.Size(116, 21)
        Me.popImageButton3.TabIndex = 5
        Me.popImageButton3.Text = "popImageButton3"
        '
        'popImageButton2
        '
        Me.popImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.popImageButton2.Enabled = False
        Me.popImageButton2.Image = Global.AnimatedButtons.My.Resources.Resources.hotTrackButton2
        Me.popImageButton2.Location = New System.Drawing.Point(51, 82)
        Me.popImageButton2.Name = "popImageButton2"
        Me.popImageButton2.PaintFocusCue = True
        Me.popImageButton2.Size = New System.Drawing.Size(116, 23)
        Me.popImageButton2.TabIndex = 4
        Me.popImageButton2.Text = "popImageButton2"
        '
        'popImageButton1
        '
        Me.popImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.popImageButton1.Image = Global.AnimatedButtons.My.Resources.Resources.hotTrackButton1
        Me.popImageButton1.Location = New System.Drawing.Point(51, 32)
        Me.popImageButton1.Name = "popImageButton1"
        Me.popImageButton1.PaintFocusCue = True
        Me.popImageButton1.Size = New System.Drawing.Size(116, 38)
        Me.popImageButton1.TabIndex = 3
        Me.popImageButton1.Text = "popImageButton1"
        '
        'PopImageButtonTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.popImageButton3)
        Me.Controls.Add(Me.popImageButton2)
        Me.Controls.Add(Me.popImageButton1)
        Me.Name = "PopImageButtonTest"
        Me.Text = "PopImageButtonTest"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents popImageButton3 As AnimatedButtons.PopImageButton
    Private WithEvents popImageButton2 As AnimatedButtons.PopImageButton
    Private WithEvents popImageButton1 As AnimatedButtons.PopImageButton
End Class
