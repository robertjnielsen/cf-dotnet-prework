# Readings & Videos
This document contains my writeups for [Readings](https://github.com/codefellows/code-401-dotnet-prework/blob/master/prework-readings.md) portion of the prework assignments.

## Five Main Points
These are the five highlights I took from all of the combined readings / videos below.

- .NET is an open source development platform used to build many different types of applications.

- Visual Studio allots some really great debugging features, including conditional break points and the capability to `Step Into` your code during debugging instead of simply just `Step Over`.

- Code written in a .NET language is managed by the CLR, which compiles and manages our high-level code in a IL format, which is _then_ compiled as it runs using JIT compiling.

- .NET Core is an implementation of .NET that supports multiple operating systems and platforms, ranging from various desktop operating systems, to mobile devices, cloud applications, and IoT platforms as well.

- 

## History of .NET and C#

#### C# Version History

C# version 1.0 released with Visual Studio .NET 2002. It's intended objective was to be a;
> "simple, modern, general-purpose object-oriented language."

Version 1.0 lacked many of the common capablities that developers would be used to or even expect these days.

By version 2.0, C# had really started to distinguish itself from Java, and focused on targeting some serious and well known developer pain points.

C# continued to develop, and several versions were subsequentially released, each bringing with it major improvements and capabilities.

Visual Studio 2017 released with C# version 7.0, and along with it came the capability of .NET Core and the ability to target and develop for varying operating systems, devices, IoT and the cloud.

For an in depth look into the changes made with each version, check out [this link](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history).

#### .NET Core Guide

.NET Core is an open-source, general purpose implementation of Microsoft's .NET platform that is maintained by both Microsoft and the .NET community on GitHub.

.NET Core is cross-platform, meaning that it supports multiple operating systems (to include Windows, macOS and Linux), and can build applications on mobile devices, cloud platforms, and IoT platforms / devices.

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
