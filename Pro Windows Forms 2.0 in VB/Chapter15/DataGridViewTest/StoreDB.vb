Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Namespace DataGridViewTest
	Public Class StoreDB
		Public Function GetProducts() As DataTable
			Dim connectionString As String = My.Settings.Default.Store
			Dim con As SqlConnection = New SqlConnection(connectionString)
			Dim cmd As SqlCommand = New SqlCommand("GetProducts", con)
			cmd.CommandType = CommandType.StoredProcedure
			Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)

			Dim ds As DataSet = New DataSet()
			' Get read-only column info.
			adapter.FillSchema(ds, SchemaType.Mapped, "Products")
			' Fill the table.
			adapter.Fill(ds, "Products")
			Return ds.Tables(0)
		End Function

		Public Function GetCategoriesAndProducts() As DataSet
			Dim connectionString As String = My.Settings.Default.Store
			Dim con As SqlConnection = New SqlConnection(connectionString)
			Dim cmd As SqlCommand = New SqlCommand("GetProducts", con)
			cmd.CommandType = CommandType.StoredProcedure
			Dim adapter As SqlDataAdapter = New SqlDataAdapter(cmd)

			Dim ds As DataSet = New DataSet()
			adapter.Fill(ds, "Products")
			cmd.CommandText = "GetCategories"
			adapter.Fill(ds, "Categories")

			ds.Relations.Add("Cat_Prod", ds.Tables("Categories").Columns("CategoryID"), ds.Tables("Products").Columns("CategoryID"))
			Return ds
		End Function

		Public Function ValidateProduct(ByVal row As DataRow) As String
			Dim errors As String = ""

			If (CDec(row("UnitCost"))) <= 0 Then
				errors &= "* UnitCost value too low" & Constants.vbLf
			End If
			If row("ModelNumber").ToString() = "" Then
				errors &= "* You must specify a ModelNumber" & Constants.vbLf
			End If
			If row("ModelName").ToString() = "" Then
				errors &= "* You must specify a ModelName" & Constants.vbLf
			End If
			Return errors
		End Function

	End Class

End Namespace
