Public Class About

    Dim Pos As Point
    Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "About!" Then
            RichTextBox1.Text = "XMRig GUI - Version 0.0.1 beta
____________________________________________

This is a beta Release, if not work properly
 you need restart the GUI.

YouTube:https://youtube.com/user/MrHworange
Github: https://github.com/hworangerival
Support: hworangerival@gmail.com

                                                Created by
                                    ..:: Hworange Rival ::.."
            Button1.Text = "Informazioni"
        Else
            RichTextBox1.Text = "
- Per avviare correttamente l'interfaccia
   inserirla nella stessa cartella di
   XMRig Miner.

- Per selezionare una pool automaticamente 
   all'avvio impostarla come prima voce 
   nell'elenco a cascata.

- L'Interfaccia crea file di configurazione
   in ..\Config\FileConfig.ini
-"

            Button1.Text = "About!"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class