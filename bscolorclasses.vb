Public Class bscolorclasses
    Dim bootcolor As String = ""
    Dim style As String = ""
    Private Sub bscolorclasses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        bootcolor = "danger"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        bootcolor = "dark"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        bootcolor = "info"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        bootcolor = "light"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        bootcolor = "primary"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        bootcolor = "secondary"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        bootcolor = "success"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        bootcolor = "warning"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        bootcolor = "white"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        RadioButton2.Enabled = False
        style = "text-"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        RadioButton1.Enabled = False
        style = "bg-"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Main.RichTextBox1.SelectedText = style & bootcolor
        Me.Close()
    End Sub
End Class