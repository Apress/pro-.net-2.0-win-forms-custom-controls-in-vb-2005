Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class UnboundImage : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private genericImage As Image
		Private newImage As Image

		Private Sub UnboundImage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			genericImage = imageList.Images(1)
			newImage = imageList.Images(0)

			' Bind the grid.
			dataGridView1.DataSource = Program.StoreDB.GetProducts()

			' Create the image column.
			Dim imageCol As DataGridViewImageColumn = New DataGridViewImageColumn()
			imageCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			imageCol.ImageLayout = DataGridViewImageCellLayout.Normal
			imageCol.Frozen = True
			imageCol.Name = "Image"
			imageCol.HeaderText = ""

			' Move the column to the left, and move the ProductID
			' column out of the way.
			imageCol.DisplayIndex = 0
			dataGridView1.Columns("ProductID").DisplayIndex = 1

			' By default, show the generic image.
			imageCol.Image = genericImage

			' Add the image column to the grid.
			dataGridView1.Columns.Add(imageCol)

		End Sub

		Private Sub dataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dataGridView1.CellValueChanged
			If e.RowIndex <> -1 Then
				' Retrieve the image column for this row.
				Dim col As DataGridViewImageCell = CType(dataGridView1.Rows(e.RowIndex).Cells("Image"), DataGridViewImageCell)

				' Set the image.
				col.Value = newImage
			End If
		End Sub
	End Class
End Namespace