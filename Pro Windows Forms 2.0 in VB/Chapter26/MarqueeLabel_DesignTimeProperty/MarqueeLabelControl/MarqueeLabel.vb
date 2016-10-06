Imports System.ComponentModel

<Designer(GetType(MarqueeLabelDesigner))> _
Public Class MarqueeLabel
    Implements ISupportInitialize

    Private _text As String
    Private _scrollAmount As Integer = 10
    Private position As Integer = 0

    Public Overrides Property Text() As String
        Get
            Return _text
        End Get
        Set(ByVal value As String)
            _text = value
            Invalidate()
        End Set
    End Property

    Public Property ScrollTimeInterval() As Integer
        Get
            Return tmrScroll.Interval
        End Get
        Set(ByVal value As Integer)
            tmrScroll.Interval = value
        End Set
    End Property

    Public Property ScrollPixelAmount() As Integer
        Get
            Return _scrollAmount
        End Get
        Set(ByVal value As Integer)
            _scrollAmount = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        DoubleBuffered = True
        ResizeRedraw = True
    End Sub

    Public Sub Scroll(ByVal state As Boolean)
        tmrScroll.Enabled = state
    End Sub

    Private Sub tmrScroll_Tick(ByVal sender As Object, ByVal e As EventArgs) _
  Handles tmrScroll.Tick
        position += ScrollPixelAmount

        ' Force a refresh.
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)

        If position > Width Then
            ' Reset the text to scroll back onto the control.
            position = -CInt(e.Graphics.MeasureString(Text, Font).Width)
        End If
        e.Graphics.DrawString(Text, Font, New SolidBrush(ForeColor), position, 0)
    End Sub

    Private Sub BeginInit() Implements ISupportInitialize.BeginInit

    End Sub

    Private Sub EndInit() Implements ISupportInitialize.EndInit
        If Not DesignMode Then
            tmrScroll.Enabled = True
        End If

    End Sub
End Class
