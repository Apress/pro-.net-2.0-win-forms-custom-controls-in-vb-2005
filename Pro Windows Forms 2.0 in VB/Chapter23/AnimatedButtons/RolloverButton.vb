Public Class RolloverButton
    Inherits AnimatedButtonBase

    Private _normalImage As Image
    Private _mouseOverImage As Image
    Private _pushedImage As Image
    Private _disabledImage As Image

    Public Property NormalImage() As Image
        Get
            Return _normalImage
        End Get
        Set(ByVal value As Image)
            _normalImage = value

            ' Just perform this tweak the first time the image is set
            ' at design time.
            If _normalImage IsNot Nothing And DesignMode Then
                Size = New Size( _
                  _normalImage.Size.Width + 10, _normalImage.Size.Height + 2)
            End If
            Invalidate()
        End Set
    End Property

    Public Property MouseOverImage() As Image
        Get
            Return _mouseOverImage
        End Get
        Set(ByVal value As Image)
            _mouseOverImage = value
            Invalidate()
        End Set
    End Property

    Public Property PushedImage() As Image
        Get
            Return _pushedImage
        End Get
        Set(ByVal value As Image)
            _pushedImage = value
            Invalidate()
        End Set
    End Property

    Public Property DisabledImage() As Image
        Get
            Return _disabledImage
        End Get
        Set(ByVal value As Image)
            _disabledImage = value
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub PaintNormal(ByVal g As Graphics)
        If normalImage IsNot Nothing Then
            g.DrawImageUnscaled(NormalImage, New Point(0, 0))
        End If
    End Sub

    Protected Overrides Sub PaintMouseOver(ByVal g As Graphics)
        If MouseOverImage IsNot Nothing Then
            g.DrawImageUnscaled(MouseOverImage, New Point(0, 0))
        ElseIf NormalImage IsNot Nothing Then
            ' If there is no mouse-over image, fall back on the
            ' normal image (if it exists).
            g.DrawImageUnscaled(NormalImage, New Point(0, 0))
        End If
    End Sub

    Protected Overrides Sub PaintPushed(ByVal g As Graphics)
        ' Try pushed, mouse-over, and normal images, in 
        ' that order of preference.
        If PushedImage IsNot Nothing Then
            g.DrawImageUnscaled(PushedImage, New Point(0, 0))
        ElseIf MouseOverImage IsNot Nothing Then
            g.DrawImageUnscaled(MouseOverImage, New Point(0, 0))
        ElseIf NormalImage IsNot Nothing Then
            g.DrawImageUnscaled(NormalImage, New Point(0, 0))
        End If
    End Sub

    Protected Overrides Sub PaintDisabled(ByVal g As Graphics)
        If DisabledImage IsNot Nothing Then
            g.DrawImageUnscaled(DisabledImage, New Point(0, 0))
        Else
            If normalImage IsNot Nothing Then
                ' Fake a disabled image.
                ' Serveral techniques are possible, but this is the easiest.
                ControlPaint.DrawImageDisabled(g, NormalImage, 0, 0, BackColor)
            End If
        End If
    End Sub

End Class