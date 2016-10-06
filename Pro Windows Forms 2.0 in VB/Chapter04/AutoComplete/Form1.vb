Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim colorNames As String() = [Enum].GetNames(GetType(KnownColor))
        lstColors.Items.AddRange(colorNames)
    End Sub
End Class
