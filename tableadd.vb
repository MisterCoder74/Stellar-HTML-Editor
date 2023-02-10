Public Class tableadd
    Dim rows As Integer
    Dim columns As Integer
    Dim border As Integer
    Dim caption As String
    Dim halign As String
    Dim valign As String
    Dim align As String
    Dim twidth As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            caption = TextBox3.Text
            border = Val(TextBox4.Text)
            twidth = Val(TextBox5.Text)
            halign = ComboBox1.SelectedItem.ToString
            valign = ComboBox2.SelectedItem.ToString
            align = ComboBox3.SelectedItem.ToString
            Main.RichTextBox1.SelectedText = "<table width=" & twidth & " border=" & border & " align=" & align & ">" & vbCrLf & "<caption>" & caption & "</caption>" & vbCrLf
            For rows = 1 To Val(TextBox1.Text)
                Main.RichTextBox1.SelectedText = "<tr>" & vbCrLf
                For columns = 1 To Val(TextBox2.Text)
                    Main.RichTextBox1.SelectedText = "<td align=" & halign & " valign=" & valign & "> </td>" & vbCrLf
                Next
                Main.RichTextBox1.SelectedText = "</tr>" & vbCrLf
            Next
            Main.RichTextBox1.SelectedText = "</table>" & vbCrLf
            Me.Close()
        Catch ex As Exception
            MsgBox("Please fill the neded fields.")
        End Try

        
    End Sub

   
End Class