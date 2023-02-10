Public Class imageadd

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Main.RichTextBox1.SelectedText = "<img src=" & Chr(34) & TextBox1.Text & Chr(34) & ">"
        Me.Close()
    End Sub
End Class