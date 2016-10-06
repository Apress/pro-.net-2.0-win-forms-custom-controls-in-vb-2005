Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class Wrapping : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Wrapping_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.DataSource = Program.StoreDB.GetProducts()
			For Each col As DataGridViewColumn In dataGridView1.Columns
				col.Visible = False
			Next col
			' Retrieve the columns you need to work with.
			Dim colID As DataGridViewColumn = dataGridView1.Columns("ProductID")
			Dim colModel As DataGridViewColumn = dataGridView1.Columns("ModelName")
			Dim colDesc As DataGridViewColumn = dataGridView1.Columns("Description")

			colID.Visible = True
			colModel.Visible = True
			colDesc.Visible = True


			colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
			colModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

			colDesc.DefaultCellStyle.WrapMode = DataGridViewTriState.True
			colDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
		End Sub
	End Class
End Namespace