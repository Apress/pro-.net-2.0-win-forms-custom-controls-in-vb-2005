Public Class PopImageButton
    Inherits AnimatedButtonBase

    Private _image As Image
    Private _bounds As Rectangle

    Public Property Image() As Image
        Get
            Return _image
        End Get
        Set(ByVal value As Image)
            _image = value
            If Image IsNot Nothing Then
                _bounds = New Rectangle(0, 0, Image.Width + 5, Image.Height + 5)
            End If

            Invalidate()
        End Set
    End Property

    Protected Overrides Function HitTest(ByVal X As Integer, ByVal Y As Integer) _
  As Boolean
        ' Check if the mouse pointer is over the button.
        If Image Is Nothing Then
            Return False
        Else
            Return _bounds.Contains(X, Y)
        End If
    End Function

    Protected Overrides Sub PaintNormal(ByVal g As Graphics)
        If Image IsNot Nothing Then g.DrawImage(Image, 2, 2)
        PaintText(g)
    End Sub

    Protected Overrides Sub PaintMouseOver(ByVal g As Graphics)
        If Image IsNot Nothing Then
            ControlPaint.DrawBorder3D(g, _bounds, _
              Border3DStyle.Raised, Border3DSide.All)
            g.DrawImage(Image, 2, 2)
        End If
        PaintText(g)
    End Sub

    Protected Overrides Sub PaintPushed(ByVal g As Graphics)
        If Image IsNot Nothing Then
            ControlPaint.DrawBorder3D(g, _bounds, _
              Border3DStyle.Sunken, Border3DSide.All)
            g.DrawImage(Image, 3, 3)
        End If
        PaintText(g)
    End Sub

    Protected Overrides Sub PaintDisabled(ByVal g As Graphics)
        If Image IsNot Nothing Then
            ControlPaint.DrawImageDisabled(g, Image, 2, 2, _
              BackColor)
        End If
        PaintText(g)
    End Sub

    Private Sub PaintText(ByVal g As Graphics)
        ' If there is no image, center the text (vertically) between
        ' the borders of the control.
        ' If there is an image, center the text to the midline of the image.
        Dim y As Integer = 0
        If Image Is Nothing Then
            y = Height
        Else
            y = Bounds.Height
        End If

        Dim brush As New SolidBrush(ForeColor)
        g.DrawString(Text, Font, _
          brush, _bounds.Width + 3, (y - Font.Height) / 2)
        brush.Dispose()
    End Sub

End Class