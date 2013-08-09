;--------------------------------------
; The Multiple Installer Example Script
;--------------------------------------

;--------------------------------
;Version Information

  VIProductVersion "1.0.0.0"
  VIAddVersionKey "ProductName" "GEXVOC CE"
  VIAddVersionKey "Comments" ""
  VIAddVersionKey "CompanyName" "Coremain"
  VIAddVersionKey "LegalTrademarks" "Todos los derechos reservados."
  VIAddVersionKey "LegalCopyright" "© Coremain"
  VIAddVersionKey "FileDescription" "Sistema de gestión de explotaciones."
  VIAddVersionKey "FileVersion" "1.0"

;--------------------------------

Caption "Instalador de GEXVOC CE"
;BGGradient 000000 E62E1A FFFFFF
InstallColors FF8080 000030

;--------------------------------
; HM NIS Edit Wizard helper defines
;--------------------------------
!define PRODUCT_NAME "GEXVOC CE"
!define PRODUCT_VERSION "1.0.0"
!define PRODUCT_PUBLISHER "GEXVOC CE"
!define PRODUCT_WEB_SITE "http://www.coremain.com"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_UNINST_ROOT_KEY "HKLM"



;--------------------------------
; MUI Settings
;--------------------------------
;Include Modern UI
!include "MUI.nsh"

!define MUI_ABORTWARNING
!define MUI_ICON "app.ico"
!define MUI_UNICON "app.ico"
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_BITMAP "win.bmp"
!define MUI_WELCOMEFINISHPAGE_BITMAP "arrow.bmp"
;--------------------------------
; MUI Pages
;--------------------------------
; Welcome page
!insertmacro MUI_PAGE_WELCOME

; License page
;!define MUI_LICENSEPAGE_RADIOBUTTONS

;!define MUI_LICENSEPAGE_TEXT_TOP "Test"
;!insertmacro MUI_PAGE_LICENSE "eula.txt"

; Components page
!insertmacro MUI_PAGE_COMPONENTS

; Instfiles page
!insertmacro MUI_PAGE_INSTFILES

; Finish page
!define MUI_FINISHPAGE_SHOWREADME "$INSTDIR\readme.html"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "Spanish"

;-------------------------------------
; MUI end
;-------------------------------------


;--------------------------------
;Configuration
;--------------------------------
Name "${PRODUCT_NAME} ${PRODUCT_VERSION}"
OutFile "Instalador_GEXVOC_CE.exe"
InstallDir "$PROGRAMFILES\GEXVOC_CE\"
ShowInstDetails show
ShowUnInstDetails show




;-------------------------------
; Call Pocket PC ActiveSync App
;-------------------------------
Section
 ;locate and launch the CEAPPMGR for the Pocket PC
 Call InitInstallCAB
SectionEnd




;--------------------------------
; Installer Sections
;--------------------------------

Section "CompactFramework2.0" SEC01

  ;FRAMEWORKINSTALLED:
  SectionIn 1
  SetOutPath "$INSTDIR"
  SetOverwrite on

  File netcf20.ini
  File NETCFv2.wm.armv4i.cab
  StrCpy $0 "$INSTDIR\netcf20.ini"
  Call InstallCAB
 
  File system.ini
  File System_SR_es_wm.cab
  StrCpy $0 "$INSTDIR\system.ini"
  Call InstallCAB
  
  MessageBox MB_OK|MB_ICONEXCLAMATION \
    "Espere a que termine la instalación del .NET Compact Framework 2.0 en el dispositivo antes de continuar.."

  ;FRAMEWORKNOTINSTALLED:
SectionEnd ; end of section 'Optional'


; NETCF Server Mobile Install
Section "SQLServerMobile" SEC02
        SectionIn 1
        SetOutPath "$INSTDIR"
        SetOverwrite on
        
File sqlMobile.ini
File sqlce.ppc.wce5.armv4i.CAB
StrCpy $0 "$INSTDIR\sqlMobile.ini"
Call InstallCAB

File sqlMobileRepl.ini
File sqlce.repl.ppc.wce5.armv4i.CAB
StrCpy $0 "$INSTDIR\sqlMobileRepl.ini"
Call InstallCAB

File sqlClient.ini
File sqlce.dev.es.ppc.wce5.armv4i.CAB
StrCpy $0 "$INSTDIR\sqlClient.ini"
Call InstallCAB


MessageBox MB_OK|MB_ICONEXCLAMATION \
"Espere a que termine la instalación de SQL Server 2005 CE en el dispositivo antes de continuar.."
SectionEnd ; end of section 'Optional'

; GEXVOC_CE
Section "GEXVOC CE" SEC03 ; (default, required section)
        SectionIn 1, RO
        SetOutPath "$INSTDIR"
        SetOverwrite on
File eula.txt
File readme.html
File GEXVOC.ini
File CAB_GEXVOC_CE.CAB

StrCpy $0 "$INSTDIR\GEXVOC.ini"
Call InstallCAB
    MessageBox MB_OK|MB_ICONEXCLAMATION \
    "Espere a que termine la instalación de GEXVOC_CE en el dispositivo antes de continuar."
SectionEnd ; end of default section

;--------------------------------
; Addtional Sections
;--------------------------------
Section -AdditionalIcons
  WriteIniStr "$INSTDIR\${PRODUCT_NAME}.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  CreateDirectory "$SMPROGRAMS\GEXVOC_CE"
  CreateShortCut "$SMPROGRAMS\GEXVOC_CE\Web.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
  CreateShortCut "$SMPROGRAMS\GEXVOC_CE\Desinstalar.lnk" "$INSTDIR\uninst.exe"
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\uninst.exe"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
  
      ;SetOutPath $INSTDIR
      ;File "win.bmp"
SectionEnd



;--------------------------------
; Section Descriptions
;--------------------------------
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC01} "Instala .Net Compact Framework 2.0 (Necesario para lanzar la aplicación)."
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC02} "Instala SQL Server 2005 CE (Necesario para lanzar la aplicación)."
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC03} "Instala GEXVOC CE."
!insertmacro MUI_FUNCTION_DESCRIPTION_END



;--------------------------------
;Uninstaller Section
;--------------------------------

Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) fue eliminado correctamente del equipo."
FunctionEnd



Function un.onInit
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "¿Está seguro que desea eliminar $(^Name) y todos sus componentes?" IDYES +2
  Abort
FunctionEnd



Section Uninstall
  Delete "$INSTDIR\${PRODUCT_NAME}.url"
  Delete "$INSTDIR\uninst.exe"
  Delete "$INSTDIR\readme.html"
  Delete "$INSTDIR\CAB_GEXVOC_CE.CAB"
  Delete "$INSTDIR\sqlce.ppc.wce5.armv4i.CAB"
  Delete "$INSTDIR\sqlce.repl.ppc.wce5.armv4i.CAB"
  Delete "$INSTDIR\sqlce.dev.es.ppc.wce5.armv4i.CAB"
  Delete "$INSTDIR\System_SR_es_wm.cab"
  Delete "$INSTDIR\NETCFv2.wm.armv4i.cab"
  Delete "$SMPROGRAMS\GEXVOC CE\Desinstalar.lnk"
  Delete "$SMPROGRAMS\GEXVOC CE\Web.lnk"

  RMDir "$SMPROGRAMS\GEXVOC CE"
  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_UNINST_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  SetAutoClose true
SectionEnd




;--------------------------------
; Pocket PC Install Section
;--------------------------------
; Installs a PocketPC cab-application
; It expects $0 to contain the absolute location of the ini file to be installed.
Function InstallCAB
  ExecWait '"$1" "$0"'
FunctionEnd




;--------------------------------
; OPEN CEAPPMGR FOR POCKET PC APPLICATION INSTALLING
;--------------------------------
Function InitInstallCAB
; one-time initialization needed for InstallCAB subroutine
ReadRegStr $1 HKEY_LOCAL_MACHINE "software\Microsoft\Windows\CurrentVersion\App Paths\CEAppMgr.exe" ""
IfErrors Error
Goto End
Error:
MessageBox MB_OK|MB_ICONEXCLAMATION \
"No se ha encontrado el gestor de aplicaciones para PocketPC. \
Instale ActiveSync y reinstale su aplicación."
End:
FunctionEnd


; eof
