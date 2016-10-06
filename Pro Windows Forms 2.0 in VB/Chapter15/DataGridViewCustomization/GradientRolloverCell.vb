Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.Drawing

Public Class GradientRolloverCell
    Inherits DataGridViewTextBoxCell
    Private Shared inCell As Integer = -1

    Protected Overrides Sub OnMouseEnter(ByVal rowIndex As Integer)
        inCell = rowIndex

        ' Invalidate the cell.
        Me.DataGridView.InvalidateCell(Me.ColumnIndex, rowIndex)
    End Sub

    Protected Overrides Sub OnMouseLeave(ByVal rowIndex As Integer)
        inCell = -1

        ' Invalidate the cell.
        Me.DataGridView.InvalidateCell(Me.ColumnIndex, rowIndex)
    End Sub

    Protected Overrides Sub Paint(ByVal graphics As System.Drawing.Graphics, ByVal clipBounds As System.Drawing.Rectangle, ByVal cellBounds As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
        ' Is the mouse hovering over this cell?
        If (inCell = rowIndex) AndAlso ((cellState And DataGridViewElementStates.Selected) <> DataGridViewElementStates.Selected) Then
            ' Get the rectangle where painting will take place.
            Dim rect As Rectangle = New Rectangle(cellBounds.X, cellBounds.Y, cellBounds.Width - 1, cellBounds.Height - 1)

            ' Render the custom cell background.
            Dim gradientColor As Color
            Dim gradientColumn As GradientRolloverColumn = TryCast(Me.OwningColumn, GradientRolloverColumn)
            If Not gradientColumn Is Nothing Then
                gradientColor = (CType(MyBase.OwningColumn, GradientRolloverColumn)).GradientColor
            Else
                gradientColor = Color.Blue
            End If


            Using brush As LinearGradientBrush = New LinearGradientBrush(rect, Color.White, gradientColor, 35.0F)
                graphics.FillRectangle(brush, rect)
            End Using

            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts And Not (DataGridViewPaintParts.Background Or DataGridViewPaintParts.SelectionBackground))
        Else
            ' Perform the standard painting.
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        End If
    End Sub
End Class

Public Class GradientRolloverColumn
    Inherits System.Windows.Forms.DataGridViewColumn

    Public Sub New(ByVal gradientColor As Color)
        Me.GradientColor = gradientColor
        MyBase.CellTemplate = New GradientRolloverCell()
    End Sub

    Private color As Color
    Public Property GradientColor() As Color
        Get
            Return color
        End Get
        Set(ByVal value As Color)
            color = value
        End Set
    End Property

End Class


