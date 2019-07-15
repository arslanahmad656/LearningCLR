The executables in the folder were created using the following commands:

Program.netmodule:
csc /t:module Program.cs

Program2.exe:
al.exe /t:exe /out:Program2.exe /Main:NonProject.Examples.AddingResources.AddingIconResource.Program.Main Program.netmodule

Program.csc.exe:
csc.exe /out:Program.csc.exe /win32icon:icon.ico

out:Program2.netmodule:
csc.exe /t:module /out:Program2.netmodule /win32icon:icon.ico Program.cs

Module Program2.netmodule has embedded win32icon which has increased its size too much that the following command gives a fatal error:
al.exe /t:exe Main:NonProject.Examples.AddingResources.AddingIconResource.Program.Main /out:Program3.exe Program2.netmodule