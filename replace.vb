Public Class replace

    

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Main.RichTextBox1.Text = Main.RichTextBox1.Text.Replace(TextBox1.Text, TextBox2.Text)
        Main.ToolStripStatusLabel1.Text = "Text replaced"
    End Sub
End Class