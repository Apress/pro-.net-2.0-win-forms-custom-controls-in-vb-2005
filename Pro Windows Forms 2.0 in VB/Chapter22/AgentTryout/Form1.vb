Public Class Form1

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private controller As AgentController
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        controller = New AgentController(axAgent1, "Genie")
        lstAnimations.DataSource = controller.GetAnimations()
        controller.Show()
    End Sub

    Private Sub cmdPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlay.Click
        controller.Animate(lstAnimations.Text)
    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        controller.StopAll()
    End Sub

    Private Sub cmdSpeak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSpeak.Click
        controller.Speak(txtSpeak.Text)
    End Sub

    Private Sub cmdMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMove.Click
        controller.MoveTo(Short.Parse(txtX.Text), Short.Parse(txtY.Text))
    End Sub
End Class
