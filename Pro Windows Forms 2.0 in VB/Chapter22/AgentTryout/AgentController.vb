Public Class AgentController
    Implements IDisposable

    ' Balloon constants
    Private Const BalloonOn As Int16 = 1
    Private Const SizeToText As Int16 = 2
    Private Const AutoHide As Int16 = 4
    Private Const AutoPace As Int16 = 8

    ' Name of the initialized character.
    Private characterName As String

    ' Agent variable.
    Private agentChar As AgentObjects.IAgentCtlCharacterEx

    Public Sub New(ByVal agentHost As AxAgentObjects.AxAgent, _
      ByVal character As String)
        agentHost.Characters.Load(character, Nothing)
        agentChar = agentHost.Characters(character)
        characterName = character

        ' You could put your own options in this menu, if desired.
        agentChar.AutoPopupMenu = False

        ' Set balloon style.
        agentChar.Balloon.Style = agentChar.Balloon.Style Or BalloonOn
        agentChar.Balloon.Style = agentChar.Balloon.Style Or SizeToText
        agentChar.Balloon.Style = agentChar.Balloon.Style Or AutoHide
    End Sub

    Public Sub Show()
        agentChar.Show(Nothing)
    End Sub

    Public Sub Hide()
        agentChar.Hide(Nothing)
    End Sub

    Public Sub Speak(ByVal text As String)
        agentChar.StopAll(Nothing)
        agentChar.Speak(text, "")
    End Sub

    Public Sub Think(ByVal text As String)
        agentChar.StopAll(Nothing)
        agentChar.Think(text)
    End Sub

    Public Sub MoveTo(ByVal x As Int16, ByVal y As Int16)
        agentChar.MoveTo(x, y, Nothing)
    End Sub

    Public Sub GestureAt(ByVal x As Int16, ByVal y As Int16)
        agentChar.GestureAt(x, y)
    End Sub

    Public Sub StopAll()
        agentChar.StopAll(Nothing)
    End Sub

    Public Function GetAnimations() As List(Of String)
        Dim list As New List(Of String)()
        For Each animation As String In agentChar.AnimationNames
            list.Add(animation)
        Next

        Return list
    End Function

    Public Sub Animate(ByVal animation As String)
        agentChar.StopAll(Nothing)
        agentChar.Play(animation)
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        If agentChar.Visible Then
            agentChar.StopAll(Nothing)
            agentChar.Hide(Nothing)
        End If
    End Sub


End Class
