Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace MdiSynchronized
	Public Partial Class Parent : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private mdiIndex As Integer = 0

		Private Sub cmdNew(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripButton.Click, newToolStripMenuItem.Click
			' Show a new child form.
			Dim frmChild As Child = New Child()
			frmChild.MdiParent = Me

			frmChild.RefreshText(synchronizedText)
			mdiIndex += 1
			frmChild.Text = "MDI Child #" & mdiIndex.ToString()

			frmChild.Show()
		End Sub

		Private Sub cmdClose(ByVal sender As Object, ByVal e As EventArgs) Handles openToolStripButton.Click, closeToolStripMenuItem.Click
			' Close the active child.
			If Not ActiveMdiChild Is Nothing Then
				ActiveMdiChild.Close()
			End If
		End Sub

		Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
			Close()
		End Sub

		Private synchronizedText As String
		Public Sub RefreshChildren(ByVal sender As Child, ByVal text As String)
			' Store text for use when creating a child form, or if needed later.
			synchronizedText = text

			' Update children.
			For Each frm As Child In Me.MdiChildren
				If Not frm Is sender Then
					frm.RefreshText(text)
				End If
            Next
		End Sub

		Private Sub mnuMinimizeAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles minimizeAllToolStripMenuItem.Click
			For Each frm As Form In Me.MdiChildren
				frm.WindowState = FormWindowState.Minimized
            Next
        End Sub

		Private Sub mnuTileH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tileHorizontalToolStripMenuItem.Click
			Me.LayoutMdi(MdiLayout.TileHorizontal)
		End Sub

		Private Sub mnuTileV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tileVerticalToolStripMenuItem.Click
			Me.LayoutMdi(MdiLayout.TileVertical)
		End Sub

		Private Sub mnuCascade_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cascadeToolStripMenuItem.Click
			Me.LayoutMdi(MdiLayout.Cascade)
		End Sub

		Private Sub windowToolStripMenuItem_DropDownOpening(ByVal sender As Object, ByVal e As EventArgs) Handles windowToolStripMenuItem.DropDownOpening
			If Me.MdiChildren.Length = 0 Then
				' There are no children.
				' The last item in the menu must be a separator.
				' Hide it.
				Dim lastItem As Integer = windowToolStripMenuItem.DropDown.Items.Count - 1
				windowToolStripMenuItem.DropDown.Items(lastItem).Visible = False
			End If
		End Sub

		Private Sub windowToolStripMenuItem_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs) Handles windowToolStripMenuItem.DropDownClosed
			If Me.MdiChildren.Length = 0 Then
				Dim lastItem As Integer = windowToolStripMenuItem.DropDown.Items.Count - 1
				windowToolStripMenuItem.DropDown.Items(lastItem).Visible = True
			End If
		End Sub
	End Class
End Namespace