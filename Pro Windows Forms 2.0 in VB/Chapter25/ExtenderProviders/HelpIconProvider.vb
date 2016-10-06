Imports System.ComponentModel

<ProvideProperty("HelpID", GetType(Control))> _
Public Class HelpIconProvider
    Inherits Component
    Implements IExtenderProvider, ISupportInitialize

    Public Function CanExtend(ByVal extendee As Object) As Boolean Implements System.ComponentModel.IExtenderProvider.CanExtend
        Return (TypeOf extendee Is Control)
    End Function

    Private _helpFile As String
    Public Property HelpFile() As String
        Get
            Return _helpFile
        End Get
        Set(ByVal value As String)
            _helpFile = value
        End Set
    End Property

    ' Store the context-senstive ID for each control.
    Private contextIDs As New Dictionary(Of Control, String)()

    ' Store the dynamically inserted PictureBox controls.
    Private pictures As New Dictionary(Of Control, PictureBox)()

    Public Function GetHelpID(ByVal extendee As Control) As String
        If contextIDs.ContainsKey(extendee) Then
            Return contextIDs(extendee)
        Else
            Return ""
        End If
    End Function

    Public Sub SetHelpID(ByVal extendee As Control, ByVal value As String)
        ' A blank value string indicates the control is trying to unregister.
        If value = "" Then
            ' Check if the item is registered.
            If pictures.ContainsKey(extendee) And Not DesignMode Then
                ' Perform this step only if the form is created.
                If extendee.Parent IsNot Nothing Then
                    UnRegister(extendee)
                End If
            End If

            ' Stop maintaining the help ID.
            contextIDs.Remove(extendee)
        Else
            ' The user has supplied a value.
            ' Check if the item is registered.
            If Not pictures.ContainsKey(extendee) And Not DesignMode Then
                If extendee.Parent IsNot Nothing Then
                    Register(extendee)
                End If
            End If

            ' Update or store the help ID.
            contextIDs(extendee) = value
            End If
    End Sub

    Public Sub BeginInit() Implements ISupportInitialize.BeginInit
    End Sub

    Public Sub EndInit() Implements ISupportInitialize.EndInit
        ' No design-time PictureBox controls are created.
        ' Add them now.
        For Each item As KeyValuePair(Of Control, String) In contextIDs
            Register(item.Key)
        Next
    End Sub

    Private Sub Register(ByVal control As Control)
        ' Create new PictureBox.
        Dim pic As New PictureBox()
        pic.Image = My.Resources.help
        pic.Size = New Size(16, 16)
        pic.Location = New Point(control.Right + 10, control.Top)

        ' Register for DoubleClick event.
        AddHandler pic.DoubleClick, AddressOf PicDoubleClick

        ' Store a reference to the help icon
        ' So you can remove it later.
        pictures(control) = pic

        ' Add it to the form.
        control.Parent.Controls.Add(pic)
    End Sub

    Private Sub UnRegister(ByVal control As Control)
        ' Detach event handler.
        RemoveHandler pictures(control).DoubleClick, AddressOf PicDoubleClick

        ' Remove the picture from the form.
        control.Parent.Controls.Remove(pictures(control))
        pictures(control).Dispose()

        pictures.Remove(control)
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            ' Dispose all the PictureBox controls.
            For Each item As KeyValuePair(Of Control, PictureBox) In pictures
                item.Value.Dispose()
            Next
        End If
    End Sub

    Public Sub PicDoubleClick(ByVal sender As Object, ByVal e As EventArgs)
        ' Find the related control.
        Dim ctrl As Control = Nothing
        For Each item As KeyValuePair(Of Control, PictureBox) In pictures
            If item.Value Is sender Then
                ctrl = item.Key
                Exit For
            End If
        Next

        ' Show the help.
        If ctrl IsNot Nothing Then
            Help.ShowHelp(ctrl, helpFile, HelpNavigator.Topic, _
              contextIDs(ctrl))
        End If
    End Sub

End Class
