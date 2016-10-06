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
        Me.label2 = New System.Windows.Forms.Label
        Me.cmdSetTextConstraint = New System.Windows.Forms.Button
        Me.cmdSetText = New System.Windows.Forms.Button
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.label1 = New System.Windows.Forms.Label
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(17, 259)
        Me.label2.Margin = New System.Windows.Forms.Padding(10)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(216, 75)
        Me.label2.TabIndex = 9
        Me.label2.Text = "The Margin settings on various controls (the Label, GroupBox, etc) are increased " & _
            "to ensure some breathing room when the labels grow."
        '
        'cmdSetTextConstraint
        '
        Me.cmdSetTextConstraint.Location = New System.Drawing.Point(55, 92)
        Me.cmdSetTextConstraint.Name = "cmdSetTextConstraint"
        Me.cmdSetTextConstraint.Size = New System.Drawing.Size(165, 23)
        Me.cmdSetTextConstraint.TabIndex = 8
        Me.cmdSetTextConstraint.Text = "Constrain Label and Set Text"
        Me.cmdSetTextConstraint.UseVisualStyleBackColor = True
        '
        'cmdSetText
        '
        Me.cmdSetText.Location = New System.Drawing.Point(55, 66)
        Me.cmdSetText.Name = "cmdSetText"
        Me.cmdSetText.Size = New System.Drawing.Size(165, 23)
        Me.cmdSetText.TabIndex = 7
        Me.cmdSetText.Text = "Set Text"
        Me.cmdSetText.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(20, 13)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(200, 47)
        Me.textBox1.TabIndex = 6
        Me.textBox1.Text = "The quick brown fox jumps over the lazy dog. The quick brown fox jumps over the l" & _
            "azy dog."
        '
        'groupBox1
        '
        Me.groupBox1.AutoSize = True
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(20, 134)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(20)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(200, 100)
        Me.groupBox1.TabIndex = 5
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "groupBox1"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(17, 25)
        Me.label1.Margin = New System.Windows.Forms.Padding(5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 346)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cmdSetTextConstraint)
        Me.Controls.Add(Me.cmdSetText)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cmdSetTextConstraint As System.Windows.Forms.Button
    Private WithEvents cmdSetText As System.Windows.Forms.Button
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
