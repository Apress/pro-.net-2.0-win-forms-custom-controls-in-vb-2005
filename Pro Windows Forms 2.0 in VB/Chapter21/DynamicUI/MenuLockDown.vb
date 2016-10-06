Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Data


Public Class MenuLockDown

    Public Shared Sub SearchMenu(ByVal items As ToolStripItemCollection, ByVal dtPermissions As DataTable)
        Dim rowMatch As DataRow()

        For Each item As ToolStripItem In items
            ' Skip separators and other controls
            Dim mnuItem As ToolStripMenuItem = TryCast(item, ToolStripMenuItem)
            If Not mnuItem Is Nothing Then
                ' See if this menu item has a corresponding row.
                rowMatch = dtPermissions.Select("ControlName = '" & mnuItem.Name & "'")

                ' If it does, configure the menu item state accordingly.			
                If rowMatch.GetLength(0) > 0 Then
                    Dim state As DBPermissions.State
                    state = CType(Integer.Parse(rowMatch(0)("State").ToString()), DBPermissions.State)

                    Select Case state
                        Case DBPermissions.State.Hidden
                            mnuItem.Visible = False
                        Case DBPermissions.State.Disabled
                            mnuItem.Enabled = False
                    End Select
                Else
                    mnuItem.Visible = True
                    mnuItem.Enabled = True
                End If

                ' Search recursively through any submenus.
                If mnuItem.DropDownItems.Count > 0 Then
                    SearchMenu(mnuItem.DropDownItems, dtPermissions)
                End If
            End If
        Next
    End Sub
End Class

