<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimpleOwnerDrawList
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
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'listBox1
        '
        Me.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Items.AddRange(New Object() {"Test 1", "Test 2", "Test 3"})
        Me.listBox1.Location = New System.Drawing.Point(12, 12)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(179, 160)
        Me.listBox1.TabIndex = 1
        '
        'SimpleOwnerDrawList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.listBox1)
        Me.Name = "SimpleOwnerDrawList"
        Me.Text = "SimpleOwnerDrawList"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents listBox1 As System.Windows.Forms.ListBox
End Class
