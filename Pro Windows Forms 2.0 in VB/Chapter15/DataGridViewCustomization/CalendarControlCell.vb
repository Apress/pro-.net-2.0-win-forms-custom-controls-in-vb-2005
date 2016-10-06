Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewCustomization
	Public Partial Class CalendarControlCell : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CalendarControlCell_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim col As CalendarColumn = New CalendarColumn()
			Me.dataGridView1.Columns.Add(col)
			Me.dataGridView1.RowCount = 5
			For Each row As DataGridViewRow In Me.dataGridView1.Rows
				row.Cells(0).Value = DateTime.Now
			Next row

		End Sub
	End Class
End Namespace