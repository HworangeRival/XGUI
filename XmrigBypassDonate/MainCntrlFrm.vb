'                                                                                                                                                                               
'                                                                                                                                                                               
'                        ____    ____                                                                            ________                             ___                       
'                        `MM'    `MM'                                                                            `MMMMMMMb.  68b                      `MM                       
'                         MM      MM                                                                              MM    `Mb  Y89                       MM                       
'                         MM      MM ____    _    ___  _____  ___  __    ___    ___  __     __      ____          MM     MM  ___ ____    ___   ___     MM                       
'          68b 68b        MM      MM `MM(   ,M.   )M' 6MMMMMb `MM 6MM  6MMMMb   `MM 6MMb   6MMbMMM 6MMMMb         MM     MM  `MM `MM(    )M' 6MMMMb    MM       68b 68b         
'          Y89 Y89        MMMMMMMMMM  `Mb   dMb   d' 6M'   `Mb MM69 " 8M'  `Mb   MMM9 `Mb 6M'`Mb  6M'  `Mb        MM    .M9   MM  `Mb    d' 8M'  `Mb   MM       Y89 Y89         
'                         MM      MM   YM. ,PYM. ,P  MM     MM MM'        ,oMM   MM'   MM MM  MM  MM    MM        MMMMMMM9'   MM   YM.  ,P      ,oMM   MM                       
'                         MM      MM   `Mb d'`Mb d'  MM     MM MM     ,6MM9'MM   MM    MM YM.,M9  MMMMMMMM        MM  \M\     MM    MM  M   ,6MM9'MM   MM                       
'                         MM      MM    YM,P  YM,P   MM     MM MM     MM'   MM   MM    MM  YMM9   MM              MM   \M\    MM    `Mbd'   MM'   MM   MM                       
'  68b 68b 68b 68b        MM      MM    `MM'  `MM'   YM.   ,M9 MM     MM.  ,MM   MM    MM (M      YM    d9        MM    \M\   MM     YMP    MM.  ,MM   MM       68b 68b 68b 68b 
'  Y89 Y89 Y89 Y89       _MM_    _MM_    YP    YP     YMMMMM9 _MM_    `YMMM9'Yb._MM_  _MM_ YMMMMb. YMMMM9        _MM_    \M\__MM_     M     `YMMM9'Yb._MM_      Y89 Y89 Y89 Y89 
'                                                                                         6M    Yb                                                                              
'                                                                                         YM.   d9                                                                              
'                                                                                          YMMMM9                                                                               
'''''''''''''''''''''''''''''''''2021'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class MainCntrlFrm

#Region "INI Setting File"
    Private XMRingStartPath As String = Application.StartupPath & "\Xmrig.exe"
    Public FileIniPoolMinig As String = Application.StartupPath & "\Config\MiningPool.ini"
    Public FileIniSettinGUI As String = Application.StartupPath & "\Config\SettingsGUI.ini"
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedText Is Nothing Then MsgBox("Select Mining Pool First!") : Exit Sub
        If Button1.Text = "
Avvia Miner" Then StartMiner() Else StopMiner()
    End Sub
    Private Sub StartMiner()
        Button1.BackgroundImage = My.Resources._stop
        Dim stringaArgomenti As String
        stringaArgomenti = "-o " & GetPoolAddress(ComboBox1.SelectedItem.ToString()) & " -a rx" '-a rx = algoritmo rx
        'aggiungi combobox
        If CheckBox11.Checked Then stringaArgomenti = stringaArgomenti & " --astrobwt-max-size=400" 'salta hash piu grandi di 400
        If CheckBox2.Checked Then stringaArgomenti = stringaArgomenti & " --pause-on-active=5" 'pausa userLive
        If CheckBox3.Checked Then stringaArgomenti = stringaArgomenti & " -b" 'background
        If CheckBox7.Checked Then stringaArgomenti = stringaArgomenti & " --no-dmi"
        If CheckBox8.Checked Then stringaArgomenti = stringaArgomenti & " --health-print-time=360" ' 
        If CheckBox9.Checked Then stringaArgomenti = stringaArgomenti & " --no-huge-pages" 'disable huge page
        If CheckBox10.Checked Then stringaArgomenti = stringaArgomenti & " --asm=auto" ' autoasm profile
        If CheckBox4.Checked Then stringaArgomenti = stringaArgomenti & " -k" '-k = send paket prevent timeout
        If CheckBox5.Checked Then stringaArgomenti = stringaArgomenti & " --cpu-no-yield" ' autohashrate -cpunoyeld
        'agiungi wallet
        stringaArgomenti = stringaArgomenti & " -u " & TxBx_Wallet.Text
        'chiudi stringa
        stringaArgomenti = stringaArgomenti & " -p x"
        '  MsgBox(stringaArgomenti) 'convalida stringa a video
        Dim p As New Process
        p.StartInfo.Arguments = stringaArgomenti
        If CheckBox6.Checked = False Then p.StartInfo.CreateNoWindow = True : p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo.FileName = XMRingStartPath
        p.Start()
        If CheckBox1.Checked Then BypassDonateTmr.Start()
        Button1.Text = "
Ferma Miner"
        DetectRigTmr.Start()
    End Sub
    Function GetPoolAddress(ListPool As String) As String
        Dim TemPoll As String = ListPool.Replace(" MINING POOL", ""), ReturnPool As String = String.Empty
        Dim ListaPool As String() = IO.File.ReadAllLines(FileIniPoolMinig) : TemPoll = TemPoll.TrimStart
        For Each line As String In ListaPool
            Dim Pool As String() = Split(line, "|")
            If Pool(0).Contains(TemPoll) Then ReturnPool = Pool(1) & ":" & Pool(2)
        Next line
        Return ReturnPool
    End Function
    Private Sub StopMiner()
        For Each p As Process In Process.GetProcesses
            If p.ProcessName.ToString.Contains("xmrig") Then p.Kill()
        Next p

        If CheckBox1.Checked Then BypassDonateTmr.Stop()

        Button1.BackgroundImage = My.Resources.play
        Button1.Text = "
Avvia Miner"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MinPool.Show()
    End Sub
    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick
        MsgBox("Xmrig GUI - V.0.1 - Created by ..:: Hworange Rival ::..", MsgBoxStyle.Information, Application.ProductName)
    End Sub
    Private Sub MainCntrlFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try : ControllaECreaCartellaConfigurazione() : Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName) : End Try

        Try : ReadSettingPool(FileIniPoolMinig) : ComboBox1.SelectedIndex += 1 : ReadSettingGUI(FileIniSettinGUI)
        Catch ex As Exception : MsgBox(ex.Message, MsgBoxStyle.Critical, Application.ProductName) : End Try
    End Sub
    Sub ControllaECreaCartellaConfigurazione()
        If IO.Directory.Exists(Application.StartupPath & "\Config") Then
            If IO.File.Exists(FileIniPoolMinig) = False And IO.File.Exists(FileIniSettinGUI) = False Then
                IO.File.WriteAllText(FileIniPoolMinig, "UNMINEABLE|rx.unmineable.com|3333") 'poolfile
                IO.File.WriteAllText(FileIniSettinGUI, "False|False|True") 'settingfile
            End If
        Else
            IO.Directory.CreateDirectory(Application.StartupPath & "\Config")
            IO.File.WriteAllText(FileIniPoolMinig, "UNMINEABLE|rx.unmineable.com|3333") 'poolfile
            IO.File.WriteAllText(FileIniSettinGUI, "False|False|True") 'settingfile
        End If
    End Sub
    Sub ReadSettingGUI(SettingFile As String)
        Dim ListaSetting As String() = Split(IO.File.ReadAllText(SettingFile), "|")
        ' If ComboBox1.SelectedText Is Nothing Then Exit Sub
        If ListaSetting(1) Then StartMiner()
        If ListaSetting(2) Then SettFrm.SleepTmr.Start() ' previeni standby
    End Sub
    Sub ReadSettingPool(SettingFile As String)
        Dim ListaPool As String() = IO.File.ReadAllLines(SettingFile)
        For Each line As String In ListaPool
            Dim Pool As String() = Split(line, "|")
            InserisciPoolInBox(Pool(0))
        Next line
    End Sub
    Sub InserisciPoolInBox(Pool As String)
        ComboBox1.Items.Add("  " & Pool & " MINING POOL")
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AlgoFrm.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SettFrm.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AggiornaFrm.Show()
    End Sub
    Private Sub BypassDonateTmr_Tick(sender As Object, e As EventArgs) Handles BypassDonateTmr.Tick
        StopMiner() : StartMiner()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        About.Show()
    End Sub
    Private Sub DetectRigTmr_Tick(sender As Object, e As EventArgs) Handles DetectRigTmr.Tick
        Dim ListaProcessi As String = ""
        For Each p As Process In Process.GetProcesses
            ListaProcessi = ListaProcessi & "|" & p.ProcessName.ToString
        Next p
        If ListaProcessi.Contains("xmrig") = False Then
            Button1.BackgroundImage = My.Resources.play
            Button1.Text = "
Avvia Miner"
            DetectRigTmr.Stop()
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then CheckBox6.Checked = False
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info : NotifyIcon1.BalloonTipTitle = "XMRig GUI"
        NotifyIcon1.BalloonTipText = "GUI ridotta ad icona. Fare click per menù." : NotifyIcon1.Visible = True
        Me.WindowState = FormWindowState.Minimized : Me.Hide() : NotifyIcon1.ShowBalloonTip(700)
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then CheckBox3.Checked = False
    End Sub
    Private Sub StatusTmr_Tick(sender As Object, e As EventArgs) Handles StatusTmr.Tick

    End Sub

    Private Sub QuitGUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitGUIToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ShowGUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowGUIToolStripMenuItem.Click
        Me.Show() : Me.WindowState = FormWindowState.Normal : NotifyIcon1.Visible = False
    End Sub
End Class