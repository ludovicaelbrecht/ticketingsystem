'
' Create the Subversion External Tools for Visual Studio
'

' Set the Visual Studio Version Number so we access the correct
' part of the registry for External Tools.
' Visual Studio.NET      = "7.0"
' Visual Studio.NET 2003 = "7.1"
' Visual Studio.NET 2005 = "8.0"
' Visual Studio.NET 2008 = "9.0"
Dim strVisualStudioVersionNumber
strVisualStudioVersionNumber = "8.0"

Dim strTortoiseSVNBin
strTortoiseSVNBin = "c:\\program files\\TortoiseSVN\\bin\\"

' Create the scripting shell object
Dim WshShell
Set WshShell = WScript.CreateObject("WScript.Shell")

' Function to install an external tool
function WriteExternalTool(	strVersionNumber, _
				iToolNumber, _
				strTitle, _
				strCommandLine, _
				strArgs, _
				strWorkingDir, _
				strSource, _
				strOptions)
	' NOTES (from Google Groups):
	' ToolTitle<your tool number>:
	'   stores the name of your tool
	' ToolCmd<your tool number>:
	'   stores the path to your tool
	' ToolArg<your tool number>: 
	'   stores the command line arguments for your tool.
	'   Set this to a blank string if your tool takes no arguments.
	' ToolDir<your tool number>:
	'   stores the initial directory from which your tool
	'   should be run.  Set this to a blank string if you don't care where your tool
	'   is run from.
	' ToolOpt<your tool number>:
	'   stores the settings for the checkboxes at the
	'   bottom of the external tools dialog.  The easiest way to determine what
	'   value you should set, is to create your tool once manually with the
	'   checkboxes set the way you like, and then exit visual studio.  Then look up
	'   the value that's written to this regkey.  The value that this registry
	'   entries got set to is the value your installer should set. 
	
	Dim strTitleKey, strCommandLineKey, strArgsKey, strWorkingDirKey, strSourceKey, strOptionsKey
	' Construct the keys we will be adding to as strings.  These depend on the number of the tool.
	strTitleKey =		"HKEY_CURRENT_USER\Software\Microsoft\VWDExpress\" & _
					strVersionNumber & "\External Tools\ToolTitle" & iToolNumber
	strCommandLineKey =	"HKEY_CURRENT_USER\Software\Microsoft\VWDExpress\" & _
					strVersionNumber & "\External Tools\ToolCmd" & iToolNumber
	strArgsKey =		"HKEY_CURRENT_USER\Software\Microsoft\VWDExpress\" & _
					strVersionNumber & "\External Tools\ToolArg" & iToolNumber
	strWorkingDirKey =	"HKEY_CURRENT_USER\Software\Microsoft\VWDExpress\" & _
					strVersionNumber & "\External Tools\ToolDir" & iToolNumber
	strSourceKey =		"HKEY_CURRENT_USER\Software\Microsoft\VWDExpress\" & _
					strVersionNumber & "\External Tools\ToolSourceKey" & iToolNumber
	strOptionsKey =		"HKEY_CURRENT_USER\Software\Microsoft\VWDExpress\" & _
					strVersionNumber & "\External Tools\ToolOpt" & iToolNumber
	
	' Write out the contents of an external tool	
	WshShell.RegWrite strTitleKey, strTitle
	WshShell.RegWrite strCommandLineKey, strCommandLine
	WshShell.RegWrite strArgsKey, strArgs
	WshShell.RegWrite strWorkingDirKey, strWorkingDir
	WshShell.RegWrite strSourceKey, strSource
	WshShell.RegWrite strOptionskey, strOptions, "REG_DWORD"

	' Update the count of external tools for the benefit of Visual Studio
	WshShell.RegWrite	"HKEY_CURRENT_USER\Software\Microsoft\VWDExpress\" & _
					strVersionNumber & _
					"\External Tools\ToolNumKeys", _
				iToolNumber + 1, _
				"REG_DWORD"
	
	WriteExternalTool = (iToolNumber + 1)
end function

' Get the number of current external tools as this will tell us where to start the numbering
Dim iNumTools
iNumTools = WshShell.RegRead(	"HKEY_CURRENT_USER\Software\Microsoft\VWDEXpress\" & _
				strVisualStudioVersionNumber & _
				"\External Tools\ToolNumKeys")

' Install Subversion Tools

' The order is:
'   SVN Commit
'   SVN Update
'   SVN History
'   SVN Diff
'   SVN Blame
'   SVN Revert
'   SVN Modifications
'   SVN Edit Conflicts
'   SVN Resolve
'   SVN Repository
'   SVN Project History
'   SVN Add Solution
'   SVN Branch/Tag
'   SVN Settings

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Commit - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:commit /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Update - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:update /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)
				
iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"History - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:log /path:""$(ItemPath)"" /notempfile", _
				"$(ItemDir)", _
				"", _
				17)
				
iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Diff - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:diff /path:""$(ItemPath)"" /notempfile", _
				"$(ItemDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Blame - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:blame /path:""$(ItemPath)"" /notempfile", _
				"$(ItemDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Revert - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:revert /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Modifications - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:repostatus /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Edit Conflicts - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:conflicteditor /path:""$(ItemPath)"" /notempfile", _
				"$(ItemDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Resolve - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:resolve /path:""$(ItemPath)"" /noquestion /notempfile", _
				"$(ItemDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Repository - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:repobrowser /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Project History - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:log /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Add Solution - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:import /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Branch/Tag - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:copy /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

iNumTools = WriteExternalTool(	strVisualStudioVersionNumber, _
				iNumTools, _
				"Settings - SVN", _
				strTortoiseSVNBin & "tortoiseproc.exe", _
				"/command:settings /path:""$(SolutionDir)"" /notempfile", _
				"$(SolutionDir)", _
				"", _
				17)

' Reset the scripting shell object
set WshShell = nothing


