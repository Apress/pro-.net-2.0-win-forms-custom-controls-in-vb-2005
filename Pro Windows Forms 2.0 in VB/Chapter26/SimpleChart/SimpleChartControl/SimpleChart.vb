Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles
Imports System.ComponentModel.Design


<Designer(GetType(SimpleChartDesigner))> _
Public Class SimpleChart
    Inherits Control
    Private components As IContainer

    Public Sub New()
        ' This call is required by the Windows.Forms Form Designer.
        InitializeComponent()

        ' TODO: Add any initialization after the InitForm call
        DoubleBuffered = True
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"
    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        ' 
        ' SimpleChart
        ' 
        Me.Size = New System.Drawing.Size(372, 228)
        '            Me.Resize += New System.EventHandler(Me.SimpleChart_Resize);
        Me.ResumeLayout(False)

    End Sub
#End Region

    Private _bars As New BarItemCollection()

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
    Public Property Bars() As BarItemCollection
        Get
            Return _bars
        End Get
        Set(ByVal value As BarItemCollection)
            _bars = value
            RebuildChart()
        End Set
    End Property

    Private barRectangles As List(Of Rectangle) = New List(Of Rectangle)()

    Public Sub RebuildChart()
        If Bars.Count = 0 Then Return

        ' Find out how much space a single bar can occupy.
        Dim barWidth As Integer = Int(Width / Bars.Count)

        ' Set the maximum value on the chart.
        Dim maxValue As Single = 0
        For Each bar As BarItem In Bars
            If bar.Value > maxValue Then
                maxValue = bar.Value
            End If
        Next

        ' Create the rectangle shapes and store them for later use.
        ' Clear any existing shapes.
        barRectangles.Clear()

        ' Track the x-coordinate while laying out the bars.
        Dim x As Integer = 0

        ' Leave some space at the top.
        Dim topMargin As Integer = 5

        ' Leave some space between bars.
        Dim barGap As Integer = 4

        For Each bar As BarItem In Bars
            Dim barHeight As Integer = Int(bar.Value / maxValue * (Me.Height - topMargin))
            Dim top As Integer = Me.Height - barHeight

            barRectangles.Add(New Rectangle(x + barGap / 2, top, _
              barWidth - barGap, barHeight))
            x += barWidth
        Next

        ' Trigger a repaint.
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
        ' Fill the background.
        If Application.RenderWithVisualStyles Then
            Dim renderer As New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupBackground.Normal)
            renderer.DrawBackground(e.Graphics, e.ClipRectangle)
        Else
            ' Use a solid fill with the BackColor.
            Dim brush As Brush = New SolidBrush(MyBase.BackColor)
            e.Graphics.FillRectangle(brush, e.ClipRectangle)
            brush.Dispose()
        End If
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        If barRectangles.Count = 0 Then
            Return
        End If

        For Each rect As Rectangle In barRectangles
            If Application.RenderWithVisualStyles Then
                Dim renderer As New VisualStyleRenderer(VisualStyleElement.StartPanel.UserPane.Normal)
                renderer.DrawBackground(e.Graphics, rect)
            Else
                ' Draw bar (two rectangles are used for a shadowed effect).
                Dim shadowMargin As Integer = 4
                Dim rectShadow As Rectangle = rect
                rectShadow.Offset(shadowMargin, shadowMargin)

                e.Graphics.FillRectangle(Brushes.White, rectShadow)
                e.Graphics.FillRectangle(Brushes.SteelBlue, rect)
            End If
        Next

        ' Draw text separately so it's superimposed on any
        ' overlapping bars.
        Dim index As Integer = 0
        For Each rect As Rectangle In barRectangles
            ' Get title.
            Dim text As String = _bars(index).ShortForm

            ' Get the position.
            Dim textTopOffset As Integer = 10, textLeftOffset As Integer = 15
            Dim ptText As Point = rect.Location
            ptText.Offset(textTopOffset, textLeftOffset)

            ' Draw the title.
            e.Graphics.DrawString(text, Font, Brushes.White, ptText)

            index += 1
        Next

        ' Draw bottom line of the the grid.
        Dim pen As New Pen(Color.Black, 3)
        e.Graphics.DrawLine(pen, 0, Height - 1, Width, Height - 1)
        pen.Dispose()
        'e.Graphics.DrawLine(Pens.Black, 0, 0, 0, base.Height);

    End Sub

    Private toolTip As ToolTip
    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If DesignMode Then
            Return
        End If

        Dim bar As BarItem = HitTest(e.Location)
        If Not bar Is Nothing Then
            ' Get matching value.
            Dim text As String = String.Format("{0:C}", bar.Value)

            ' Get point in form coordinates.
            Dim pt As Point = e.Location
            pt.Offset(MyBase.Location)
            toolTip.Show(text, MyBase.FindForm(), pt)
            Return
        Else
            ' No bar found.
            toolTip.Hide(MyBase.FindForm())
        End If
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        If DesignMode Then
            Dim bar As BarItem = HitTest(e.Location)

            If Not bar Is Nothing Then
                Dim selectService As ISelectionService = CType(GetService(GetType(ISelectionService)), ISelectionService)
                Dim selection As New ArrayList()
                selection.Add(bar)
                selectService.SetSelectedComponents(selection)
            End If

        End If
    End Sub


    Public Function HitTest(ByVal p As Point) As BarItem
        ' Hit test all the bars.
        Dim i As Integer = 0
        Do While i < barRectangles.Count
            If barRectangles(i).Contains(p) Then
                Return _bars(i)
            End If
            i += 1
        Loop
        Return Nothing
    End Function

    Private Sub SimpleChart_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        RebuildChart()
        MyBase.Invalidate()
    End Sub

End Class

