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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label1 = New System.Windows.Forms.Label
        Me.directoryTree1 = New DirectoryTreeControl.DirectoryTree
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.Location = New System.Drawing.Point(282, 274)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(334, 68)
        Me.label1.TabIndex = 8
        Me.label1.Text = resources.GetString("label1.Text")
        '
        'directoryTree1
        '
        Me.directoryTree1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.directoryTree1.Drive = Global.Microsoft.VisualBasic.ChrW(67)
        Me.directoryTree1.Location = New System.Drawing.Point(282, 19)
        Me.directoryTree1.Name = "directoryTree1"
        Me.directoryTree1.Size = New System.Drawing.Size(331, 250)
        Me.directoryTree1.TabIndex = 7
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.propertyGrid1.Location = New System.Drawing.Point(9, 15)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.SelectedObject = Me.directoryTree1
        Me.propertyGrid1.Size = New System.Drawing.Size(260, 329)
        Me.propertyGrid1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 359)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.directoryTree1)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents directoryTree1 As DirectoryTreeControl.DirectoryTree
    Private WithEvents propertyGrid1 As System.Windows.Forms.PropertyGrid

End Class
