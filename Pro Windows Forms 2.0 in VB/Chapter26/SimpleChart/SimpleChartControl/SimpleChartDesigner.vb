Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel
Imports System.ComponentModel.Design

Public Class SimpleChartDesigner
    Inherits System.Windows.Forms.Design.ControlDesigner
    Private pen As Pen

    Public Overrides Sub Initialize(ByVal c As IComponent)
        MyBase.Initialize(c)
        pen = New Pen(Color.Red)
        pen.DashStyle = DashStyle.Dash
    End Sub

    Protected Overrides Sub OnPaintAdornments(ByVal pe As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintAdornments(pe)

        ' Add a border at design-time.
        pe.Graphics.DrawRectangle(pen, 0, 0, Control.Width - 1, Control.Height - 1)
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not pen Is Nothing Then
                pen.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Protected Overrides Function GetHitTest(ByVal point As System.Drawing.Point) As Boolean
        point = Control.PointToClient(point)

        Dim chart As SimpleChart = CType(Component, SimpleChart)
        Dim bar As BarItem = chart.HitTest(point)

        ' If the mouse is positioned over a bar,
        ' allow the mouse events to occur.
        Return (Not bar Is Nothing)
    End Function

End Class

