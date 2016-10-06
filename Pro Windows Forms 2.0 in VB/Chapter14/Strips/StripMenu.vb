Imports System.Drawing.Text

Public Class StripMenu

    Private Sub StripMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Create the font collection.
        Dim fontFamilies As New InstalledFontCollection()

        ' Iterate through all font families.
        For Each family As FontFamily In fontFamilies.Families
            Try
                ' Create a ToolStripMenuItem that will display text in this font.
                Dim item As New ToolStripMenuItem(family.Name)
                item.Font = New Font(family, 8)

                ' Only get from A-B (save time).
                If family.Name(0) = "C" Then Exit For

                mnuFont.DropDownItems.Add(item)
            Catch
                ' An error will occur if the selected font does
                ' not support normal style (the default used when
                ' creating a Font object). This problem can be
                ' harmlessly ignored.
            End Try
        Next

        ' Create the table-like File menu.
        ' Create a new drop-down menu.
        Dim menu As New ToolStripDropDown()

        ' Copy the existing items.
        Dim items(fileToolStripMenuItem.DropDown.Items.Count - 1) As ToolStripItem
        fileToolStripMenuItem.DropDown.Items.CopyTo(items, 0)

        ' Transfer the items into the drop-down menu.
        For Each item As ToolStripItem In items
            If Not TypeOf item Is ToolStripSeparator Then menu.Items.Add(item)
        Next

        ' Adjust the layout of the new menu.
        menu.LayoutStyle = ToolStripLayoutStyle.Table
        CType(menu.LayoutSettings, TableLayoutSettings).ColumnCount = 2

        ' Attach it to the File menu.
        fileToolStripMenuItem.DropDown = menu

    End Sub
End Class