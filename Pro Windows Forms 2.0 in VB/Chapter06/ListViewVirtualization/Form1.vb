Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listView.VirtualMode = True
        listView.VirtualListSize = NorthwindDB.GetOrdersCount()

        ' Suspending automatic refreshes as items are added/removed.
        listView.BeginUpdate()

        ' Add column headers for Details view.
        listView.Columns.Add("ID", 100, HorizontalAlignment.Left)
        listView.Columns.Add("ShippedDate", 100, HorizontalAlignment.Left)

        ' Re-enable the display.
        listView.EndUpdate()
    End Sub
    Private dtCachedItems As DataTable

    Private Sub listView_RetrieveVirtualItem(ByVal sender As Object, _
      ByVal e As RetrieveVirtualItemEventArgs) _
      Handles listView.RetrieveVirtualItem

        ' Check whether the item is in the local cache.
        ' Remember to add 1 to the index because SQL Server counts from 1 up,
        ' while the ListView counts from 0.
        Dim match As DataRow = Nothing
        If dtCachedItems IsNot Nothing Then
            match = dtCachedItems.Rows.Find(e.ItemIndex + 1)
        End If

        If match Is Nothing Then
            ' The item isn't in memory.
            ' Get a new range of 100 records.
            Dim fromNumber, toNumber As Integer
            If e.ItemIndex < 50 Then
                fromNumber = 0
            Else
                fromNumber = e.ItemIndex - 50
            End If

            toNumber = fromNumber + 100
            dtCachedItems = NorthwindDB.GetOrders(fromNumber, toNumber)
            match = dtCachedItems.Rows.Find(e.ItemIndex + 1)

            lblStatus.Text = String.Format( _
              "Fetched rows from {0} to {1}.", _
              fromNumber.ToString(), toNumber.ToString())
        End If

        ' Create the ListViewItem for the matching record.
        e.Item = New ListViewItem(match("OrderID").ToString(), 0)
        e.Item.SubItems.Add(match("ShippedDate").ToString())
    End Sub

End Class
