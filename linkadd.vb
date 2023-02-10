Public Class linkadd

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim target As String
        If CheckBox1.CheckState = CheckState.Checked Then
            target = "_blank"
        Else
            target = ""
        End If
        Main.RichTextBox1.SelectedText = "<a href=" & Chr(34) & TextBox1.Text & Chr(34) & " target=" & Chr(34) & target & Chr(34) & ">" & TextBox2.Text & "</a>"
        Me.Close()
    End Sub
End Class