Imports System.ComponentModel

<ProvideProperty("HelpText", GetType(ToolStripItem))> _
Public Class StatusStripHelpLabel
    Inherits ToolStripStatusLabel
    Implements IExtenderProvider

    ' The collection for tracking the Help text information.
    Private helpText As New Dictionary(Of ToolStripItem, String)()

    Public Function CanExtend(ByVal extendee As Object) As Boolean Implements System.ComponentModel.IExtenderProvider.CanExtend
        Return (TypeOf extendee Is ToolStripItem)
    End Function

    Public Sub SetHelpText(ByVal extendee As ToolStripItem, ByVal value As String)
        ' A blank value string indicates the control is trying to unregister.
        If value = "" Then
            ' Check if the item is registered.
            If Not helpText.ContainsKey(extendee) And Not DesignMode Then
                ' Unregister.
                RemoveHandler extendee.MouseEnter, AddressOf MenuSelect
                RemoveHandler extendee.MouseLeave, AddressOf MenuClear
            End If
            helpText.Remove(extendee)
        Else
            ' The user has supplied Help text.
            ' Check if the item is registered.
            If Not helpText.ContainsKey(extendee) And Not DesignMode Then
                ' It hasn't been registered yet. Register it now.
                AddHandler extendee.MouseEnter, AddressOf MenuSelect
                AddHandler extendee.MouseLeave, AddressOf MenuClear
            End If

            ' Either way, update the Help text.
            helpText(extendee) = value
        End If
    End Sub

    <DisplayName("HelpText")> _
    <Category("Behavior")> _
    <Description("This text appears in the linked StatusStripHelpLabel.")> _
    Public Function GetHelpText(ByVal extendee As ToolStripItem) As String
        If helpText.ContainsKey(extendee) Then
            Return helpText(extendee)
        Else
            Return ""
        End If
    End Function

    Private Sub MenuSelect(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.Text = helpText(CType(sender, ToolStripMenuItem))
    End Sub

    Private Sub MenuClear(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.Text = ""
    End Sub

End Class
