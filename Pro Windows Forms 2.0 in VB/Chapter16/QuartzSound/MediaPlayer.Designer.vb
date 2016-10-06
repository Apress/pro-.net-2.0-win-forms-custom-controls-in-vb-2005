<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MediaPlayer
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
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdPause = New System.Windows.Forms.Button
        Me.cmdStop = New System.Windows.Forms.Button
        Me.cmdPlay = New System.Windows.Forms.Button
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer1
        '
        Me.timer1.Interval = 500
        '
        'cmdPause
        '
        Me.cmdPause.Location = New System.Drawing.Point(105, 12)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(75, 26)
        Me.cmdPause.TabIndex = 7
        Me.cmdPause.Text = "Pause"
        '
        'cmdStop
        '
        Me.cmdStop.Location = New System.Drawing.Point(186, 12)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(75, 26)
        Me.cmdStop.TabIndex = 6
        Me.cmdStop.Text = "Stop"
        '
        'cmdPlay
        '
        Me.cmdPlay.Location = New System.Drawing.Point(24, 12)
        Me.cmdPlay.Name = "cmdPlay"
        Me.cmdPlay.Size = New System.Drawing.Size(75, 26)
        Me.cmdPlay.TabIndex = 5
        Me.cmdPlay.Text = "Play"
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel1, Me.statusLabel2, Me.statusLabel3})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 97)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(344, 32)
        Me.statusStrip1.TabIndex = 4
        Me.statusStrip1.Text = "statusStrip1"
        '
        'statusLabel1
        '
        Me.statusLabel1.Name = "statusLabel1"
        Me.statusLabel1.Padding = New System.Windows.Forms.Padding(5)
        Me.statusLabel1.Size = New System.Drawing.Size(10, 27)
        '
        'statusLabel2
        '
        Me.statusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.statusLabel2.Name = "statusLabel2"
        Me.statusLabel2.Padding = New System.Windows.Forms.Padding(5)
        Me.statusLabel2.Size = New System.Drawing.Size(14, 27)
        '
        'statusLabel3
        '
        Me.statusLabel3.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.statusLabel3.Name = "statusLabel3"
        Me.statusLabel3.Padding = New System.Windows.Forms.Padding(5)
        Me.statusLabel3.Size = New System.Drawing.Size(93, 27)
        Me.statusLabel3.Text = "Using test.mp3"
        '
        'MediaPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 129)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.cmdPlay)
        Me.Controls.Add(Me.statusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MediaPlayer"
        Me.Text = "Media Player"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents timer1 As System.Windows.Forms.Timer
    Private WithEvents cmdPause As System.Windows.Forms.Button
    Private WithEvents cmdStop As System.Windows.Forms.Button
    Private WithEvents cmdPlay As System.Windows.Forms.Button
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents statusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents statusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents statusLabel3 As System.Windows.Forms.ToolStripStatusLabel

End Class
