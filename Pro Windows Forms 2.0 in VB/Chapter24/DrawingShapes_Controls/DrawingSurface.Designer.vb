<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DrawingSurface
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
        Me.components = New System.ComponentModel.Container
        Me.mnuInsertShape = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRectangle = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEllipse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTriangle = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSelectShape = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuColorChange = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRemoveShape = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSendToBack = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBringToFront = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuInsertShape.SuspendLayout()
        Me.mnuSelectShape.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuInsertShape
        '
        Me.mnuInsertShape.AllowDrop = True
        Me.mnuInsertShape.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRectangle, Me.mnuEllipse, Me.mnuTriangle})
        Me.mnuInsertShape.Name = "contextMenuStrip1"
        Me.mnuInsertShape.Size = New System.Drawing.Size(194, 70)
        '
        'mnuRectangle
        '
        Me.mnuRectangle.Name = "mnuRectangle"
        Me.mnuRectangle.Size = New System.Drawing.Size(193, 22)
        Me.mnuRectangle.Text = "Create New Rectangle"
        '
        'mnuEllipse
        '
        Me.mnuEllipse.Name = "mnuEllipse"
        Me.mnuEllipse.Size = New System.Drawing.Size(193, 22)
        Me.mnuEllipse.Text = "Create New Ellipse"
        '
        'mnuTriangle
        '
        Me.mnuTriangle.Name = "mnuTriangle"
        Me.mnuTriangle.Size = New System.Drawing.Size(193, 22)
        Me.mnuTriangle.Text = "Create New Triangle"
        '
        'mnuSelectShape
        '
        Me.mnuSelectShape.AllowDrop = True
        Me.mnuSelectShape.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorChange, Me.mnuRemoveShape, Me.mnuBringToFront, Me.mnuSendToBack})
        Me.mnuSelectShape.Name = "contextMenuStrip1"
        Me.mnuSelectShape.Size = New System.Drawing.Size(158, 114)
        '
        'mnuColorChange
        '
        Me.mnuColorChange.Name = "mnuColorChange"
        Me.mnuColorChange.Size = New System.Drawing.Size(157, 22)
        Me.mnuColorChange.Text = "Change Color"
        '
        'mnuRemoveShape
        '
        Me.mnuRemoveShape.Name = "mnuRemoveShape"
        Me.mnuRemoveShape.Size = New System.Drawing.Size(157, 22)
        Me.mnuRemoveShape.Text = "Remove Shape"
        '
        'mnuSendToBack
        '
        Me.mnuSendToBack.Name = "mnuSendToBack"
        Me.mnuSendToBack.Size = New System.Drawing.Size(157, 22)
        Me.mnuSendToBack.Text = "Send To Back"
        '
        'mnuBringToFront
        '
        Me.mnuBringToFront.Name = "mnuBringToFront"
        Me.mnuBringToFront.Size = New System.Drawing.Size(157, 22)
        Me.mnuBringToFront.Text = "Bring to Front"
        '
        'DrawingSurface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 430)
        Me.ContextMenuStrip = Me.mnuInsertShape
        Me.Name = "DrawingSurface"
        Me.Text = "DrawingShapes"
        Me.mnuInsertShape.ResumeLayout(False)
        Me.mnuSelectShape.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents mnuInsertShape As System.Windows.Forms.ContextMenuStrip
    Private WithEvents mnuRectangle As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuEllipse As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuTriangle As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuSelectShape As System.Windows.Forms.ContextMenuStrip
    Private WithEvents mnuColorChange As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuRemoveShape As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuSendToBack As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuBringToFront As System.Windows.Forms.ToolStripMenuItem

End Class
