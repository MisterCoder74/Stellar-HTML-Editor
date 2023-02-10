Public Class listcreator
    Dim openingstring As String
    Dim closingstring As String
    Dim itemsnumber As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If ComboBox1.SelectedIndex = 0 Then
                openingstring = "<ol>"
                closingstring = "</ol>"
                Main.RichTextBox1.SelectedText = openingstring & vbCrLf
                For itemsnumber = 1 To Val(TextBox1.Text)
                    Main.RichTextBox1.SelectedText = "<li> </li>" & vbCrLf
                Next
                Main.RichTextBox1.SelectedText = closingstring & vbCrLf

            ElseIf ComboBox1.SelectedIndex = 1 Then
                openingstring = "<ul>"
                closingstring = "</ul>"
                Main.RichTextBox1.SelectedText = openingstring & vbCrLf
                For itemsnumber = 1 To Val(TextBox1.Text)
                    Main.RichTextBox1.SelectedText = "<li> </li>" & vbCrLf
                Next
                Main.RichTextBox1.SelectedText = closingstring & vbCrLf

            ElseIf ComboBox1.SelectedIndex = 2 Then
                openingstring = "<menu>"
                closingstring = "</menu>"
                Main.RichTextBox1.SelectedText = openingstring & vbCrLf & closingstring & vbCrLf

            ElseIf ComboBox1.SelectedIndex = 3 Then
                openingstring = "<dl>"
                closingstring = "</dl>"
                Main.RichTextBox1.SelectedText = openingstring & vbCrLf
                For itemsnumber = 1 To Val(TextBox1.Text)
                    Main.RichTextBox1.SelectedText = "<dt > </dt>" & vbCrLf & "<dd> </dd>" & vbCrLf
                Next
                Main.RichTextBox1.SelectedText = closingstring & vbCrLf
            Else
                MsgBox("Please fill the needed fields.")
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("Please fill the needed fields.")
        End Try

       
    End Sub
End Class