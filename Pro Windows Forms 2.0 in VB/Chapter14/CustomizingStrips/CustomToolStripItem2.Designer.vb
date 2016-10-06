<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomToolStripItem2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomToolStripItem2))
        Me.CustomToolStripButton1 = New CustomizingStrips.CustomToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.CheckTextBoxToolStripItem1 = New CustomizingStrips.CheckTextBoxToolStripItem
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomToolStripButton1
        '
        Me.CustomToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomToolStripButton1.Image = CType(resources.GetObject("CustomToolStripButton1.Image"), System.Drawing.Image)
        Me.CustomToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CustomToolStripButton1.Name = "CustomToolStripButton1"
        Me.CustomToolStripButton1.Size = New System.Drawing.Size(23, 27)
        Me.CustomToolStripButton1.Text = "CustomToolStripButton1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomToolStripButton1, Me.CheckTextBoxToolStripItem1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(406, 30)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CheckTextBoxToolStripItem1
        '
        Me.CheckTextBoxToolStripItem1.BackColor = System.Drawing.Color.Transparent
        Me.CheckTextBoxToolStripItem1.Name = "CheckTextBoxToolStripItem1"
        Me.CheckTextBoxToolStripItem1.Size = New System.Drawing.Size(127, 27)
        Me.CheckTextBoxToolStripItem1.Text = "CheckTextBoxToolStripItem1"
        Me.CheckTextBoxToolStripItem1.TextEnabled = True
        '
        'CustomToolStripItem2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 266)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "CustomToolStripItem2"
        Me.Text = "CustomToolStripItem2"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomToolStripButton1 As CustomizingStrips.CustomToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CheckTextBoxToolStripItem1 As CustomizingStrips.CheckTextBoxToolStripItem
End Class
