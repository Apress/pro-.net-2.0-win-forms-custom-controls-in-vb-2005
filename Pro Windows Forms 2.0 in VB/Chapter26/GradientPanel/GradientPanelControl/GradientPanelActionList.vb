Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Drawing.Drawing2D

Public Class GradientPanelActionList : Inherits System.ComponentModel.Design.DesignerActionList
    Private linkedControl As GradientPanel

    ' The constructor associates the control to the smart tag action list. 

    Public Sub New(ByVal ctrl As GradientPanel)
        MyBase.New(ctrl)
        linkedControl = ctrl
    End Sub

    ' A helper method to retrieve control properties.
    ' GetProperties ensures undo and menu updates to work properly. 
    Private Function GetPropertyByName(ByVal propName As String) As PropertyDescriptor
        Dim prop As PropertyDescriptor
        prop = TypeDescriptor.GetProperties(linkedControl)(propName)

        If Nothing Is prop Then
            Throw New ArgumentException("Matching property not found.", propName)
        Else
            Return prop
        End If
    End Function

    ' Properties that are targets of DesignerActionPropertyItem 
    ' entries. 
    Public Property ColorA() As Color
        Get
            Return linkedControl.ColorA
        End Get
        Set(ByVal value As Color)
            GetPropertyByName("ColorA").SetValue(linkedControl, value)
        End Set
    End Property

    Public Property ColorB() As Color
        Get
            Return linkedControl.ColorB
        End Get
        Set(ByVal value As Color)
            GetPropertyByName("ColorB").SetValue(linkedControl, Value)
        End Set
    End Property

    Public Property GradientFillStyle() As LinearGradientMode
        Get
            Return linkedControl.GradientFillStyle
        End Get
        Set(ByVal value As LinearGradientMode)
            GetPropertyByName("GradientFillStyle").SetValue(linkedControl, Value)
        End Set
    End Property

    ' Method that is target of a DesignerActionMethodItem 
    Public Sub ChooseRandomColors()
        Dim rand As New Random()

        ' Set the colors through the property procedures
        ' in this class.
        ColorA = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255))
        ColorB = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255))

    End Sub



    ' Implementation of this abstract method creates smart tag 
    ' items, associates their targets, and collects into list. 
    Public Overrides Function GetSortedActionItems() As DesignerActionItemCollection
        ' Create 8 items.
        Dim items As New DesignerActionItemCollection()

        ' Begin by creating the headers.
        items.Add(New DesignerActionHeaderItem("Appearance"))
        items.Add(New DesignerActionHeaderItem("Information"))

        ' Add items that wrap the properties.
        items.Add(New DesignerActionPropertyItem("ColorA", "Gradient Color A", "Appearance", "Sets the first color in the gradient."))

        items.Add(New DesignerActionPropertyItem("ColorB", "Gradient Color B", "Appearance", "Sets the second color in the gradient."))

        items.Add(New DesignerActionPropertyItem("GradientFillStyle", "Gradient Fill Style", "Appearance", "Sets the blend direction for the gradient."))

        ' Add an action link. 
        ' This item is also added to the context menu 
        ' as a designer verb. 
        items.Add(New DesignerActionMethodItem(Me, "ChooseRandomColors", "Randomize colors", "Appearance", "Chooses random colors for the gradient.", True))

        ' Create entries for static Information section. 
        items.Add(New DesignerActionTextItem("Location: " & linkedControl.Location.ToString(), "Information"))

        items.Add(New DesignerActionTextItem("Location: " & linkedControl.Size.ToString(), "Information"))

        Return items

    End Function

End Class


