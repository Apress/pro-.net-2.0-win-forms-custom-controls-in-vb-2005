Imports System.Windows.Forms.VisualStyles

Public Class SimpleChart
    Inherits Control

    ' This prevents serialization errors by telling Visual Studio
    ' not to serialize the Bars property. Refer to Chapter 26
    ' for an advanced example that solves this problem
    ' and allows design-time chart creation.
    Public Function ShouldSerializeBars() As Boolean
        Return False
    End Function
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private components As System.ComponentModel.IContainer

    Private _bars As New List(Of BarItem)()
    Public Property Bars() As List(Of BarItem)
        Get
            Return _bars
        End Get
        Set(ByVal value As List(Of BarItem))
            _bars = value
        End Set
    End Property

    Public Sub New()
        DoubleBuffered = True
        initializecomponents()
    End Sub

    Private barRectangles As New List(Of Rectangle)()

    Public Sub RebuildChart()
        If Bars.Count = 0 Then Return

        ' Find out how much space a single bar can occupy.
        Dim barWidth As Integer = Int(Width / Bars.Count)

        ' Set the maximum value on the chart.
        Dim maxValue As Single = 0
        For Each bar As BarItem In Bars
            If bar.Value > maxValue Then
                maxValue = bar.Value
            End If
        Next

        ' Create the rectangle shapes and store them for later use.
        ' Clear any existing shapes.
        barRectangles.Clear()

        ' Track the x-coordinate while laying out the bars.
        Dim x As Integer = 0

        ' Leave some space at the top.
        Dim topMargin As Integer = 5

        ' Leave some space between bars.
        Dim barGap As Integer = 4

        For Each bar As BarItem In Bars
            Dim barHeight As Integer = Int(bar.Value / maxValue * (Me.Height - topMargin))
            Dim top As Integer = Me.Height - barHeight

            barRectangles.Add(New Rectangle(x + barGap / 2, top, _
              barWidth - barGap, barHeight))
            x += barWidth
        Next

        ' Trigger a repaint.
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        If Application.RenderWithVisualStyles Then
            ' Use part of the current theme.
            Dim renderer As New VisualStyleRenderer( _
          VisualStyleElement.ExplorerBar.NormalGroupBackground.Normal)
            renderer.DrawBackground(e.Graphics, e.ClipRectangle)
        Else
            ' Use a solid fill with the BackColor.
            Dim brush As New SolidBrush(MyBase.BackColor)
            e.Graphics.FillRectangle(brush, e.ClipRectangle)
            brush.Dispose()
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        If Bars.Count = 0 Then Return

        For Each rect As Rectangle In barRectangles
            If Application.RenderWithVisualStyles Then
                Dim renderer As New VisualStyleRenderer( _
                  VisualStyleElement.StartPanel.UserPane.Normal)
                renderer.DrawBackground(e.Graphics, rect)
            Else
                ' Draw bar (two rectangles are used for a shadowed effect).
                Dim shadowMargin As Integer = 4
                Dim rectShadow As Rectangle = rect
                rectShadow.Offset(shadowMargin, shadowMargin)

                e.Graphics.FillRectangle(Brushes.White, rectShadow)
                e.Graphics.FillRectangle(Brushes.SteelBlue, rect)
            End If
        Next
        Dim index As Integer = 0
        For Each rect As Rectangle In barRectangles
            ' Get title.
            Dim text As String = Bars(index).ShortForm

            ' Get the position.
            Dim textTopOffset As Integer = 10
            Dim textLeftOffset As Integer = 15
            Dim ptText As Point = rect.Location
            ptText.Offset(textTopOffset, textLeftOffset)

            ' Draw the title.
            e.Graphics.DrawString(text, Font, Brushes.White, ptText)
            index += 1
        Next

        ' Draw bottom line of the the grid.
        Dim pen As New Pen(Color.Black, 3)
        e.Graphics.DrawLine(pen, 0, MyBase.Height - 1, _
          MyBase.Width, MyBase.Height - 1)
        pen.Dispose()
    End Sub

    Private Sub InitializeComponents()
        Me.components = New System.ComponentModel.Container
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        Me.ResumeLayout(False)
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        ' Hit test all the bars.
        Dim index As Integer = 0
        For Each rect As Rectangle In barRectangles
            If rect.Contains(e.Location) Then
                ' Get matching value.
                Dim text As String = String.Format("{0:C}", Bars(index).Value)

                ' Get point relative to the top-left corner of the form
                ' (currently the point is relative to the top-left corner
                ' of the chart control).
                Dim pt As Point = e.Location
                pt.Offset(MyBase.Location)
                toolTip1.Show(text, MyBase.FindForm(), pt)
                Return
            End If
            index += 1
        Next

        ' No bar found.
        toolTip1.Hide(MyBase.FindForm())
    End Sub

End Class
