<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowserRestricted
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
        Me.panel1 = New System.Windows.Forms.Panel
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip
        Me.progressBar = New System.Windows.Forms.ToolStripProgressBar
        Me.statusBar = New System.Windows.Forms.ToolStripStatusLabel
        Me.panel1.SuspendLayout()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.webBrowser1)
        Me.panel1.Location = New System.Drawing.Point(12, 6)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(401, 323)
        Me.panel1.TabIndex = 4
        '
        'webBrowser1
        '
        Me.webBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webBrowser1.Location = New System.Drawing.Point(0, 5)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(399, 321)
        Me.webBrowser1.TabIndex = 0
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progressBar, Me.statusBar})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 360)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(427, 22)
        Me.statusStrip1.TabIndex = 3
        Me.statusStrip1.Text = "statusStrip1"
        '
        'progressBar
        '
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(100, 16)
        '
        'statusBar
        '
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(310, 17)
        Me.statusBar.Spring = True
        Me.statusBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WebBrowserRestricted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 382)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "WebBrowserRestricted"
        Me.Text = "WebBrowserRestricted"
        Me.panel1.ResumeLayout(False)
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents progressBar As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents statusBar As System.Windows.Forms.ToolStripStatusLabel
End Class
