Imports System.Data.SqlClient

Public Class StoreDB

    Public Function GetCategories() As DataTable
        Dim connectionString As String = My.Settings.Store
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("GetProducts", con)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adapter As New SqlDataAdapter(cmd)

        Dim ds As New DataSet()
        adapter.Fill(ds, Tables.Product)
        cmd.CommandText = "GetCategories"
        adapter.Fill(ds, Tables.Category)


        ' Set up a relation between these tables.
        Dim relCategoryProduct As New DataRelation("CategoryProduct", _
          ds.Tables(Tables.Category).Columns(CategoryField.ID), _
          ds.Tables(Tables.Product).Columns(ProductField.CategoryID))
        ds.Relations.Add(relCategoryProduct)
        Return ds.Tables(Tables.Category)
    End Function

    Public Class Tables
        Public Const Product = "Products"
        Public Const Category = "Categories"
    End Class

    Public Class ProductField
        Public Const Name = "ModelName"
        Public Const Description = "Description"
        Public Const CategoryID = "CategoryID"
    End Class

    Public Class CategoryField
        Public Const Name = "CategoryName"
        Public Const ID = "CategoryID"
    End Class

    Public Function GetProductsInCategory(ByVal rowParent As DataRow) _
      As DataRow()
        Dim relCategoryProduct As DataRelation
        relCategoryProduct = rowParent.Table.DataSet.Relations(0)
        Return rowParent.GetChildRows(relCategoryProduct)
    End Function

    Public Function GetDisplayText(ByVal row As DataRow) As String
        Dim text As String = ""

        Select Case row.Table.TableName
            Case Tables.Product
                text = "ID: " & row(0) & vbNewLine
                text &= "Name: " & row(ProductField.Name) & vbNewLine & vbNewLine
                text &= row(ProductField.Description)
        End Select
        Return text
    End Function

End Class
