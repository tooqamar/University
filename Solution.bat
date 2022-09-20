@ECHO OFF
ECHO Build started
call "C:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\Tools\VsMSBuildCmd.bat"
call msbuild.exe  F:\Qamar Work\MVC_RTL_Tile\MVC_RTL_Tile\MVC_RTL_Tile.sln /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU"
ECHO Build Completed