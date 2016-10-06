Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing

Namespace DocumentView
	Public Partial Class OrderPrintPreview : Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

        Private _document As Order
        Public Property Document() As Order
            Set(ByVal value As Order)
                ' Store a reference to the document, attach the event handler,
                ' and refresh the display.
                _document = Value
                AddHandler _document.DocumentChanged, AddressOf RefreshList
                AddHandler printDoc_Renamed.PrintPage, AddressOf PrintDoc
                RefreshList()
            End Set
            Get
                Return _document
            End Get
        End Property

		Private printDoc_Renamed As PrintDocument = New PrintDocument()

        Public Sub New(ByVal document As Order)
            Me.New()
            ' Store a reference to the document, attach the document event handlers,
            ' and refresh the display.
            Me.Document = document

        End Sub

		Private Sub RefreshList(ByVal sender As Object, ByVal e As System.EventArgs)
			RefreshList()
		End Sub

		Private Sub RefreshList()
			Preview.Document = printDoc_Renamed
			Preview.InvalidatePreview()
		End Sub

		' Tracks placement while printing.
		Private itemNumber As Integer

		' The print font.
		Private printFont As Font = New Font("Tahoma", 14, FontStyle.Bold)

		Private Sub PrintDoc(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

			' Tracks the line position on the page.
			Dim y As Integer = 70

			' Step through the items and write them to the page.
			Dim item As OrderItem
			Dim itemProduct As Product

			itemNumber = 0
			Do While itemNumber < Document.Count
				item = Document(itemNumber)
				e.Graphics.DrawString(item.ID.ToString(), printFont, Brushes.Black, 70, y)
				itemProduct = PriceList.GetItem(item.ID)
				e.Graphics.DrawString(itemProduct.Name, printFont, Brushes.Black, 120, y)
				e.Graphics.DrawString(itemProduct.Price.ToString(), printFont, Brushes.Black, 350, y)

				' Check if more pages are required.
				If (y + 30) > e.MarginBounds.Height AndAlso itemNumber < (Document.Count - 1) Then
					e.HasMorePages = True
					Return
				End If

				' Move to the next line.
				y += 20
				itemNumber += 1
			Loop

			' Printing is finished.
			e.HasMorePages = False
			itemNumber = 0
		End Sub
	End Class
End Namespace
