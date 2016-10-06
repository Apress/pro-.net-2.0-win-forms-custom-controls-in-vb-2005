Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Xml
Imports System.Windows.Forms


Public Class SurveyDeserializer
    Private fileName As String
    Private targetContainer As Panel
    Public Sub New(ByVal fileName As String, ByVal targetContainer As Panel)
        Me.fileName = fileName
        Me.targetContainer = targetContainer
    End Sub

    Public Sub LoadForm()
        ' Dispose the child controls.
        For Each ctrl As Control In targetContainer.Controls
            ctrl.Dispose()
        Next

        Try
            ' Load the form into memory.
            Dim doc As New XmlDocument()
            doc.Load(fileName)

            ' Iterate over panel nodes.
            For Each nodePanel As XmlNode In doc.DocumentElement.ChildNodes
                ' Convert the element name into the appropriate enum value.
                Dim type As PanelTypes = CType(System.Enum.Parse(GetType(PanelTypes), nodePanel.LocalName), PanelTypes)

                ' Check for caption node.
                Dim caption As String = CheckForAttribute(nodePanel, "caption")

                ' Create the container for this survey element.
                ' It's placed into the next available cell.
                Dim container As Control = CreateContainer(type, caption)
                container.SuspendLayout()

                ' Iterate over the nested nodes.        
                For Each nodeItem As XmlNode In nodePanel.ChildNodes
                    ' Get the node information.
                    Dim id As String = CheckForAttribute(nodeItem, "id")
                    caption = CheckForAttribute(nodeItem, "caption")
                    If caption = "" Then
                        caption = id
                    End If

                    ' Create the content inside the survey element.
                    CreateContent(type, nodeItem.LocalName, caption, id, container)
                Next
                container.ResumeLayout()
            Next
        Catch err As Exception
            MessageBox.Show("Failure parsing file." & Constants.vbLf + err.Message)
        End Try
    End Sub

    Private Function CreateContainer(ByVal type As PanelTypes, ByVal caption As String) As Control
        ' Represents the top-level container
        ' (a TableLayoutPanel or FlowLayoutPanel,
        ' depending on the survey element).
        Dim pnlTable As TableLayoutPanel = Nothing
        Dim pnlFlow As FlowLayoutPanel = Nothing

        ' Represents the control object that contains
        ' the rest of the survey content.
        ' Often, this is the same as the top-level
        ' container, but not so with the CheckBoxList.
        ' For this survey element, a FlowLayoutPanel
        ' hosts the caption and CheckBoxList, but
        ' the CheckBoxList is container for survey elements,
        ' not the FlowLayoutPanel.
        Dim container As Control = Nothing

        ' Represents a caption that can be inserted at
        ' the top of the panel.
        Dim lblCaption As Label

        Select Case type
            Case PanelTypes.TextBoxPanel
                pnlTable = New TableLayoutPanel()
                pnlTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
                pnlTable.ColumnCount = 2

                ' Make sure the full width of the form is used
                ' for the text box.
                pnlTable.Anchor = AnchorStyles.Left Or AnchorStyles.Right

                container = pnlTable

            Case PanelTypes.GroupSelectionPanel
                pnlFlow = New FlowLayoutPanel()

                ' Each radio button should take
                ' a full line.
                pnlFlow.FlowDirection = FlowDirection.TopDown

                ' Add a caption.
                lblCaption = New Label()
                lblCaption.Text = caption
                lblCaption.AutoSize = True
                pnlFlow.Controls.Add(lblCaption)

                container = pnlFlow

            Case PanelTypes.CheckBoxListPanel
                pnlTable = New TableLayoutPanel()
                pnlTable.ColumnCount = 1

                ' Add a caption.
                lblCaption = New Label()
                lblCaption.Text = caption
                lblCaption.AutoSize = True
                pnlTable.Controls.Add(lblCaption)

                ' Add the checkbox list.
                Dim checks As New CheckedListBox()
                checks.AutoSize = True
                pnlTable.Controls.Add(checks)

                container = checks

            Case PanelTypes.LargeTextBoxPanel
                pnlTable = New TableLayoutPanel()
                pnlTable.ColumnCount = 1
                pnlTable.Anchor = AnchorStyles.Left Or AnchorStyles.Right

                ' Add a caption.
                lblCaption = New Label()
                lblCaption.Text = caption
                lblCaption.AutoSize = True
                pnlTable.Controls.Add(lblCaption)

                container = pnlTable
        End Select

        ' Add the top-level container (the
        ' FlowLayoutPanel or TableLayoutPanel)
        ' to the table.
        Dim pnl As Panel = Nothing
        If Not pnlTable Is Nothing Then
            pnl = pnlTable
        Else
            pnl = pnlFlow
        End If
        pnl.AutoSize = True
        pnl.Margin = New Padding(7)
        targetContainer.Controls.Add(pnl)

        ' Return the container control, so more content can
        ' be inserted inside it.
        Return container
    End Function

    Private Sub CreateContent(ByVal type As PanelTypes, ByVal elementName As String, ByVal caption As String, ByVal id As String, ByVal container As Control)
        Dim ctrl As Control = Nothing
        Select Case type
            Case PanelTypes.TextBoxPanel
                If elementName <> "TextItem" Then
                    Throw New XmlException("Element " & elementName & " not expected")
                End If
                ctrl = New Label()
                ctrl.Text = caption
                container.Controls.Add(ctrl)

                ctrl = New TextBox()
                ctrl.Name = id
                ctrl.Dock = DockStyle.Fill
                container.Controls.Add(ctrl)
            Case PanelTypes.GroupSelectionPanel
                If elementName <> "SelectionItem" Then
                    Throw New XmlException("Element " & elementName & " not expected")
                End If
                ctrl = New RadioButton()

                ctrl.Name = id
                ctrl.Text = caption
                ctrl.Margin = New Padding(3, 0, 3, 0)
                container.Controls.Add(ctrl)
            Case PanelTypes.CheckBoxListPanel
                If elementName <> "SelectionItem" Then
                    Throw New XmlException("Element " & elementName & " not expected")
                End If
                CType(container, CheckedListBox).Items.Add(New CheckBoxListItem(caption, id))
            Case PanelTypes.LargeTextBoxPanel
                If elementName <> "TextItem" Then
                    Throw New XmlException("Element " & elementName & " not expected")
                End If
                ctrl = New TextBox()
                ctrl.Dock = DockStyle.Fill
                CType(ctrl, TextBox).WordWrap = True
                CType(ctrl, TextBox).AcceptsReturn = True
                CType(ctrl, TextBox).Multiline = True
                ctrl.Height *= 3
                container.Controls.Add(ctrl)
        End Select
    End Sub

    Private Function CheckForAttribute(ByVal node As XmlNode, ByVal name As String) As String
        For Each attr As XmlAttribute In node.Attributes
            If attr.Name = name Then
                Return attr.Value
            End If
        Next
        Return ""
    End Function

    Public Class CheckBoxListItem
        Public Caption As String
        Public ID As String

        Public Sub New(ByVal caption As String, ByVal id As String)
            Me.Caption = caption
            Me.ID = id
        End Sub

        Public Overrides Function ToString() As String
            Return Caption
        End Function
    End Class

    Public Enum PanelTypes
        TextBoxPanel
        GroupSelectionPanel
        CheckBoxListPanel
        LargeTextBoxPanel
    End Enum
End Class

