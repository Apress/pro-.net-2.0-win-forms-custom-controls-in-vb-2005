Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MultithreadingWorker

Namespace MultithreadingClient
    Public Partial Class TaskManagerClient : Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub taskManager_ReportWorkerProgress(ByVal sender As Object, ByVal e As MultithreadingWorker.ReportWorkerProgressEventArgs) Handles taskManager.ReportWorkerProgress
            ' Find the matching item.
            For Each item As ListViewItem In listTasks.Items
                If item.Text = e.TaskID.ToString() Then
                    item.SubItems(2).Text = e.Progress.ToString() & "% completed"
                    Exit For
                End If
            Next
        End Sub

        Private Sub taskManager_WorkerCompleted(ByVal sender As Object, ByVal e As MultithreadingWorker.WorkerCompletedEventArgs) Handles taskManager.WorkerCompleted
            ' Find the matching item.
            For Each item As ListViewItem In listTasks.Items
                If item.Text = e.ID.ToString() Then
                    item.SubItems(2).Text = "Completed"

                    ' Store the results for later use.
                    ' Could use a custom ListView here, but the
                    ' Tag is a messier shortcut.
                    item.Tag = e.PrimeList
                    Exit For
                End If
            Next
        End Sub

        Private Sub cmdFind_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdFind.Click
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

            ' Create the task.
            Dim task As New EratosthenesTask(fromNumber, toNumber)

            ' Add the task to the grid.
            Dim item As New ListViewItem(task.ID.ToString())
            item.SubItems.Add(fromNumber.ToString() & " to " & toNumber.ToString())
            item.SubItems.Add("Queued")
            listTasks.Items.Add(item)

            ' Enqueue the task.
            taskManager.EnqueueTask(task)
        End Sub

        Private Sub TaskManagerClient_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            taskManager.StartAllocatingWork(Me)
        End Sub

        Private Sub listTasks_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles listTasks.DoubleClick
            ' Check for item click.
            If Not listTasks.SelectedItems(0) Is Nothing Then
                ' Check item is completed.
                If Not listTasks.SelectedItems(0).Tag Is Nothing Then
                    Dim result As New AsyncTestResult()
                    result.ShowList(CStr(listTasks.SelectedItems(0).Tag))
                    result.ShowDialog()
                    result.Dispose()
                End If
            End If

        End Sub
    End Class
End Namespace