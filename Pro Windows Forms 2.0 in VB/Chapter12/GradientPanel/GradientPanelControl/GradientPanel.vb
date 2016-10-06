Imports System.Drawing.Drawing2D

Public Class GradientPanel
    Inherits Panel

    Private _colorA As Color = Color.LightBlue
    Private _colorB As Color = Color.Purple
    Private _gradientStyle As LinearGradientMode = LinearGradientMode.ForwardDiagonal

    Public Property ColorA() As Color
        Get
            Return _colorA
        End Get
        Set(ByVal value As Color)
            _colorA = value
            If _gradientBrush IsNot Nothing Then
                _gradientBrush.Dispose()
                _gradientBrush = Nothing
            End If
            Invalidate()
        End Set
    End Property

    Public Property ColorB() As Color
        Get
            Return _colorB
        End Get
        Set(ByVal value As Color)
            _colorB = value
            If _gradientBrush IsNot Nothing Then
                _gradientBrush.Dispose()
                _gradientBrush = Nothing
            End If
            Invalidate()
        End Set
    End Property

    Public Property GradientFillStyle() As LinearGradientMode
        Get
            Return _gradientStyle
        End Get
        Set(ByVal value As LinearGradientMode)
            _gradientStyle = value
            If _gradientBrush IsNot Nothing Then
                _gradientBrush.Dispose()
                _gradientBrush = Nothing
            End If
            Invalidate()
        End Set
    End Property

    Public Sub New()
        ResizeRedraw = True
    End Sub

    Protected Overrides Sub OnScroll(ByVal se As ScrollEventArgs)
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
                  ClientRectangle, ColorA, ColorB, GradientFillStyle)
            End If
            Return _gradientBrush
        End Get
    End Property

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If gradientBrush IsNot Nothing Then gradientBrush.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

End Class
