SimpleDLNA
===
A simple, zero-config DLNA media server, that you can just fire up and be done with it.  

See [the github page](http://nmaier.github.io/simpleDLNA/) for more details and downloads.  

---
Thanks to [Nils Maier](https://github.com/nmaier) for his excellent and simple dlna server.    
I just fork it to make a "Very Simple" DLNA server with quick & dirty code changes ^^   
Other fork: https://github.com/PFloeschel/simpleDLNA  

## Binary available in /build ##

**Reduce IO usage**

 - Disable A/V Covers
 - Disable Thumbs
 - Disable use of ffmpeg

**"Improve" logging**

 - Disable thumbs & covers not found traces
 - Add datetime to traces
 - Change some info to debug
 - Add startup message for rescanning state

**Upgrade and fix project**
    
- Upgrade .NET SDK 4.5.1 => 4.8 _(min. 4.5.1 runtime required)_
- release in /build

Actually using [nssm](https://nssm.cc/) to run it as a Windows service with stdout redirected to log file.

Simple to compile with [MS Build Tools 2017](https://www.visualstudio.com/fr/downloads/)  
``MSBuild.exe sdlna.sln /m /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" /p:DebugSymbols=false /p:DebugType=None``