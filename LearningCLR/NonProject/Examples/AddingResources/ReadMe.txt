Adding embedded resource in a module/assembly.

 The embedded resouce may be added in a module or in a assembly (in which case the resouce is added to the main module).
 Furthermore, the resouce can be embedded by using the C# compiler CSC or by using the assembly linker tool AL.

 ----------------------------------------------------------------------------------------------------------------------------------------------
 Using assembly linker tool to embed resources
 ---------------------------------------------

  AL operates on the modules. Switch used to embed resouce in an assembly: /embed[resource]

  al.exe /t:exe /out:<output-file-name> /main:<entry-method> /embed:<resource-to-embed> <module-name>

  The above mentioned command will embed the resource in the <output-file-name> file, and not in the <module-name> module. 
  Note that the <module-name> module might already have embedded resources.
  
  ----------------------------------------------------------------------------------------------------------------------------------------------
  Using C# compiler to embed resources
  ------------------------------------

  CSC operates on C# source files. Switch used to embed resource in a file (assembly or module depending on /t[arget] switch): /resource

  csc.exe /t:<output-type> /resource:<resource-filename> /out:<output-filename> <souce-file>

  The above mentioned comand will embed the resource in the <output-filename>.

  ----------------------------------------------------------------------------------------------------------------------------------------------
  The folder contains several .netmoudle and .exe files. These were created using following commands:

  Executable_NoRes.netmodule:
  csc.exe /t:module /out:Executable_NoRes.netmodule Executable.cs

  Executable_Res.netmodule:
  csc.exe /t:module /out:Executable_Res.netmodule /resource:textfile.txt Executable.cs

  Executable_ModuleRes.exe:
  al.exe /t:exe /out:Executable_ModuleRes.exe /main:NonProject.Examples.AddingResources.Executable.Main Executable_Res.netmodule

  Executable_SelfRes.exe:
  al.exe /t:exe /out:Executable_SelfRes.exe /main:NonProject.Examples.AddingResources.Executable.Main /embed:textfile1.txt Executable_NoRes.netmodule

  Executable_CscRes.exe:
  csc.exe /t:exe /resource:textfile.txt /out:Executable_CscRes.exe Executable.cs

  Executable_SelfRes_ModuleRes.exe:
  al.exe /t:exe /out:Executable_SelfRes_ModuleRes.exe /main:NonProject.Examples.AddingResources.Executable.Main /embed:textfile2.txt Executable_Res.netmodule

  Executable_Add_Module.dll:
  csc.exe /t:library /out:Executable_Add_Module.dll /addmodule:Executable_Res.netmodule
  
  When an assembly is created using al.exe, all of the embedded resources including the main module's and the added modules appear in the ManifestResourceDef table of the assembly.
