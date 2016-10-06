Partial Class FileWatcher
    Inherits System.ComponentModel.Component

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal Container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        Container.Add(Me)

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileWatcher))
        Me.fileSystemWatcher1 = New System.IO.FileSystemWatcher
        Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmdShowFiles = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdExit = New System.Windows.Forms.ToolStripMenuItem
        Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        CType(Me.fileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuStrip1.SuspendLayout()
        '
        'fileSystemWatcher1
        '
        Me.fileSystemWatcher1.EnableRaisingEvents = True
        Me.fileSystemWatcher1.IncludeSubdirectories = True
        Me.fileSystemWatcher1.Path = "c:\"
        '
        'contextMenuStrip1
        '
        Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdShowFiles, Me.cmdExit})
        Me.contextMenuStrip1.Name = "contextMenuStrip1"
        Me.contextMenuStrip1.Size = New System.Drawing.Size(104, 26)
        '
        'cmdShowFiles
        '
        Me.cmdShowFiles.Name = "cmdShowFiles"
        Me.cmdShowFiles.Size = New System.Drawing.Size(135, 22)
        Me.cmdShowFiles.Text = "Show Files"
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(103, 22)
        Me.cmdExit.Text = "Exit"
        '
        'notifyIcon1
        '
        Me.notifyIcon1.ContextMenuStrip = Me.contextMenuStrip1
        Me.notifyIcon1.Icon = CType(resources.GetObject("notifyIcon1.Icon"), System.Drawing.Icon)
        Me.notifyIcon1.Text = "My .NET Application"
        Me.notifyIcon1.Visible = True
        CType(Me.fileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuStrip1.ResumeLayout(False)

    End Sub
    Private WithEvents fileSystemWatcher1 As System.IO.FileSystemWatcher
    Private WithEvents contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents cmdShowFiles As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmdExit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
