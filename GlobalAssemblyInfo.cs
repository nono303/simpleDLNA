using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyCompany("Nils Maier")]
[assembly: AssemblyProduct("SimpleDLNA")]
[assembly: AssemblyCopyright("Copyright © 2012-2023 Nils Maier - nono303")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion("1.3.*")]
[assembly: AssemblyInformationalVersion("1.3.0")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: CLSCompliant(true)]
