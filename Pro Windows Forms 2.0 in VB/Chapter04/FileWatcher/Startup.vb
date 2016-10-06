Public Module Startup

    Public Sub Main()
        ' Apply the Windows XP look (if available).
        Application.EnableVisualStyles()

        ' Create the component (and begin showing the icon). 
        Dim Watcher As New FileWatcher

        ' No forms are currently displayed.
        ' Start a message loop and don't exit.
        Application.Run()
    End Sub

End Module

