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
        Me.cmdAddImage = New System.Windows.Forms.Button
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdBold = New System.Windows.Forms.ToolStripButton
        Me.cmdItalic = New System.Windows.Forms.ToolStripButton
        Me.cmdUnderline = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.lstColors = New System.Windows.Forms.ToolStripDropDownButton
        Me.lstFonts = New System.Windows.Forms.ToolStripDropDownButton
        Me.lstFontSize = New System.Windows.Forms.ToolStripDropDownButton
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.lstZoom = New System.Windows.Forms.ToolStripDropDownButton
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAddImage
        '
        Me.cmdAddImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmdAddImage.Location = New System.Drawing.Point(12, 257)
        Me.cmdAddImage.Name = "cmdAddImage"
        Me.cmdAddImage.Size = New System.Drawing.Size(154, 23)
        Me.cmdAddImage.TabIndex = 5
        Me.cmdAddImage.Text = "Insert Image"
        Me.cmdAddImage.UseVisualStyleBackColor = True
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdBold, Me.cmdItalic, Me.cmdUnderline, Me.toolStripSeparator1, Me.lstColors, Me.lstFonts, Me.lstFontSize, Me.toolStripSeparator2, Me.lstZoom})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(384, 25)
        Me.toolStrip1.TabIndex = 4
        Me.toolStrip1.Text = "toolStrip1"
        '
        'cmdBold
        '
        Me.cmdBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdBold.Image = CType(resources.GetObject("cmdBold.Image"), System.Drawing.Image)
        Me.cmdBold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBold.Name = "cmdBold"
        Me.cmdBold.Size = New System.Drawing.Size(31, 22)
        Me.cmdBold.Text = "Bold"
        '
        'cmdItalic
        '
        Me.cmdItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdItalic.Image = CType(resources.GetObject("cmdItalic.Image"), System.Drawing.Image)
        Me.cmdItalic.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdItalic.Name = "cmdItalic"
        Me.cmdItalic.Size = New System.Drawing.Size(34, 22)
        Me.cmdItalic.Text = "Italic"
        '
        'cmdUnderline
        '
        Me.cmdUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdUnderline.Image = CType(resources.GetObject("cmdUnderline.Image"), System.Drawing.Image)
        Me.cmdUnderline.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUnderline.Name = "cmdUnderline"
        Me.cmdUnderline.Size = New System.Drawing.Size(56, 22)
        Me.cmdUnderline.Text = "Underline"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lstColors
        '
        Me.lstColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lstColors.Image = CType(resources.GetObject("lstColors.Image"), System.Drawing.Image)
        Me.lstColors.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lstColors.Name = "lstColors"
        Me.lstColors.Size = New System.Drawing.Size(45, 22)
        Me.lstColors.Text = "Color"
        '
        'lstFonts
        '
        Me.lstFonts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lstFonts.Image = CType(resources.GetObject("lstFonts.Image"), System.Drawing.Image)
        Me.lstFonts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lstFonts.Name = "lstFonts"
        Me.lstFonts.Size = New System.Drawing.Size(42, 22)
        Me.lstFonts.Text = "Font"
        '
        'lstFontSize
        '
        Me.lstFontSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lstFontSize.Image = CType(resources.GetObject("lstFontSize.Image"), System.Drawing.Image)
        Me.lstFontSize.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lstFontSize.Name = "lstFontSize"
        Me.lstFontSize.Size = New System.Drawing.Size(39, 22)
        Me.lstFontSize.Text = "Size"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'lstZoom
        '
        Me.lstZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lstZoom.Image = CType(resources.GetObject("lstZoom.Image"), System.Drawing.Image)
        Me.lstZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.lstZoom.Name = "lstZoom"
        Me.lstZoom.Size = New System.Drawing.Size(46, 22)
        Me.lstZoom.Text = "Zoom"
        '
        'richTextBox1
        '
        Me.richTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.richTextBox1.BulletIndent = 5
        Me.richTextBox1.Location = New System.Drawing.Point(14, 30)
        Me.richTextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(356, 221)
        Me.richTextBox1.TabIndex = 3
        Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 289)
        Me.Controls.Add(Me.cmdAddImage)
        Me.Controls.Add(Me.toolStrip1)
        Me.Controls.Add(Me.richTextBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "RichTextBox Test"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cmdAddImage As System.Windows.Forms.Button
    Private WithEvents toolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents cmdBold As System.Windows.Forms.ToolStripButton
    Private WithEvents cmdItalic As System.Windows.Forms.ToolStripButton
    Private WithEvents cmdUnderline As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lstColors As System.Windows.Forms.ToolStripDropDownButton
    Private WithEvents lstFonts As System.Windows.Forms.ToolStripDropDownButton
    Private WithEvents lstFontSize As System.Windows.Forms.ToolStripDropDownButton
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents lstZoom As System.Windows.Forms.ToolStripDropDownButton
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox

End Class
