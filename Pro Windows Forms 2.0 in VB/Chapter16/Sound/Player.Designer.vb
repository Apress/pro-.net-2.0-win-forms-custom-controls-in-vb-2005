<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player
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
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.loadAsyncButton = New System.Windows.Forms.Button
        Me.playLoopAsyncButton = New System.Windows.Forms.Button
        Me.stopButton = New System.Windows.Forms.Button
        Me.playOnceAsyncButton = New System.Windows.Forms.Button
        Me.playOnceSyncButton = New System.Windows.Forms.Button
        Me.loadSyncButton = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.selectFileButton = New System.Windows.Forms.Button
        Me.filepathTextbox = New System.Windows.Forms.TextBox
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 212)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(397, 22)
        Me.statusStrip1.TabIndex = 31
        Me.statusStrip1.Text = "statusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'loadAsyncButton
        '
        Me.loadAsyncButton.Location = New System.Drawing.Point(154, 55)
        Me.loadAsyncButton.Name = "loadAsyncButton"
        Me.loadAsyncButton.Size = New System.Drawing.Size(147, 23)
        Me.loadAsyncButton.TabIndex = 30
        Me.loadAsyncButton.Text = "Load Asynchronously"
        '
        'playLoopAsyncButton
        '
        Me.playLoopAsyncButton.Location = New System.Drawing.Point(12, 111)
        Me.playLoopAsyncButton.Name = "playLoopAsyncButton"
        Me.playLoopAsyncButton.Size = New System.Drawing.Size(142, 23)
        Me.playLoopAsyncButton.TabIndex = 29
        Me.playLoopAsyncButton.Text = "Loop Asynchronously"
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(154, 111)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(147, 23)
        Me.stopButton.TabIndex = 28
        Me.stopButton.Text = "Stop"
        '
        'playOnceAsyncButton
        '
        Me.playOnceAsyncButton.Location = New System.Drawing.Point(154, 88)
        Me.playOnceAsyncButton.Name = "playOnceAsyncButton"
        Me.playOnceAsyncButton.Size = New System.Drawing.Size(147, 23)
        Me.playOnceAsyncButton.TabIndex = 27
        Me.playOnceAsyncButton.Text = "Play Once Asynchronously"
        '
        'playOnceSyncButton
        '
        Me.playOnceSyncButton.Location = New System.Drawing.Point(12, 88)
        Me.playOnceSyncButton.Name = "playOnceSyncButton"
        Me.playOnceSyncButton.Size = New System.Drawing.Size(142, 23)
        Me.playOnceSyncButton.TabIndex = 26
        Me.playOnceSyncButton.Text = "Play Once Synchronously"
        '
        'loadSyncButton
        '
        Me.loadSyncButton.Location = New System.Drawing.Point(12, 55)
        Me.loadSyncButton.Name = "loadSyncButton"
        Me.loadSyncButton.Size = New System.Drawing.Size(142, 23)
        Me.loadSyncButton.TabIndex = 25
        Me.loadSyncButton.Text = "Load Synchronously"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(145, 17)
        Me.label1.TabIndex = 24
        Me.label1.Text = ".wav path or URL:"
        '
        'selectFileButton
        '
        Me.selectFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.selectFileButton.Location = New System.Drawing.Point(279, 27)
        Me.selectFileButton.Name = "selectFileButton"
        Me.selectFileButton.Size = New System.Drawing.Size(23, 21)
        Me.selectFileButton.TabIndex = 23
        Me.selectFileButton.Text = "..."
        '
        'filepathTextbox
        '
        Me.filepathTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filepathTextbox.Location = New System.Drawing.Point(12, 27)
        Me.filepathTextbox.Name = "filepathTextbox"
        Me.filepathTextbox.Size = New System.Drawing.Size(261, 21)
        Me.filepathTextbox.TabIndex = 22
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 234)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.loadAsyncButton)
        Me.Controls.Add(Me.playLoopAsyncButton)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.playOnceAsyncButton)
        Me.Controls.Add(Me.playOnceSyncButton)
        Me.Controls.Add(Me.loadSyncButton)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.selectFileButton)
        Me.Controls.Add(Me.filepathTextbox)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Player"
        Me.Text = "Player"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents loadAsyncButton As System.Windows.Forms.Button
    Private WithEvents playLoopAsyncButton As System.Windows.Forms.Button
    Private WithEvents stopButton As System.Windows.Forms.Button
    Private WithEvents playOnceAsyncButton As System.Windows.Forms.Button
    Private WithEvents playOnceSyncButton As System.Windows.Forms.Button
    Private WithEvents loadSyncButton As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents selectFileButton As System.Windows.Forms.Button
    Private WithEvents filepathTextbox As System.Windows.Forms.TextBox

End Class
