Public Class Formmenang
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.padoru, AudioPlayMode.BackgroundLoop)
        LLyangmenang.Text = FormPlay.LLangka.Text
    End Sub
End Class