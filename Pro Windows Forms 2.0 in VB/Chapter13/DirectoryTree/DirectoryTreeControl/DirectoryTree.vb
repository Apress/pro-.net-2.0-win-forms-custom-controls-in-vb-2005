Imports System.IO
Imports System.ComponentModel
Imports System.Drawing.Design

<ToolboxBitmap(GetType(DirectoryTree), "DirectoryTree.bmp")> _
<DefaultEvent("DirectorySelected")> _
<DefaultProperty("Drive")> _
Public Class DirectoryTree
    Inherits TreeView

    Private _drive As Char

    '<TypeConverter(GetType(DriveCharConverter))> _
    <Editor(GetType(DriveEditor), GetType(UITypeEditor))> _
    Public Property Drive() As Char
        Get
            Return _drive
        End Get
        Set(ByVal value As Char)
            _drive = value
            RefreshDisplay()
        End Set
    End Property

    ' This is public so a refresh can be triggered manually.
    Public Sub RefreshDisplay()
        ' Nodes aren't generated at design-time.
        ' Instead, they're created at runtime.
        ' Otherwise, these nodes will be serialized
        ' into the designer code, which isn't what we want.
        ' A more elegant approach is to use a control designer,
        ' as shown in the version of the DirectoryTree control
        ' used in Chapter 26.
        If Me.DesignMode Then Return

        ' Erase the existing tree.
        Nodes.Clear()

        ' Set the first node.
        Dim rootNode As New TreeNode(Drive & ":\")
        Nodes.Add(rootNode)

        ' Fill the first level and expand it.
        Fill(rootNode)
        Nodes(0).Expand()
    End Sub

    Private Sub Fill(ByVal dirNode As TreeNode)
        Dim dir As New DirectoryInfo(dirNode.FullPath)

        For Each dirItem As DirectoryInfo In dir.GetDirectories()
            ' Add node for the directory.
            Try
                Dim newNode As New TreeNode(dirItem.Name)
                dirNode.Nodes.Add(newNode)
                newNode.Nodes.Add("*")
            Catch err As Exception
                ' An exception could be thrown in this code if you don't
                ' have sufficient security permissions for a file or directory.
                ' You can catch and then ignore this exception.
            End Try
        Next
    End Sub

    Protected Overrides Sub OnBeforeExpand(ByVal e As TreeViewCancelEventArgs)
        MyBase.OnBeforeExpand(e)

        ' If a dummy node is found, remove it and read the real directory list.
        If e.Node.Nodes(0).Text = "*" Then
            e.Node.Nodes.Clear()
            Fill(e.Node)
        End If
    End Sub

    Public Event DirectorySelected(ByVal sender As Object, _
  ByVal e As DirectorySelectedEventArgs)

    Protected Overrides Sub OnAfterSelect(ByVal e As TreeViewEventArgs)
        MyBase.OnAfterSelect(e)

        ' Raise the DirectorySelected event.
        RaiseEvent DirectorySelected(Me, _
          New DirectorySelectedEventArgs(e.Node.FullPath))
    End Sub

End Class
