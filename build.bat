@echo off
set MSBUILD_OPTS=/nologo ^
/nr:false ^
/m:16 ^
/p:Turbo=true ^
/p:CL_MPCount=16 ^
/p:RunCodeAnalysis=false ^
/p:DebugType=None ^
/p:DebugSymbols=true ^
/p:WindowsTargetPlatformVersion=10.0.22621.0 ^
/p:PlatformToolset=v143 ^
/clp:EnableMPLogging;Summary;ShowCommandLine ^
/v:d
MSBuild.exe sdlna.sln %MSBUILD_OPTS% ^
/t:clean,restore,Build ^
/p:Configuration=Release ^
/p:Platform="Any CPU" ^
/p:RestorePackagesConfig=true