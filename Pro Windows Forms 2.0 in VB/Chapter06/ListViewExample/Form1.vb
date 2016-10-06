Public Class Form1

    Private Sub cmdFillList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFillList.Click
        FillList()
    End Sub

    Private Sub NewView(ByVal sender As Object, ByVal e As System.EventArgs) _
  Handles optTile.CheckedChanged, optSmallIcon.CheckedChanged, _
  optList.CheckedChanged, optLargeIcon.CheckedChanged, _
  optDetails.CheckedChanged

        ' Set the current view mode based on the number in the tag value of the
        ' selected radio button.
        Dim ctrl As Control = CType(sender, Control)
        listView.View = CType(ctrl.Tag, View)

        ' Display the current view style.
        Me.Text = "Using View: " & listView.View.ToString()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listView.View = View.Tile
        listView.TileSize = New Size(300, 50)
        optLargeIcon.Tag = View.LargeIcon
        optSmallIcon.Tag = View.SmallIcon
        optDetails.Tag = View.Details
        optList.Tag = View.List
        optTile.Tag = View.Tile
        FillList()
    End Sub

    Private Sub FillList()

        listView.Items.Clear()

        ' Create groups if needed. They only
        ' appear is ShowGroups is true.
        If listView.Groups.Count = 0 Then
            Dim dt As DataTable = StoreDB.GetCategories()
            For Each dr As DataRow In dt.Rows
                listView.Groups.Add(dr("CategoryID").ToString(), _
                  dr("CategoryName").ToString())
            Next
        End If
        ' Turn groups on or off.
        listView.ShowGroups = chkGroups.Checked

        Dim dtProducts As DataTable = StoreDB.GetProducts()

        ' Suspending automatic refreshes as items are added/removed.
        listView.BeginUpdate()

        ' Add column headers for Details view (if they haven't been added before).
        If listView.Columns.Count = 0 Then
            listView.Columns.Add("Product", 100, HorizontalAlignment.Left)
            listView.Columns.Add("ID", 100, HorizontalAlignment.Left)
            listView.Columns.Add("Description", 100, HorizontalAlignment.Left)
        End If

        For Each dr As DataRow In dtProducts.Rows
            Dim listItem As New ListViewItem(dr("ModelName").ToString())
            listItem.ImageIndex = 0

            ' Put it in the appropriate group.
            ' (Only has an effect if ShowGroups is true.)
            listItem.Group = listView.Groups(dr("CategoryID").ToString())

            ' Add subitems for Details view.
            listItem.SubItems.Add(dr("ProductID").ToString())
            listItem.SubItems.Add(dr("Description").ToString())

            listView.Items.Add(listItem)
        Next

        ' Re-enable the display.
        listView.EndUpdate()
    End Sub

    Private Sub listView_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles listView.ColumnClick

        If listView.ListViewItemSorter IsNot Nothing AndAlso _
          TypeOf listView.ListViewItemSorter Is ListViewItemComparer Then
            ' The list is sorted with ListViewItemSorter.
            ' But is it on this column?
            Dim sorter As ListViewItemComparer
            sorter = CType(listView.ListViewItemSorter, ListViewItemComparer)

            If sorter.Column = e.Column And Not sorter.Descending Then
                ' The list is already sorted on this column.
                ' Time to flip the sort.
                sorter.Descending = True

                ' Keep the ListView.Sorting property
                ' synchronized, just for tidiness.
                listView.Sorting = SortOrder.Descending
            Else
                listView.Sorting = SortOrder.Ascending
                sorter.Descending = False
                sorter.Column = e.Column
            End If

        Else
            ' No ListViewItemSorter sort is applied.
            ' Use the default sort.
            Dim sorter As New ListViewItemComparer(e.Column)
            listView.ListViewItemSorter = sorter
        End If

        ' Perform the sort.
        listView.Sort()

    End Sub

    Private Sub cmdResizeColumns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdResizeColumns.Click
        listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Private Sub listView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listView.SelectedIndexChanged
        If listView.SelectedItems.Count > 0 Then
            txtSelected.Text = listView.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub chkGroups_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGroups.CheckedChanged
        FillList()
    End Sub
End Class
