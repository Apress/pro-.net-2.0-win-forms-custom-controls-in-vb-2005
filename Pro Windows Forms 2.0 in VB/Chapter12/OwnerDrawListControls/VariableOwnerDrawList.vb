Imports System.Drawing.Text

Public Class VariableOwnerDrawList

    Private Sub VariableOwnerDrawList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim families As New InstalledFontCollection()

        For Each family As FontFamily In families.Families
            Try
                Dim font As New Font(family.Name, 12)
                Dim item As New FormattedListItemWrapper(family.Name, font)
                listBox1.Items.Add(item)
            Catch err As ArgumentException
                ' An error occurs if the font doesn't support normal
                ' typeface or 12-point size. Ignore this font.
            End Try
        Next
    End Sub

    Private Sub listBox1_MeasureItem(ByVal sender As Object, _
  ByVal e As MeasureItemEventArgs) Handles listBox1.MeasureItem
        Dim list As ListBox = CType(sender, ListBox)

        If TypeOf list.Items(e.Index) Is FormattedListItemWrapper Then

            Dim item As FormattedListItemWrapper
            item = CType(list.Items(e.Index), FormattedListItemWrapper)

            If item.Font IsNot Nothing Then
                ' Get the height from the current item's font.
                e.ItemHeight = item.Font.Height
                Return
            End If
        End If

        ' If item or font information can't be found, use the default..
        e.ItemHeight = 15
    End Sub

    Private Sub listBox1_DrawItem(ByVal sender As Object, _
  ByVal e As DrawItemEventArgs) Handles listBox1.DrawItem
        Dim list As ListBox = CType(sender, ListBox)

        Dim item As FormattedListItemWrapper = Nothing
        If TypeOf list.Items(e.Index) Is FormattedListItemWrapper Then
            item = CType(list.Items(e.Index), FormattedListItemWrapper)
        End If

        Dim font As Font = Nothing
        Dim foreColor As Color = Color.Empty
        Dim backColor As Color = Color.Empty

        If item IsNot Nothing Then
            font = item.Font
            foreColor = item.ForeColor
            backColor = item.BackColor
        End If

        ' The font could be null if there is no ListItemWrapper or the 
        ' ListItemWrapper doesn't specify a font.
        If font Is Nothing Then
            ' Use the ListBox font if no custom font is provided.
            font = list.Font
        End If

        ' The color could be empty if there is no ListItemWrapper or the
        ' ListItemWrapper doesn't specify a color.
        Dim brush As Brush
        If foreColor = Color.Empty Then
            ' Use the default color.
            brush = Brushes.Black
        Else
            ' Use the custom color.
            brush = New SolidBrush(item.ForeColor)
        End If

        ' Override the color if the item is selected.
        ' Alternatively, you could add SelectedForeColor and
        ' SelectedBackColor properties to the wrapper.
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            brush = Brushes.White
        End If

        ' Paint the background.
        If backColor = Color.Empty Then
            e.DrawBackground()
        Else
            Dim brushBackground As New SolidBrush(item.BackColor)
            e.Graphics.FillRectangle(brushBackground, e.Bounds)
        End If

        ' Draw the item text.
        Dim text As String = list.Items(e.Index).ToString()
        e.Graphics.DrawString(text, font, _
          brush, e.Bounds.X, e.Bounds.Y)
    End Sub

End Class