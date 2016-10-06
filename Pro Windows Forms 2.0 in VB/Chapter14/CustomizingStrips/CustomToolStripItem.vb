Public Class CustomToolStripItem

    Private item As ToolStripControlHost
    Private Sub CustomToolStripItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DateTimePicker()
        dt.Value = DateTime.Now
        dt.Format = DateTimePickerFormat.Short
        dt.Width /= 2
        item = New ToolStripControlHost(dt)
        toolStrip1.Items.Add(item)
    End Sub

    Private Sub toolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
      Handles toolStripButton1.Click, toolStripButton2.Click
        MessageBox.Show("The current date is " & item.Text)
        MessageBox.Show("The current date format is " & _
          CType(item.Control, DateTimePicker).Format.ToString())

    End Sub
End Class