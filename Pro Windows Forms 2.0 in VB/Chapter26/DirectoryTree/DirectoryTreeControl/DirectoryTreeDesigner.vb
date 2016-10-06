Imports System.Windows.Forms.Design
Imports System.ComponentModel.Design
Imports System.ComponentModel
Imports System.Drawing.Design


Public Class DirectoryTreeDesigner
    Inherits ControlDesigner

    Private _verbs As New DesignerVerbCollection()

    Private verbSetDrive As DesignerVerb

    Public Sub New()
        ' Configure the designer verb collection.
        ' Add the Set Drive verb that calls up the form.
        verbSetDrive = New DesignerVerb("Set Drive", New EventHandler(AddressOf OnVerb))
        _verbs.Add(verbSetDrive)

        ' Add a verb for quickly setting each possible drive value
        ' (for demonstration purposes).
        Dim drives As String() = System.IO.Directory.GetLogicalDrives()

        For Each drive As String In drives
            _verbs.Add(New DesignerVerb("Set Drive " & drive, New EventHandler(AddressOf OnVerb)))
        Next
    End Sub

    Private changeService As IComponentChangeService
    Public Overrides Sub Initialize(ByVal component As IComponent)
        MyBase.Initialize(component)

        ' Update your designer verb whenever ComponentChanged event occurs. 
        changeService = CType(GetService(GetType(IComponentChangeService)), IComponentChangeService)
        If Not changeService Is Nothing Then
            AddHandler changeService.ComponentChanged, AddressOf ComponentChanged
        End If
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not changeService Is Nothing Then
            RemoveHandler changeService.ComponentChanged, AddressOf ComponentChanged
        End If
    End Sub

    Private Sub ComponentChanged(ByVal sender As Object, ByVal e As ComponentChangedEventArgs)
        Dim tree As DirectoryTree = CType(Me.Control, DirectoryTree)

        If Not tree Is Nothing Then
            For Each verb As DesignerVerb In _verbs
                If Not verb Is verbSetDrive Then
                    If verb.Text(10) = tree.Drive Then
                        verb.Enabled = False
                    Else
                        verb.Enabled = True
                    End If
                End If
            Next
        End If
    End Sub

    Public Overrides ReadOnly Property Verbs() As DesignerVerbCollection
        Get
            Return _verbs
        End Get
    End Property

    Protected Sub OnVerb(ByVal sender As Object, ByVal e As EventArgs)
        Dim oldValue As Char = (CType(Me.Control, DirectoryTree)).Drive
        Dim newValue As Char

        If sender Is verbSetDrive Then
            ' Show the form.
            Using frm As New SelectDrive()
                frm.DriveSelection = oldValue

                ' Exit in case Cancel is clicked.
                If frm.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then
                    Return
                End If

                ' Get the result.
                newValue = frm.DriveSelection
            End Using
        Else
            ' Retrieve the selected drive.
            newValue = (CType(sender, DesignerVerb)).Text(10)
        End If

        ' Adjust the associated control.
        CType(Me.Control, DirectoryTree).Drive = newValue

        ' Notify the IDE that the Drive property has changed.
        Dim properties As PropertyDescriptorCollection
        properties = TypeDescriptor.GetProperties(GetType(DirectoryTree))
        Dim changedProperty As PropertyDescriptor = properties.Find("Drive", False)
        Me.RaiseComponentChanged(changedProperty, oldValue, newValue)
    End Sub

    Protected Overrides Sub PostFilterProperties(ByVal properties As System.Collections.IDictionary)
        properties.Remove("Nodes")
        MyBase.PostFilterProperties(properties)
    End Sub
End Class

