#Region "Using directives"


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

#End Region

Namespace MultithreadingWorker
    Public Class Worker
        Public Shared Function FindPrimes(ByVal fromNumber As Integer, ByVal toNumber As Integer) As Integer()
            Return FindPrimes(fromNumber, toNumber, Nothing)
        End Function

        Public Shared Function FindPrimes(ByVal fromNumber As Integer, ByVal toNumber As Integer, ByVal backgroundWorker As System.ComponentModel.BackgroundWorker) As Integer()
            Dim list As Integer() = New Integer(toNumber - fromNumber - 1){}

            ' Create an array containing all integers between the two specified numbers.
            Dim i As Integer = 0
            Do While i < list.Length
                list(i) = fromNumber
                fromNumber += 1
                i += 1
            Loop


            'find out the module for each item in list, divided by each d, where
            'd is < or == to sqrt(to)
            'if the remainder is 0, the nubmer is a composite, and thus
            'we mark its position with 0 in the marks array,
            'otherwise the number is a prime, and thus mark it with 1
            Dim maxDiv As Integer = CInt(Fix(Math.Floor(Math.Sqrt(toNumber))))

            Dim mark As Integer() = New Integer(list.Length - 1){}


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
                If (i Mod iteration = 0) AndAlso (Not backgroundWorker Is Nothing) Then
                    If backgroundWorker.WorkerReportsProgress Then
                        'float progress = ((float)(i + 1)) / list.Length * 100;
                        backgroundWorker.ReportProgress(CInt(i / iteration))
                            '(int)Math.Round(progress));
                    End If
                    If backgroundWorker.CancellationPending Then
                        ' Return without doing any more work.
                        Return Nothing
                    End If
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

            Dim ret As Integer() = New Integer(primes - 1){}
            Dim curs As Integer = 0
            i = 0
            Do While i < mark.Length
                If mark(i) = 0 Then
                    ret(curs) = list(i)
                    curs += 1
                End If
                i += 1
            Loop

            If Not backgroundWorker Is Nothing Then
                backgroundWorker.ReportProgress(100)
            End If

            Return ret

        End Function


    End Class
End Namespace
