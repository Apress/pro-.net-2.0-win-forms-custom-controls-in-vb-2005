#Region "Using directives"


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text

#End Region

Namespace MultithreadingClient
    Friend Partial Class AsyncTestQuery : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Public ReadOnly Property From() As Integer
            Get
'INSTANT VB NOTE: The local variable from was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
                Dim from_Renamed As Integer
                Int32.TryParse(txtFrom.Text, from_Renamed)
                Return from_Renamed
            End Get
        End Property

        Public ReadOnly Property [To]() As Integer
            Get
'INSTANT VB NOTE: The local variable to was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
                Dim to_Renamed As Integer
                Int32.TryParse(txtTo.Text, to_Renamed)
                Return to_Renamed
            End Get
        End Property

    End Class
End Namespace