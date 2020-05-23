# C# 9 Preview

Testing some features of the C# 9 preview release 05/19/2020

## Requirements

* [Visual Studio 2019 Version 16.7.0 Preview 1.0](https://visualstudio.microsoft.com/pt-br/vs/preview/)
* [.NET 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)

## Creating the project

Create a Console application and update the `.csproj` to the following:
```xml
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <OutputType>Exe</OutputType>
        <TargetFramework>net5.0</TargetFramework>
        <LangVersion>preview</LangVersion>
    </PropertyGroup>
</Project>
```
