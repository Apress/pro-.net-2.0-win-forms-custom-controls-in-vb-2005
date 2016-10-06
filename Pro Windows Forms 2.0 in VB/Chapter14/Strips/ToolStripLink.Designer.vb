<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolStripLink
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
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLinkLabel = New System.Windows.Forms.ToolStripLabel
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1, Me.ToolStripLinkLabel})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(272, 25)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripLabel1
        '
        Me.toolStripLabel1.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.toolStripLabel1.Name = "toolStripLabel1"
        Me.toolStripLabel1.Size = New System.Drawing.Size(77, 22)
        Me.toolStripLabel1.Text = "Ordinary Label"
        '
        'ToolStripLinkLabel
        '
        Me.ToolStripLinkLabel.IsLink = True
        Me.ToolStripLinkLabel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 2)
        Me.ToolStripLinkLabel.Name = "ToolStripLinkLabel"
        Me.ToolStripLinkLabel.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLinkLabel.Tag = "www.prosetech.com"
        Me.ToolStripLinkLabel.Text = "Link Label"
        '
        'ToolStripLink
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 138)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "ToolStripLink"
        Me.Text = "ToolStripLink"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents ToolStripLinkLabel As System.Windows.Forms.ToolStripLabel
End Class
