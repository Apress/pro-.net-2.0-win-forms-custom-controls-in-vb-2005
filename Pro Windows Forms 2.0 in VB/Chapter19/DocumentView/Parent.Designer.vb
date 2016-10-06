Imports Microsoft.VisualBasic
Imports System
Namespace DocumentView
	Public Partial Class Parent
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parent))
            Me.imgButtons = New System.Windows.Forms.ImageList(Me.components)
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
            Me.toolStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'imgButtons
            '
            Me.imgButtons.ImageStream = CType(resources.GetObject("imgButtons.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgButtons.TransparentColor = System.Drawing.Color.Transparent
            Me.imgButtons.Images.SetKeyName(0, "")
            Me.imgButtons.Images.SetKeyName(1, "")
            Me.imgButtons.Images.SetKeyName(2, "")
            Me.imgButtons.Images.SetKeyName(3, "")
            Me.imgButtons.Images.SetKeyName(4, "")
            '
            'toolStrip1
            '
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4, Me.toolStripSeparator1, Me.toolStripButton5})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.Size = New System.Drawing.Size(521, 36)
            Me.toolStrip1.TabIndex = 1
            Me.toolStrip1.Text = "toolStrip1"
            '
            'toolStripButton1
            '
            Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Size = New System.Drawing.Size(32, 33)
            Me.toolStripButton1.Text = "New"
            Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton2
            '
            Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Size = New System.Drawing.Size(37, 33)
            Me.toolStripButton2.Text = "Open"
            Me.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton3
            '
            Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(37, 33)
            Me.toolStripButton3.Text = "Close"
            Me.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton4
            '
            Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(35, 33)
            Me.toolStripButton4.Text = "Save"
            Me.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 36)
            '
            'toolStripButton5
            '
            Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(49, 33)
            Me.toolStripButton5.Text = "Preview"
            Me.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'Parent
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(521, 408)
            Me.Controls.Add(Me.toolStrip1)
            Me.IsMdiContainer = True
            Me.Name = "Parent"
            Me.Text = "Parent"
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private imgButtons As System.Windows.Forms.ImageList
		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

