Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class ProportionateFill : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ProportionateFill_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.DataSource = Program.StoreDB.GetProducts()
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
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

			' Give much more weigth to the description.
			colID.FillWeight = 25
			colModel.FillWeight = 25
			colDesc.FillWeight = 100

			' However, keep a minimum width that ensures
			' the first two columns are readable.
			' Another option in this scenario is to only
			' assign fill mode to the description column.
			colID.MinimumWidth = 75
			colModel.MinimumWidth = 125
			colDesc.MinimumWidth = 100
		End Sub
	End Class
End Namespace