Imports System.Windows.Forms.Design
Imports System.ComponentModel.Design

Public Class GradientPanelDesigner
    Inherits System.Windows.Forms.Design.ParentControlDesigner

    Private _actionLists As DesignerActionListCollection

    Public Overrides ReadOnly Property ActionLists() As DesignerActionListCollection
        Get
            If _actionLists Is Nothing Then
                _actionLists = New DesignerActionListCollection()
                _actionLists.Add(New GradientPanelActionList(CType(Control, GradientPanel)))
            End If
            Return _actionLists
        End Get
    End Property
End Class
