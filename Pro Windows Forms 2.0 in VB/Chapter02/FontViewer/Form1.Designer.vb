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
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.lstFonts = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.statusBar = New System.Windows.Forms.StatusStrip
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.groupBox1.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.lstFonts)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(7, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(497, 40)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        '
        'lstFonts
        '
        Me.lstFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lstFonts.DropDownWidth = 340
        Me.lstFonts.FormattingEnabled = True
        Me.lstFonts.Location = New System.Drawing.Point(100, 12)
        Me.lstFonts.Name = "lstFonts"
        Me.lstFonts.Size = New System.Drawing.Size(340, 21)
        Me.lstFonts.TabIndex = 1
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(80, 12)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Choose Font:"
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.statusBar.Location = New System.Drawing.Point(0, 167)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(521, 22)
        Me.statusBar.TabIndex = 4
        Me.statusBar.Text = "statusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 189)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.statusBar)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "FontViewer"
        Me.groupBox1.ResumeLayout(False)
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents lstFonts As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents statusBar As System.Windows.Forms.StatusStrip
    Private WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel

End Class
