<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollabsibleLayout
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.CollapsiblePanel1 = New CollabsiblePanelControl.CollapsiblePanel
        Me.CollapsiblePanel2 = New CollabsiblePanelControl.CollapsiblePanel
        Me.CollapsiblePanel3 = New CollabsiblePanelControl.CollapsiblePanel
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.CollapsiblePanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.CollapsiblePanel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.CollapsiblePanel3)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(243, 357)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'CollapsiblePanel1
        '
        Me.CollapsiblePanel1.Collapsed = False
        Me.CollapsiblePanel1.Location = New System.Drawing.Point(13, 119)
        Me.CollapsiblePanel1.Name = "CollapsiblePanel1"
        Me.CollapsiblePanel1.Size = New System.Drawing.Size(200, 100)
        Me.CollapsiblePanel1.TabIndex = 0
        Me.CollapsiblePanel1.Text = "CollapsiblePanel1"
        '
        'CollapsiblePanel2
        '
        Me.CollapsiblePanel2.Collapsed = False
        Me.CollapsiblePanel2.Location = New System.Drawing.Point(13, 13)
        Me.CollapsiblePanel2.Name = "CollapsiblePanel2"
        Me.CollapsiblePanel2.Size = New System.Drawing.Size(200, 100)
        Me.CollapsiblePanel2.TabIndex = 1
        Me.CollapsiblePanel2.Text = "CollapsiblePanel2"
        '
        'CollapsiblePanel3
        '
        Me.CollapsiblePanel3.Collapsed = False
        Me.CollapsiblePanel3.Location = New System.Drawing.Point(13, 225)
        Me.CollapsiblePanel3.Name = "CollapsiblePanel3"
        Me.CollapsiblePanel3.Size = New System.Drawing.Size(200, 100)
        Me.CollapsiblePanel3.TabIndex = 1
        Me.CollapsiblePanel3.Text = "CollapsiblePanel3"
        '
        'CollabsibleLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(243, 357)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "CollabsibleLayout"
        Me.Text = "CollabsibleLayout"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CollapsiblePanel2 As CollabsiblePanelControl.CollapsiblePanel
    Friend WithEvents CollapsiblePanel1 As CollabsiblePanelControl.CollapsiblePanel
    Friend WithEvents CollapsiblePanel3 As CollabsiblePanelControl.CollapsiblePanel
End Class
