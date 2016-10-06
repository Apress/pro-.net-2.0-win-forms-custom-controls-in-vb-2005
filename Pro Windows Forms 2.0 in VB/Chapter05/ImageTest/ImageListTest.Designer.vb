<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageListTest
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
        Me.iconImages = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdPaintImages = New System.Windows.Forms.Button
        Me.cmdFillImageList = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'iconImages
        '
        Me.iconImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.iconImages.ImageSize = New System.Drawing.Size(16, 16)
        Me.iconImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'cmdPaintImages
        '
        Me.cmdPaintImages.Location = New System.Drawing.Point(151, 213)
        Me.cmdPaintImages.Name = "cmdPaintImages"
        Me.cmdPaintImages.Size = New System.Drawing.Size(112, 23)
        Me.cmdPaintImages.TabIndex = 3
        Me.cmdPaintImages.Text = "Paint Images"
        Me.cmdPaintImages.UseVisualStyleBackColor = True
        '
        'cmdFillImageList
        '
        Me.cmdFillImageList.Location = New System.Drawing.Point(27, 213)
        Me.cmdFillImageList.Name = "cmdFillImageList"
        Me.cmdFillImageList.Size = New System.Drawing.Size(118, 23)
        Me.cmdFillImageList.TabIndex = 2
        Me.cmdFillImageList.Text = "Fill Image List"
        Me.cmdFillImageList.UseVisualStyleBackColor = True
        '
        'ImageListTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.cmdPaintImages)
        Me.Controls.Add(Me.cmdFillImageList)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ImageListTest"
        Me.Text = "ImageListTest"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents iconImages As System.Windows.Forms.ImageList
    Private WithEvents cmdPaintImages As System.Windows.Forms.Button
    Private WithEvents cmdFillImageList As System.Windows.Forms.Button
End Class
