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
			Me.New()
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
			End Select

			' Add the view to the form.
			view.Dock = DockStyle.Fill
			Me.Controls.Add(view)
		End Sub
	End Class
End Namespace