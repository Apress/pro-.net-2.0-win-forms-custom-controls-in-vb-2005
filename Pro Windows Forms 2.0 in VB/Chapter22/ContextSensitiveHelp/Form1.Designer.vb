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
        Me.helpProvider1 = New System.Windows.Forms.HelpProvider
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'helpProvider1
        '
        Me.helpProvider1.HelpNamespace = "HelpTest.chm"
        '
        'textBox2
        '
        Me.helpProvider1.SetHelpKeyword(Me.textBox2, "ValueOfHelp.htm")
        Me.helpProvider1.SetHelpNavigator(Me.textBox2, System.Windows.Forms.HelpNavigator.Topic)
        Me.textBox2.Location = New System.Drawing.Point(72, 48)
        Me.textBox2.Name = "textBox2"
        Me.helpProvider1.SetShowHelp(Me.textBox2, True)
        Me.textBox2.Size = New System.Drawing.Size(214, 20)
        Me.textBox2.TabIndex = 7
        Me.textBox2.Text = "Press F1 here for ValueOfHelp.htm"
        '
        'textBox1
        '
        Me.helpProvider1.SetHelpKeyword(Me.textBox1, "BadHelp.htm")
        Me.helpProvider1.SetHelpNavigator(Me.textBox1, System.Windows.Forms.HelpNavigator.Topic)
        Me.textBox1.Location = New System.Drawing.Point(72, 18)
        Me.textBox1.Name = "textBox1"
        Me.helpProvider1.SetShowHelp(Me.textBox1, True)
        Me.textBox1.Size = New System.Drawing.Size(214, 20)
        Me.textBox1.TabIndex = 6
        Me.textBox1.Text = "Press F1 here for BadHelp.htm"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 55)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(35, 13)
        Me.label2.TabIndex = 5
        Me.label2.Text = "label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 21)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents helpProvider1 As System.Windows.Forms.HelpProvider
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
