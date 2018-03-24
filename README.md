# DotnetCore
A quick boilerplate demo of .NET core

## Table of content
0. [Prerequisites](#prerequisites)
1. [Creating a Console App](#creating-a-console-app)


## Prerequisites

- Make sure you have installed the **.NET Core SDK v 2.0+** [Download here](https://www.microsoft.com/net/download/windows)
> Verify the you have everything needed by opening *Powershell* or another *command console tool* and type

```powershell

dotnet --version

``` 
> A version number greater than or equal to 2.0.0 should appear. If so you are all set!


[Back to top](#table-of-content)

## Creating a Console App

- Create a new *project file* **(filename.csproj)**

Add the following configuration in your project file

```xml

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
  </PropertyGroup>

</Project>

```

- Once saved try running the *dotnet run* command from within the root of your new project folder. An error will occur!
> Notice: The *dotnet run* command will build a **debug** version of your code. If you need to run a **release** version, you should run 

```powershell

dotnet run -c Release
```

> When running the command, you will get the following error..

```powershell

CSC : error CS5001: Program does not contain a static 'Main' method suitable for an entry point [*******.csproj]

The build failed. Please fix the build errors and run again.

```


- Every *Exe* (executables) in **.NET** needs an entry point. Let's make a file *program.cs* and add the entry point **The main method**

```csharp

using System;

namespace firstconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from xemmel's .NET Core tutorial!");
        }
    }
}

```

[Back to top](#table-of-content)

