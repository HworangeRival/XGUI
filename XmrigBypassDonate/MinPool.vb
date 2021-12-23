Public Class MinPool
    Dim Pos As Point
    Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub MinPool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load ini file with poolminigsetting
        If IO.File.Exists(MainCntrlFrm.FileIniPoolMinig) Then ReadSettingPool(MainCntrlFrm.FileIniPoolMinig)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub AddMiningPoolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMiningPoolToolStripMenuItem.Click
        ListView1.Size = ListView1.MinimumSize
    End Sub

    Private Sub RemoveMiningPoolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveMiningPoolToolStripMenuItem.Click
        ListView1.Items.RemoveAt(ListView1.FocusedItem.Index)
    End Sub

    Sub InserisciItemInListMiningPool(lst As ListView, NamePool As String, AddressPool As String, MinigPort As String)
        Dim lvi As New ListViewItem(NamePool)
        lvi.SubItems.AddRange({AddressPool, MinigPort})
        lst.Items.Add(lvi)
    End Sub

    Sub ReadSettingPool(SettingFile As String)
        Dim ListaPool As String() = IO.File.ReadAllLines(SettingFile)
        For Each line As String In ListaPool
            Dim Pool As String() = Split(line, "|")
            InserisciItemInListMiningPool(ListView1, Pool(0), Pool(1), Pool(2))
        Next line
    End Sub

    Sub WriteSettingPool(SettingFile As String)
        Using sw As New IO.StreamWriter(SettingFile)
            For Each lvi As ListViewItem In ListView1.Items
                Dim line As String = ""
                For Each item As ListViewItem.ListViewSubItem In lvi.SubItems
                    line &= item.Text & "|"
                Next item
                line = line.Remove(line.Length - 1, 1)
                sw.WriteLine(line)
            Next
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListView1.Items.Add(TxBxNamePool.Text).SubItems.AddRange({TxBxAddrPool.Text, TxBxMiniPort.Text})
        TxBxAddrPool.Text = "" : TxBxMiniPort.Text = "" : TxBxNamePool.Text = ""
        ListView1.Size = ListView1.MaximumSize
    End Sub

    Private Sub SaveReloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveReloadToolStripMenuItem.Click
        WriteSettingPool(MainCntrlFrm.FileIniPoolMinig)
        MainCntrlFrm.ComboBox1.Items.Clear()
        MainCntrlFrm.ReadSettingPool(MainCntrlFrm.FileIniPoolMinig)
        MainCntrlFrm.ComboBox1.SelectedIndex += 1
        Me.Close()
    End Sub

    Private Sub MinPool_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        WriteSettingPool(MainCntrlFrm.FileIniPoolMinig)
    End Sub

End Class
