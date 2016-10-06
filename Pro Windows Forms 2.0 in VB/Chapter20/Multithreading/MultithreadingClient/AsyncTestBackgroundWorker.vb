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
    Friend Partial Class AsyncTestBackgroundWorker : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub


        Private Sub cmdFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdFind.Click
            ' Disable the button.
            cmdFind.Enabled = False
            statusPanel.Text = ""

            ' Get the search range.
            Dim fromNumber, toNumber As Integer
            If (Not Int32.TryParse(txtFrom.Text, fromNumber)) Then
                MessageBox.Show("Invalid From value.")
                Return
            End If
            If (Not Int32.TryParse(txtTo.Text, toNumber)) Then
                MessageBox.Show("Invalid To value.")
                Return
            End If

            ' Start the search for primes on another thread.
            Dim input As New FindPrimesInput(fromNumber, toNumber)
            backgroundWorker.RunWorkerAsync(input)
        End Sub

        Private Sub statusStrip1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles statusStrip1.DoubleClick
            If statusPanel.Text <> "" Then
                txtResults.Text = primeList
                primeList = ""
                statusPanel.Text = ""
            End If
        End Sub

        Private Sub backgroundWorker_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles backgroundWorker.DoWork
            ' Get the input values.
            Dim input As FindPrimesInput = CType(e.Argument, FindPrimesInput)

            ' Start the search for primes and wait.
            Dim primes As Integer() = MultithreadingWorker.Worker.FindPrimes(input.From, input.To, backgroundWorker)

            If backgroundWorker.CancellationPending Then
                e.Cancel = True
                Return
            End If

            ' Paste the list of primes together into one long string.
            Dim sb As New StringBuilder()
            For Each prime As Integer In primes
                sb.Append(prime.ToString())
                sb.Append("  ")
            Next

            ' Return the result.
            e.Result = sb.ToString()
        End Sub

        Private primeList As String
        Private Sub backgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundWorker.RunWorkerCompleted
            primeList = ""
            statusPanel.Text = ""

            If e.Cancelled Then
                MessageBox.Show("Search cancelled.")
                progressPanel.Value = 0
            ElseIf Not e.Error Is Nothing Then
                ' An error was thrown by the DoWork event handler.
                MessageBox.Show(e.Error.Message, "An Error Occurred")
            Else
                primeList = CStr(e.Result)
                statusPanel.Text = "Double-click panel to see new prime list."
            End If
            cmdFind.Enabled = True
        End Sub

        Private Sub backgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles backgroundWorker.ProgressChanged
            progressPanel.Value = e.ProgressPercentage
        End Sub

        Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCancel.Click
            backgroundWorker.CancelAsync()
        End Sub

    End Class

    Public Class FindPrimesInput
        Private _to As Integer
        Public Property [To]() As Integer
            Get
                Return _to
            End Get
            Set(ByVal value As Integer)
                _to = Value
            End Set
        End Property

        Private _from As Integer
        Public Property From() As Integer
            Get
                Return _from
            End Get
            Set(ByVal value As Integer)
                _from = Value
            End Set
        End Property

        Public Sub New(ByVal from As Integer, ByVal [to] As Integer)
            Me.To = [to]
            Me.From = From
        End Sub

    End Class
End Namespace