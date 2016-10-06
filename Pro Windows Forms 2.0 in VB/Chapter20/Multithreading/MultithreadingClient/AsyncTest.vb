Imports MultithreadingWorker

Namespace MultithreadingClient
    Friend Partial Class AsyncTest : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Delegate Sub CallAsyncWorkerDelegate(ByVal from As Integer, ByVal [to] As Integer)

        Private Sub CallAsyncWorker(ByVal fromNumber As Integer, ByVal toNumber As Integer)
            Try
                ' Start the search for primes and wait.
                Dim startTime As DateTime = DateTime.Now
                Dim primes As Integer() = MultithreadingWorker.Worker.FindPrimes(fromNumber, toNumber)

                ' Calculate the time for the call to complete.
                Dim timeTaken As TimeSpan = DateTime.Now.Subtract(startTime)

                ' Paste the list of primes together into one long string.
                Dim sb As New StringBuilder()
                For Each prime As Integer In primes
                    sb.Append(prime.ToString())
                    sb.Append("  ")
                Next

                ' Use the Control.Invoke() method of the current form,
                ' which is on the same thread as the rest of the controls.
                Me.Invoke(New UpdateFormDelegate(AddressOf UpdateForm), New Object() {timeTaken, sb.ToString()})

            Catch err As Exception
                MessageBox.Show(err.Message)
            End Try
        End Sub

        Private Delegate Sub UpdateFormDelegate(ByVal timeTaken As TimeSpan, ByVal primeList As String)
        Private Sub UpdateForm(ByVal timeTaken As TimeSpan, ByVal primeList As String)
            lblTimeTaken.Text = timeTaken.TotalSeconds.ToString()
            txtResults.Text = primeList

            cmdFind.Enabled = True
        End Sub

        Private Sub cmdFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdFind.Click
            ' Disable the button.
            cmdFind.Enabled = False

            txtResults.Text = ""
            lblTimeTaken.Text = ""

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
            Dim doWork As New CallAsyncWorkerDelegate(AddressOf CallAsyncWorker)
            doWork.BeginInvoke(fromNumber, toNumber, Nothing, Nothing)
        End Sub

    End Class
End Namespace