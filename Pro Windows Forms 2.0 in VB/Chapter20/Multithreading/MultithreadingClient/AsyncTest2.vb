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
    Partial Friend Class AsyncTest2
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Delegate Sub CallAsyncWorkerDelegate(ByVal from As Integer, ByVal [to] As Integer)

        ' Shared data.
        Private primeList As StringBuilder

        Private Sub CallAsyncWorker(ByVal from As Integer, ByVal [to] As Integer)
            Try
                ' Start the search for primes and wait.
                Dim primes As Integer() = MultithreadingWorker.Worker.FindPrimes(from, [to])

                ' Paste the list of primes together into one long string.
                Dim sb As New StringBuilder()
                For Each prime As Integer In primes
                    sb.Append(prime.ToString())
                    sb.Append("  ")
                Next

                ' Store the list of primes for later use.
                primeList = sb

                ' Indicate that the prime list is available.
                Me.Invoke(New MethodInvoker(AddressOf NotifyComplete))
            Catch err As Exception
                MessageBox.Show(err.Message)
            End Try
        End Sub

        Private dataAvailable As Boolean = False
        Private Sub NotifyComplete()
            dataAvailable = True
            statusPanel.Text = "Double-click panel to see new prime list."
            cmdFind.Enabled = True
        End Sub

        Private Sub cmdFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdFind.Click
            ' Disable the button.
            cmdFind.Enabled = False

            statusPanel.Text = ""

            ' Get the search range.
            Dim from, [to] As Integer
            If Not Int32.TryParse(txtFrom.Text, from) Then
                MessageBox.Show("Invalid From value.")
                Return
            End If
            If Not Int32.TryParse(txtTo.Text, [to]) Then
                MessageBox.Show("Invalid To value.")
                Return
            End If

            ' Start the search for primes on another thread.
            Dim doWork As New CallAsyncWorkerDelegate(AddressOf CallAsyncWorker)
            doWork.BeginInvoke(from, [to], Nothing, Nothing)
        End Sub

        Private Sub statusStrip1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles statusPanel.Click
            If dataAvailable Then
                txtResults.Text = primeList.ToString()
                statusPanel.Text = ""
                dataAvailable = False
            End If
        End Sub

    End Class
End Namespace