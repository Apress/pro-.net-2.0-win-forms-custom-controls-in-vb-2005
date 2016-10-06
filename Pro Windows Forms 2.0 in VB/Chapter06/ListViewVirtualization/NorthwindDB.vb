Imports System.Data.SqlClient

Public Class NorthwindDB
    Private Shared connectionString As String = My.Settings.ConnectionString

    Public Shared Function GetOrdersCount() As Integer
        ' Create the command and the connection.
        Dim sql As String = "SELECT COUNT(*) FROM Orders"
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand(sql, con)

        ' Get the number of records.
        Using con
            con.Open()
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    Public Shared Function GetOrders(ByVal fromOrderID As Integer, _
      ByVal toOrderID As Integer) As DataTable
        ' Create the command and the connection.
        Dim con As New SqlConnection(connectionString)
        Dim cmd As New SqlCommand("GetOrdersByPage", con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add(New SqlParameter("@FromID", SqlDbType.Int, 4))
        cmd.Parameters("@FromID").Value = fromOrderID
        cmd.Parameters.Add(New SqlParameter("@ToID", SqlDbType.Int, 4))
        cmd.Parameters("@ToID").Value = toOrderID

        ' Prepare to fill a new DataSet.
        Dim adapter As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()

        ' Get the appropriate "page" of order records.
        adapter.Fill(ds)

        ' Define the primary key (required for searching).
        ds.Tables(0).PrimaryKey = _
          New DataColumn() {ds.Tables(0).Columns("ID")}

        Return ds.Tables(0)
    End Function

End Class
