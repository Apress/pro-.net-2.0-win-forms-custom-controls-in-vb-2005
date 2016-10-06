Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class CustomSorting : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CustomSorting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim dt As DataTable = Program.StoreDB.GetProducts()
			dt.Columns.Add("InStock", GetType(Boolean))
			dataGridView1.DataSource = dt

			For Each col As DataGridViewColumn In dataGridView1.Columns
				col.SortMode = DataGridViewColumnSortMode.Programmatic
			Next col
			dataGridView1.Columns("InStock").SortMode = DataGridViewColumnSortMode.Automatic
		End Sub


		Private Sub dataGridView1_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dataGridView1.ColumnHeaderMouseClick
            If dataGridView1.Columns(e.ColumnIndex).Name = "InStock" Then Return

			dataGridView1.Sort(dataGridView1.Columns(e.ColumnIndex), ListSortDirection.Ascending)
			dataGridView1.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending
		End Sub
	End Class
End Namespace