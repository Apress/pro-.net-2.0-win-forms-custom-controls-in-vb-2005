Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms

Namespace MultithreadingWorker
    Public Delegate Sub ReportWorkerProgressEventHandler(ByVal sender As Object, ByVal e As ReportWorkerProgressEventArgs)
    Public Delegate Sub WorkerCompletedEventHandler(ByVal sender As Object, ByVal e As WorkerCompletedEventArgs)

    ' Inherit from component for design-time use.
    Public Class TaskManager
        Inherits System.ComponentModel.Component

        Private _maxThreads As Integer = 2
        Public Property MaxThreads() As Integer
            Get
                Return _maxThreads
            End Get
            Set(ByVal value As Integer)
                _maxThreads = value
            End Set
        End Property

        ' Track ongoing workers.
        Private workers As New List(Of ThreadWrapperBase)()

        ' Track queued requests.
        Private workersQueued As New List(Of ThreadWrapperBase)()

        ' Task completed requests.
        Private workersCompleted As New List(Of ThreadWrapperBase)()

        Public ReadOnly Property CompletedTasks() As ThreadWrapperBase()
            Get
                ' To avoid synchronization issues, make a copy of this
                ' information.
                Dim taskArray As ThreadWrapperBase()
                SyncLock workersCompleted
                    taskArray = New ThreadWrapperBase(workersCompleted.Count - 1) {}
                    workersCompleted.CopyTo(taskArray)
                End SyncLock
                Return taskArray
            End Get
        End Property

        Public Sub EnqueueTask(ByVal task As ThreadWrapperBase)
            SyncLock workersQueued
                workersQueued.Add(task)
            End SyncLock
        End Sub



        Private allocateWork_Renamed As Thread
        Private working As Boolean = False
        Private invokeContext As Control
        Public Sub StartAllocatingWork(ByVal invokeContext As Control)
            If working = False Then
                Me.invokeContext = invokeContext
                allocateWork_Renamed = New Thread(AddressOf AllocateWork)
                allocateWork_Renamed.IsBackground = True
                'allocateWork.Priority = ThreadPriority.BelowNormal;
                working = True
                allocateWork_Renamed.Start()
            End If

        End Sub

        Public Event ReportWorkerProgress As ReportWorkerProgressEventHandler
        Private Sub OnReportWorkerProgress(ByVal sender As Object, ByVal e As ReportWorkerProgressEventArgs)
            If Not ReportWorkerProgressEvent Is Nothing Then
                RaiseEvent ReportWorkerProgress(sender, e)
            End If
        End Sub

        Public Event WorkerCompleted As WorkerCompletedEventHandler
        Private Sub OnWorkerCompleted(ByVal sender As Object, ByVal e As WorkerCompletedEventArgs)
            If Not WorkerCompletedEvent Is Nothing Then
                RaiseEvent WorkerCompleted(sender, e)
            End If
        End Sub

        Private Sub AllocateWork()
            Do
                ' Remove completed tasks.
                ' Because we are not using foreach, the collection
                ' doesn't need to be locked. It could grow while this
                ' method is working, but that would only result in a
                ' slot being missed until the next pass, which is acceptable.
                ' It can't shrink, because no other methods remove work.
                ' We count in reverse order so a single pass can 
                ' remove multiple entries without rearranging the items
                ' that haven't been scanned.
                ' Deferring the locking improves performance.
                For i As Integer = workers.Count - 1 To 0 Step -1
                    If workers(i).Status = StatusState.Completed Then
                        Dim worker As ThreadWrapperBase = workers(i)
                        SyncLock workersCompleted
                            workersCompleted.Add(worker)
                        End SyncLock
                        SyncLock workers
                            workers.Remove(worker)
                        End SyncLock
                        ' Fire notification event.
                        invokeContext.Invoke(New WorkerCompletedEventHandler(AddressOf OnWorkerCompleted), New Object() {Me, New WorkerCompletedEventArgs(CType(worker, EratosthenesTask))})
                    End If
                Next

                ' Allocate new work while threads are available.
                Do While workersQueued.Count > 0 AndAlso workers.Count < _maxThreads
                    Dim task As ThreadWrapperBase = workersQueued(0)

                    ' Some exception handling code here would be useful
                    ' to prevent performing one part of this sequence
                    ' (starting the task), without the other (removing it
                    ' from the queue).
                    SyncLock workers
                        workers.Add(task)
                    End SyncLock
                    SyncLock workersQueued
                        workersQueued.RemoveAt(0)
                    End SyncLock
                    task.Start()
                Loop

                ' Report progress.
                For i As Integer = workers.Count - 1 To 0 Step -1
                    Dim worker As ThreadWrapperBase = workers(i)
                    If worker.Status = StatusState.InProgress Then
                        ' Fire notification event.
                        If invokeContext.Created Then
                            invokeContext.Invoke(New ReportWorkerProgressEventHandler(AddressOf OnReportWorkerProgress), New Object() {Me, New ReportWorkerProgressEventArgs(worker.ID, worker.Progress)})
                        End If
                    End If
                Next

                ' Pause 2 seconds before the next pass.
                ' You could make this variable configurable.
                Thread.Sleep(TimeSpan.FromSeconds(2))
            Loop
        End Sub


        Public Sub StopAllTasks()
            ' Stop the work allocator.
            allocateWork_Renamed.Abort()
            ' Make sure it's finished.
            allocateWork_Renamed.Join()

            ' Stop the tasks.
            For Each worker As ThreadWrapperBase In workers
                worker.StopTask()
            Next
        End Sub
    End Class


    Public Class ReportWorkerProgressEventArgs : Inherits EventArgs
        Private progress_Renamed As Integer
        Public Property Progress() As Integer
            Get
                Return progress_Renamed
            End Get
            Set
                progress_Renamed = Value
            End Set
        End Property
        Private taskID_Renamed As Guid
        Public Property TaskID() As Guid
            Get
                Return taskID_Renamed
            End Get
            Set
                taskID_Renamed = Value
            End Set
        End Property

'INSTANT VB NOTE: The parameter taskID was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter progress was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
        Public Sub New(ByVal taskID_Renamed As Guid, ByVal progress_Renamed As Integer)
            Progress = progress_Renamed
            TaskID = taskID_Renamed
        End Sub
    End Class


    Public Class WorkerCompletedEventArgs : Inherits EventArgs
        Private primeList_Renamed As String
            Public Property PrimeList() As String
                Get
                    Return primeList_Renamed
                End Get
                Set
                    primeList_Renamed = Value
                End Set
            End Property

            Private id_Renamed As Guid
            Public Property ID() As Guid
                Get
                    Return id_Renamed
                End Get
                Set
                    id_Renamed = Value
                End Set
            End Property
            Public Sub New(ByVal task As EratosthenesTask)
                PrimeList = task.GetResultOfLastTask()
                id_Renamed = task.ID
            End Sub


    End Class
End Namespace
