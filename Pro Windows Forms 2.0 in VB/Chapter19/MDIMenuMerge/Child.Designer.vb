Imports Microsoft.VisualBasic
Imports System
Namespace MdiMenuMerge
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
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.documentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.testToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.mergedSubMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.documentsToolStripMenuItem, Me.mergedSubMenuToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(233, 24)
			Me.menuStrip1.TabIndex = 0
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' documentsToolStripMenuItem
			' 
			Me.documentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.testToolStripMenuItem})
			Me.documentsToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Replace
			Me.documentsToolStripMenuItem.MergeIndex = 0
			Me.documentsToolStripMenuItem.Name = "documentsToolStripMenuItem"
			Me.documentsToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
			Me.documentsToolStripMenuItem.Text = "Document"
			' 
			' testToolStripMenuItem
			' 
			Me.testToolStripMenuItem.Name = "testToolStripMenuItem"
			Me.testToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
			Me.testToolStripMenuItem.Text = "Child (in a Replace submenu)"
			' 
			' mergedSubMenuToolStripMenuItem
			' 
			Me.mergedSubMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.printToolStripMenuItem})
			Me.mergedSubMenuToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.MatchOnly
			Me.mergedSubMenuToolStripMenuItem.Name = "mergedSubMenuToolStripMenuItem"
			Me.mergedSubMenuToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
			Me.mergedSubMenuToolStripMenuItem.Text = "Merged SubMenu"
			' 
			' printToolStripMenuItem
			' 
			Me.printToolStripMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert
			Me.printToolStripMenuItem.MergeIndex = 3
			Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
			Me.printToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
			Me.printToolStripMenuItem.Text = "Print (Merge Index 3)"
			' 
			' Child
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(233, 104)
			Me.Controls.Add(Me.menuStrip1)
			Me.MainMenuStrip = Me.menuStrip1
			Me.Name = "Child"
			Me.Text = "Child"
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private documentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private testToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private mergedSubMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace