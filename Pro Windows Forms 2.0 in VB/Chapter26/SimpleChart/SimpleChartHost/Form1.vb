Imports SimpleChartControl

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SimpleChart1.Bars.Add(New BarItem("Sales 2002", 10000))
        SimpleChart1.Bars.Add(New BarItem("Sales 2003", 20000))
        SimpleChart1.Bars.Add(New BarItem("Sales 2004", 5000))
        SimpleChart1.Bars.Add(New BarItem("Sales 2005", 27000))
        SimpleChart1.RebuildChart()
    End Sub
End Class
