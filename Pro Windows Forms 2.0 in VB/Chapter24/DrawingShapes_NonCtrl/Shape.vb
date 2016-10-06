Imports System.Drawing.Drawing2D

<Serializable()> _
Public MustInherit Class Shape
    Implements IComparable

    Private _foreColor As Color
    Public Property ForeColor() As Color
        Get
            Return _foreColor
        End Get
        Set(ByVal value As Color)
            _foreColor = value
        End Set
    End Property

    Private _backColor As Color
    Public Property BackColor() As Color
        Get
            Return _backColor
        End Get
        Set(ByVal value As Color)
            _backColor = value
        End Set
    End Property

    Private _size As Size
    Public Property Size() As Size
        Get
            Return _size
        End Get
        Set(ByVal value As Size)
            _size = value
            _path = Nothing
        End Set
    End Property

    Private _location As Point
    Public Property Location() As Point
        Get
            Return _location
        End Get
        Set(ByVal value As Point)
            _location = value
            _path = Nothing
        End Set
    End Property

    ' Even internally, all access to the path should
    ' go through the Path property, so that the path
    ' is regenerated if null.
    <NonSerialized()> Private _path As GraphicsPath
    Public ReadOnly Property Path() As GraphicsPath
        Get
            ' The path is refreshed automatically
            ' as needed.
            If _path Is Nothing Then
                RefreshPath()
            End If
            Return _path
        End Get
    End Property

    ' Create the corresponding GraphicsPath for the shape.
    Private Sub RefreshPath()
        _path = GeneratePath()
    End Sub
    Protected MustOverride Function GeneratePath() As GraphicsPath

    Private _selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _selected
        End Get
        Set(ByVal value As Boolean)
            _selected = value
        End Set
    End Property

    ' These details could be wrapped in properties
    ' to provide more customization for line thickness
    ' and border patterns.
    Private penThickness As Integer = 3
    Private focusBorderSpace As Integer = 5
    <NonSerialized()> Private outlinePen As Pen

    Public Sub Render(ByVal g As Graphics)
        If outlinePen IsNot Nothing Then outlinePen.Dispose()
        outlinePen = New Pen(ForeColor, penThickness)
        Dim surfaceBrush As New SolidBrush(BackColor)

        ' Paint the shape.
        g.FillPath(surfaceBrush, Path)
        g.DrawPath(outlinePen, Path)

        ' If required, paint the focus box.
        If Selected Then
            Dim rect As Rectangle = Rectangle.Round(Path.GetBounds())
            rect.Inflate(New Size(focusBorderSpace, focusBorderSpace))
            ControlPaint.DrawFocusRectangle(g, rect)
        End If
        surfaceBrush.Dispose()
    End Sub

    ' Check if the point is in the shape.
    Public Overridable Function HitTest(ByVal point As Point) As Boolean
        Return Path.IsVisible(point)
    End Function

    ' Check if the point is in the outline of the shape.
    Public Overridable Function HitTestBorder(ByVal point As Point) As Boolean
        Return Path.IsOutlineVisible(point, outlinePen)
    End Function

    Public Enum HitSpot
        Top
        Bottom
        Left
        Right
        TopLeftCorner
        BottomLeftCorner
        TopRightCorner
        BottomRightCorner
        None
    End Enum

    Public Function HitTestFocusBorder(ByVal point As Point, _
  ByRef hitSpot As HitSpot) As Boolean
        hitSpot = hitSpot.None

        ' Ignore controls that don't have a focus square.
        If Not Selected Then
            Return False
        Else
            Dim rectInner As Rectangle = Rectangle.Round(Path.GetBounds())
            Dim rectOuter As Rectangle = rectInner
            rectOuter.Inflate(New Size(focusBorderSpace, focusBorderSpace))

            If rectOuter.Contains(point) And Not rectInner.Contains(point) Then
                ' Point is on (or close enough) to the focus square.
            Else
                Return False
            End If
            Dim top As Boolean = False
            Dim bottom As Boolean = False
            Dim left As Boolean = False
            Dim right As Boolean = False

            ' Check the point against all edges.
            If Math.Abs(point.X - Location.X) < focusBorderSpace Then
                left = True
            End If
            If Math.Abs(point.X - (Location.X + Size.Width)) < focusBorderSpace Then
                right = True
            End If
            If Math.Abs(point.Y - Location.Y) < focusBorderSpace Then
                top = True
            End If
            If Math.Abs(point.Y - (Location.Y + Size.Height)) < focusBorderSpace Then
                bottom = True
            End If

            ' Determine the hit spot based on the edges that are close.
            If top And left Then
                hitSpot = hitSpot.TopLeftCorner
            ElseIf top And right Then
                hitSpot = hitSpot.TopRightCorner
            ElseIf bottom And left Then
                hitSpot = hitSpot.BottomLeftCorner
            ElseIf bottom And right Then
                hitSpot = hitSpot.BottomRightCorner
            ElseIf top Then
                hitSpot = hitSpot.Top
            ElseIf bottom Then
                hitSpot = hitSpot.Bottom
            ElseIf left Then
                hitSpot = hitSpot.Left
            ElseIf right Then
                hitSpot = hitSpot.Right
            End If

            If hitSpot = hitSpot.None Then
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Public Function GetLargestPossibleRegion() As Rectangle
        Dim rect As Rectangle = Rectangle.Round(Path.GetBounds())
        ' The +10 corrects for squashed triangles, where
        ' the corner pokes out of the bounding box.
        rect.Inflate(New Size(focusBorderSpace + 10, focusBorderSpace + 10))
        Return rect
    End Function

    Private _zOrder As Integer
    Public Property ZOrder() As Integer
        Get
            Return _zOrder
        End Get
        Set(ByVal value As Integer)
            _zOrder = value
        End Set
    End Property

    Public Function CompareTo(ByVal obj As Object) As Integer _
      Implements System.IComparable.CompareTo
        Return ZOrder.CompareTo(CType(obj, Shape).ZOrder)
    End Function

    <NonSerialized()> _
    Private _region As Region
    Public ReadOnly Property Region() As Region
        Get
            If _region Is Nothing Then
                _region = New Region(Path)
            End If
            Return _region
        End Get
    End Property
End Class
