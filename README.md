# tco-x64

There is a tail call optimization mechanism in the .NET Framework JIT compiler for x64. For some reason, this mechanism is absent from all other environments, as far as I can tell. 

The .NET 8 project `CSSumNet8` dies with a stack overflow in all these builds.

* `dotnet build -c Debug`
* `dotnet build -c Release`
* `dotnet build -c Release -a x64`

The .NET Framework project `CSSumNetFramework` (which includes exactly the same `Program.cs` as `CSSumNet8`) dies with a stack overflow when built with one of these commands.

* `msbuild /p:Configuration=Debug`
* `msbuild /p:Configuration=Release`

But it magically works without a stack overflow when built like this:

* `msbuild /p:Configuration=Release /p:Platform=x64`

