Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Namespace DocumentView
    Partial Public Class OrderGridView
        Inherits UserControl

        Private _document As Order
        Public Property Document() As Order
            Set(ByVal value As Order)
                ' Store a reference to the document, attach the event handler,
                ' and refresh the display.
                _document = value
                AddHandler _document.DocumentChanged, AddressOf RefreshList
                RefreshList()
            End Set
            Get
                Return _document
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        ' This constructor calls the default constructor to make sure the controls
        ' were added at design-time are created.
        Public Sub New(ByVal document As Order)
            Me.New()
            ' Store a reference to the document, attach the event handler,
            ' and refresh the display.
            Me.Document = document
        End Sub

        Private Sub RefreshList(ByVal sender As Object, ByVal e As System.EventArgs)
            RefreshList()
        End Sub

        Private Sub RefreshList()
            ' Update the ListView control with the new document contents.
            If Not List Is Nothing Then
                ' For best performance, disable refreshes while updating the list.
                List.SuspendLayout()

                List.Items.Clear()

                ' Step through the list of items in the document.
                Dim itemProduct As Product
                Dim itemDisplay As ListViewItem
                For Each item As OrderItem In Me.Document
                    itemDisplay = List.Items.Add(item.ID.ToString())
                    itemProduct = PriceList.GetItem(item.ID)
                    itemDisplay.SubItems.Add(itemProduct.Name)
                    itemDisplay.SubItems.Add(itemProduct.Price.ToString())
                    itemDisplay.SubItems.Add(itemProduct.Description)
                Next item

                List.ResumeLayout()
            End If
        End Sub

        ' Triggered when the Add button is clicked.
        Private Sub cmdAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
            ' Add a random item.
            Dim randomItem As Random = New Random()
            Document.Add(New OrderItem(randomItem.Next(1, 4)))
        End Sub

        ' Triggered when the Remove button is clicked.
        Private Sub cmdRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
            ' Remove the current item.
            ' The ListView Is configured for single-selection only.
            If List.SelectedIndices.Count = 1 Then
                Document.Remove(List.SelectedIndices(0))
            End If
        End Sub
    End Class
End Namespace
