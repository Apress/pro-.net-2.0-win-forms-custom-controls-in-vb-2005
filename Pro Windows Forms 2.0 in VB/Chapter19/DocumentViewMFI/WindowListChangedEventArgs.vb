Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

Namespace DocumentView
	Public Class WindowListChangedEventArgs : Inherits EventArgs
        Private _windowNames As Dictionary(Of Form, String)
		Public ReadOnly Property WindowNames() As Dictionary(Of Form, String)
			Get
                Return _windowNames
			End Get
		End Property

        Public Sub New(ByVal windowNames As Dictionary(Of Form, String))
            _windowNames = windowNames
        End Sub
	End Class
End Namespace
