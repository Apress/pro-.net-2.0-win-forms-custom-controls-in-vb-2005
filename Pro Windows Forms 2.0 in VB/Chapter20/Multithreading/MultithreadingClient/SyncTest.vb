#Region "Using directives"


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text

#End Region

Namespace MultithreadingClient
    Friend Partial Class SyncTest : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub cmdFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdFind.Click
            Me.Cursor = Cursors.WaitCursor

            txtResults.Text = ""
            lblTimeTaken.Text = ""

            Try
                ' Get the search range.
                Dim from, [to] As Integer
                If (Not Int32.TryParse(txtFrom.Text, from)) Then
                    MessageBox.Show("Invalid From value.")
                    Return
                End If
                If (Not Int32.TryParse(txtTo.Text, [to])) Then
                    MessageBox.Show("Invalid To value.")
                    Return
                End If

                ' Start the search for primes and wait.
                Dim startTime As DateTime = DateTime.Now
                Dim primes As Integer() = MultithreadingWorker.Worker.FindPrimes(from, [to])

                ' Display the time for the call to complete.
                lblTimeTaken.Text = DateTime.Now.Subtract(startTime).TotalSeconds.ToString()


                ' Paste the list of primes together into one long string.
                Dim sb As New StringBuilder()
                For Each prime As Integer In primes
                    sb.Append(prime.ToString())
                    sb.Append("  ")
                Next
                txtResults.Text = sb.ToString()
            Catch err As Exception
                 MessageBox.Show(err.Message)
            End Try

            Me.Cursor = Cursors.Default
        End Sub


    End Class
End Namespace