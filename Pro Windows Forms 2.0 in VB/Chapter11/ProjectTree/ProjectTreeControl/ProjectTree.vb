Imports System.ComponentModel

<Designer(GetType(ProjectTreeDesigner))> _
Public Class ProjectTree
    Inherits TreeView

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectTree))
        Me.imagesTree = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'imagesTree
        '
        Me.imagesTree.ImageStream = CType(resources.GetObject("imagesTree.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imagesTree.TransparentColor = System.Drawing.Color.Transparent
        Me.imagesTree.Images.SetKeyName(0, "")
        Me.imagesTree.Images.SetKeyName(1, "")
        Me.imagesTree.Images.SetKeyName(2, "")
        Me.imagesTree.Images.SetKeyName(3, "")
        Me.imagesTree.Images.SetKeyName(4, "")
        '
        'ProjectTree
        '
        Me.ImageIndex = 0
        Me.ImageList = Me.imagesTree
        Me.SelectedImageIndex = 0
        Me.ResumeLayout(False)

    End Sub
    Private components As System.ComponentModel.IContainer
    Private WithEvents imagesTree As System.Windows.Forms.ImageList

    ' Specific numbers correspond to the image index.
    Private Enum NodeImages
        UnassignedGroup = 0
        InProgressGroup = 1
        ClosedGroup = 2
        NormalProject = 3
        SelectedProject = 4
    End Enum

    Private _nodeUnassigned As TreeNode
    Public ReadOnly Property UnassignedProjectsNode() As TreeNode
        Get
            Return _nodeUnassigned
        End Get
    End Property

    Private _nodeInProgress As TreeNode
    Public ReadOnly Property InProgressProjectsNode() As TreeNode
        Get
            Return _nodeInProgress
        End Get
    End Property

    Private _nodeClosed As TreeNode
    Public ReadOnly Property ClosedProjectsNode() As TreeNode
        Get
            Return _nodeClosed
        End Get
    End Property

    Public Sub New()
        InitializeComponent()

        ' Create the first level of nodes.
        _nodeUnassigned = New TreeNode("Unassigned", _
          CInt(NodeImages.UnassignedGroup), CInt(NodeImages.UnassignedGroup))
        _nodeInProgress = New TreeNode("In Progress", _
          CInt(NodeImages.InProgressGroup), CInt(NodeImages.InProgressGroup))
        _nodeClosed = New TreeNode("Closed", _
          CInt(NodeImages.ClosedGroup), CInt(NodeImages.ClosedGroup))

        ' Add the project category nodes.
        Nodes.Add(_nodeUnassigned)
        Nodes.Add(_nodeInProgress)
        Nodes.Add(_nodeClosed)

    End Sub

    Public Sub AddProject(ByVal project As Project)
        Dim nodeNew As New ProjectTreeNode(project, project.Name, _
         CInt(NodeImages.NormalProject), CInt(NodeImages.SelectedProject))

        Select Case project.Status
            Case project.StatusType.Unassigned
                _nodeUnassigned.Nodes.Add(nodeNew)
            Case project.StatusType.InProgress
                _nodeInProgress.Nodes.Add(nodeNew)
            Case project.StatusType.Closed
                _nodeClosed.Nodes.Add(nodeNew)
        End Select
    End Sub

    Public Function GetProject(ByVal name As String, _
  ByVal status As Project.StatusType) As Project
        Dim nodes As TreeNodeCollection = Nothing

        Select Case status
            Case Project.StatusType.Unassigned
                nodes = _nodeUnassigned.Nodes
            Case Project.StatusType.InProgress
                nodes = _nodeInProgress.Nodes
            Case Project.StatusType.Closed
                nodes = _nodeClosed.Nodes
        End Select

        For Each node As TreeNode In nodes
            ' Test for a name match.
            If node.Text = name Then
                ' Get the Project object for this node.
                If TypeOf node Is ProjectTreeNode Then
                    Return CType(node, ProjectTreeNode).Project
                End If
            End If
        Next

        ' If nothing was found...
        Return Nothing
    End Function

    Public Event ProjectSelected(ByVal sender As Object, _
  ByVal e As ProjectSelectedEventArgs)

    ' When a node is selected, retrieve the Project and raise the event.
    Protected Overrides Sub OnAfterSelect(ByVal e As TreeViewEventArgs)
        MyBase.OnAfterSelect(e)

        If e.Node.Level = 1 Then
            Dim project As Project = CType(e.Node, ProjectTreeNode).Project
            Dim arg As New ProjectSelectedEventArgs(project)
            RaiseEvent ProjectSelected(Me, arg)
        End If
    End Sub

End Class
