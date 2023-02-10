Public Class formcreator

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Main.RichTextBox1.SelectedText = "<form>" & vbCrLf & "<input name=" & Chr(34) & "q" & Chr(34) & " type=" & Chr(34) & "search" & Chr(34) & ">" & vbCrLf & "<input type=" & Chr(34) & "submit" & Chr(34) & " value=" & Chr(34) & "Find" & Chr(34) & ">" & vbCrLf
        Main.RichTextBox1.SelectedText = "</form>" & vbCrLf
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        main.RichTextBox1.SelectedText = "<form method=" & Chr(34) & "post" & Chr(34) & " action=" & Chr(34) & "(insert script name here)" & Chr(34) & ">" & vbCrLf
        main.RichTextBox1.SelectedText = "<input type=" & Chr(34) & "text" & Chr(34) & " name=" & Chr(34) & "login" & Chr(34) & " value=" & Chr(34) & " " & Chr(34) & " placeholder=" & Chr(34) & "Username or Email" & Chr(34) & "> userID or e-mail<br>" & vbCrLf
        main.RichTextBox1.SelectedText = "<input type=" & Chr(34) & "text" & Chr(34) & " name=" & Chr(34) & "password" & Chr(34) & " value=" & Chr(34) & " " & Chr(34) & " placeholder=" & Chr(34) & "Password" & Chr(34) & "> password<br>" & vbCrLf
        main.RichTextBox1.SelectedText = "<input type=" & Chr(34) & "checkbox" & Chr(34) & " name=" & Chr(34) & "remember_me" & Chr(34) & " id=" & Chr(34) & "remember_me" & Chr(34) & "> Remember me on this computer<br>" & vbCrLf
        Main.RichTextBox1.SelectedText = "<input type=" & Chr(34) & "submit" & Chr(34) & " name=" & Chr(34) & "Login" & Chr(34) & " value=" & Chr(34) & "Login" & Chr(34) & ">" & vbCrLf
        Main.RichTextBox1.SelectedText = "</form>" & vbCrLf
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        main.RichTextBox1.SelectedText = "<form method=" & Chr(34) & "post" & Chr(34) & " action=" & Chr(34) & "(insert script name here)" & Chr(34) & " enctype=" & Chr(34) & "multipart/form-data" & Chr(34) & " > " & vbCrLf
        main.RichTextBox1.SelectedText = "<input type=" & Chr(34) & "text" & Chr(34) & " name=" & Chr(34) & "textline" & Chr(34) & " size=" & Chr(34) & "30" & Chr(34) & "> (some text here)<br>" & vbCrLf
        Main.RichTextBox1.SelectedText = "<input type=" & Chr(34) & "file" & Chr(34) & " id=" & Chr(34) & "file" & Chr(34) & " name=" & Chr(34) & "datafile" & Chr(34) & " size=" & Chr(34) & "30" & Chr(34) & "> File to upload<br>" & vbCrLf
        Main.RichTextBox1.SelectedText = "<label for=" & Chr(34) & "file" & Chr(34) & "> Browse </label>" & vbCrLf
        Main.RichTextBox1.SelectedText = "<button> Submit </button>" & vbCrLf
        Main.RichTextBox1.SelectedText = "</form>" & vbCrLf
        Me.Close()
    End Sub

   
End Class