Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DocumentView
	Public Partial Class Child : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Enum ViewType
			ItemGrid
			PrintPreview
		End Enum

		Public Document As Order

		Public Sub New(ByVal doc As Order, ByVal viewType As ViewType)
			InitializeComponent()

			toolStrip1.Items(0).Image = imgButtons.Images(0)
			toolStrip1.Items(1).Image = imgButtons.Images(1)
			toolStrip1.Items(2).Image = imgButtons.Images(2)
			toolStrip1.Items(3).Image = imgButtons.Images(3)
			toolStrip1.Items(5).Image = imgButtons.Images(4)

			' Set up window list.
            AddHandler Program.DocumentManager.WindowListChanged, AddressOf WindowListChanged

			' Configure the title.
			Me.Text = doc.LastFileName
			Me.Document = doc

			' Create a reference for the view.
			' This reference can accomodate any type of control.
			Dim view As Control = Nothing

			' Instantiate the appropriate view.
			Select Case viewType
				Case ViewType.ItemGrid
					view = New OrderGridView(doc)
				Case ViewType.PrintPreview
					view = New OrderPrintPreview(doc)
					Me.Text &= " (Preview)"
					toolStrip1.Visible = False
					menuStrip1.Visible = False
			End Select

			' Add the view to the form.
			view.Dock = DockStyle.Fill

			Me.Controls.Add(view)
			view.BringToFront()
		End Sub

		Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
			Program.AppTasks.[New]()
		End Sub

		Private Sub toolStripButton2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton2.Click
			Program.AppTasks.Open()
		End Sub

		Private Sub toolStripButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton3.Click
			Me.Close()
		End Sub

		Private Sub toolStripButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton4.Click
			Program.AppTasks.Save()
		End Sub

		Private Sub toolStripButton5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton5.Click
			Program.AppTasks.Preview()
		End Sub

		Public Sub WindowListChanged(ByVal sender As Object, ByVal e As WindowListChangedEventArgs)
			windowToolStripMenuItem.DropDownItems.Clear()
			For Each name As KeyValuePair(Of Form,String) In e.WindowNames
				Dim menuItem As ToolStripItem = windowToolStripMenuItem.DropDownItems.Add(name.Value)
				menuItem.Tag = name.Key
			Next name
		End Sub

		Private Sub windowToolStripMenuItem_DropDownItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles windowToolStripMenuItem.DropDownItemClicked
			 ' Show the linked form.
			CType(e.ClickedItem.Tag, Form).Activate()
		End Sub
	End Class
End Namespace