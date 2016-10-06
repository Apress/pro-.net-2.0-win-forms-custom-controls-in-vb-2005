Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics
Imports System.Text.RegularExpressions

Namespace DataGridViewTest
	Public Partial Class Barebones : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Barebones_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.DataSource = Program.StoreDB.GetProducts()

			For Each row As DataGridViewRow In dataGridView1.Rows
				If (Not row.IsNewRow) AndAlso Convert.ToInt32(row.Cells("UnitCost").Value) > 50 Then
					Debug.WriteLine(row.Cells("ProductID").Value)
				End If
			Next row

			For Each col As DataGridViewColumn In dataGridView1.Columns
				col.HeaderText = Regex.Replace(col.HeaderText, "(\p{Ll})(\p{Lu})|_+", "$1 $2")
			Next col
		End Sub




	End Class
End Namespace