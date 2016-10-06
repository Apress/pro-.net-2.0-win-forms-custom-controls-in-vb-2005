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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DrawingSurface))
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.mnuForm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRectangle = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEllipse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTriangle = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.newDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.saveDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.loadDrawingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuShape = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuColorChange = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRemoveShape = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.mnuToFront = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuToBack = New System.Windows.Forms.ToolStripMenuItem
        Me.toolStrip2 = New System.Windows.Forms.ToolStrip
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.saveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.mnuNew = New System.Windows.Forms.ToolStripButton
        Me.mnuLoad = New System.Windows.Forms.ToolStripButton
        Me.mnuSave = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdRectangle = New System.Windows.Forms.ToolStripButton
        Me.cmdEllipse = New System.Windows.Forms.ToolStripButton
        Me.cmdTriangle = New System.Windows.Forms.ToolStripButton
        Me.mnuForm.SuspendLayout()
        Me.mnuShape.SuspendLayout()
        Me.toolStrip2.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuForm
        '
        Me.mnuForm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRectangle, Me.mnuEllipse, Me.mnuTriangle, Me.toolStripSeparator2, Me.newDrawingToolStripMenuItem, Me.saveDrawingToolStripMenuItem, Me.loadDrawingToolStripMenuItem})
        Me.mnuForm.Name = "mnuForm"
        Me.mnuForm.Size = New System.Drawing.Size(192, 142)
        '
        'mnuRectangle
        '
        Me.mnuRectangle.Name = "mnuRectangle"
        Me.mnuRectangle.Size = New System.Drawing.Size(191, 22)
        Me.mnuRectangle.Text = "Create New Rectange"
        '
        'mnuEllipse
        '
        Me.mnuEllipse.Name = "mnuEllipse"
        Me.mnuEllipse.Size = New System.Drawing.Size(191, 22)
        Me.mnuEllipse.Text = "Create New Ellipse"
        '
        'mnuTriangle
        '
        Me.mnuTriangle.Name = "mnuTriangle"
        Me.mnuTriangle.Size = New System.Drawing.Size(191, 22)
        Me.mnuTriangle.Text = "Create New Triangle"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(188, 6)
        '
        'newDrawingToolStripMenuItem
        '
        Me.newDrawingToolStripMenuItem.Name = "newDrawingToolStripMenuItem"
        Me.newDrawingToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.newDrawingToolStripMenuItem.Text = "New Drawing"
        '
        'saveDrawingToolStripMenuItem
        '
        Me.saveDrawingToolStripMenuItem.Name = "saveDrawingToolStripMenuItem"
        Me.saveDrawingToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.saveDrawingToolStripMenuItem.Text = "Save Drawing"
        '
        'loadDrawingToolStripMenuItem
        '
        Me.loadDrawingToolStripMenuItem.Name = "loadDrawingToolStripMenuItem"
        Me.loadDrawingToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.loadDrawingToolStripMenuItem.Text = "Load Drawing"
        '
        'mnuShape
        '
        Me.mnuShape.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorChange, Me.mnuRemoveShape, Me.toolStripSeparator3, Me.mnuToFront, Me.mnuToBack})
        Me.mnuShape.Name = "mnuShape"
        Me.mnuShape.Size = New System.Drawing.Size(158, 98)
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
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(154, 6)
        '
        'mnuToFront
        '
        Me.mnuToFront.Name = "mnuToFront"
        Me.mnuToFront.Size = New System.Drawing.Size(157, 22)
        Me.mnuToFront.Text = "Bring To Front"
        '
        'mnuToBack
        '
        Me.mnuToBack.Name = "mnuToBack"
        Me.mnuToBack.Size = New System.Drawing.Size(157, 22)
        Me.mnuToBack.Text = "Send To Back"
        '
        'toolStrip2
        '
        Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.cmdDelete, Me.toolStripSeparator, Me.toolStripButton2, Me.toolStripButton3})
        Me.toolStrip2.Location = New System.Drawing.Point(0, 25)
        Me.toolStrip2.Name = "toolStrip2"
        Me.toolStrip2.Size = New System.Drawing.Size(566, 25)
        Me.toolStrip2.TabIndex = 5
        Me.toolStrip2.Text = "toolStrip2"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(76, 22)
        Me.toolStripButton1.Text = "Change Color"
        '
        'cmdDelete
        '
        Me.cmdDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(50, 22)
        Me.cmdDelete.Text = "Remove"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(52, 22)
        Me.toolStripButton2.Text = "To Front"
        '
        'toolStripButton3
        '
        Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(48, 22)
        Me.toolStripButton3.Text = "To Back"
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuLoad, Me.mnuSave, Me.toolStripSeparator1, Me.cmdRectangle, Me.cmdEllipse, Me.cmdTriangle})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(566, 25)
        Me.toolStrip1.TabIndex = 4
        Me.toolStrip1.Text = "toolStrip1"
        '
        'mnuNew
        '
        Me.mnuNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(23, 22)
        Me.mnuNew.Text = "&New"
        '
        'mnuLoad
        '
        Me.mnuLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuLoad.Image = CType(resources.GetObject("mnuLoad.Image"), System.Drawing.Image)
        Me.mnuLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuLoad.Name = "mnuLoad"
        Me.mnuLoad.Size = New System.Drawing.Size(23, 22)
        Me.mnuLoad.Text = "&Open"
        '
        'mnuSave
        '
        Me.mnuSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(23, 22)
        Me.mnuSave.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdRectangle
        '
        Me.cmdRectangle.Image = CType(resources.GetObject("cmdRectangle.Image"), System.Drawing.Image)
        Me.cmdRectangle.ImageTransparentColor = System.Drawing.Color.White
        Me.cmdRectangle.Name = "cmdRectangle"
        Me.cmdRectangle.Size = New System.Drawing.Size(75, 22)
        Me.cmdRectangle.Text = "Rectangle"
        '
        'cmdEllipse
        '
        Me.cmdEllipse.Image = CType(resources.GetObject("cmdEllipse.Image"), System.Drawing.Image)
        Me.cmdEllipse.ImageTransparentColor = System.Drawing.Color.White
        Me.cmdEllipse.Name = "cmdEllipse"
        Me.cmdEllipse.Size = New System.Drawing.Size(56, 22)
        Me.cmdEllipse.Text = "Ellipse"
        '
        'cmdTriangle
        '
        Me.cmdTriangle.Image = CType(resources.GetObject("cmdTriangle.Image"), System.Drawing.Image)
        Me.cmdTriangle.ImageTransparentColor = System.Drawing.Color.White
        Me.cmdTriangle.Name = "cmdTriangle"
        Me.cmdTriangle.Size = New System.Drawing.Size(65, 22)
        Me.cmdTriangle.Text = "Triangle"
        '
        'DrawingSurface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 417)
        Me.Controls.Add(Me.toolStrip2)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "DrawingSurface"
        Me.Text = "Drawing Surface"
        Me.mnuForm.ResumeLayout(False)
        Me.mnuShape.ResumeLayout(False)
        Me.toolStrip2.ResumeLayout(False)
        Me.toolStrip2.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Private WithEvents mnuForm As System.Windows.Forms.ContextMenuStrip
    Private WithEvents mnuRectangle As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuEllipse As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuTriangle As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents newDrawingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents saveDrawingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents loadDrawingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuShape As System.Windows.Forms.ContextMenuStrip
    Private WithEvents mnuColorChange As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuRemoveShape As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuToFront As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents mnuToBack As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStrip2 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents cmdDelete As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
    Private WithEvents saveFileDialog As System.Windows.Forms.SaveFileDialog
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents mnuNew As System.Windows.Forms.ToolStripButton
    Private WithEvents mnuLoad As System.Windows.Forms.ToolStripButton
    Private WithEvents mnuSave As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cmdRectangle As System.Windows.Forms.ToolStripButton
    Private WithEvents cmdEllipse As System.Windows.Forms.ToolStripButton
    Private WithEvents cmdTriangle As System.Windows.Forms.ToolStripButton

End Class
