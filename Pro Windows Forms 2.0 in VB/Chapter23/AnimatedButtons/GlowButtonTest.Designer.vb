<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlowButtonTest
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
        Me.SimpleGlowButton1 = New AnimatedButtons.SimpleGlowButton
        Me.SimpleGlowButton2 = New AnimatedButtons.SimpleGlowButton
        Me.SimpleGlowButton3 = New AnimatedButtons.SimpleGlowButton
        Me.SuspendLayout()
        '
        'SimpleGlowButton1
        '
        Me.SimpleGlowButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SimpleGlowButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleGlowButton1.Location = New System.Drawing.Point(36, 28)
        Me.SimpleGlowButton1.Name = "SimpleGlowButton1"
        Me.SimpleGlowButton1.PaintFocusCue = True
        Me.SimpleGlowButton1.Size = New System.Drawing.Size(136, 23)
        Me.SimpleGlowButton1.TabIndex = 0
        Me.SimpleGlowButton1.Text = "SimpleGlowButton1"
        '
        'SimpleGlowButton2
        '
        Me.SimpleGlowButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SimpleGlowButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleGlowButton2.Location = New System.Drawing.Point(36, 57)
        Me.SimpleGlowButton2.Name = "SimpleGlowButton2"
        Me.SimpleGlowButton2.PaintFocusCue = True
        Me.SimpleGlowButton2.Size = New System.Drawing.Size(136, 23)
        Me.SimpleGlowButton2.TabIndex = 1
        Me.SimpleGlowButton2.Text = "SimpleGlowButton2"
        '
        'SimpleGlowButton3
        '
        Me.SimpleGlowButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.SimpleGlowButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleGlowButton3.Location = New System.Drawing.Point(36, 86)
        Me.SimpleGlowButton3.Name = "SimpleGlowButton3"
        Me.SimpleGlowButton3.PaintFocusCue = True
        Me.SimpleGlowButton3.Size = New System.Drawing.Size(136, 23)
        Me.SimpleGlowButton3.TabIndex = 2
        Me.SimpleGlowButton3.Text = "SimpleGlowButton3"
        '
        'GlowButtonTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.SimpleGlowButton3)
        Me.Controls.Add(Me.SimpleGlowButton2)
        Me.Controls.Add(Me.SimpleGlowButton1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "GlowButtonTest"
        Me.Text = "GlowButtonTest"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleGlowButton1 As AnimatedButtons.SimpleGlowButton
    Friend WithEvents SimpleGlowButton2 As AnimatedButtons.SimpleGlowButton
    Friend WithEvents SimpleGlowButton3 As AnimatedButtons.SimpleGlowButton
End Class
