Imports System.Drawing.Text
Public Class Fontwizard
    Private Sub Fontwizard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim fonts As New InstalledFontCollection
        For Each one As FontFamily In fonts.Families
            ComboBox1.Items.Add(one.Name)
        Next

        Dim lines() As String = IO.File.ReadAllLines("resources/colorlist.txt")
        ComboBox2.Items.AddRange(lines)
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Enabled = False
            TextBox1.Enabled = True
            NumericUpDown1.Enabled = False
        Else
            CheckBox2.Enabled = True
            TextBox1.Enabled = False
            NumericUpDown1.Enabled = False
        End If

    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Enabled = False
            TextBox1.Enabled = False
            NumericUpDown1.Enabled = True
        Else
            CheckBox1.Enabled = True
            TextBox1.Enabled = False
            NumericUpDown1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked Then
            Main.RichTextBox1.SelectedText = "<p style=" & Chr(34) & "font-family:" & ComboBox1.SelectedItem & "; font-size:" & TextBox1.Text & "; color:" & ComboBox2.SelectedItem & "; text-decoration:" & ComboBox3.SelectedItem & Chr(34) & ">" & vbCrLf
            Main.RichTextBox1.SelectedText = "(your text here)" & vbCrLf
            Main.RichTextBox1.SelectedText = "</p>" & vbCrLf
        ElseIf CheckBox2.Checked Then
            Main.RichTextBox1.SelectedText = "<font color=" & Chr(34) & ComboBox2.SelectedItem & Chr(34) & " face=" & Chr(34) & ComboBox1.SelectedItem & Chr(34) & " size=" & Chr(34) & NumericUpDown1.Value & Chr(34) & ">" & vbCrLf
            If ComboBox3.SelectedItem = "underline" Then
                Main.RichTextBox1.SelectedText = "<u> (your text here) </u>" & vbCrLf
            ElseIf ComboBox3.SelectedItem = "bold" Then
                Main.RichTextBox1.SelectedText = "<b> (your text here) </b>" & vbCrLf
            ElseIf ComboBox3.SelectedItem = "italic" Then
                Main.RichTextBox1.SelectedText = "<i> (your text here) </i>" & vbCrLf
            Else
                Main.RichTextBox1.SelectedText = "(your text here)" & vbCrLf
            End If
            Main.RichTextBox1.SelectedText = "</font>" & vbCrLf
        Else
            MsgBox("PLease select HTML5 or HTML4 compliance")
        End If
        Me.Close()
    End Sub
End Class