Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace DocumentView
	Friend Class Program
        Private Shared _appTasks As New ApplicationTasks
        Private Sub New()
        End Sub
        Public Shared ReadOnly Property AppTasks() As ApplicationTasks
            Get
                Return _appTasks
            End Get
        End Property

        Private Shared _documentManager As DocumentManager = New DocumentManager()
        Public Shared ReadOnly Property DocumentManager() As DocumentManager
            Get
                Return _documentManager
            End Get
        End Property

        <STAThread()> _
  Shared Sub Main()
            Application.EnableVisualStyles()

            ' Start with one document.
            AppTasks.[New]()

            Application.Run()
        End Sub
	End Class
End Namespace