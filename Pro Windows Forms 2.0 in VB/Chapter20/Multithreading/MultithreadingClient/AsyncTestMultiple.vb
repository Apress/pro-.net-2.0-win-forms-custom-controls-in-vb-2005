#Region "Using directives"


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MultithreadingWorker

#End Region

Namespace MultithreadingClient
    Friend Partial Class AsyncTestMultiple : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub


        ' Track ongoing threads.
        Private workers As List(Of EratosthenesTask) = New List(Of EratosthenesTask)()

        Private Sub cmdNewSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdNewSearch.Click
            Dim search As New AsyncTestQuery()
            If search.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                ' Start the new search.
                Dim worker As New EratosthenesTask(search.From, search.To)
                AddHandler worker.Completed, AddressOf WorkerCompleted
                SyncLock workers
                    workers.Add(worker)
                    statusPanel.Text = String.Format("Currently running {0} tasks.", workers.Count)
                End SyncLock
                worker.Start()
            End If
            search.Dispose()
        End Sub

        Private Sub WorkerCompleted(ByVal sender As Object, ByVal e As FindPrimesCompletedEventArgs)
            ' Stop tracking the worker.
            SyncLock workers
                workers.Remove(CType(sender, EratosthenesTask))
            End SyncLock

            ' Show the results (on the user interface thread).
            Me.Invoke(New FindPrimesCompletedEventHandler(AddressOf ShowResults), New Object() {sender, e})
        End Sub

         Private Sub ShowResults(ByVal sender As Object, ByVal e As FindPrimesCompletedEventArgs)
            Dim result As New AsyncTestResult()
            result.Text = String.Format("Primes From {0} To {1}", New Object() { e.From, e.To })
            result.ShowList(e.PrimeList)
            result.MdiParent = Me
            result.Show()

            SyncLock workers
                statusPanel.Text = String.Format("Currently running {0} tasks.", workers.Count)
            End SyncLock
         End Sub

        Private Sub AsyncTestMultiple_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed
            ' This would be a good place to loop through the workes and
            ' terminate each one.
            ' As it stands, they are background threads, so they will
            ' be aborted by the CLR when the application ends.
        End Sub

    End Class
End Namespace