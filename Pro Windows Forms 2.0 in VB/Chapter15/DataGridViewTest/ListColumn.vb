Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class ListColumn : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ListColumn_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim ds As DataSet = Program.StoreDB.GetCategoriesAndProducts()
			dataGridView1.DataSource = ds.Tables("Products")

			' Remove the auto-generated CategoryID column.
			dataGridView1.Columns.Remove("CategoryID")

			' Create a list column for the CategoryID.
			Dim listCol As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
			listCol.DisplayIndex = 0
			listCol.HeaderText = "Category"

			' This column is bound to the Products.CategoryID field.
			listCol.DataPropertyName = "CategoryID"

			' The list is filled from the Categories table.
			listCol.DataSource = ds.Tables("Categories")
			listCol.DisplayMember = "CategoryName"
			listCol.ValueMember = "CategoryID"

			' Add the column.
			dataGridView1.Columns.Add(listCol)

		End Sub
	End Class
End Namespace