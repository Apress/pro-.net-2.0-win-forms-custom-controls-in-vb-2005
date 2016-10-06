<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExploreDOM
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
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.treeDOM = New System.Windows.Forms.TreeView
        Me.cmdBuildTree = New System.Windows.Forms.Button
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitContainer1.Location = New System.Drawing.Point(9, 11)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.webBrowser1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.treeDOM)
        Me.splitContainer1.Size = New System.Drawing.Size(600, 362)
        Me.splitContainer1.SplitterDistance = 200
        Me.splitContainer1.TabIndex = 9
        Me.splitContainer1.Text = "splitContainer1"
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(196, 358)
        Me.webBrowser1.TabIndex = 6
        '
        'treeDOM
        '
        Me.treeDOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.treeDOM.Location = New System.Drawing.Point(0, 0)
        Me.treeDOM.Name = "treeDOM"
        Me.treeDOM.Size = New System.Drawing.Size(392, 358)
        Me.treeDOM.TabIndex = 5
        '
        'cmdBuildTree
        '
        Me.cmdBuildTree.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdBuildTree.Enabled = False
        Me.cmdBuildTree.Location = New System.Drawing.Point(9, 382)
        Me.cmdBuildTree.Name = "cmdBuildTree"
        Me.cmdBuildTree.Size = New System.Drawing.Size(88, 36)
        Me.cmdBuildTree.TabIndex = 8
        Me.cmdBuildTree.Text = "Analyze Page"
        '
        'ExploreDOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 429)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.cmdBuildTree)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ExploreDOM"
        Me.Text = "ExploreDOM"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents treeDOM As System.Windows.Forms.TreeView
    Private WithEvents cmdBuildTree As System.Windows.Forms.Button
End Class
