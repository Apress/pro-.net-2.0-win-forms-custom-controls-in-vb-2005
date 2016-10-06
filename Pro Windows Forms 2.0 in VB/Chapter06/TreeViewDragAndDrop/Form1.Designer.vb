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
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.treeOne = New System.Windows.Forms.TreeView
        Me.treeTwo = New System.Windows.Forms.TreeView
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.treeOne)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.treeTwo)
        Me.splitContainer1.Size = New System.Drawing.Size(418, 384)
        Me.splitContainer1.SplitterDistance = 218
        Me.splitContainer1.TabIndex = 1
        Me.splitContainer1.Text = "splitContainer1"
        '
        'treeOne
        '
        Me.treeOne.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeOne.HideSelection = False
        Me.treeOne.Location = New System.Drawing.Point(0, 0)
        Me.treeOne.Name = "treeOne"
        Me.treeOne.Size = New System.Drawing.Size(218, 384)
        Me.treeOne.TabIndex = 5
        '
        'treeTwo
        '
        Me.treeTwo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeTwo.Location = New System.Drawing.Point(0, 0)
        Me.treeTwo.Name = "treeTwo"
        Me.treeTwo.Size = New System.Drawing.Size(196, 384)
        Me.treeTwo.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 384)
        Me.Controls.Add(Me.splitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "TreeView Drag-And-Drop"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents treeOne As System.Windows.Forms.TreeView
    Private WithEvents treeTwo As System.Windows.Forms.TreeView

End Class
