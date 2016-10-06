Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewTest
	Public Partial Class AutoResize : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub AutoResize_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.DataSource = Program.StoreDB.GetProducts()

			For Each col As DataGridViewColumn In dataGridView1.Columns
				col.Visible = False
			Next col
			dataGridView1.Columns("ProductID").Visible = True
			dataGridView1.Columns("ModelName").Visible = True
			dataGridView1.Columns("Description").Visible = True

			lstAutoSizeRows.Items.AddRange(System.Enum.GetNames(GetType(DataGridViewAutoSizeRowsMode)))
			lstAutoSizeColumns.Items.AddRange(System.Enum.GetNames(GetType(DataGridViewAutoSizeColumnsMode)))

			lstAutoSizeColumns.Text = dataGridView1.AutoSizeColumnsMode.ToString()
			lstAutoSizeRows.Text = dataGridView1.AutoSizeRowsMode.ToString()


		End Sub


		Private Sub lst_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstAutoSizeRows.SelectedIndexChanged, lstAutoSizeColumns.SelectedIndexChanged
			If lstAutoSizeColumns.Text = "" OrElse lstAutoSizeRows.Text = "" Then
			Return
			End If
			dataGridView1.AutoSizeColumnsMode = CType(System.Enum.Parse(GetType(DataGridViewAutoSizeColumnsMode), lstAutoSizeColumns.Text), DataGridViewAutoSizeColumnsMode)
			dataGridView1.AutoSizeRowsMode = CType(System.Enum.Parse(GetType(DataGridViewAutoSizeRowsMode), lstAutoSizeRows.Text), DataGridViewAutoSizeRowsMode)
		End Sub

		Private Sub optAllWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optAllWrap.CheckedChanged
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True
		End Sub

		Private Sub optNoWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optNoWrap.CheckedChanged
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False
			dataGridView1.Columns("Description").DefaultCellStyle.WrapMode = DataGridViewTriState.False
		End Sub

		Private Sub optWrapDesc_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles optWrapDesc.CheckedChanged
			dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.False
			dataGridView1.Columns("Description").DefaultCellStyle.WrapMode = DataGridViewTriState.True
		End Sub
	End Class
End Namespace