<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CollapseTest
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
        Me.CollapsiblePanel1 = New CollabsiblePanelControl.CollapsiblePanel
        Me.CollapsiblePanel2 = New CollabsiblePanelControl.CollapsiblePanel
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label1 = New System.Windows.Forms.Label
        Me.CollapsiblePanel1.SuspendLayout()
        Me.CollapsiblePanel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CollapsiblePanel1
        '
        Me.CollapsiblePanel1.Collapsed = False
        Me.CollapsiblePanel1.Controls.Add(Me.button2)
        Me.CollapsiblePanel1.Controls.Add(Me.button1)
        Me.CollapsiblePanel1.Location = New System.Drawing.Point(29, 42)
        Me.CollapsiblePanel1.Name = "CollapsiblePanel1"
        Me.CollapsiblePanel1.Size = New System.Drawing.Size(200, 100)
        Me.CollapsiblePanel1.TabIndex = 0
        Me.CollapsiblePanel1.Text = "CollapsiblePanel1"
        '
        'CollapsiblePanel2
        '
        Me.CollapsiblePanel2.Collapsed = False
        Me.CollapsiblePanel2.Controls.Add(Me.panel1)
        Me.CollapsiblePanel2.Location = New System.Drawing.Point(254, 42)
        Me.CollapsiblePanel2.Name = "CollapsiblePanel2"
        Me.CollapsiblePanel2.Size = New System.Drawing.Size(200, 100)
        Me.CollapsiblePanel2.TabIndex = 1
        Me.CollapsiblePanel2.Text = "CollapsiblePanel2"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(21, 61)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 24)
        Me.button2.TabIndex = 4
        Me.button2.Text = "button2"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(21, 31)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 24)
        Me.button1.TabIndex = 3
        Me.button1.Text = "button1"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(20, 31)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(161, 52)
        Me.panel1.TabIndex = 2
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(21, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(68, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Sample text."
        '
        'CollapseTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 237)
        Me.Controls.Add(Me.CollapsiblePanel1)
        Me.Controls.Add(Me.CollapsiblePanel2)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "CollapseTest"
        Me.Text = "CollapseTest"
        Me.CollapsiblePanel1.ResumeLayout(False)
        Me.CollapsiblePanel2.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CollapsiblePanel1 As CollabsiblePanelControl.CollapsiblePanel
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents CollapsiblePanel2 As CollabsiblePanelControl.CollapsiblePanel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
