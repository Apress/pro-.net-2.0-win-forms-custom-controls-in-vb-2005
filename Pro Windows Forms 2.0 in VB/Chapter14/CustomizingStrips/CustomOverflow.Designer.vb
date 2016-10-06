<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomOverflow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomOverflow))
        Me.toolStripOverflow = New System.Windows.Forms.ToolStrip
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton
        Me.toolStripOverflow.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStripOverflow
        '
        Me.toolStripOverflow.AllowItemReorder = True
        Me.toolStripOverflow.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolStripOverflow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4, Me.toolStripSeparator2, Me.toolStripButton5, Me.toolStripButton6, Me.toolStripButton7, Me.toolStripSeparator3, Me.toolStripButton8})
        Me.toolStripOverflow.Location = New System.Drawing.Point(0, 0)
        Me.toolStripOverflow.Name = "toolStripOverflow"
        Me.toolStripOverflow.Size = New System.Drawing.Size(554, 25)
        Me.toolStripOverflow.TabIndex = 2
        Me.toolStripOverflow.Text = "toolStrip2"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.AutoToolTip = False
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(50, 22)
        Me.toolStripButton1.Text = "&New"
        '
        'toolStripButton2
        '
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(53, 22)
        Me.toolStripButton2.Text = "&Open"
        '
        'toolStripButton3
        '
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(52, 22)
        Me.toolStripButton3.Text = "&Save"
        '
        'toolStripButton4
        '
        Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
        Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton4.Name = "toolStripButton4"
        Me.toolStripButton4.Size = New System.Drawing.Size(48, 22)
        Me.toolStripButton4.Text = "&Print"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton5
        '
        Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
        Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton5.Name = "toolStripButton5"
        Me.toolStripButton5.Size = New System.Drawing.Size(43, 22)
        Me.toolStripButton5.Text = "C&ut"
        '
        'toolStripButton6
        '
        Me.toolStripButton6.Image = CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image)
        Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton6.Name = "toolStripButton6"
        Me.toolStripButton6.Size = New System.Drawing.Size(52, 22)
        Me.toolStripButton6.Text = "&Copy"
        '
        'toolStripButton7
        '
        Me.toolStripButton7.Image = CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image)
        Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton7.Name = "toolStripButton7"
        Me.toolStripButton7.Size = New System.Drawing.Size(54, 22)
        Me.toolStripButton7.Text = "&Paste"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton8
        '
        Me.toolStripButton8.Image = CType(resources.GetObject("toolStripButton8.Image"), System.Drawing.Image)
        Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton8.Name = "toolStripButton8"
        Me.toolStripButton8.Size = New System.Drawing.Size(48, 22)
        Me.toolStripButton8.Text = "He&lp"
        '
        'CustomOverflow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 184)
        Me.Controls.Add(Me.toolStripOverflow)
        Me.Name = "CustomOverflow"
        Me.Text = "CustomOverflow"
        Me.toolStripOverflow.ResumeLayout(False)
        Me.toolStripOverflow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents toolStripOverflow As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton7 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolStripButton8 As System.Windows.Forms.ToolStripButton
End Class
