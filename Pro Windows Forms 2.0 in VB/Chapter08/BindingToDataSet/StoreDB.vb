Imports System.Data.SqlClient

Public Class StoreDB

    Public Function GetProducts() As DataTable
        ' Get the connection string from the .config file.
        Dim connectionString As String = My.Settings.Store

        ' Create the ADO.NET objects.
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("GetProducts", con)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adapter As New SqlDataAdapter(cmd)

        ' Fill a DataTable.
        Dim ds As New DataSet()
        adapter.Fill(ds, "Products")
        Return ds.Tables("Products")
    End Function

    Public Function GetCategoriesAndProducts() As DataSet
        Dim connectionString As String = My.Settings.Store
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("GetProducts", con)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adapter As New SqlDataAdapter(cmd)

        Dim ds As New DataSet()
        adapter.Fill(ds, "Products")
        cmd.CommandText = "GetCategories"
        adapter.Fill(ds, "Categories")

        Return ds
    End Function

    Public Function ValidateProduct(ByVal row As DataRow) As String
        Dim errors As String = ""

        If Val(row("UnitCost")) <= 0 Then
            errors &= "* UnitCost value too low" & vbNewLine
        End If

        If row("ModelNumber").ToString().Length = 0 Then
            errors &= "* You must specify a ModelNumber" & vbNewLine
        End If

        If row("ModelName").ToString().Length = 0 Then
            errors &= "* You must specify a ModelName" & vbNewLine
        End If
        Return errors
    End Function

End Class
