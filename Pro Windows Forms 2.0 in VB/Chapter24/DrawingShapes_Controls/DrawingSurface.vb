Public Class DrawingSurface

    Private Sub mnuNewShape_Click(ByVal sender As Object, ByVal e As EventArgs) _
      Handles mnuRectangle.Click, mnuTriangle.Click, mnuEllipse.Click
        ' Create and configure the shape with some defaults.
        Dim newShape As New Shape()
        newShape.Size = New Size(40, 40)
        newShape.ForeColor = Color.Coral




        ' Configure the appropriate shape depending on the menu option selected.
        If sender Is mnuRectangle Then
            newShape.Type = Shape.ShapeType.Rectangle
        ElseIf sender Is mnuEllipse Then
            newShape.Type = Shape.ShapeType.Ellipse
        ElseIf sender Is mnuTriangle Then
            newShape.Type = Shape.ShapeType.Triangle
        End If

        ' To determine where to place the shape, you need to convert the 
        ' current screen-based mouse coordinates into relative form coordinates.
        newShape.Location = Me.PointToClient(Control.MousePosition)

        ' Attach a context menu to the shape.
        newShape.ContextMenuStrip = mnuSelectShape

        ' Connect the shape to all its event handlers.
        AddHandler newShape.MouseDown, AddressOf ctrl_MouseDown
        AddHandler newShape.MouseMove, AddressOf ctrl_MouseMove
        AddHandler newShape.MouseUp, AddressOf ctrl_MouseUp

        ' Add the shape to the form.
        Me.Controls.Add(newShape)
    End Sub

    ' Keep track of when drag or resize mode is enabled.
    Private isDragging As Boolean = False
    Private isResizing As Boolean = False

    ' Store the location where the user clicked on the control.
    Private clickOffsetX, clickOffsetY As Integer

    Private Sub ctrl_MouseDown(ByVal sender As Object, _
     ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Retrieve a reference to the active label.
        Dim currentCtrl As Control
        currentCtrl = CType(sender, Control)

        If e.Button = MouseButtons.Right Then
            ' Show the context menu.
            mnuSelectShape.Show(currentCtrl, New Point(e.X, e.Y))
        ElseIf e.Button = MouseButtons.Left Then
            clickOffsetX = e.X
            clickOffsetY = e.Y

            If currentCtrl.Cursor = Cursors.SizeNWSE Or _
              currentCtrl.Cursor = Cursors.SizeNS Or _
              currentCtrl.Cursor = Cursors.SizeWE Then
                ' The mouse pointer is at one of the sides,
                ' so resizing mode is appropriate.
                isResizing = True
            Else
                ' The mouse is somewhere else, so dragging mode is
                ' appropriate.
                isDragging = True
            End If
        End If
    End Sub

    Private Sub ctrl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' Retrieve a reference to the active shape.
        Dim currentCtrl As Control
        currentCtrl = CType(sender, Control)

        If isDragging Then
            ' Move the control.
            currentCtrl.Left = e.X + currentCtrl.Left - clickOffsetX
            currentCtrl.Top = e.Y + currentCtrl.Top - clickOffsetY
        ElseIf isResizing Then
            ' Resize the control, according to the resize mode.
            If currentCtrl.Cursor = Cursors.SizeNWSE Then
                currentCtrl.Width = e.X
                currentCtrl.Height = e.Y
            ElseIf currentCtrl.Cursor = Cursors.SizeNS Then
                currentCtrl.Height = e.Y
            ElseIf currentCtrl.Cursor = Cursors.SizeWE Then
                currentCtrl.Width = e.X
            End If
        Else
            ' Change the cursor if the mouse pointer is on one of the right
            ' and lower edges of the control.
            If (e.X + 5) > currentCtrl.Width And _
               (e.Y + 5) > currentCtrl.Height Then
                currentCtrl.Cursor = Cursors.SizeNWSE
            ElseIf (e.X + 5) > currentCtrl.Width Then
                currentCtrl.Cursor = Cursors.SizeWE
            ElseIf (e.Y + 5) > currentCtrl.Height Then
                currentCtrl.Cursor = Cursors.SizeNS
            Else
                ' This misleadingly named cursor is the four-way
                ' mouse pointer often used for moving objects.
                currentCtrl.Cursor = Cursors.SizeAll
            End If
        End If
    End Sub

    Private Sub ctrl_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        isDragging = False
        isResizing = False
    End Sub

    Private Sub mnuColorChange_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles mnuColorChange.Click
        ' Show color dialog.
        Dim dlgColor As New ColorDialog()
        If dlgColor.ShowDialog() = DialogResult.OK Then
            ' Change shape background.
            Dim ctrl As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
            mnuSelectShape.SourceControl.BackColor = dlgColor.Color
        End If
    End Sub

    Private Sub mnuRemoveShape_Click(ByVal sender As Object, ByVal e As EventArgs) _
  Handles mnuRemoveShape.Click
        Dim ctrlShape As Control = mnuSelectShape.SourceControl
        Me.Controls.Remove(ctrlShape)
    End Sub

    Private Sub mnuBringToFront_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBringToFront.Click
        Dim ctrlShape As Control = mnuSelectShape.SourceControl
        ctrlShape.BringToFront()
    End Sub

    Private Sub mnuSendToBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSendToBack.Click
        Dim ctrlShape As Control = mnuSelectShape.SourceControl
        ctrlShape.SendToBack()
    End Sub
End Class
