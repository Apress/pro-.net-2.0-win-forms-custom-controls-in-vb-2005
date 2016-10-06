Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms


Partial Public Class DynamicDBMenu
    Inherits Form

    Public Sub New()
        InitializeComponent()
        permissions = New DBPermissions()
    End Sub

    Private permissions As DBPermissions
    Private Sub cmdUser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdUser.Click
        Dim dtPermissions As DataTable

        ' Get permissions for an Admin-level user.
        dtPermissions = permissions.GetPermissions(DBPermissions.Level.User)

        ' Update the menu with these permissions.
        MenuLockDown.SearchMenu(MainMenuStrip.Items, dtPermissions)

    End Sub

    Private Sub cmdAdmin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAdmin.Click
        Dim dtPermissions As DataTable

        ' Get permissions for an Admin-level user.
        dtPermissions = permissions.GetPermissions(DBPermissions.Level.Admin)

        ' Update the menu with these permissions.
        MenuLockDown.SearchMenu(MainMenuStrip.Items, dtPermissions)

    End Sub



End Class
