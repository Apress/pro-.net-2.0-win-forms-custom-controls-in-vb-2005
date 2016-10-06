Public Class StoreDB

    Public Shared Function GetProducts() As DataTable
        Dim dsStore As New DataSet()
        dsStore.ReadXmlSchema(Application.StartupPath & "\\store.xsd")
        dsStore.ReadXml(Application.StartupPath & "\\store.xml")
        Return dsStore.Tables("Products")
    End Function

    Public Shared Function GetCategories() As DataTable
        Dim dsStore As New DataSet()
        dsStore.ReadXmlSchema(Application.StartupPath & "\\store.xsd")
        dsStore.ReadXml(Application.StartupPath & "\\store.xml")
        Return dsStore.Tables("Categories")
    End Function

End Class
