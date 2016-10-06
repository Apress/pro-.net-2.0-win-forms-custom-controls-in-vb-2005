<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerDrawTreeView
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
        Me.treeView1 = New System.Windows.Forms.TreeView
        Me.SuspendLayout()
        '
        'cmdGetSelected
        '
        Me.cmdGetSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGetSelected.Location = New System.Drawing.Point(153, 270)
        Me.cmdGetSelected.Name = "cmdGetSelected"
        Me.cmdGetSelected.Size = New System.Drawing.Size(140, 23)
        Me.cmdGetSelected.TabIndex = 3
        Me.cmdGetSelected.Text = "Get Selected Nodes"
        Me.cmdGetSelected.UseVisualStyleBackColor = True
        '
        'treeView1
        '
        Me.treeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeView1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText
        Me.treeView1.Location = New System.Drawing.Point(16, 13)
        Me.treeView1.Name = "treeView1"
        Me.treeView1.Scrollable = False
        Me.treeView1.Size = New System.Drawing.Size(277, 251)
        Me.treeView1.TabIndex = 2
        '
        'OwnerDrawTreeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 306)
        Me.Controls.Add(Me.cmdGetSelected)
        Me.Controls.Add(Me.treeView1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "OwnerDrawTreeView"
        Me.Text = "OwnerDrawTreeView"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cmdGetSelected As System.Windows.Forms.Button
    Private WithEvents treeView1 As System.Windows.Forms.TreeView
End Class
