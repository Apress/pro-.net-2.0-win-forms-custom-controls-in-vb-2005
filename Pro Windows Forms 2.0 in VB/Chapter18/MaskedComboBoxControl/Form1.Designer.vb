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
        Me.maskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.maskedComboBox1 = New MaskedComboBoxControl.MaskedComboBox
        Me.SuspendLayout()
        '
        'maskedTextBox1
        '
        Me.maskedTextBox1.Location = New System.Drawing.Point(70, 105)
        Me.maskedTextBox1.Mask = "(999) 000-0000"
        Me.maskedTextBox1.Name = "maskedTextBox1"
        Me.maskedTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.maskedTextBox1.TabIndex = 3
        '
        'maskedComboBox1
        '
        Me.maskedComboBox1.FormattingEnabled = True
        Me.maskedComboBox1.Location = New System.Drawing.Point(70, 78)
        Me.maskedComboBox1.Mask = ""
        Me.maskedComboBox1.Name = "maskedComboBox1"
        Me.maskedComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.maskedComboBox1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.maskedTextBox1)
        Me.Controls.Add(Me.maskedComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents maskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Private WithEvents maskedComboBox1 As MaskedComboBoxControl.MaskedComboBox

End Class
