Imports Microsoft.VisualBasic
Imports System
Namespace MdiSynchronized
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parent))
			Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
			Me.newToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.openToolStripButton = New System.Windows.Forms.ToolStripButton()
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.windowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.tileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.tileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.cascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.minimizeAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStrip1.SuspendLayout()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' toolStrip1
			' 
			Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripButton, Me.openToolStripButton})
			Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
			Me.toolStrip1.Name = "toolStrip1"
			Me.toolStrip1.Size = New System.Drawing.Size(412, 25)
			Me.toolStrip1.TabIndex = 1
			Me.toolStrip1.Text = "toolStrip1"
			' 
			' newToolStripButton
			' 
			Me.newToolStripButton.Image = (CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image))
			Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.newToolStripButton.Name = "newToolStripButton"
			Me.newToolStripButton.Text = "&New"
'			Me.newToolStripButton.Click += New System.EventHandler(Me.cmdNew);
			' 
			' openToolStripButton
			' 
			Me.openToolStripButton.Image = (CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image))
			Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.openToolStripButton.Name = "openToolStripButton"
			Me.openToolStripButton.Text = "&Close"
'			Me.openToolStripButton.Click += New System.EventHandler(Me.cmdClose);
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.helpToolStripMenuItem, Me.windowToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.MdiWindowListItem = Me.windowToolStripMenuItem
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(412, 24)
			Me.menuStrip1.TabIndex = 2
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.closeToolStripMenuItem, Me.toolStripSeparator1, Me.exitToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Text = "File"
			' 
			' newToolStripMenuItem
			' 
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Text = "New"
'			Me.newToolStripMenuItem.Click += New System.EventHandler(Me.cmdNew);
			' 
			' closeToolStripMenuItem
			' 
			Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
			Me.closeToolStripMenuItem.Text = "Close"
'			Me.closeToolStripMenuItem.Click += New System.EventHandler(Me.cmdClose);
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Text = "Exit"
'			Me.exitToolStripMenuItem.Click += New System.EventHandler(Me.exitToolStripMenuItem_Click);
			' 
			' helpToolStripMenuItem
			' 
			Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.aboutToolStripMenuItem})
			Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
			Me.helpToolStripMenuItem.Text = "Help"
			' 
			' aboutToolStripMenuItem
			' 
			Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
			Me.aboutToolStripMenuItem.Text = "About"
			' 
			' windowToolStripMenuItem
			' 
			Me.windowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.tileHorizontalToolStripMenuItem, Me.tileVerticalToolStripMenuItem, Me.cascadeToolStripMenuItem, Me.minimizeAllToolStripMenuItem, Me.toolStripSeparator2})
			Me.windowToolStripMenuItem.Name = "windowToolStripMenuItem"
			Me.windowToolStripMenuItem.Text = "Window"
'			Me.windowToolStripMenuItem.DropDownClosed += New System.EventHandler(Me.windowToolStripMenuItem_DropDownClosed);
'			Me.windowToolStripMenuItem.DropDownOpening += New System.EventHandler(Me.windowToolStripMenuItem_DropDownOpening);
			' 
			' tileHorizontalToolStripMenuItem
			' 
			Me.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem"
			Me.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal"
'			Me.tileHorizontalToolStripMenuItem.Click += New System.EventHandler(Me.mnuTileH_Click);
			' 
			' tileVerticalToolStripMenuItem
			' 
			Me.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem"
			Me.tileVerticalToolStripMenuItem.Text = "Tile Vertical"
'			Me.tileVerticalToolStripMenuItem.Click += New System.EventHandler(Me.mnuTileV_Click);
			' 
			' cascadeToolStripMenuItem
			' 
			Me.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem"
			Me.cascadeToolStripMenuItem.Text = "Cascade"
'			Me.cascadeToolStripMenuItem.Click += New System.EventHandler(Me.mnuCascade_Click);
			' 
			' minimizeAllToolStripMenuItem
			' 
			Me.minimizeAllToolStripMenuItem.Name = "minimizeAllToolStripMenuItem"
			Me.minimizeAllToolStripMenuItem.Text = "Minimize All"
'			Me.minimizeAllToolStripMenuItem.Click += New System.EventHandler(Me.mnuMinimizeAll_Click);
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			' 
			' Parent
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(412, 339)
			Me.Controls.Add(Me.toolStrip1)
			Me.Controls.Add(Me.menuStrip1)
			Me.IsMdiContainer = True
			Me.MainMenuStrip = Me.menuStrip1
			Me.Name = "Parent"
			Me.Text = "Parent"
			Me.toolStrip1.ResumeLayout(False)
			Me.menuStrip1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private WithEvents newToolStripButton As System.Windows.Forms.ToolStripButton
		Private WithEvents openToolStripButton As System.Windows.Forms.ToolStripButton
		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents closeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents windowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents tileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents tileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents cascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents minimizeAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	End Class
End Namespace

