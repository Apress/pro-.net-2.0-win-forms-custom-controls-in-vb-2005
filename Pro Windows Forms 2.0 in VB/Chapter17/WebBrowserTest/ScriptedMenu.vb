Imports System.Runtime.InteropServices

<ComVisible(True)> _
Public Class ScriptedMenu

    Private Sub ScriptedMenu_Load(ByVal sender As Object, _
    ByVal e As EventArgs) Handles MyBase.Load
        webBrowser1.ObjectForScripting = Me
        webBrowser1.Navigate(System.IO.Path.Combine(Application.StartupPath, "..\..\HTML\sample.htm"))
    End Sub

    Public Sub WebClick(ByVal source As String)
        MessageBox.Show("Received: " & source)
    End Sub

End Class