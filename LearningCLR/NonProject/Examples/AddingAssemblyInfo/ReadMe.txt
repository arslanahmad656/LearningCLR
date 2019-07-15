Assembly version resource information can be added using the custom attributes e.g. AssemblyVersionAttribute, AssemblyTitleAttribute etc.
Or this information can also be set when generating the assembly using al.exe.
C# compiler (csc.exe), however, does not offer these switches.

The files in this folder were created using the following commands:

Demo.netmodule:
csc.exe /t:module Demo.cs

Program.exe:
al.exe /t:exe /out:Program.exe /main:NonProject.Examples.AddingAssemblyInfo.Demo.Main /company:RAVIAN656 /description:"This is a dfdsf" /title:"Test assembly" /Version:6.4.4.5 Demo.netmodule