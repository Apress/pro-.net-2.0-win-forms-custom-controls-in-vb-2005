Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Diagnostics
Imports System.ComponentModel


Public Class SingleLineFlowLayoutManager
    Private container As Control

    ' Instead of using a simple integer, you could use a full Padding structure.
    Private _margin As Integer
    Public Property Margin() As Integer
        Get
            Return _margin
        End Get
        Set(ByVal value As Integer)
            _margin = value
            container.PerformLayout()
        End Set
    End Property


    Public Sub New(ByVal container As Control, ByVal margin As Integer)
        Me.container = container
        Me.Margin = Margin

        ' Attach the event handler.
        AddHandler container.Layout, AddressOf UpdateLayout

        ' Refresh the layout.
        container.PerformLayout(container, "LayoutManager")
    End Sub

    Private Sub UpdateLayout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs)
        Dim debugMessage As String = "Called: " & Constants.vbLf & " Affected Control: " & e.AffectedControl.Name + Constants.vbLf & " Affected Property: " & e.AffectedProperty
        Debug.WriteLine(debugMessage)

        If e.AffectedProperty = "Visible" Then
            Return
        End If
        Dim y As Integer = 0
        For Each ctrl As Control In container.Controls
            y += Margin

            ' For maximum efficiency, set the 
            ' size and location in one step through
            ' the Bounds property.
            ctrl.Bounds = New Rectangle(Margin, y, container.Width - Margin * 2, Margin)
        Next
    End Sub

End Class


