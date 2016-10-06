Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class Unbound : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Unbound_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim col1 As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
			col1.Name = "ProductID"
			col1.HeaderText = "Product ID"
			dataGridView1.Columns.Add(col1)

			' The easiest way to add a column, with name and header text.
			dataGridView1.Columns.Add("ModelName", "Model Name")
			dataGridView1.Columns.Add("Description", "Description")
			dataGridView1.Columns.Add("UnitCost", "Unit Cost")
			dataGridView1.Columns("UnitCost").ValueType = GetType(Decimal)


			' Fill in a row of data (as a list of values).
			dataGridView1.Rows.Add(100, "Emergency Travel Gear", "Be prepared for vacation disasters.", 34.44D)

			' Add another row (the hard way).
			Dim row As DataGridViewRow = CType(dataGridView1.Rows(0).Clone(), DataGridViewRow)
			row.SetValues(101, "Supreme Flight", "Sail over the trees with this glider.", 138.25D)
			dataGridView1.Rows.Add(row)

			' Disable editing features.
			dataGridView1.AllowUserToAddRows = False
			dataGridView1.AllowUserToDeleteRows = False
			dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically
		End Sub

		Private Sub dataGridView1_SortCompare(ByVal sender As Object, ByVal e As DataGridViewSortCompareEventArgs) Handles dataGridView1.SortCompare

		End Sub
	End Class
End Namespace