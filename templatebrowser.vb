Public Class templatebrowser

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim FilePath As String = TextBox2.Text & "/" & ListBox1.SelectedItem.ToString
        TextBox1.Text = System.IO.File.ReadAllText(FilePath)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim FilePath As String = TextBox2.Text & "/" & ListBox1.SelectedItem.ToString
        Main.RichTextBox1.SelectedText = System.IO.File.ReadAllText(FilePath)
        Me.Close()
    End Sub
End Class