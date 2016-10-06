Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.Layout


Partial Public Class CustomLayoutEngine : Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CustomLayoutEngine_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private layoutEngine_Renamed As SingleLineFlowLayoutEngine = Nothing
    Public Overrides ReadOnly Property LayoutEngine() As LayoutEngine
        Get
            If layoutEngine_Renamed Is Nothing Then
                layoutEngine_Renamed = New SingleLineFlowLayoutEngine(20)
            End If
            Return layoutEngine_Renamed
        End Get
    End Property
End Class
