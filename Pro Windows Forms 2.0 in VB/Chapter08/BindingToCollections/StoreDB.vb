Imports System.Data.SqlClient

Public Class StoreDB

    Public Function GetProducts() As ProductList
        ' Get the connection string from the .config file.
        Dim connectionString As String = My.Settings.Store

        ' Create the ADO.NET objects.
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("GetProducts", con)
        cmd.CommandType = CommandType.StoredProcedure

        Dim products As New ProductList()
        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Do While reader.Read()
                ' Create a Product object that wraps the 
                ' current record.
                Dim product As New Product(CStr(reader("ModelNumber")), _
                  CStr(reader("ModelName")), CDec(reader("UnitCost")), _
                  CStr(reader("Description")))

                ' Add to collection
                products.Add(product)
            Loop
        Finally
            con.Close()
        End Try
        Return products
    End Function

End Class
