Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dirTree As New DirectoryTreeControl.DirectoryTree()
        dirTree.Size = New Size(Me.Width - 30, Me.Height - 60)
        dirTree.Location = New Point(5, 5)
        dirTree.Drive = "C"
        Me.Controls.Add(dirTree)
    End Sub
End Class
