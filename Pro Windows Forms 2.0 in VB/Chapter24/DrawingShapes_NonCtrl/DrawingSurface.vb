Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Drawing.Drawing2D

Public Class DrawingSurface

    Private shapes As New ShapeCollection()

    Private Sub DrawingSurface_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' Erase the current image.
        e.Graphics.Clear(Color.White)

        ' Ensure shapes on the top obscure shapes on the bottom.
        shapes.ReverseSort()

        ' Ask all the shapes to paint themselves.
        For Each shape As Shape In shapes
            If e.ClipRectangle.IntersectsWith(shape.GetLargestPossibleRegion()) Then
                shape.Render(e.Graphics)
            End If
        Next
    End Sub

    Private currentShape As Shape

    Private Sub ClearSelectedShape()
        If currentShape IsNot Nothing Then
            currentShape.Selected = False

            ' Make sure the display is updated to reflect
            ' newly de-selected shape.
            ' Only use if NO double-buffering.
            Invalidate(currentShape.GetLargestPossibleRegion())
        End If
        currentShape = Nothing
    End Sub

    ' Store the location where the user clicked on the control.
    Private clickOffsetX, clickOffsetY As Integer
    ' Keep track of when drag or resize mode is enabled.
    Private isDragging As Boolean = False
    Private isResizing As Boolean = False
    Private resizingMode As Shape.HitSpot

    Private Sub DrawingSurface_MouseDown(ByVal sender As Object, _
  ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        ' Check for a hit on a focus square.
        Dim hitSpot As Shape.HitSpot

        If currentShape IsNot Nothing AndAlso currentShape.Selected AndAlso _
          currentShape.HitTestFocusBorder(New Point(e.X, e.Y), hitSpot) Then
            ' The border was clicked. Turn on resize mode.
            clickOffsetX = e.X - currentShape.Location.X
            clickOffsetY = e.Y - currentShape.Location.Y
            isResizing = True
        Else
            ' Remove the last selected shape.
            ClearSelectedShape()

            ' Retrieve a reference to the selected shape
            ' using hit testing.
            currentShape = shapes.HitTest(New Point(e.X, e.Y))

            If currentShape Is Nothing Then
                ' No shape was clicked.
                ' Depending on the mouse button, show a menu.
                If e.Button = MouseButtons.Right Then
                    mnuForm.Show(Me, New Point(e.X, e.Y))
                End If
            Else
                ' Select the new shape.
                currentShape.Selected = True

                ' Make sure the display is updated to reflect
                ' newly selected or deselected shapes.
                Invalidate(currentShape.GetLargestPossibleRegion())

                ' Check what action should be performed with the
                ' shape, depending on the mouse button that was clicked.
                If e.Button = MouseButtons.Right Then
                    ' Show the context menu.
                    mnuShape.Show(Me, New Point(e.X, e.Y))
                ElseIf e.Button = MouseButtons.Left Then
                    ' Start dragging mode.
                    clickOffsetX = e.X - currentShape.Location.X
                    clickOffsetY = e.Y - currentShape.Location.Y
                    isDragging = True
                End If
            End If
        End If
    End Sub

    Private Sub mnuColorChange_Click(ByVal sender As Object, _
  ByVal e As EventArgs) Handles toolStripButton1.Click, mnuColorChange.Click
        ' Show color dialog.
        Dim dlgColor As New ColorDialog()
        If dlgColor.ShowDialog() = DialogResult.OK Then
            ' Change shape background.
            currentShape.BackColor = dlgColor.Color
            Invalidate(currentShape.Region)
        End If
    End Sub

    Private Sub mnuRemoveShape_Click(ByVal sender As Object, _
      ByVal e As EventArgs) Handles mnuRemoveShape.Click, cmdDelete.Click
        shapes.Remove(currentShape)
        ClearSelectedShape()
    End Sub

    Private Sub mnuToFront_Click(ByVal sender As Object, _
  ByVal e As EventArgs) Handles mnuToFront.Click, toolStripButton2.Click
        shapes.BringShapeToFront(currentShape)
        Invalidate(currentShape.GetLargestPossibleRegion())
    End Sub

    Private Sub mnuToBack_Click(ByVal sender As Object, _
      ByVal e As EventArgs) Handles mnuToBack.Click, toolStripButton3.Click
        shapes.SendShapeToBack(currentShape)
        Invalidate(currentShape.GetLargestPossibleRegion())
    End Sub

    Private Sub DrawingSurface_MouseMove(ByVal sender As Object, _
  ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If isDragging Then
            Dim oldPosition, newPosition As Rectangle
            oldPosition = currentShape.GetLargestPossibleRegion()
            currentShape.Location = New Point(e.X - clickOffsetX, _
              e.Y - clickOffsetY)

            ' Invalidate a section of the form that includes the old and new
            ' positions.
            newPosition = currentShape.GetLargestPossibleRegion()
            Invalidate(Rectangle.Union(oldPosition, newPosition))
        ElseIf isResizing Then
            Dim minSize As Integer = 5
            Dim oldPosition, newPosition As Rectangle
            oldPosition = currentShape.GetLargestPossibleRegion()

            ' Resize the control, according to the resize mode.
            Select Case resizingMode
                ' Clicks on the top and top-right corner are treated in the same
                ' way. The top edge of the control is selected, and can be dragged
                ' up or down.
                Case Shape.HitSpot.Top, Shape.HitSpot.TopRightCorner
                    ' Before resizing the control, make sure the top edge hasn't
                    ' been dragged below the bottom edge.
                    ' The minimum size forces the shape to be a 5-pixel sliver.
                    If e.Y < (currentShape.Location.Y + _
                      currentShape.Size.Height - minSize) Then
                        ' When the top edge is dragged, you need to change both the
                        ' position of the control and the size to reflect the new
                        ' top edge.
                        currentShape.Size = New Size(currentShape.Size.Width, _
                          currentShape.Location.Y + currentShape.Size.Height - _
                          (e.Y - clickOffsetY))
                        currentShape.Location = New Point(currentShape.Location.X, _
                          e.Y - clickOffsetY)
                    End If
                Case Shape.HitSpot.Bottom
                    If e.Y > (currentShape.Location.Y + minSize) Then
                        currentShape.Size = New Size(currentShape.Size.Width, _
                          e.Y - currentShape.Location.Y)
                    End If
                Case Shape.HitSpot.Left, Shape.HitSpot.BottomLeftCorner, _
                  Shape.HitSpot.TopLeftCorner
                    If e.X < (currentShape.Location.X + _
                      currentShape.Size.Width - minSize) Then
                        currentShape.Size = New Size( _
                          (currentShape.Location.X + currentShape.Size.Width) - _
                          (e.X - clickOffsetX), currentShape.Size.Height)
                        currentShape.Location = New Point(e.X - clickOffsetX, _
                          currentShape.Location.Y)
                    End If
                Case Shape.HitSpot.Right
                    If e.X > (currentShape.Location.X + minSize) Then
                        currentShape.Size = New Size(e.X - currentShape.Location.X, _
                          currentShape.Size.Height)
                    End If
                Case Shape.HitSpot.BottomRightCorner
                    If e.Y > (currentShape.Location.Y + minSize) Then
                        currentShape.Size = New Size(currentShape.Size.Width, _
                          e.Y - currentShape.Location.Y)
                    End If
                    If e.X > (currentShape.Location.X + minSize) Then
                        currentShape.Size = New Size(e.X - currentShape.Location.X, _
                          currentShape.Size.Height)
                    End If
            End Select
            newPosition = currentShape.GetLargestPossibleRegion()
            Invalidate(Rectangle.Union(oldPosition, newPosition))
        Else
            If currentShape IsNot Nothing AndAlso currentShape.Selected _
              AndAlso currentShape.HitTestFocusBorder(New Point(e.X, e.Y), _
                resizingMode) Then

                Select Case resizingMode
                    Case Shape.HitSpot.Top, Shape.HitSpot.Bottom, _
                      Shape.HitSpot.TopRightCorner
                        Cursor = Cursors.SizeNS
                    Case Shape.HitSpot.Left, Shape.HitSpot.Right, _
                      Shape.HitSpot.BottomLeftCorner, Shape.HitSpot.TopLeftCorner
                        Cursor = Cursors.SizeWE
                    Case Shape.HitSpot.BottomRightCorner
                        Cursor = Cursors.SizeNWSE
                    Case Else
                        Cursor = Cursors.Arrow
                End Select
            Else
                Cursor = Cursors.Arrow
            End If
        End If
    End Sub


    Private Sub mnuNewShape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles mnuRectangle.Click, mnuEllipse.Click, mnuTriangle.Click, cmdTriangle.Click, cmdRectangle.Click, cmdEllipse.Click

        ' Create and configure the shape with some defaults.
        Dim newShape As Shape = Nothing
        ' Configure the appropriate shape depending on the menu option selected.
        If sender Is mnuRectangle Or sender Is cmdRectangle Then
            newShape = New RectangleShape()
        ElseIf sender Is mnuEllipse Or sender Is cmdEllipse Then
            newShape = New EllipseShape()
        ElseIf sender Is mnuTriangle Or sender Is cmdTriangle Then
            newShape = New TriangleShape()
        Else
            Throw New ApplicationException("Not a valid shape command.")
        End If

        newShape.Size = New Size(40, 40)
        newShape.ForeColor = Color.Coral

        If TypeOf sender Is ToolStripButton Then
            newShape.Location = New Point(150, 100)
        Else
            ' To determine where to place the shape, you need to convert the 
            ' current screen-based mouse coordinates into relative form coordinates.
            newShape.Location = PointToClient(Control.MousePosition)
        End If

        ' Remove the last selected shape.
        ClearSelectedShape()
        currentShape = newShape
        currentShape.Selected = True

        ' Add the shape to the form and trigger a refresh.
        shapes.Add(newShape)
        Invalidate(newShape.GetLargestPossibleRegion())

    End Sub

    Private Sub DrawingSurface_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        isDragging = False
        isResizing = False
    End Sub


    Private Sub mnuSave_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles mnuSave.Click
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim fs As FileStream = File.Create(saveFileDialog.FileName)
                Using fs
                    Dim f As New BinaryFormatter()
                    f.Serialize(fs, shapes)
                End Using
            Catch err As Exception
                MessageBox.Show("Error while saving. " & err.Message)
            End Try
        End If
    End Sub

    Private Sub mnuLoad_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles mnuLoad.Click
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim newShapes As ShapeCollection = Nothing
            Try
                Dim fs As FileStream = File.Open(openFileDialog.FileName, FileMode.Open)
                Using fs
                    Dim f As New BinaryFormatter()
                    newShapes = CType(f.Deserialize(fs, Nothing), ShapeCollection)
                End Using
            Catch err As Exception
                MessageBox.Show("Error while loading. " & err.Message)
                Return
            End Try

            ' Trigger a refresh.
            shapes = newShapes
            Invalidate()
        End If
    End Sub

    Private Sub newToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNew.Click
        shapes.Clear()
        Invalidate()
    End Sub

End Class
