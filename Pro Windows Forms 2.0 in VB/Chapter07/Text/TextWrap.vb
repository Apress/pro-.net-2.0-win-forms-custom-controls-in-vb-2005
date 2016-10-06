Imports System.Drawing.Text

Public Class TextWrap

    Private Sub lst_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTrimming.SelectedIndexChanged, lstAlignmentV.SelectedIndexChanged, lstAlignmentH.SelectedIndexChanged
        Invalidate()
    End Sub

    Private Sub TextWrap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ResizeRedraw = True
        lstAlignmentH.DataSource = [Enum].GetNames(GetType(StringAlignment))
        lstAlignmentV.DataSource = [Enum].GetNames(GetType(StringAlignment))
        lstTrimming.DataSource = [Enum].GetNames(GetType(StringTrimming))

    End Sub

    Private Sub TextWrap_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim text As String = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."

        Dim stringFormat As New StringFormat()
        ' Center each line of text.
        stringFormat.Alignment = CType( _
          [Enum].Parse(GetType(StringAlignment), lstAlignmentH.Text), _
          StringAlignment)

        ' Center the block of text (top to bottom) in the rectangle.
        stringFormat.LineAlignment = CType( _
           [Enum].Parse(GetType(StringAlignment), lstAlignmentV.Text), _
           StringAlignment)

        ' Set the wrap style.
        stringFormat.Trimming = CType( _
           [Enum].Parse(GetType(StringTrimming), lstTrimming.Text), _
           StringTrimming)

        Dim font As New Font("Verdana", 12)
        Dim rect As New Rectangle(30, 110, Width - 60, Height - 160)
        e.Graphics.DrawString(text, font, Brushes.Black, rect, stringFormat)


        e.Graphics.DrawRectangle(Pens.Black, rect)
        font.Dispose()

    End Sub
End Class
