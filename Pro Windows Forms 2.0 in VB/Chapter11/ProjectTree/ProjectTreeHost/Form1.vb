Imports ProjectTreeControl

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProjectTree1.AddProject(New Project("Migration to .NET", "", Project.StatusType.InProgress))
        ProjectTree1.AddProject(New Project("Revamp pricing site", "", Project.StatusType.Unassigned))
        ProjectTree1.AddProject(New Project("Prepare L-DAP feasibility report", "", Project.StatusType.Unassigned))
        ProjectTree1.AddProject(New Project("Update E201-G to Windows XP", "", Project.StatusType.Closed))
        ProjectTree1.AddProject(New Project("Annual meeting", "", Project.StatusType.Closed))
    End Sub
End Class
