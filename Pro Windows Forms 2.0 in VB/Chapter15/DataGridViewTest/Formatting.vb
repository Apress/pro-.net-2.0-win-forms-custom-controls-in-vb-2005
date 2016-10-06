Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class Formatting : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Formatting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.DataSource = Program.StoreDB.GetProducts()

			dataGridView1.Columns("ProductImage").Visible = False
			dataGridView1.Columns("CategoryID").Visible = False
			dataGridView1.Columns("ModelNumber").DisplayIndex = 4

			dataGridView1.Columns("ProductID").Frozen = True
			dataGridView1.Columns("ProductID").Resizable = DataGridViewTriState.False

			' Clean up all the columns.
			For Each col As DataGridViewColumn In dataGridView1.Columns
				col.HeaderCell.Value = Utility.SplitStringByCase(col.HeaderText)
			Next col

			dataGridView1.Columns("UnitCost").DefaultCellStyle.Format = "C"
			dataGridView1.Columns("UnitCost").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
			dataGridView1.Columns("UnitCost").DefaultCellStyle.BackColor = Color.LightYellow

			' Remove cells with the objectionable description.
			For Each row As DataGridViewRow In dataGridView1.Rows
				If TestForWords(Convert.ToString(row.Cells("Description").Value)) Then
					row.Visible = False
				End If
			Next row
		End Sub

		Private Function TestForWords(ByVal stringToTest As String) As Boolean
			stringToTest = stringToTest.ToLower()
			Return (stringToTest.Contains("warning") OrElse stringToTest.Contains("danger"))
		End Function

		Private Sub dataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dataGridView1.CellFormatting
			If dataGridView1.Columns(e.ColumnIndex).Name = "UnitCost" Then
				If Convert.ToInt32(e.Value) >= 1000 Then
					e.CellStyle.ForeColor = Color.Red
					e.CellStyle.BackColor = Color.Yellow
					e.CellStyle.Font = New Font(dataGridView1.DefaultCellStyle.Font, FontStyle.Bold)
				End If
			End If
		End Sub


	End Class
End Namespace