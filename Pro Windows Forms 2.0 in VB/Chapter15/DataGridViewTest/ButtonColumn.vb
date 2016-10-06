Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class ButtonColumn : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ButtonColumn_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim ds As DataSet = Program.StoreDB.GetCategoriesAndProducts()
			dataGridView1.DataSource = ds.Tables("Categories")

			Dim detailsCol As DataGridViewButtonColumn = New DataGridViewButtonColumn()
			detailsCol.Name = "Details"
			detailsCol.Text = "Details..."

			detailsCol.UseColumnTextForButtonValue = True
			dataGridView1.Columns.Insert(dataGridView1.Columns.Count, detailsCol)

			dataGridView1.AllowUserToAddRows = False
		End Sub

		Private Sub dataGridView1_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dataGridView1.CellClick
			If dataGridView1.Columns(e.ColumnIndex).Name = "Details" Then
				' Create the new form.
				Dim frm As ChildForm = New ChildForm()

				' Provide the OrderID to the new form.
				frm.CategoryID = Convert.ToInt32(dataGridView1.Rows(e.RowIndex).Cells("CategoryID").Value)

				' Show the form.
				frm.ShowDialog()
				frm.Dispose()
			End If

		End Sub
	End Class
End Namespace