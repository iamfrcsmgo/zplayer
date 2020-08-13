Public Class ZPlayer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ajouter.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
            AxWindowsMediaPlayer1.URL = TextBox1.Text
        End If
    End Sub

    Private Sub restaurer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restaurer.Click
        TextBox1.Clear()
        AxWindowsMediaPlayer1.URL = ""
        transparence.Checked = False
        Me.TransparencyKey = Color.Empty
        Me.BackColor = Color.Empty
    End Sub

    Private Sub theme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles theme.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub transparence_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles transparence.CheckedChanged
        If transparence.Checked = True Then
            Me.TransparencyKey = Me.BackColor
        Else
            Me.TransparencyKey = Color.Empty
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options.Click
        AxWindowsMediaPlayer1.ShowPropertyPages()
    End Sub

    Private Sub addplaylist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addplaylist.Click
        Playlist.Items.Add(AxWindowsMediaPlayer1.URL)
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Playlist.Items.Remove(Playlist.SelectedItem)
    End Sub

    Private Sub Playlist_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Playlist.DoubleClick
        Try
            AxWindowsMediaPlayer1.URL = Playlist.SelectedItem
            TextBox1.Text = Playlist.SelectedItem
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Playlist_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Playlist.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub plusecran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plusecran.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Suivant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AxWindowsMediaPlayer1.Enter

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        heure.Text = Date.Now.ToString("dd-MM-yyyy / " & TimeOfDay)
    End Sub

    Private Sub naviguer_Click(sender As System.Object, e As System.EventArgs) Handles naviguer.Click
        WebBrowser1.Navigate(TextBox2.Text)
    End Sub

    Private Sub precedent_Click(sender As System.Object, e As System.EventArgs) Handles precedent.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub suivant_Click_1(sender As System.Object, e As System.EventArgs) Handles suivant.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub WebBrowser1_Navigated(sender As Object, e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated
        TextBox2.Text = WebBrowser1.Url.ToString
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
