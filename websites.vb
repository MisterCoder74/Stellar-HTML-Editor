Imports System.IO
Public Class websites

    Dim imagefile As String = ""
    Dim percorsotemplate As String = ""
    Dim nometemplate As String = ""
    Dim params(3) As String
    Private Sub websites_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim npath As String = Application.StartupPath & "\templates\websites\sitelist.txt"
        Dim nsr As StreamReader = File.OpenText(npath)
        Dim i As Integer
        Dim ls As String
        
        For Each ls In File.ReadLines(npath)
            params = ls.Split(","c)
            nometemplate = params(0)
            imagefile = params(1)
            percorsotemplate = params(2)
            ListBox1.Items.Add(nometemplate)
            ListBox2.Items.Add(imagefile)
            ListBox3.Items.Add(percorsotemplate)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.SelectedIndex = ListBox1.SelectedIndex
        ListBox3.SelectedIndex = ListBox1.SelectedIndex
        PictureBox1.Image = Image.FromFile("templates\websites\" & ListBox2.SelectedItem.ToString)
    End Sub

   
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
                percorsotemplate = Application.StartupPath & "\" & ListBox3.Items.Item(ListBox1.SelectedIndex)
                Dim targetdir = FolderBrowserDialog1.SelectedPath & "\" & ListBox1.Items.Item(ListBox1.SelectedIndex)
                'Label1.Text = percorsotemplate
                'Label2.Text = targetdir
                My.Computer.FileSystem.CopyDirectory(percorsotemplate, targetdir, True)
                MsgBox("The selected template has been installed")
            End If
        Catch ex As Exception
            MsgBox("The selected template could not be installed" & vbCrLf & "Please make sure the template exists.")
        End Try
       

    End Sub
End Class