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
        Me.lblSaturation = New System.Windows.Forms.Label
        Me.lblHue = New System.Windows.Forms.Label
        Me.lblBrightness = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstColors = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lblSaturation
        '
        Me.lblSaturation.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSaturation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSaturation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblSaturation.Location = New System.Drawing.Point(270, 58)
        Me.lblSaturation.Name = "lblSaturation"
        Me.lblSaturation.Size = New System.Drawing.Size(136, 20)
        Me.lblSaturation.TabIndex = 9
        Me.lblSaturation.Text = " Saturation"
        '
        'lblHue
        '
        Me.lblHue.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHue.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblHue.Location = New System.Drawing.Point(270, 34)
        Me.lblHue.Name = "lblHue"
        Me.lblHue.Size = New System.Drawing.Size(136, 20)
        Me.lblHue.TabIndex = 8
        Me.lblHue.Text = " Hue"
        '
        'lblBrightness
        '
        Me.lblBrightness.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBrightness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBrightness.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblBrightness.Location = New System.Drawing.Point(270, 10)
        Me.lblBrightness.Name = "lblBrightness"
        Me.lblBrightness.Size = New System.Drawing.Size(136, 20)
        Me.lblBrightness.TabIndex = 7
        Me.lblBrightness.Text = " Brightness"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = " Choose a Background Color:"
        '
        'lstColors
        '
        Me.lstColors.FormattingEnabled = True
        Me.lstColors.Location = New System.Drawing.Point(14, 38)
        Me.lstColors.Name = "lstColors"
        Me.lstColors.Size = New System.Drawing.Size(200, 238)
        Me.lstColors.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 287)
        Me.Controls.Add(Me.lblSaturation)
        Me.Controls.Add(Me.lblHue)
        Me.Controls.Add(Me.lblBrightness)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstColors)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Color Changer"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblSaturation As System.Windows.Forms.Label
    Private WithEvents lblHue As System.Windows.Forms.Label
    Private WithEvents lblBrightness As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lstColors As System.Windows.Forms.ListBox

End Class
