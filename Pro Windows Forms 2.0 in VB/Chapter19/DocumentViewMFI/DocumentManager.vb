Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms

Namespace DocumentView
	Public Class DocumentManager

        ' Track the open documents.
        Private _documents As Dictionary(Of Form, String) = New Dictionary(Of Form, String)()
        Public ReadOnly Property Documents() As Dictionary(Of Form, String)
            Get
                Return _documents
            End Get
        End Property

		' Track the form that has focus.
        Private _activeDocumentForm As Form
		Public ReadOnly Property ActiveDocumentForm() As Form
			Get
                Return _activeDocumentForm
            End Get
        End Property

        Public Sub AddForm(ByVal form As Form)
            If (Not _documents.ContainsKey(form)) Then
                _documents.Add(form, form.Text)

                ' Watch for activation and close events.
                AddHandler form.Activated, AddressOf Form_Activated
                AddHandler form.Closed, AddressOf Form_Closed

                AddHandler form.TextChanged, AddressOf Form_TextChanged
                OnWindowListChanged()
            End If
        End Sub

        Private Sub Form_Closed(ByVal sender As Object, ByVal e As EventArgs)
            Dim form As Form = CType(sender, Form)
            _documents.Remove(form)

            If _documents.Count = 0 AndAlso _quitWhenLastDocumentClosed Then
                Application.Exit()
            End If
            OnWindowListChanged()
        End Sub

        ' Provide an automatic shut-down feature when 
        ' last document is closed, if desired.
        Private _quitWhenLastDocumentClosed As Boolean = True
        Public Property QuitWhenLastDocumentClosed() As Boolean
            Get
                Return _quitWhenLastDocumentClosed
            End Get
            Set(ByVal value As Boolean)
                _quitWhenLastDocumentClosed = value
            End Set
        End Property

        Private Sub Form_Activated(ByVal sender As Object, ByVal e As EventArgs)
            _activeDocumentForm = CType(sender, Form)
        End Sub

		Private Sub Form_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim form As Form = CType(sender, Form)
            _documents(form) = form.Text
            OnWindowListChanged()
        End Sub

        Public Event WindowListChanged As EventHandler(Of WindowListChangedEventArgs)
        Public Sub OnWindowListChanged()
            RaiseEvent WindowListChanged(Me, New WindowListChangedEventArgs(_documents))
        End Sub
	End Class
End Namespace
