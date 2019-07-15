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