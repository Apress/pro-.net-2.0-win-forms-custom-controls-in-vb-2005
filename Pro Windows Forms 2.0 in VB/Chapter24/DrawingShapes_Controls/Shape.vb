Imports System.Drawing.Drawing2D

Public Class Shape
    Inherits System.Windows.Forms.Control

    ' The types of shapes supported by this control.
    Public Enum ShapeType
        Rectangle
        Ellipse
        Triangle
    End Enum

    ' The current shape.
    Private shape As ShapeType = ShapeType.Rectangle
    Private path As GraphicsPath

    Public Property Type() As ShapeType
        Get
            Return shape
        End Get
        Set(ByVal value As ShapeType)
            shape = value
            RefreshPath()
            Me.Invalidate()
        End Set
    End Property

    ' Create the corresponding GraphicsPath for the shape, and apply
    ' it to the control by setting the Region property.
    Private Sub RefreshPath()
        If path IsNot Nothing Then path.Dispose()
        path = New GraphicsPath()

        Select Case shape
            Case ShapeType.Rectangle
                path.AddRectangle(Me.ClientRectangle)
            Case ShapeType.Ellipse
                path.AddEllipse(Me.ClientRectangle)
            Case ShapeType.Triangle
                Dim pt1 As Point = New Point(Me.Width / 2, 0)
                Dim pt2 As Point = New Point(0, Me.Height)
                Dim pt3 As Point = New Point(Me.Width, Me.Height)
                path.AddPolygon(New Point() {pt1, pt2, pt3})
        End Select

        Me.Region = New Region(path)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        If path IsNot Nothing Then
            Dim shapeBrush As New SolidBrush(Me.BackColor)
            Dim shapePen As New Pen(Me.ForeColor, 5)

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.FillPath(shapeBrush, path)
            e.Graphics.DrawPath(shapePen, path)

            shapePen.Dispose()
            shapeBrush.Dispose()
        End If
    End Sub

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        RefreshPath()
        Me.Invalidate()
    End Sub

End Class
