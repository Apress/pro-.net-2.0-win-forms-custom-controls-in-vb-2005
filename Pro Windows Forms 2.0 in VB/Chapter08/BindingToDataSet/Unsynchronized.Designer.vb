<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Unsynchronized
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
        Me.grpB = New System.Windows.Forms.GroupBox
        Me.lstModelNameB = New System.Windows.Forms.ListBox
        Me.grpA = New System.Windows.Forms.GroupBox
        Me.lstModelNameA = New System.Windows.Forms.ListBox
        Me.grpB.SuspendLayout()
        Me.grpA.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpB
        '
        Me.grpB.Controls.Add(Me.lstModelNameB)
        Me.grpB.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpB.Location = New System.Drawing.Point(10, 143)
        Me.grpB.Name = "grpB"
        Me.grpB.Size = New System.Drawing.Size(280, 136)
        Me.grpB.TabIndex = 9
        Me.grpB.TabStop = False
        '
        'lstModelNameB
        '
        Me.lstModelNameB.FormattingEnabled = True
        Me.lstModelNameB.Location = New System.Drawing.Point(16, 24)
        Me.lstModelNameB.Name = "lstModelNameB"
        Me.lstModelNameB.Size = New System.Drawing.Size(248, 95)
        Me.lstModelNameB.TabIndex = 1
        '
        'grpA
        '
        Me.grpA.Controls.Add(Me.lstModelNameA)
        Me.grpA.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.grpA.Location = New System.Drawing.Point(10, 6)
        Me.grpA.Name = "grpA"
        Me.grpA.Size = New System.Drawing.Size(280, 136)
        Me.grpA.TabIndex = 8
        Me.grpA.TabStop = False
        '
        'lstModelNameA
        '
        Me.lstModelNameA.FormattingEnabled = True
        Me.lstModelNameA.Location = New System.Drawing.Point(16, 24)
        Me.lstModelNameA.Name = "lstModelNameA"
        Me.lstModelNameA.Size = New System.Drawing.Size(248, 95)
        Me.lstModelNameA.TabIndex = 0
        '
        'Unsynchronized
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 285)
        Me.Controls.Add(Me.grpB)
        Me.Controls.Add(Me.grpA)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Unsynchronized"
        Me.Text = "Unsynchronized"
        Me.grpB.ResumeLayout(False)
        Me.grpA.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grpB As System.Windows.Forms.GroupBox
    Private WithEvents lstModelNameB As System.Windows.Forms.ListBox
    Private WithEvents grpA As System.Windows.Forms.GroupBox
    Private WithEvents lstModelNameA As System.Windows.Forms.ListBox
End Class
