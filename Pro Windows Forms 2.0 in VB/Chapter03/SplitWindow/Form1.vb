Imports System.IO

Public Class Form1

    Private Sub cmdHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHide.Click
        splitContainer1.Panel1Collapsed = True
        pnlShow.Visible = True
    End Sub

    Private Sub cmdShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShow.Click
        pnlShow.Visible = False
        splitContainer1.Panel1Collapsed = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim d As New DirectoryInfo(Application.StartupPath)
        For Each f As FileInfo In d.GetFiles()
            ListView1.Items.Add(f.Name)
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Try
            Dim urlText As String = Path.Combine( _
             Application.StartupPath, ListView1.SelectedItems(0).Text)

            webBrowser1.Navigate(urlText)
            Dim r As StreamReader = File.OpenText(urlText)
            TextBox1.Text = r.ReadToEnd()
            r.Close()

        Catch

        End Try

    End Sub
End Class
