#Region "Using directives"


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
#End Region

Namespace MultithreadingWorker
    Public Enum StatusState
        Unstarted
        InProgress
        Completed
    End Enum

    Public MustInherit Class ThreadWrapperBase

        ' Track the status of the task.
        Private _status As StatusState = StatusState.Unstarted
        Public ReadOnly Property Status() As StatusState
            Get
                Return _status
            End Get
        End Property

        ' Use a unique ID to track the task later, if needed.
        Private _id As Guid = Guid.NewGuid()
        Public ReadOnly Property ID() As Guid
            Get
                Return _id
            End Get
        End Property


        ' This is the thread where the task is carried out.
        Private thread As Thread

        ' Start the new operation.
        Public Sub Start()
            If _status = StatusState.InProgress Then
                Throw New InvalidOperationException("Already in progress.")
            Else
                ' Initialize the new task.
                _status = StatusState.InProgress

                ' Create the thread and run it in the background,
                ' so it will terminate automatically if the application ends.
                thread = New Thread(AddressOf StartTaskAsync)
                thread.IsBackground = True

                ' Start the thread.
                thread.Start()
            End If
        End Sub

        Private Sub StartTaskAsync()
            DoTask()
            _status = StatusState.Completed
            OnCompleted()
        End Sub

        ' Override this class to supply the task logic.
        Protected MustOverride Sub DoTask()

        ' Override this class to supply the callback logic.
        Protected MustOverride Sub OnCompleted()

        ' Flag that indicates a stop is requested.
        Private _requestCancel As Boolean = False
        Protected ReadOnly Property RequestCancel() As Boolean
            Get
                Return _requestCancel
            End Get
        End Property

        ' How long the thread will wait (in total)
        ' before aborting a thread that hasn't responded to
        ' the cancellation message.
        ' TimeSpan.Zero means polite stops are not enabled.
        Private _cancelWaitTime As TimeSpan = TimeSpan.Zero
        Protected Property CancelWaitTime() As TimeSpan
            Get
                Return _cancelWaitTime
            End Get
            Set(ByVal value As TimeSpan)
                _cancelWaitTime = value
            End Set
        End Property

        ' How often the thread checks to see if a cancellation
        ' message has been heeded.
        Private _cancelCheckInterval As Integer = 5
        Protected Property CancelCheckInterval() As Integer
            Get
                Return _cancelCheckInterval
            End Get
            Set(ByVal value As Integer)
                _cancelCheckInterval = value
            End Set
        End Property

        Public Sub StopTask()
            ' Perform no operation if task isn't running.
            If _status <> StatusState.InProgress Then
                Return
            End If

            ' Try the polite approach.
            If _cancelWaitTime <> TimeSpan.Zero Then
                Dim startTime As DateTime = DateTime.Now
                Do While DateTime.Now.Subtract(startTime).TotalSeconds > 0
                    ' Still waiting for the time limit to pass.
                    ' Allow other threads to do some work.
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(_cancelCheckInterval))
                Loop
            End If

            ' Use the forced approach.
            thread.Abort()
        End Sub

        ' Add Pause and Resume methods here.

        Private _supportsProgress As Boolean = False
        Protected Property SupportsProgress() As Boolean
            Get
                Return _supportsProgress
            End Get
            Set(ByVal value As Boolean)
                _supportsProgress = Value
            End Set
        End Property

        Protected _progress As Integer
        Public ReadOnly Property Progress() As Integer
            Get
                If (Not _supportsProgress) Then
                    Throw New InvalidOperationException("This worker does not report progess.")
                Else
                    Return _progress
                End If
            End Get
        End Property
    End Class

End Namespace
