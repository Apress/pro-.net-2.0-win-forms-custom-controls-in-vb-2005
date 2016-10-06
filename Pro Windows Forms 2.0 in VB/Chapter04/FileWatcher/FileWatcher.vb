Public Class FileWatcher
    ' Track newly created files here.
    Dim newFiles As New List(Of String)()

    Private Sub fileSystemWatcher1_Changed(ByVal sender As System.Object, ByVal e As System.IO.FileSystemEventArgs) Handles fileSystemWatcher1.Changed
        newFiles.Add(e.Name)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        ' Make sure the icon disappears promptly.
        Me.Dispose()

        Application.Exit()
    End Sub

    Private Sub cmdShowFiles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdShowFiles.Click
        Dim frmFileList As New FileList()
        frmFileList.FillList(newFiles)
        frmFileList.Show()
    End Sub
End Class
