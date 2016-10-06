Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D

Namespace DataGridViewCustomization
	Public Partial Class CellPainting : Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub CellPainting_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			dataGridView1.DataSource = Program.StoreDB.GetProducts()

		End Sub


		Private Sub dataGridView1_CellPainting(ByVal sender As Object, ByVal e As DataGridViewCellPaintingEventArgs) Handles dataGridView1.CellPainting
			' Only paint the desired column and
			' don't paint headers.
            If (e.ColumnIndex = 0) And (e.RowIndex >= 0) Then
                ' If the cell is selected, use the normal painting
                ' instead of the custom painting.
                If (e.State And DataGridViewElementStates.Selected) <> DataGridViewElementStates.Selected Then
                    ' Suppress normal cell painting.
                    e.Handled = True

                    ' Get the rectangle where painting will take place.
                    Dim rect As Rectangle = New Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1)

                    ' Render the custom cell background.
                    Using brush As LinearGradientBrush = New LinearGradientBrush(rect, Color.White, Color.YellowGreen, 35.0F)
                        e.Graphics.FillRectangle(brush, rect)
                    End Using

                    ' Paint the cell text, the border, and the error icon (if needed).
                    ' Don't worry about the focus rectangle or selection background,
                    ' because we aren't painting selected cells.
                    e.Paint(e.ClipBounds, DataGridViewPaintParts.ContentForeground Or DataGridViewPaintParts.Border Or DataGridViewPaintParts.ErrorIcon Or DataGridViewPaintParts.Focus)
                End If
            End If
		End Sub
	End Class
End Namespace