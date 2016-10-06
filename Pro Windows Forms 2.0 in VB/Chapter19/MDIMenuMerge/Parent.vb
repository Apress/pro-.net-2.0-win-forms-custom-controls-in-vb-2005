Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MdiMenuMerge
	Public Partial Class Parent : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub noMergeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles noMergeToolStripMenuItem.Click
			Dim child As Child = New Child()
			child.MdiParent = Me
			child.SetNoMerge()
			child.Show()
		End Sub

		Private Sub mergeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mergeToolStripMenuItem.Click
			Dim child As Child = New Child()
			child.MdiParent = Me
			child.Show()
		End Sub
	End Class
End Namespace