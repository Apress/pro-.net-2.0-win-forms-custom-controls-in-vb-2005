Imports Microsoft.VisualBasic
Imports System

Namespace DocumentView
	''' <summary>
	''' Summary description for PriceList.
	''' </summary>
	Public Class PriceList
		Public Shared Function GetItem(ByVal ID As Integer) As Product
				Select Case ID
					Case 1
						Return New Product(ID, "Sample Product 1", "Sample Description 1", CDec(14.99))

					Case 2
						Return New Product(ID, "Sample Product 2", "Sample Description 2", CDec(14.99))

					Case 3
						Return New Product(ID, "Sample Product 3", "Sample Description 3", CDec(14.99))

					Case Else
						Throw New IndexOutOfRangeException("Not a valid product ID.")
				End Select

		End Function

	End Class
End Namespace
