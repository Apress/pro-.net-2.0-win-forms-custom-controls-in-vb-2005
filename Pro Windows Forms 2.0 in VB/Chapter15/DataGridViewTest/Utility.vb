Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace DataGridViewTest
	Public Class Utility
		Private Sub New()
		End Sub
		Public Shared Function SplitStringByCase(ByVal inputString As String) As String
			If inputString = "" Then
				Return ""
			Else
				Dim sb As StringBuilder = New System.Text.StringBuilder()

				' Add first character.
				sb.Append(inputString.Chars(0))

				' Add middle characters. Insert space before capitals.
				Dim i As Integer = 1
				Do While i < inputString.Length - 1
					Dim c As Char = inputString.Chars(i)
					' Skip existing spaces (if any).
					If c = " "c Then
						sb.Append(c)
						i += 1
						sb.Append(Char.ToUpper(inputString.Chars(i)))
						Continue Do
					End If

					If Char.IsUpper(c) Then
						sb.Append(" ")
					End If

					sb.Append(c)
					i += 1
				Loop

				' Add last character.
				sb.Append(inputString.Chars(inputString.Length - 1))
				Return sb.ToString()
			End If
		End Function
	End Class
End Namespace
