Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = AdvancedCursors.Create( _
              Path.Combine(Application.StartupPath, "blob.ani"))
        Catch Err As ApplicationException
            MessageBox.Show(Err.Message)
        End Try

    End Sub
End Class
