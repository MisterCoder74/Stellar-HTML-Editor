Public Class datalistcreator
  
    Dim itemsnumber As Integer = 0

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Main.RichTextBox1.SelectedText = "<label for=" & Chr(34) & TextBox2.Text & Chr(34) & ">" & TextBox1.Text & "</label><br>" & vbCrLf
        Main.RichTextBox1.SelectedText = "<input list=" & Chr(34) & TextBox3.Text & Chr(34) & " id=" & Chr(34) & TextBox2.Text & Chr(34) & " name=" & Chr(34) & TextBox2.Text & Chr(34) & ">" & vbCrLf
        Main.RichTextBox1.SelectedText = "<datalist id=" & Chr(34) & TextBox3.Text & Chr(34) & ">" & vbCrLf
        For itemsnumber = 1 To Val(TextBox4.Text)
            Main.RichTextBox1.SelectedText = "<option value=" & Chr(34) & " " & Chr(34) & ">" & vbCrLf
        Next
        Main.RichTextBox1.SelectedText = "</datalist>" & vbCrLf
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        Button1.Enabled = True
    End Sub
End Class