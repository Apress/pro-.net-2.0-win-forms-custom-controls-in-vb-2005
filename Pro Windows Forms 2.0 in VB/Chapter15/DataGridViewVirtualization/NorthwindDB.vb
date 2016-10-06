Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data

Namespace DataGridViewVirtualization
	Public Class NorthwindDB
        Private Shared connectionString As String = My.Settings.Default.ConnectionString

		Public Shared Function GetOrdersCount() As Integer
			' Create the command and the connection.
			Dim sql As String = "SELECT COUNT(*) FROM Orders"
			Dim con As SqlConnection = New SqlConnection(connectionString)
			Dim cmd As SqlCommand = New SqlCommand(sql, con)

			' Get the number of records.
			Using con
				con.Open()
				Return CInt(Fix(cmd.ExecuteScalar()))
			End Using
		End Function

		Public Shared Function GetOrders(ByVal fromOrderID As Integer, ByVal toOrderID As Integer) As DataTable
			Dim con As SqlConnection = New SqlConnection(connectionString)
			Dim cmd As SqlCommand = New SqlCommand("GetOrdersByPage", con)
			cmd.CommandType = CommandType.StoredProcedure
			cmd.Parameters.Add(New SqlParameter("@FromID", SqlDbType.Int, 4))
			cmd.Parameters("@FromID").Value = fromOrderID
			cmd.Parameters.Add(New SqlParameter("@ToID", SqlDbType.Int, 4))
			cmd.Parameters("@ToID").Value = toOrderID

			' Prepare to fill a new DataSet.
			Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)
			Dim ds As DataSet = New DataSet()

			' Get the appropriate "page" of order records.
			adapter.Fill(ds)
			ds.Tables(0).PrimaryKey = New DataColumn() { ds.Tables(0).Columns("ID") }
			Return ds.Tables(0)
		End Function
	End Class
End Namespace