Public Class SettFrm
    Dim Pos As Point
    <FlagsAttribute()>
    Public Enum EXECUTION_STATE As UInteger
        ES_SYSTEM_REQUIRED = &H1
        ES_DISPLAY_REQUIRED = &H2
        ES_CONTINUOUS = &H80000000UI
    End Enum
    <Runtime.InteropServices.DllImport("Kernel32.DLL", CharSet:=Runtime.InteropServices.CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetThreadExecutionState(ByVal state As EXECUTION_STATE) As EXECUTION_STATE
    End Function
    Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub SettFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists(MainCntrlFrm.FileIniSettinGUI) Then ReadSettingGUI(MainCntrlFrm.FileIniSettinGUI)
    End Sub
    Sub AggiungiRegistro(Keyname As String, KeyPath As String) '"SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim regKey As Microsoft.Win32.RegistryKey
        regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KeyPath, True)
        regKey.SetValue(Keyname, Application.ExecutablePath) : regKey.Close()
    End Sub
    Sub RimuoviRegistro(Keyname As String, KeyPath As String)  'Write to register "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
        Dim regKey As Microsoft.Win32.RegistryKey : regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(KeyPath, True) : regKey.DeleteValue(Keyname, False) : regKey.Close()
    End Sub
    Sub ReadSettingGUI(SettingFile As String)
        Dim ListaSetting As String() = Split(IO.File.ReadAllText(SettingFile), "|")
        CheckBox10.Checked = ListaSetting(0) : CheckBox1.Checked = ListaSetting(1) : CheckBox2.Checked = ListaSetting(2) ' previeni standby
    End Sub
    Sub WriteSettingGUI(SettingFile As String)
        Using sw As New IO.StreamWriter(SettingFile)
            Dim line As String = CheckBox10.Checked.ToString & "|" & CheckBox1.Checked.ToString & "|" & CheckBox2.Checked.ToString : sw.Write(line)
        End Using
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WriteSettingGUI(MainCntrlFrm.FileIniSettinGUI)
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then SleepTmr.Start() Else SleepTmr.Stop()
    End Sub
    Private Sub SleepTmr_Tick(sender As Object, e As EventArgs) Handles SleepTmr.Tick
        SetThreadExecutionState(EXECUTION_STATE.ES_SYSTEM_REQUIRED Or EXECUTION_STATE.ES_CONTINUOUS)
    End Sub

End Class