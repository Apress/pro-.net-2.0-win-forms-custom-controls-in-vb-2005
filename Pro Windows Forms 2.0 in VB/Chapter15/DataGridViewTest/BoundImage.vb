Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Namespace DataGridViewTest
	Public Partial Class BoundImage : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub BoundImage_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Bind the grid.
			dataGridView1.DataSource = Program.StoreDB.GetProducts()

			For Each col As DataGridViewColumn In dataGridView1.Columns
				col.Visible = False
			Next col
			' Retrieve the columns you need to work with.
			Dim colID As DataGridViewColumn = dataGridView1.Columns("ProductID")
			Dim colModel As DataGridViewColumn = dataGridView1.Columns("ModelName")

			colID.Visible = True
			colModel.Visible = True

			' Create a new image column.
			Dim imageCol As DataGridViewImageColumn = New DataGridViewImageColumn()
			imageCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
			imageCol.ImageLayout = DataGridViewImageCellLayout.Normal
			imageCol.Name = "Image"
			dataGridView1.Columns.Add(imageCol)

			' Make sure pictures are visible.
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
		End Sub

		Private Sub dataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dataGridView1.CellFormatting
			' Check if it's the Image column.
            If dataGridView1.Columns(e.ColumnIndex).Name = "Image" And _
             dataGridView1.Rows(e.RowIndex).Cells("ProductImage").Value IsNot Nothing Then
                ' Set the value based on the hidden ProductImage column.
                Dim fileName As String = Application.StartupPath & "\" & dataGridView1.Rows(e.RowIndex).Cells("ProductImage").Value.ToString()
                If File.Exists(fileName) Then
                    e.Value = Image.FromFile(fileName)
                End If
            End If
		End Sub
	End Class
End Namespace