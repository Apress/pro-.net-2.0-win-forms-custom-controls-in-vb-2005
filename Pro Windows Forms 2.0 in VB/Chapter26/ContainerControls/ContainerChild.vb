Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Windows.Forms.Design
Imports System.ComponentModel.Design

'[ToolboxItem(false)]
<Designer(GetType(ContainerChildDesigner))> _
Public Class ContainerChild : Inherits Control
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        e.Graphics.FillRectangle(Brushes.Red, Me.ClientRectangle)
        e.Graphics.DrawString(Text, SystemFonts.IconTitleFont, Brushes.White, Me.ClientRectangle)
    End Sub

    Protected Overrides Sub OnParentChanged(ByVal e As EventArgs)
        ' Allow a null parent to support drag-and-drop
        ' (from one Container to another) at design time.
        If (TypeOf Me.Parent Is Container) OrElse (Me.Parent Is Nothing) Then
            MyBase.OnParentChanged(e)
        Else
            Throw New NotSupportedException("A ContainerChild control can only be added to a Container control")
        End If
    End Sub
End Class

Public Class ContainerChildDesigner : Inherits ControlDesigner
    Public Overrides Function CanBeParentedTo(ByVal parentDesigner As IDesigner) As Boolean
        ' Control can only be parented by Container. 
        Return (TypeOf parentDesigner Is ContainerDesigner)
    End Function
End Class
