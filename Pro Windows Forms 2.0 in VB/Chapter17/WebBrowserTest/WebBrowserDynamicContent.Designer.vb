<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowserDynamicContent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowserDynamicContent))
        Me.panel1 = New System.Windows.Forms.Panel
        Me.webBrowser = New System.Windows.Forms.WebBrowser
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.txtHtml = New System.Windows.Forms.TextBox
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.webBrowser)
        Me.panel1.Location = New System.Drawing.Point(14, 192)
        Me.panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(384, 247)
        Me.panel1.TabIndex = 10
        '
        'webBrowser
        '
        Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser.Margin = New System.Windows.Forms.Padding(3, 1, 3, 3)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.Size = New System.Drawing.Size(382, 245)
        Me.webBrowser.TabIndex = 1
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.txtHtml)
        Me.groupBox1.Location = New System.Drawing.Point(11, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(390, 164)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Enter HTML Here"
        '
        'txtHtml
        '
        Me.txtHtml.AcceptsReturn = True
        Me.txtHtml.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHtml.Location = New System.Drawing.Point(7, 20)
        Me.txtHtml.Multiline = True
        Me.txtHtml.Name = "txtHtml"
        Me.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHtml.Size = New System.Drawing.Size(377, 138)
        Me.txtHtml.TabIndex = 0
        Me.txtHtml.Text = resources.GetString("txtHtml.Text")
        '
        'WebBrowserDynamicContent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 457)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.groupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "WebBrowserDynamicContent"
        Me.Text = "WebBrowserDynamicContent"
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents webBrowser As System.Windows.Forms.WebBrowser
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtHtml As System.Windows.Forms.TextBox
End Class
