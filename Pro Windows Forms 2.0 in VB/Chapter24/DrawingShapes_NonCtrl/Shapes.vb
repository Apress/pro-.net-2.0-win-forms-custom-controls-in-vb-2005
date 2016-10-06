Imports System.Drawing.Drawing2D

<Serializable()> _
Public Class RectangleShape
    Inherits Shape

    Protected Overrides Function GeneratePath() As GraphicsPath
        Dim newPath As New GraphicsPath()
        newPath.AddRectangle(New Rectangle( _
          Location.X, Location.Y, Size.Width, Size.Height))
        Return newPath
    End Function
End Class

<Serializable()> _
Public Class EllipseShape
    Inherits Shape

    Protected Overrides Function GeneratePath() As GraphicsPath
        Dim newPath As New GraphicsPath()
        newPath.AddEllipse(Location.X, Location.Y, Size.Width, Size.Height)
        Return newPath
    End Function
End Class

<Serializable()> _
Public Class TriangleShape
    Inherits Shape

    Protected Overrides Function GeneratePath() As GraphicsPath
        Dim newPath As New GraphicsPath()

        Dim pt1 As New Point(Location.X + Size.Width / 2, Location.Y)
        Dim pt2 As New Point(Location.X, Location.Y + Size.Height)
        Dim pt3 As New Point(Location.X + Size.Width, Location.Y + Size.Height)
        newPath.AddPolygon(New Point() {pt1, pt2, pt3})
        Return newPath
    End Function
End Class
