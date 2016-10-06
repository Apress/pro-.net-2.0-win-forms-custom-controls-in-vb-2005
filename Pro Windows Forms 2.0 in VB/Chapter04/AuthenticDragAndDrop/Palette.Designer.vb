<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Palette
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Palette))
        Me.images = New System.Windows.Forms.ImageList(Me.components)
        Me.lblPictureTwo = New System.Windows.Forms.Label
        Me.lblPictureOne = New System.Windows.Forms.Label
        Me.lblPictureThree = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'images
        '
        Me.images.ImageStream = CType(resources.GetObject("images.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.images.TransparentColor = System.Drawing.Color.Transparent
        Me.images.Images.SetKeyName(0, "")
        Me.images.Images.SetKeyName(1, "")
        Me.images.Images.SetKeyName(2, "")
        '
        'lblPictureTwo
        '
        Me.lblPictureTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPictureTwo.ImageIndex = 1
        Me.lblPictureTwo.ImageList = Me.images
        Me.lblPictureTwo.Location = New System.Drawing.Point(12, 61)
        Me.lblPictureTwo.Name = "lblPictureTwo"
        Me.lblPictureTwo.Size = New System.Drawing.Size(56, 48)
        Me.lblPictureTwo.TabIndex = 8
        '
        'lblPictureOne
        '
        Me.lblPictureOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPictureOne.ImageIndex = 0
        Me.lblPictureOne.ImageList = Me.images
        Me.lblPictureOne.Location = New System.Drawing.Point(12, 9)
        Me.lblPictureOne.Name = "lblPictureOne"
        Me.lblPictureOne.Size = New System.Drawing.Size(56, 48)
        Me.lblPictureOne.TabIndex = 7
        '
        'lblPictureThree
        '
        Me.lblPictureThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPictureThree.ImageIndex = 2
        Me.lblPictureThree.ImageList = Me.images
        Me.lblPictureThree.Location = New System.Drawing.Point(12, 113)
        Me.lblPictureThree.Name = "lblPictureThree"
        Me.lblPictureThree.Size = New System.Drawing.Size(56, 48)
        Me.lblPictureThree.TabIndex = 9
        '
        'Palette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(82, 175)
        Me.Controls.Add(Me.lblPictureTwo)
        Me.Controls.Add(Me.lblPictureOne)
        Me.Controls.Add(Me.lblPictureThree)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Palette"
        Me.Text = "Palette"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents images As System.Windows.Forms.ImageList
    Private WithEvents lblPictureTwo As System.Windows.Forms.Label
    Private WithEvents lblPictureOne As System.Windows.Forms.Label
    Private WithEvents lblPictureThree As System.Windows.Forms.Label
End Class
