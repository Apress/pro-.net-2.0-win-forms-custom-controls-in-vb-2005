Public Class Program
    Private Shared _storeDB As New StoreDB

    Public Shared ReadOnly Property StoreDB() As StoreDB
        Get
            Return _storeDB
        End Get
    End Property
End Class
