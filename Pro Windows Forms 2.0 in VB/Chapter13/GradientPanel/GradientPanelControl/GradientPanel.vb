Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class GradientPanel
    Inherits Panel

    Private _gradientFill As New GradientFill()

    Private Sub GradientChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _gradientBrush IsNot Nothing Then _gradientBrush.Dispose()
        _gradientBrush = Nothing
        Invalidate()
    End Sub

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public Property GradientFill() As GradientFill
        Get
            Return _gradientFill
        End Get
        Set(ByVal value As GradientFill)
            _gradientFill = value
            AddHandler _gradientFill.GradientChanged, AddressOf GradientChanged
            _gradientBrush = Nothing
            Invalidate()
        End Set
    End Property

    Public Sub New()

    End Sub

    Protected Overrides Sub OnScroll(ByVal se As ScrollEventArgs)
        Invalidate()
    End Sub

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        _gradientBrush = Nothing
        Invalidate()
    End Sub


    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        ' Draw the gradient background.
        e.Graphics.FillRectangle(GradientBrush, ClientRectangle)
    End Sub

    Private _gradientBrush As Brush
    Private ReadOnly Property GradientBrush() As Brush
        Get
            If _gradientBrush Is Nothing Then
                _gradientBrush = New LinearGradientBrush( _
                  ClientRectangle, GradientFill.ColorA, GradientFill.ColorB, GradientFill.GradientFillStyle)
            End If
            Return _gradientBrush
        End Get
    End Property

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If GradientBrush IsNot Nothing Then GradientBrush.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

End Class
