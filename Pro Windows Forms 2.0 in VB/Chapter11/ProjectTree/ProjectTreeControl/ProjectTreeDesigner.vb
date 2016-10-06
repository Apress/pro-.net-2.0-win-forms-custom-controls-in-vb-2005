Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms.Design
Imports System.ComponentModel.Design

Public Class ProjectTreeDesigner
    Inherits ControlDesigner

    Protected Overrides Sub PostFilterProperties(ByVal properties As System.Collections.IDictionary)

        MyBase.PostFilterProperties(properties)
        properties.Remove("Nodes")
        properties.Remove("ImageList")
        properties.Remove("ImageIndex")
        properties.Remove("ImageKey")
    End Sub

    Protected Overrides Sub PostFilterEvents(ByVal events As System.Collections.IDictionary)

        MyBase.PostFilterEvents(events)
        events.Remove("AfterSelect")
    End Sub

End Class
