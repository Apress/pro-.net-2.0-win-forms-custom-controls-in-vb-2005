Imports Microsoft.VisualBasic
Imports System
Namespace DocumentView
	Public Partial Class Child
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Child))
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.windowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.imgButtons = New System.Windows.Forms.ImageList(Me.components)
			Me.toolStrip1.SuspendLayout()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4, Me.toolStripSeparator1, Me.toolStripButton5})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(473, 36)
			Me.toolStrip1.TabIndex = 3
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(32, 33)
			Me.toolStripButton1.Text = "New"
			Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton1.Click += New System.EventHandler(Me.toolStripButton1_Click);
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(37, 33)
			Me.toolStripButton2.Text = "Open"
			Me.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton2.Click += New System.EventHandler(Me.toolStripButton2_Click);
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(37, 33)
			Me.toolStripButton3.Text = "Close"
			Me.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton3.Click += New System.EventHandler(Me.toolStripButton3_Click);
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New System.Drawing.Size(35, 33)
			Me.toolStripButton4.Text = "Save"
			Me.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton4.Click += New System.EventHandler(Me.toolStripButton4_Click);
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 36)
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.Image = (CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image))
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(49, 33)
			Me.toolStripButton5.Text = "Preview"
			Me.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
'			Me.toolStripButton5.Click += New System.EventHandler(Me.toolStripButton5_Click);
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.windowToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 36)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(473, 24)
			Me.menuStrip1.TabIndex = 5
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' windowToolStripMenuItem
			' 
			Me.windowToolStripMenuItem.Name = "windowToolStripMenuItem"
			Me.windowToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
			Me.windowToolStripMenuItem.Text = "Window"
'			Me.windowToolStripMenuItem.DropDownItemClicked += New System.Windows.Forms.ToolStripItemClickedEventHandler(Me.windowToolStripMenuItem_DropDownItemClicked);
			' 
			' imgButtons
			' 
			Me.imgButtons.ImageStream = (CType(resources.GetObject("imgButtons.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imgButtons.TransparentColor = System.Drawing.Color.Transparent
			Me.imgButtons.Images.SetKeyName(0, "")
			Me.imgButtons.Images.SetKeyName(1, "")
			Me.imgButtons.Images.SetKeyName(2, "")
			Me.imgButtons.Images.SetKeyName(3, "")
			Me.imgButtons.Images.SetKeyName(4, "")
			' 
			' Child
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.AliceBlue
			Me.ClientSize = New System.Drawing.Size(473, 345)
			Me.Controls.Add(Me.menuStrip1)
			Me.Controls.Add(Me.toolStrip1)
			Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Name = "Child"
			Me.Text = "Child"
			Me.toolStrip1.ResumeLayout(False)
			Me.toolStrip1.PerformLayout()
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private WithEvents windowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private imgButtons As System.Windows.Forms.ImageList
	End Class
End Namespace