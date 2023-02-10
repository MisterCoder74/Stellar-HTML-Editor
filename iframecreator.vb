Public Class iframecreator
    Dim border As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedText = "Yes" Then
            border = "border:1px solid black;"
        ElseIf ComboBox1.SelectedText = "No" Then
            border = "border:none;"
        End If
        Main.RichTextBox1.SelectedText = "<iframe src=" & Chr(34) & TextBox2.Text & Chr(34) & " title=" & Chr(34) & TextBox1.Text & Chr(34) & " width=" & TextBox3.Text & " height=" & TextBox4.Text & " style=" & Chr(34) & border & Chr(34) & ">" & vbCrLf
        Main.RichTextBox1.SelectedText = "</iframe>" & vbCrLf
        Me.Close()


    End Sub
End Class