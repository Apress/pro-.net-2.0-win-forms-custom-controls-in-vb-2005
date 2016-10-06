<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerDrawTreeViewControl
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
        Me.cmdGetSelected = New System.Windows.Forms.Button
        Me.TreeView1 = New OwnerDrawListControls.MultiSelectTreeView
        Me.SuspendLayout()
        '
        'cmdGetSelected
        '
        Me.cmdGetSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGetSelected.Location = New System.Drawing.Point(156, 265)
        Me.cmdGetSelected.Name = "cmdGetSelected"
        Me.cmdGetSelected.Size = New System.Drawing.Size(140, 23)
        Me.cmdGetSelected.TabIndex = 5
        Me.cmdGetSelected.Text = "Get Selected Nodes"
        Me.cmdGetSelected.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(284, 247)
        Me.TreeView1.TabIndex = 6
        '
        'OwnerDrawTreeViewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 296)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.cmdGetSelected)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "OwnerDrawTreeViewControl"
        Me.Text = "OwnerDrawTreeViewControl"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdGetSelected As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As OwnerDrawListControls.MultiSelectTreeView
End Class
