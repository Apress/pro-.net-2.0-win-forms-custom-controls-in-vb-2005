Imports System.ComponentModel

Public Class LocalizableUserControl

    Public Property NonLocalizableText() As String
        Get
            Return lblNonLocalizable.Text
        End Get
        Set(ByVal value As String)
            lblNonLocalizable.Text = value
        End Set
    End Property

    <Localizable(True)> _
    Public Property LocalizableText() As String
        Get
            Return lblLocalizable.Text
        End Get
        Set(ByVal value As String)
            lblLocalizable.Text = value
        End Set
    End Property

End Class
