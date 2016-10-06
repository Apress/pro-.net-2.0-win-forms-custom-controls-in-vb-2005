Imports Microsoft.VisualBasic
Imports System
Namespace MdiMenuMerge
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
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.noMergeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.mergeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.documentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.parentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.mergedSubMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.quitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem, Me.documentToolStripMenuItem, Me.mergedSubMenuToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(292, 24)
			Me.menuStrip1.TabIndex = 1
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.noMergeToolStripMenuItem, Me.mergeToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Text = "File"
			' 
			' noMergeToolStripMenuItem
			' 
			Me.noMergeToolStripMenuItem.Name = "noMergeToolStripMenuItem"
			Me.noMergeToolStripMenuItem.Text = "Show Without Merging"
'			Me.noMergeToolStripMenuItem.Click += New System.EventHandler(Me.noMergeToolStripMenuItem_Click);
			' 
			' mergeToolStripMenuItem
			' 
			Me.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem"
			Me.mergeToolStripMenuItem.Text = "Show With Merging"
'			Me.mergeToolStripMenuItem.Click += New System.EventHandler(Me.mergeToolStripMenuItem_Click);
			' 
			' documentToolStripMenuItem
			' 
			Me.documentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.parentToolStripMenuItem})
			Me.documentToolStripMenuItem.Name = "documentToolStripMenuItem"
			Me.documentToolStripMenuItem.Text = "Document"
			' 
			' parentToolStripMenuItem
			' 
			Me.parentToolStripMenuItem.Name = "parentToolStripMenuItem"
			Me.parentToolStripMenuItem.Text = "Parent"
			' 
			' mergedSubMenuToolStripMenuItem
			' 
			Me.mergedSubMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.saveToolStripMenuItem, Me.toolStripSeparator1, Me.quitToolStripMenuItem})
			Me.mergedSubMenuToolStripMenuItem.Name = "mergedSubMenuToolStripMenuItem"
			Me.mergedSubMenuToolStripMenuItem.Text = "Merged SubMenu"
			' 
			' newToolStripMenuItem
			' 
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Text = "New"
			' 
			' openToolStripMenuItem
			' 
			Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
			Me.openToolStripMenuItem.Text = "Open"
			' 
			' saveToolStripMenuItem
			' 
			Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
			Me.saveToolStripMenuItem.Text = "Save"
			' 
			' quitToolStripMenuItem
			' 
			Me.quitToolStripMenuItem.Name = "quitToolStripMenuItem"
			Me.quitToolStripMenuItem.Text = "Quit"
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			' 
			' Parent
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 266)
			Me.Controls.Add(Me.menuStrip1)
			Me.IsMdiContainer = True
			Me.MainMenuStrip = Me.menuStrip1
			Me.Name = "Parent"
			Me.Text = "Parent"
			Me.menuStrip1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents noMergeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents mergeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private documentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private parentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private mergedSubMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private quitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
	End Class
End Namespace

