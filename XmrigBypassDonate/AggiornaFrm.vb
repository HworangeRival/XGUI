Public Class AggiornaFrm
    Dim Pos As Point
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("Controllo connessione internet..ok")

        ListBox1.Items.Add("Controllo rilascio nuove versioni..ok")

        ListBox1.Items.Add("Download nuova versione..100%")

        ListBox1.Items.Add("Chiudo e Riavvio per Aggiornamento..")
        MsgBox("Work in progress..", MsgBoxStyle.Information, Application.ProductName)
    End Sub
End Class