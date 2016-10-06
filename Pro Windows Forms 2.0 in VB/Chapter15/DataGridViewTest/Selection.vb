Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class Selection : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Selection_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.DataSource = Program.StoreDB.GetProducts()

		End Sub

		Private Sub cmdSelectionInfo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSelectionInfo.Click
			DisplaySelection()
		End Sub

		Private Sub dataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dataGridView1.SelectionChanged
			DisplaySelection()
		End Sub

		Private Sub DisplaySelection()
			Dim info As StringBuilder = New StringBuilder()
			info.Append(String.Format("Selected Cells: {0}", dataGridView1.SelectedCells.Count))
			info.Append(Environment.NewLine)
			info.Append(String.Format("Selected Rows: {0}", dataGridView1.SelectedRows.Count))
			info.Append(Environment.NewLine)
			info.Append(String.Format("Selected Columns: {0}", dataGridView1.SelectedColumns.Count))
			info.Append(Environment.NewLine)

			info.Append("Values: ")
			info.Append(Environment.NewLine)
			For Each cell As DataGridViewCell In dataGridView1.SelectedCells
				info.Append(String.Format("  {0} at ({1}, {2})", cell.Value, cell.RowIndex, cell.ColumnIndex))
				info.Append(Environment.NewLine)
			Next cell

			If Not dataGridView1.CurrentCell Is Nothing Then
				info.Append(String.Format("Current Cell Value: {0}", dataGridView1.CurrentCell.Value))
				info.Append(Environment.NewLine)
				info.Append(String.Format("Current Cell Location: ({0}, {1})", dataGridView1.CurrentCellAddress.X, dataGridView1.CurrentCellAddress.Y))
			End If
			txtSelectionInfo.Text = info.ToString()
		End Sub
	End Class
End Namespace