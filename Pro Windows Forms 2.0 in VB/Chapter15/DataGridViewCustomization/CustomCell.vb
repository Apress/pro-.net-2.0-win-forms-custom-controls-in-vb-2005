Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewCustomization
	Public Partial Class CustomCell : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CustomCell_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

			dataGridView1.DataSource = Program.StoreDB.GetProducts()

			' Hide the ordinary version of this column.
			dataGridView1.Columns(0).Visible = False

			' Create custom column.
			Dim colGradient As GradientRolloverColumn = New GradientRolloverColumn(Color.SlateBlue)
			colGradient.DataPropertyName = dataGridView1.Columns(0).DataPropertyName
			colGradient.HeaderText = dataGridView1.Columns(0).HeaderText
			colGradient.Width = dataGridView1.Columns(0).Width
			colGradient.ReadOnly = dataGridView1.Columns(0).ReadOnly
			colGradient.ValueType = dataGridView1.Columns(0).ValueType
			colGradient.DisplayIndex = 0

			' Add the custom column.
			dataGridView1.Columns.Add(colGradient)
		End Sub
	End Class
End Namespace