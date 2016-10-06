Module Startup

    Public Main1 As New Form1()
    Public Main2 As New Form1()
    Public Child As New Form2()

    Public Sub Main()

        Application.EnableVisualStyles()
        Main1.Text = "Parent 2"
        Main2.Text = "Parent 1"
        Main1.Show()
        Main2.Show()

        Child.MdiParent = Main2
        Child.Show()

        System.Windows.Forms.Application.Run()
    End Sub

End Module
