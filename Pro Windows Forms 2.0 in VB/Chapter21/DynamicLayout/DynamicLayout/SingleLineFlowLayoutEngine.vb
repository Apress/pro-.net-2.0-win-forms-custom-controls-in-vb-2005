Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.Layout
Imports System.Drawing


Public Class SingleLineFlowLayoutEngine
    Inherits LayoutEngine
    Private _margin As Integer
    Public Property Margin() As Integer
        Get
            Return _margin
        End Get
        Set(ByVal value As Integer)
            _margin = value
            If Not parent Is Nothing Then
                MyBase.Layout(parent, New LayoutEventArgs(parent, "Margin"))
            End If
        End Set
    End Property

    Public Sub New(ByVal margin As Integer)
        Me.Margin = margin
    End Sub


    Private parent As Control

    ' You could choose to take other properties into account
    ' (like parent's padding, and the margins or anchor settings
    ' of each child control).
    Public Overrides Function Layout(ByVal container As Object, ByVal layoutEventArgs As LayoutEventArgs) As Boolean
        parent = TryCast(container, Control)

        Dim y As Integer = 0
        For Each ctrl As Control In parent.Controls
            y += Margin

            ' For maximum efficiency, set the 
            ' size and location in one step through
            ' the Bounds property.
            ctrl.Bounds = New Rectangle(Margin, y, parent.Width - Margin * 2, Margin)
        Next

        ' Return true if the layout should be performed again
        ' by the parent.
        Return parent.AutoSize
    End Function
End Class



