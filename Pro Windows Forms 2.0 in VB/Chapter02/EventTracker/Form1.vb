Public Class Form1

    Private Sub Log(ByVal data As String)
        lstLog.Items.Add(data)
        Dim itemsPerPage As Integer = lstLog.Height / lstLog.ItemHeight
        lstLog.TopIndex = lstLog.Items.Count - itemsPerPage
    End Sub

    Private Sub txt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt.KeyDown
        Log("Key Down: " & e.KeyCode.ToString() & e.KeyValue.ToString())
    End Sub

    Private Sub txt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt.KeyPress
        Log("Key Press: " & e.KeyChar.ToString())
    End Sub

    Private Sub txt_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt.KeyUp
        Log("Key Up: " & e.KeyCode.ToString() & e.KeyValue.ToString() & " Text is: " & txt.Text)
    End Sub

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt.TextChanged
        Log("Changed: " & " Text is: " & txt.Text)
    End Sub

    Private Sub pic_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.MouseEnter, cmd.MouseEnter
        Log("Mouse Enter")
    End Sub

    Private Sub pic_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.MouseHover, cmd.MouseHover
        Log("Mouse Hover")
    End Sub

    Private Sub pic_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.MouseLeave, cmd.MouseLeave
        Log("Mouse Leave")
    End Sub

    Private Sub pic_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseDown
        Log("Mouse Down: X=" & e.X.ToString() & " Y=" & e.Y.ToString() & " Button=" & e.Button.ToString())
    End Sub

    Private Sub pic_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseUp
        Log("Mouse Up: X=" & e.X.ToString() & " Y=" & e.Y.ToString() & " Button=" & e.Button.ToString())
    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click, cmd.Click
        Log("Click")
    End Sub

    Private Sub pic_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.DoubleClick
        Log("Double Click")
    End Sub
End Class
