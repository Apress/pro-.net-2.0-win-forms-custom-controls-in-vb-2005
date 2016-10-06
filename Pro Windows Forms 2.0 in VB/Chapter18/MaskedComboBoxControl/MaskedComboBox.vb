Imports System.ComponentModel

Public Class MaskedComboBox
    Inherits ComboBox

    Private maskProvider As MaskedTextProvider

    Public Property Mask() As String
        Get
            If maskProvider Is Nothing Then
                Return ""
            Else
                Return maskProvider.Mask
            End If
        End Get
        Set(ByVal value As String)
            If value = "" Then
                maskProvider = Nothing
                Me.Text = ""
            Else
                ' This is necessary because the Mask property is read-only.
                maskProvider = New MaskedTextProvider(value)
                Me.Text = maskProvider.ToDisplayString()
            End If
        End Set
    End Property

    Public ReadOnly Property MaskCompleted() As Boolean
        Get
            Return maskProvider.MaskCompleted
        End Get
    End Property

    Private Function SkipToEditableCharacter(ByVal startPos As Integer) _
      As Integer
        Dim newPos As Integer = maskProvider.FindEditPositionFrom(startPos, True)
        If newPos = -1 Then
            ' Already at the end of the string.
            Return startPos
        Else
            Return newPos
        End If
    End Function

    Private Sub RefreshText(ByVal pos As Integer)
        Me.Text = maskProvider.ToDisplayString()

        ' Position cursor.
        Me.SelectionStart = pos
    End Sub

    Private Declare Function GetKeyState Lib "User32.dll" ( _
  ByVal key As Integer) As Integer

    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)
        If maskProvider IsNot Nothing Then
            Dim pos As Integer = Me.SelectionStart

            ' Deleting a character (backspace).
            ' Currently this steps over a format character
            ' (unlinked MaskedTextBox, which steps over and
            ' deletes the next input character).
            ' You could use the private SkipToEditableCharacter()
            ' method to change this behavior.
            If Asc(e.KeyChar) = CInt(Keys.Back) Then
                If pos > 0 Then
                    pos -= 1
                    maskProvider.RemoveAt(pos)
                End If

                ' Adding a character.
            ElseIf pos < Me.Text.Length Then
                pos = SkipToEditableCharacter(pos)

                ' Overwrite mode is on.
                If GetKeyState(CInt(Keys.Insert)) = 1 Then
                    If maskProvider.Replace(e.KeyChar, pos) Then
                        pos += 1
                    End If
                    ' Insert mode is on.
                Else
                    If maskProvider.InsertAt(e.KeyChar, pos) Then
                        pos += 1
                    End If
                End If

                ' Find the new cursor position.
                pos = SkipToEditableCharacter(pos)
            End If

            RefreshText(pos)
            e.Handled = True
        End If

        MyBase.OnKeyPress(e)
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        Dim pos As Integer = Me.SelectionStart

        ' Deleting a character (Delete key).
        ' Currently this does nothing if you try to delete
        ' a format character (unliked MaskedTextBox, which
        ' deletes the next input character).
        ' You could use the private SkipToEditableCharacter
        ' method to change this behavior.
        If CInt(e.KeyCode) = CInt(Keys.Delete) And pos < Me.Text.Length Then
            If maskProvider.RemoveAt(pos) Then
                RefreshText(pos)
            End If
            e.Handled = True
        End If

        MyBase.OnKeyDown(e)
    End Sub

End Class
