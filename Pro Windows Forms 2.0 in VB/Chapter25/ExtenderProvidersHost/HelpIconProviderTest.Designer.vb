<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpIconProviderTest
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
        Me.HelpIconProvider1 = New ExtenderProviders.HelpIconProvider
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        CType(Me.HelpIconProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HelpIconProvider1
        '
        Me.HelpIconProvider1.HelpFile = "HelpTest.chm"
        '
        'textBox2
        '
        Me.HelpIconProvider1.SetHelpID(Me.textBox2, "ValueOfHelp.htm")
        Me.textBox2.Location = New System.Drawing.Point(27, 68)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 3
        Me.textBox2.Text = "The Value of Help"
        '
        'textBox1
        '
        Me.HelpIconProvider1.SetHelpID(Me.textBox1, "BadHelp.htm")
        Me.textBox1.Location = New System.Drawing.Point(27, 33)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 2
        Me.textBox1.Text = "Bad Help"
        '
        'HelpIconProviderTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.HelpIconProvider1.SetHelpID(Me, "")
        Me.Name = "HelpIconProviderTest"
        Me.Text = "HelpIconProviderTest"
        CType(Me.HelpIconProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpIconProvider1 As ExtenderProviders.HelpIconProvider
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
End Class
