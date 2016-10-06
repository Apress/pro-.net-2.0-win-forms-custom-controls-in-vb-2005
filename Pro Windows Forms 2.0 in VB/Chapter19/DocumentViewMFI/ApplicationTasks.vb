Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DocumentView
	Public Class ApplicationTasks
		Private lastDir As String = "C:\Temp"

		Public Sub Open()
			Dim dlgOpen As OpenFileDialog = New OpenFileDialog()
			dlgOpen.InitialDirectory = lastDir
			dlgOpen.Filter = "Order Files (*.ord)|*.ord"

			' Show the open dialog.
			If dlgOpen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Dim doc As Order = New Order()

				Try
					doc.Open(dlgOpen.FileName)
				Catch err As Exception
					' All exceptions bubble up to this level.
					MessageBox.Show(err.ToString())
					Return
				End Try

				' Create the child form for the selected file.
				Dim frmChild As Child = New Child(doc, Child.ViewType.ItemGrid)
				Program.DocumentManager.AddForm(frmChild)
				frmChild.Show()
			End If
		End Sub

		Public Sub [New]()
			' Create a new order.
			Dim doc As Order = New Order()
			Dim frmChild As Child = New Child(doc, Child.ViewType.ItemGrid)
			Program.DocumentManager.AddForm(frmChild)
			frmChild.Show()
		End Sub

		Public Sub Save()
			' Save the current order.
			If Not Program.DocumentManager.ActiveDocumentForm Is Nothing Then
				Dim dlgSave As SaveFileDialog = New SaveFileDialog()
				Dim doc As Order = (CType(Program.DocumentManager.ActiveDocumentForm, Child)).Document
				dlgSave.FileName = doc.LastFileName
				dlgSave.Filter = "Order Files (*.ord)|*.ord"

				If dlgSave.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					Try
						doc.Save(dlgSave.FileName)
						Program.DocumentManager.ActiveDocumentForm.Text = dlgSave.FileName
					Catch err As Exception
						' All exceptions bubble up to this level.
						MessageBox.Show(err.ToString())
						Return
					End Try
				End If
			End If
		End Sub

		Public Sub Preview()
			' Launch a print preview child for the active order.
			If Not Program.DocumentManager.ActiveDocumentForm Is Nothing Then
				Dim doc As Order = (CType(Program.DocumentManager.ActiveDocumentForm, Child)).Document

				Dim frmChild As Child = New Child(doc, Child.ViewType.PrintPreview)
				Program.DocumentManager.AddForm(frmChild)
				frmChild.Show()
			End If
		End Sub

	End Class
End Namespace