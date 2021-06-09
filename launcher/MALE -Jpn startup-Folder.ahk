#Warn
#NoEnv

MassEffectDir = %A_ScriptDir%\..\..\..

; Don't edit the language here - use the GUI itself
Commandline = -NoHomeDir -SeekFreeLoadingPCConsole -locale {locale} -Subtitles 20
CommandlineOverrideLang = -OVERRIDELANGUAGE=
CommandlineLang = -language=
ME1Lang = INT
ME2Lang = INT
ME3Lang = INT

Gui, Add, Button, w200 h50 gME1, Mass Effect 1
Gui, Add, Button, w200 h50 gME2, Mass Effect 2
Gui, Add, Button, w200 h50 gME3, Mass Effect 3
Gui, Add, DropDownList, w200 vLangChoice Choose1, Japanese
Gui, Show,, Mass Effect LE Launcher
Return

ME1:
Gui, Submit
Gosub, Set%LangChoice%
SetWorkingDir, "%MassEffectDir%\Game\ME1\Binaries\Win64"
RunWait, "%MassEffectDir%\Game\ME1\Binaries\Win64\MassEffect1.exe"  %Commandline% %CommandlineOverrideLang%%ME1Lang%
Gui, Show
Return

ME2:
Gui, Submit
Gosub, Set%LangChoice%
SetWorkingDir, "%MassEffectDir%\Game\ME2\Binaries\Win64"
RunWait, "%MassEffectDir%\Game\ME2\Binaries\Win64\MassEffect2.exe"  %Commandline% %CommandlineOverrideLang%%ME2Lang%
Gui, Show
Return

ME3:
Gui, Submit
Gosub, Set%LangChoice%
SetWorkingDir, "%MassEffectDir%\Game\ME3\Binaries\Win64"
RunWait, "%MassEffectDir%\Game\ME3\Binaries\Win64\MassEffect3.exe"  %Commandline% %CommandlineLang%%ME3Lang%
Gui, Show
Return



SetItalian:
ME1Lang = JA
ME2Lang = JPN
ME3Lang = JPN
Return



GuiClose:
ExitApp
