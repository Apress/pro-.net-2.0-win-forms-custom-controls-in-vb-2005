Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data.SqlClient
Imports System.Data


Public Class DBPermissions
    Public Enum State
        Normal = 0
        Disabled = 1
        Hidden = 2
    End Enum

    Public Enum Level
        Admin
        User
    End Enum

    Private con As SqlConnection

    Public Sub New()
        con = New SqlConnection(My.Settings.DBConnectionString)
    End Sub


    Public Function GetPermissions(ByVal userLevel As Level) As DataTable
        ' Permissions isn't actually actually a table in our data source.
        ' Instead, it's a view that combines the important information
        ' from all three tables using a Join query.
        Dim selectPermissions As String = "SELECT * FROM Permissions WHERE LevelName=@LevelName"
        Dim cmd As New SqlCommand(selectPermissions, con)

        Dim param As New SqlParameter("@LevelName", System.Enum.GetName(GetType(Level), userLevel))
        cmd.Parameters.Add(param)

        Dim adapter As New SqlDataAdapter(cmd)
        Dim ds As New DataSet()
        adapter.Fill(ds, "Permissions")

        Return ds.Tables("Permissions")
    End Function
End Class


