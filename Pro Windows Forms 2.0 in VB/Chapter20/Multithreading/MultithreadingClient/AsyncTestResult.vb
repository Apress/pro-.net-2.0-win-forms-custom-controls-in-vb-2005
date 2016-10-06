#Region "Using directives"


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

#End Region

Namespace MultithreadingClient
    Friend Partial Class AsyncTestResult : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub AsyncTestResult_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Public Sub ShowList(ByVal text As String)
            txtResults.Text = text
        End Sub
    End Class
End Namespace