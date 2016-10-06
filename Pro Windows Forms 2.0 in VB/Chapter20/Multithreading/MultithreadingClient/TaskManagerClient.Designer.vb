Imports Microsoft.VisualBasic
Imports System
Namespace MultithreadingClient
    Public Partial Class TaskManagerClient
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.cmdFind = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtTo = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.txtFrom = New System.Windows.Forms.TextBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.listTasks = New System.Windows.Forms.ListView()
            Me.ID = New System.Windows.Forms.ColumnHeader()
            Me.Range = New System.Windows.Forms.ColumnHeader()
            Me.Status = New System.Windows.Forms.ColumnHeader()
            Me.taskManager = New MultithreadingWorker.TaskManager()
            Me.GroupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' GroupBox1
            ' 
            Me.GroupBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.GroupBox1.Controls.Add(Me.cmdFind)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.txtTo)
            Me.GroupBox1.Controls.Add(Me.Label2)
            Me.GroupBox1.Controls.Add(Me.txtFrom)
            Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(443, 104)
            Me.GroupBox1.TabIndex = 2
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Find Prime Numbers"
            ' 
            ' cmdFind
            ' 
            Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cmdFind.Location = New System.Drawing.Point(211, 28)
            Me.cmdFind.Name = "cmdFind"
            Me.cmdFind.Size = New System.Drawing.Size(112, 24)
            Me.cmdFind.TabIndex = 5
            Me.cmdFind.Text = "Find Primes"
'            Me.cmdFind.Click += New System.EventHandler(Me.cmdFind_Click);
            ' 
            ' Label3
            ' 
            Me.Label3.Location = New System.Drawing.Point(16, 60)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(52, 20)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "To:"
            ' 
            ' txtTo
            ' 
            Me.txtTo.Location = New System.Drawing.Point(80, 56)
            Me.txtTo.Name = "txtTo"
            Me.txtTo.Size = New System.Drawing.Size(100, 21)
            Me.txtTo.TabIndex = 3
            Me.txtTo.Text = "500000"
            ' 
            ' Label2
            ' 
            Me.Label2.Location = New System.Drawing.Point(16, 32)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(52, 20)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "From:"
            ' 
            ' txtFrom
            ' 
            Me.txtFrom.Location = New System.Drawing.Point(80, 28)
            Me.txtFrom.Name = "txtFrom"
            Me.txtFrom.Size = New System.Drawing.Size(100, 21)
            Me.txtFrom.TabIndex = 0
            Me.txtFrom.Text = "1"
            ' 
            ' groupBox2
            ' 
            Me.groupBox2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.groupBox2.Controls.Add(Me.listTasks)
            Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox2.Location = New System.Drawing.Point(12, 122)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(443, 271)
            Me.groupBox2.TabIndex = 9
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Current Searches"
            ' 
            ' listTasks
            ' 
            Me.listTasks.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.listTasks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.ID, Me.Range, Me.Status})
            Me.listTasks.Location = New System.Drawing.Point(11, 22)
            Me.listTasks.MultiSelect = False
            Me.listTasks.Name = "listTasks"
            Me.listTasks.Size = New System.Drawing.Size(417, 234)
            Me.listTasks.TabIndex = 0
            Me.listTasks.UseCompatibleStateImageBehavior = False
            Me.listTasks.View = System.Windows.Forms.View.Details
'            Me.listTasks.DoubleClick += New System.EventHandler(Me.listTasks_DoubleClick);
            ' 
            ' ID
            ' 
            Me.ID.Name = "ID"
            Me.ID.Text = "ID"
            Me.ID.Width = 106
            ' 
            ' Range
            ' 
            Me.Range.Name = "Range"
            Me.Range.Text = "Range"
            Me.Range.Width = 124
            ' 
            ' Status
            ' 
            Me.Status.Name = "Status"
            Me.Status.Text = "Status"
            Me.Status.Width = 109
            ' 
            ' taskManager
            ' 
            Me.taskManager.MaxThreads = 2
'            Me.taskManager.WorkerCompleted += New MultithreadingWorker.WorkerCompletedEventHandler(Me.taskManager_WorkerCompleted);
'            Me.taskManager.ReportWorkerProgress += New MultithreadingWorker.ReportWorkerProgressEventHandler(Me.taskManager_ReportWorkerProgress);
            ' 
            ' TaskManagerClient
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(467, 423)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.Name = "TaskManagerClient"
            Me.Text = "Task Manager Client"
'            Me.Load += New System.EventHandler(Me.TaskManagerClient_Load);
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private GroupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents cmdFind As System.Windows.Forms.Button
        Private Label3 As System.Windows.Forms.Label
        Private txtTo As System.Windows.Forms.TextBox
        Private Label2 As System.Windows.Forms.Label
        Private txtFrom As System.Windows.Forms.TextBox
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents taskManager As MultithreadingWorker.TaskManager
        Private WithEvents listTasks As System.Windows.Forms.ListView
        Private ID As System.Windows.Forms.ColumnHeader
        Private Range As System.Windows.Forms.ColumnHeader
        Private Status As System.Windows.Forms.ColumnHeader
    End Class
End Namespace