; example1.nsi
;
; This script is perhaps one of the simplest NSIs you can make. All of the
; optional settings are left to their default settings. The installer simply 
; prompts the user asking them where to install, and drops a copy of example1.nsi
; there. 

;--------------------------------

; The name of the installer
Name "HellHelper"

; The file to write
OutFile "HellHelper.exe"

; The default installation directory
InstallDir $PROGRAMFILES\HellHelper

;--------------------------------

; Pages

Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "HellHelper" ;No components page, name is not important

  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File "bin\Release\HellHelper.exe"
  File "bin\Release\HellHelper.exe.config"
  
CreateDirectory "$SMPROGRAMS\HellHelper"
CreateShortCut "$SMPROGRAMS\HellHelper\HellHelper.lnk" "$INSTDIR\HellHelper.exe"
CreateShortCut "$SMPROGRAMS\HellHelper\Uninstall.lnk" "$INSTDIR\uninstall.exe"

  WriteUninstaller "uninstall.exe"

SectionEnd ; end the section

Section "Uninstall"
  
  ; Remove files and uninstaller
  Delete $INSTDIR\HellHelper.exe
  Delete $INSTDIR\HellHelper.exe.config
  Delete $INSTDIR\uninstall.exe

  Delete "$SMPROGRAMS\HellHelper\HellHelper.lnk"
  Delete "$SMPROGRAMS\HellHelper\Uninstall.lnk"

  ; Remove directories used
  RMDir "$INSTDIR"
  RMDir "$SMPROGRAMS\HellHelper"

SectionEnd
