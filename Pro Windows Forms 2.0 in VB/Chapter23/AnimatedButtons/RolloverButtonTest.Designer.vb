<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RolloverButtonTest
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
        Me.rolloverButton3 = New AnimatedButtons.RolloverButton
        Me.rolloverButton2 = New AnimatedButtons.RolloverButton
        Me.rolloverButton1 = New AnimatedButtons.RolloverButton
        Me.SuspendLayout()
        '
        'rolloverButton3
        '
        Me.rolloverButton3.BackColor = System.Drawing.Color.Transparent
        Me.rolloverButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rolloverButton3.DisabledImage = Nothing
        Me.rolloverButton3.Location = New System.Drawing.Point(229, 217)
        Me.rolloverButton3.MouseOverImage = Global.AnimatedButtons.My.Resources.Resources.buttonDSE_2
        Me.rolloverButton3.Name = "rolloverButton3"
        Me.rolloverButton3.NormalImage = Global.AnimatedButtons.My.Resources.Resources.buttonDSE_1
        Me.rolloverButton3.PaintFocusCue = True
        Me.rolloverButton3.PushedImage = Global.AnimatedButtons.My.Resources.Resources.buttonDSE_3
        Me.rolloverButton3.Size = New System.Drawing.Size(195, 39)
        Me.rolloverButton3.TabIndex = 5
        Me.rolloverButton3.Text = "rolloverButton3"
        '
        'rolloverButton2
        '
        Me.rolloverButton2.BackColor = System.Drawing.Color.Transparent
        Me.rolloverButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rolloverButton2.DisabledImage = Nothing
        Me.rolloverButton2.Location = New System.Drawing.Point(167, 140)
        Me.rolloverButton2.MouseOverImage = Global.AnimatedButtons.My.Resources.Resources.buttonDS_2
        Me.rolloverButton2.Name = "rolloverButton2"
        Me.rolloverButton2.NormalImage = Global.AnimatedButtons.My.Resources.Resources.buttonDS_1
        Me.rolloverButton2.PaintFocusCue = True
        Me.rolloverButton2.PushedImage = Global.AnimatedButtons.My.Resources.Resources.buttonDS_3
        Me.rolloverButton2.Size = New System.Drawing.Size(195, 39)
        Me.rolloverButton2.TabIndex = 4
        Me.rolloverButton2.Text = "rolloverButton2"
        '
        'rolloverButton1
        '
        Me.rolloverButton1.BackColor = System.Drawing.Color.Transparent
        Me.rolloverButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.rolloverButton1.DisabledImage = Nothing
        Me.rolloverButton1.Location = New System.Drawing.Point(293, 292)
        Me.rolloverButton1.MouseOverImage = Global.AnimatedButtons.My.Resources.Resources.buttonC_2
        Me.rolloverButton1.Name = "rolloverButton1"
        Me.rolloverButton1.NormalImage = Global.AnimatedButtons.My.Resources.Resources.buttonC_1
        Me.rolloverButton1.PaintFocusCue = True
        Me.rolloverButton1.PushedImage = Global.AnimatedButtons.My.Resources.Resources.buttonC_3
        Me.rolloverButton1.Size = New System.Drawing.Size(195, 39)
        Me.rolloverButton1.TabIndex = 3
        Me.rolloverButton1.Text = "rolloverButton1"
        '
        'RolloverButtonTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AnimatedButtons.My.Resources.Resources.background2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(657, 473)
        Me.Controls.Add(Me.rolloverButton3)
        Me.Controls.Add(Me.rolloverButton2)
        Me.Controls.Add(Me.rolloverButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RolloverButtonTest"
        Me.Text = "RolloverButton"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents rolloverButton3 As AnimatedButtons.RolloverButton
    Private WithEvents rolloverButton2 As AnimatedButtons.RolloverButton
    Private WithEvents rolloverButton1 As AnimatedButtons.RolloverButton
End Class
