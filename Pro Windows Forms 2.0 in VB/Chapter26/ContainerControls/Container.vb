Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.Design
Imports System.Drawing
Imports System.ComponentModel
Imports System.ComponentModel.Design


<Designer(GetType(ContainerDesigner))> _
Public Class Container
    Inherits Control
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim p As New Pen(Color.Blue, 5)
        Dim rect As Rectangle = Me.ClientRectangle
        rect.Inflate(-5, -5)
        e.Graphics.DrawRectangle(Pens.Blue, rect)
        p.Dispose()
    End Sub

    Protected Overrides Function CreateControlsInstance() As Control.ControlCollection
        Return New ContainerChildControlCollection(Me)
    End Function
End Class

Public Class ContainerChildControlCollection
    Inherits Control.ControlCollection
    Public Sub New(ByVal owner As Control)
        MyBase.New(owner)
    End Sub

    Public Overrides Sub Add(ByVal value As System.Windows.Forms.Control)
        If TypeOf value Is ContainerChild Then
            MyBase.Add(value)
        Else
            Throw New NotSupportedException("Only ContainerChild controls can be added to a Container control.")
        End If
    End Sub
End Class


Public Class ContainerDesigner
    Inherits ParentControlDesigner
    Public Overloads Overrides Function CanParent(ByVal control As Control) As Boolean
        ' Children can only be of type ContainerChild. 
        Return (TypeOf control Is ContainerChild)
    End Function
End Class


