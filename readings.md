# Readings & Videos
This document contains my writeups for [Readings](https://github.com/codefellows/code-401-dotnet-prework/blob/master/prework-readings.md) portion of the prework assignments.

## Five Main Points
These are the five highlights I took from all of the combined readings / videos below.

- .NET is an open source development platform used to build many different types of applications.

- Visual Studio allots some really great debugging features, including conditional break points and the capability to `Step Into` your code during debugging instead of simply just `Step Over`.

- Code written in a .NET language is managed by the CLR, which compiles and manages our high-level code in a IL format, which is _then_ compiled as it runs using JIT compiling.

- 

- 

## History of .NET and C#

#### C# Version History

#### .NET Core Guide

## Tooling

#### What Is .NET?

.NET is an open source development plaftorm for building different apps.  

A development platform consists of the languages and the libraries used to develop an application.

- .NET Core :: Runs anywhere (Windows, Linux, Mac, etc).
- .NET Framework :: Websites, services, and apps on Windows.
- Xamarin / Mono :: .NET for mobile devices / operating systems.
- .NET Standard :: The shared set of libraries used by the above.

#### What Is A .NET 'Hello World' App?

The video linked to from the reading assignment didn't actually cover the typical 'Hello World' app, but I'm assuming that the point of this question was more to get at what are we producing with a basic console app.

**_If_** that's the case, then I would say that our outputted (is that even a word?) file(s) would consist of a `.exe` file and a `.dll` file, as well as any other additional files required to run our application.

#### Basic Debugging

Visual Studio has some awesome debugging features built in. Beyond the standard break points that many ISEs / IDEs include, Visual Studio offers the ability to make break points conditional.

Another awesome feature is besides the typical `Step Over` functionality of most debuggers, Visual Studio allows you to `Step Into` your code, and view what is happening within a function / method or loop, etc.

#### What Is Managed Code?

**Managed code** is code whose execution is "managed" by a runtime (in our case, the CLR). With managed code, the developer is not required (or in some instances has less requirements) to manage machine memory, take into consideration some OS security constraints, etc.

#### What Is The CLR?

The **Common Language Runtime** (or CLR) takes high level code written in a .NET language, and compiles it into **Intermediate Language** (or IL). This IL is then managed by the CLR, which takes over and runs the code with **JIT** compilation (or just-in-time compilation), which compiles the IL into machine language as the program runs.

## C# Language

#### Introduction To The C# Language And The .NET Framework

#### C# Arrays

#### C# 7.0 In A Nutshell
