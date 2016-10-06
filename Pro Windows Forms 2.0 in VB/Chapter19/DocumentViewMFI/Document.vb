Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.IO

Public Class OrderItem
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer)
        Me.ID = id
    End Sub
End Class

Public Class Order
    Inherits CollectionBase

    Private _lastFileName As String = "[New Order]"
    Public Property LastFileName() As String
        Get
            Return _lastFileName
        End Get
        Set(ByVal value As String)
            _lastFileName = value
        End Set
    End Property

    Public Sub Add(ByVal item As OrderItem)
        MyBase.List.Add(item)
        OnDocumentChanged(New EventArgs())
    End Sub

    Public Sub Remove(ByVal index As Integer)
        ' Check to see if there is an item at the supplied index.
        If index > (Me.Count - 1) OrElse index < 0 Then
            Throw New System.IndexOutOfRangeException()
        Else
            MyBase.List.RemoveAt(index)
        End If
        OnDocumentChanged(New EventArgs())
    End Sub

    ' Indexer.
    Default Public Property Item(ByVal index As Integer) As OrderItem
        Get
            Return CType(MyBase.List(index), OrderItem)
        End Get
        Set(ByVal value As OrderItem)
            MyBase.List(index) = value
        End Set
    End Property

    Public Event DocumentChanged As EventHandler
    Protected Sub OnDocumentChanged(ByVal e As System.EventArgs)
        ' Note that this currently occurs as items are added or removed,
        ' but not when they are edited. To overcome this would require adding
        ' an additional OrderItem change event.

        ' Raise the DocumentChanged event.
        If Not DocumentChangedEvent Is Nothing Then
            RaiseEvent DocumentChanged(Me, e)
        End If
    End Sub

    Public Sub Open(ByVal filename As String)
        Using fs As FileStream = New FileStream(filename, FileMode.Open)
            Dim r As StreamReader = New StreamReader(fs)

            Do
                Me.Add(New OrderItem(Integer.Parse(r.ReadLine())))
            Loop While r.Peek() <> -1

            r.Close()
        End Using

        ' By placing this last we ensure that the file will not be updated
        ' if a load error occurs.
        Me.LastFileName = filename
    End Sub

    Public Sub Save(ByVal filename As String)
        Using fs As FileStream = New FileStream(filename, FileMode.Create)
            Dim w As StreamWriter = New StreamWriter(fs)

            For Each item As OrderItem In Me.List
                w.WriteLine(item.ID)
            Next item

            w.Close()
        End Using

        ' Note: a real pricing program would probably store the price in the file
        ' (required for orders) but update it to correspond with the current
        ' price for the item when the file is opened.

        ' By placing this last we ensure that the file will not be updated
        ' if a save error occurs.
        Me.LastFileName = filename
    End Sub

End Class


Public Class Product
    Private _id As Integer
    Public Property ID() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _description As String
    Public Property Description() As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property

    Private _price As Decimal
    Public Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(ByVal value As Decimal)
            _price = value
        End Set
    End Property

    Public Sub New(ByVal id As Integer, ByVal name As String, ByVal description As String, ByVal price As Decimal)
        Me.ID = id
        Me.Name = name
        Me.Description = description
        Me.Price = price
    End Sub
End Class



