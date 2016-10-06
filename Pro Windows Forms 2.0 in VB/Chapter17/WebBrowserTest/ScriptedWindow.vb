Imports System.Runtime.InteropServices

<ComVisible(True)> _
Public Class ScriptedWindow

    Private Sub ScriptedWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        webBrowser1.ObjectForScripting = Me
        webBrowser1.Navigate(System.IO.Path.Combine(Application.StartupPath, "..\..\HTML\feedback.htm"))
    End Sub

    Public Sub Feedback(ByVal userName As String, ByVal email As String)
        If userName <> String.Empty Then
            MessageBox.Show("Welcome, " & userName & " at " & email & ".")
        End If

        MessageBox.Show("Was this a complaint? " & webBrowser1.Document.GetElementById("Complaint").GetAttribute("checked"))
        ' You can also interrogate other properties like this:
        ' Retrieve comments.
        'MessageBox.Show(webBrowser1.Document.All("Comments").GetAttribute("value"))
    End Sub

    Private Sub webBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles webBrowser1.Navigating
        If webBrowser1.Document.All("userName").GetAttribute("value") = String.Empty Then
            e.Cancel = True
            MessageBox.Show("Please enter your name.")
        End If
    End Sub
End Class