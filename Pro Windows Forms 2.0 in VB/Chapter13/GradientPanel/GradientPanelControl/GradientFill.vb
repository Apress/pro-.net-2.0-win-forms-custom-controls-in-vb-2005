Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Drawing.Design

<TypeConverter(GetType(GradientFillConverter))> _
<Editor(GetType(GradientFillEditor), GetType(UITypeEditor))> _
Public Class GradientFill

    Private _colorA As Color = Color.LightBlue
    Private _colorB As Color = Color.Purple
    Private _gradientStyle As LinearGradientMode = _
      LinearGradientMode.ForwardDiagonal

    Public Event GradientChanged(ByVal sender As Object, ByVal e As EventArgs)

    <RefreshProperties(RefreshProperties.Repaint)> _
    <NotifyParentProperty(True)> _
    <DefaultValue(GetType(Color), "LightBlue")> _
    Public Property ColorA() As Color
        Get
            Return _colorA
        End Get
        Set(ByVal value As Color)
            _colorA = value
            OnGradientChanged(EventArgs.Empty)
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)> _
    <NotifyParentProperty(True)> _
    <DefaultValue(GetType(Color), "Purple")> _
    Public Property ColorB() As Color
        Get
            Return _colorB
        End Get
        Set(ByVal value As Color)
            _colorB = value
            OnGradientChanged(EventArgs.Empty)
        End Set
    End Property

    <RefreshProperties(RefreshProperties.Repaint)> _
    <NotifyParentProperty(True)> _
    <DefaultValue(GetType(LinearGradientMode), "ForwardDiagonal")> _
    Public Property GradientFillStyle() As LinearGradientMode
        Get
            Return _gradientStyle
        End Get
        Set(ByVal value As LinearGradientMode)
            _gradientStyle = value
            OnGradientChanged(EventArgs.Empty)
        End Set
    End Property

    Private Sub OnGradientChanged(ByVal e As EventArgs)
        RaiseEvent GradientChanged(Me, e)
    End Sub

    Public Sub New()
    End Sub

    Public Sub New(ByVal colorA As Color, ByVal colorB As Color, _
      ByVal gradientFillStyle As LinearGradientMode)
        Me.ColorA = colorA
        Me.ColorB = colorB
        Me.GradientFillStyle = gradientFillStyle
    End Sub

End Class
