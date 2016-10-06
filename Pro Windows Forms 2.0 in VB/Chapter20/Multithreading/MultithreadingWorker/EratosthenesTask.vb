Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace MultithreadingWorker
    Public Delegate Sub FindPrimesCompletedEventHandler(ByVal sender As Object, ByVal e As FindPrimesCompletedEventArgs)

    Public Class EratosthenesTask
        Inherits ThreadWrapperBase
        Public Event Completed As FindPrimesCompletedEventHandler

        ' Store the input and output information.
        Private fromNumber, toNumber As Integer
        Private primeList As String

        Public Sub New(ByVal fromNumber As Integer, ByVal toNumber As Integer)
            Me.fromNumber = fromNumber
            Me.toNumber = toNumber
            SupportsProgress = True
        End Sub

        Protected Overrides Sub DoTask()
            Dim list As Integer() = New Integer(toNumber - fromNumber - 1) {}
            Dim fromNumberCurrent As Integer = fromNumber

            ' Create an array containing all integers between the two specified numbers.
            Dim i As Integer = 0
            Do While i < list.Length
                list(i) = fromNumberCurrent
                fromNumberCurrent += 1
                i += 1
            Loop


            'find out the module for each item in list, divided by each d, where
            'd is < or == to sqrt(to)
            'if the remainder is 0, the nubmer is a composite, and thus
            'we mark its position with 0 in the marks array,
            'otherwise the number is a prime, and thus mark it with 1
            Dim maxDiv As Integer = CInt(Fix(Math.Floor(Math.Sqrt(toNumber))))

            Dim mark As Integer() = New Integer(list.Length - 1) {}


            i = 0
            Do While i < list.Length
                Dim j As Integer = 2
                Do While j <= maxDiv

                    If (list(i) <> j) AndAlso (list(i) Mod j = 0) Then
                        mark(i) = 1
                    End If

                    j += 1
                Loop

                Dim iteration As Integer = CInt(list.Length / 100)
                If i Mod iteration = 0 Then
                    _progress = CInt(i / iteration)
                End If

                i += 1
            Loop

            'create new array that contains only the primes, and return that array
            Dim primes As Integer = 0
            i = 0
            Do While i < mark.Length
                If mark(i) = 0 Then
                    primes += 1
                End If

                i += 1
            Loop

            Dim ret As Integer() = New Integer(primes - 1) {}
            Dim curs As Integer = 0
            i = 0
            Do While i < mark.Length
                If mark(i) = 0 Then
                    ret(curs) = list(i)
                    curs += 1
                End If
                i += 1
            Loop

            ' Paste the list of primes together into one long string.
            Dim sb As New StringBuilder()
            For Each prime As Integer In ret
                sb.Append(prime.ToString())
                sb.Append("  ")
            Next
            ' Store the result.
            primeList = sb.ToString()
        End Sub

        Protected Overrides Sub OnCompleted()
            
            RaiseEvent Completed(Me, New FindPrimesCompletedEventArgs(fromNumber, toNumber, primeList))

        End Sub

        ' Allow access to the result once the task is finished.
        Public Function GetResultOfLastTask() As String
            If Status = StatusState.Completed Then
                Return primeList
            Else
                Return ""
            End If
        End Function
    End Class


    Public Class FindPrimesCompletedEventArgs : Inherits EventArgs
        Private _primeList As String
        Public Property PrimeList() As String
            Get
                Return _primeList
            End Get
            Set(ByVal value As String)
                _primeList = Value
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

        Private _to As Integer
        Public Property [To]() As Integer
            Get
                Return _to
            End Get
            Set(ByVal value As Integer)
                _to = Value
            End Set
        End Property

        Public Sub New(ByVal from As Integer, ByVal [to] As Integer, ByVal primeList As String)
            _from = from
            _to = [to]
            _primeList = primeList
        End Sub
    End Class
End Namespace
