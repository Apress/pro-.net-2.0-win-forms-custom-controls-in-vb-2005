Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace DataGridViewVirtualization
	Public Partial Class Form1 : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.Columns.Clear()
			dataGridView1.RowCount = NorthwindDB.GetOrdersCount()

			' Suspending automatic refreshes as items are added/removed.
			dataGridView1.SuspendLayout()

			' Add column headers for Details view.
			dataGridView1.Columns(0).HeaderText = "ID"
			dataGridView1.Columns.Add("ShippedDate", "ShippedDate")
			dataGridView1.Columns(1).Width = 125

			' Re-enable the display.
			dataGridView1.ResumeLayout()
		End Sub

		Private dtCachedItems As DataTable

		Private Sub dataGridView1_CellValueNeeded(ByVal sender As Object, ByVal e As DataGridViewCellValueEventArgs) Handles dataGridView1.CellValueNeeded
			' Check if the item is in the local cache.
			Dim match As DataRow = Nothing
			If Not dtCachedItems Is Nothing Then
				match = dtCachedItems.Rows.Find(e.RowIndex + 1)
			End If

			If match Is Nothing Then
				' The item isn't in memory.
				' Get a new range of 100 records.
				Dim from, [to] As Integer
				If e.RowIndex < 50 Then
					from = 0
				Else
					from = (e.RowIndex - 50)
				End If

				[to] = from + 100
				dtCachedItems = NorthwindDB.GetOrders(from, [to])

				' Don't use the MessageBox to show this information.
				' Hiding any part of the ListView can retrigger this event.
				lblStatus.Text = String.Format("Fetched rows from {0} to {1} at {2}.", from.ToString(), [to].ToString(), DateTime.Now.ToLongTimeString())

				match = dtCachedItems.Rows.Find(e.RowIndex + 1)
			End If

			Select Case e.ColumnIndex
				Case 0
					e.Value = match("OrderID")
				Case 1
					e.Value = match("ShippedDate")
			End Select

		End Sub

	End Class
End Namespace