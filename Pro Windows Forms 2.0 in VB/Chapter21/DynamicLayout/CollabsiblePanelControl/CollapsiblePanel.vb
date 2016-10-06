Imports System.Drawing.Drawing2D
Imports System.Drawing.Design
Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles


' This disables the autodock smart tag
'<Designer(GetType(CollapsiblePanelDesigner))> _
<Docking(DockingBehavior.Never)> _
Public Class CollapsiblePanel
    Inherits Panel

    ' Controls
    Private button As CollapseButton
    Private timer As Timer

    ' Fields
    Private collapsing As Boolean
    Private oldHeight As Integer
    Private accelerator As Integer
    Private _collapsed As Boolean


    Public Sub New()
        Me.SetStyle(ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor, True)

        Me.DoubleBuffered = True

        ' Setup button
        button = New CollapseButton()
        button.Size = New Size(Me.Width, 25)
        button.Location = New Point(0, 0)
        button.Font = New Font("Tahoma", 8.0F, FontStyle.Bold)
        button.Dock = DockStyle.Top
        AddHandler button.Click, AddressOf button_Click
        Me.Controls.Add(button)

        ' Set up timer
        timer = New Timer()
        timer.Interval = 25
        AddHandler timer.Tick, AddressOf timer_Tick
    End Sub 'New

    ' Properties

    Public Property Collapsed() As Boolean
        Get
            Return _collapsed
        End Get
        Set(ByVal value As Boolean)
            If Collapsed <> value Then
                _collapsed = value
                If _collapsed Then
                    PerformCollapse()
                Else
                    PerformExpand()
                End If
            End If
        End Set
    End Property

    <Browsable(True)> _
        Public Overrides Property [Text]() As String
        Get
            Return button.Text
        End Get
        Set(ByVal value As String)
            button.Text = value
        End Set
    End Property


    ' Methods
    Private Sub PerformCollapse()
        collapsing = True
        SuspendLayout()
        timer.Enabled = True
    End Sub


    Private Sub PerformExpand()
        collapsing = False
        SuspendLayout()
        timer.Enabled = True
    End Sub


    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        ' Paint parent background
        InvokePaintBackground(Me, New PaintEventArgs(e.Graphics, ClientRectangle))

        ' Fill the rest of the background
        Dim renderer As New VisualStyleRenderer(VisualStyleElement.ExplorerBar.NormalGroupBackground.Normal)

        'renderer.DrawBackground(e.Graphics, e.ClipRectangle);
        Dim paintRectangle As Rectangle = e.ClipRectangle
        paintRectangle.Inflate(1, 1)
        renderer.DrawBackground(e.Graphics, paintRectangle)

        If Not timer.Enabled Then
            MyBase.OnPaint(e)
        End If
    End Sub


    Protected Overrides Sub SetBoundsCore(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, ByVal specified As BoundsSpecified)
        MyBase.SetBoundsCore(x, y, width, height, specified)
        ' My new code
        If Not timer.Enabled And Not Collapsed Then
            oldHeight = height
        End If
    End Sub 'SetBoundsCore


    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If collapsing Then
            Me.Size = New Size(Me.Width, Me.Height - 2 - accelerator)
            If Me.Height <= 25 Then
                Me.Size = New Size(Me.Width, 25)
                timer.Enabled = False
                button.Collapsed = True
                accelerator = 0
                ResumeLayout()
            End If
        Else
            Me.Size = New Size(Me.Width, Me.Height + 2 + accelerator)
            If Me.Height >= oldHeight Then
                Me.Size = New Size(Me.Width, oldHeight)
                timer.Enabled = False
                button.Collapsed = False
                accelerator = 0
                ResumeLayout()
            End If
        End If
        accelerator += 1
    End Sub


    Private Sub button_Click(ByVal sender As Object, ByVal e As EventArgs)
        If Not collapsing Then
            Collapsed = True
        Else
            Collapsed = False
        End If
    End Sub
End Class