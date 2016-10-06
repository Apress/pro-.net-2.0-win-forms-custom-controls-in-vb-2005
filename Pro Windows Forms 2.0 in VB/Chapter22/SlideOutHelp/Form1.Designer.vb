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
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.button2 = New System.Windows.Forms.Button
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.toolStrip2 = New System.Windows.Forms.ToolStrip
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.panel2 = New System.Windows.Forms.Panel
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.cmdShowHide = New System.Windows.Forms.Button
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.newToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.toolStrip2.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolStripContainer1
        '
        '
        'toolStripContainer1.ContentPanel
        '
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.splitContainer1)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(417, 333)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(417, 358)
        Me.toolStripContainer1.TabIndex = 1
        Me.toolStripContainer1.Text = "toolStripContainer1"
        '
        'toolStripContainer1.TopToolStripPanel
        '
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip1)
        '
        'splitContainer1
        '
        Me.splitContainer1.BackColor = System.Drawing.Color.Transparent
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.splitContainer1.Panel1.Controls.Add(Me.button2)
        Me.splitContainer1.Panel1.Controls.Add(Me.textBox3)
        Me.splitContainer1.Panel1.Controls.Add(Me.label3)
        Me.splitContainer1.Panel1.Controls.Add(Me.textBox2)
        Me.splitContainer1.Panel1.Controls.Add(Me.label2)
        Me.splitContainer1.Panel1.Controls.Add(Me.textBox1)
        Me.splitContainer1.Panel1.Controls.Add(Me.label1)
        Me.splitContainer1.Panel1.Controls.Add(Me.toolStrip2)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.splitContainer1.Panel2.Controls.Add(Me.panel2)
        Me.splitContainer1.Panel2.Controls.Add(Me.cmdShowHide)
        Me.splitContainer1.Size = New System.Drawing.Size(417, 333)
        Me.splitContainer1.SplitterDistance = 216
        Me.splitContainer1.TabIndex = 1
        Me.splitContainer1.Text = "splitContainer1"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(87, 148)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 8
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = True
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(87, 106)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(100, 21)
        Me.textBox3.TabIndex = 5
        Me.textBox3.Tag = "Welcome.htm"
        Me.textBox3.Text = "Welcome.htm"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(25, 109)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(60, 13)
        Me.label3.TabIndex = 4
        Me.label3.Text = "Help Topic:"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(87, 78)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 21)
        Me.textBox2.TabIndex = 3
        Me.textBox2.Tag = "ValueOfHelp.htm"
        Me.textBox2.Text = "ValueOfHelp.htm"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(25, 81)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Help Topic:"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(87, 48)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 21)
        Me.textBox1.TabIndex = 1
        Me.textBox1.Tag = "BadHelp.htm"
        Me.textBox1.Text = "BadHelp.htm"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(25, 51)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(60, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Help Topic:"
        '
        'toolStrip2
        '
        Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1})
        Me.toolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip2.Name = "toolStrip2"
        Me.toolStrip2.Size = New System.Drawing.Size(216, 25)
        Me.toolStrip2.TabIndex = 7
        Me.toolStrip2.Text = "toolStrip2"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(61, 22)
        Me.toolStripButton1.Text = "Show Help"
        '
        'panel2
        '
        Me.panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.webBrowser1)
        Me.panel2.Location = New System.Drawing.Point(5, 4)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(189, 300)
        Me.panel2.TabIndex = 0
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(187, 298)
        Me.webBrowser1.TabIndex = 0
        '
        'cmdShowHide
        '
        Me.cmdShowHide.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdShowHide.BackColor = System.Drawing.Color.White
        Me.cmdShowHide.Location = New System.Drawing.Point(5, 306)
        Me.cmdShowHide.Name = "cmdShowHide"
        Me.cmdShowHide.Size = New System.Drawing.Size(189, 23)
        Me.cmdShowHide.TabIndex = 1
        Me.cmdShowHide.Text = "Hide >"
        Me.cmdShowHide.UseVisualStyleBackColor = True
        '
        'toolStrip1
        '
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.helpToolStripButton})
        Me.toolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(208, 25)
        Me.toolStrip1.TabIndex = 0
        Me.toolStrip1.Text = "toolStrip1"
        '
        'newToolStripButton
        '
        Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
        Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newToolStripButton.Name = "newToolStripButton"
        Me.newToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.newToolStripButton.Text = "&New"
        '
        'openToolStripButton
        '
        Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
        Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.openToolStripButton.Name = "openToolStripButton"
        Me.openToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.openToolStripButton.Text = "&Open"
        '
        'saveToolStripButton
        '
        Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
        Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.saveToolStripButton.Name = "saveToolStripButton"
        Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.saveToolStripButton.Text = "&Save"
        '
        'printToolStripButton
        '
        Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
        Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.printToolStripButton.Name = "printToolStripButton"
        Me.printToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.printToolStripButton.Text = "&Print"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'cutToolStripButton
        '
        Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
        Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cutToolStripButton.Name = "cutToolStripButton"
        Me.cutToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.cutToolStripButton.Text = "C&ut"
        '
        'copyToolStripButton
        '
        Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
        Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.copyToolStripButton.Name = "copyToolStripButton"
        Me.copyToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.copyToolStripButton.Text = "&Copy"
        '
        'pasteToolStripButton
        '
        Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
        Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.pasteToolStripButton.Name = "pasteToolStripButton"
        Me.pasteToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.pasteToolStripButton.Text = "&Paste"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'helpToolStripButton
        '
        Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
        Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.helpToolStripButton.Name = "helpToolStripButton"
        Me.helpToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.helpToolStripButton.Text = "He&lp"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 358)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel1.PerformLayout()
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.toolStrip2.ResumeLayout(False)
        Me.toolStrip2.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents toolStrip2 As System.Windows.Forms.ToolStrip
    Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private WithEvents cmdShowHide As System.Windows.Forms.Button
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents saveToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents printToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents cutToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents copyToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents pasteToolStripButton As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents helpToolStripButton As System.Windows.Forms.ToolStripButton

End Class
