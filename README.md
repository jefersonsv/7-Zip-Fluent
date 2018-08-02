# 1. 7-Zip-Fluent

[![NuGet version (7-Zip-Fluent)](https://img.shields.io/nuget/v/7-Zip-Fluent.svg?style=flat-square)](https://www.nuget.org/packages/7-Zip-Fluent/)
https://www.nuget.org/packages//

7-Zip command line fluent interface builder

<!-- TOC -->

- [1. 7-Zip-Fluent](#1-7-zip-fluent)
- [2. Features](#2-features)
    - [2.1. Generation type](#21-generation-type)
    - [2.2. Commands](#22-commands)
- [3. Usage](#3-usage)

<!-- /TOC -->

# 2. Features

Generate any operation of 7z command line parameters

## 2.1. Generation type

- Cmd. Used to generate a complete 7z.exe command line
- Arguments. Used to generate only the arguments of application.

## 2.2. Commands

The command is the first non-switch argument on the command line. Command names are not case  sensitive.

- Add
- Benchmark
- Delete
- Extract
- Hash
- Information
- List
- Rename
- Test
- Update
- ExtractFullPath

# 3. Usage

```c#
SevenZipBuilder builder = new SevenZipBuilder();
var cmd = builder.CreateSevenCmd()
    .Extract()
    .OutputDirectory(@"c:\windows\temp")
    .Build();

// it's will generate: 7z.exe e -o"c:\windows\temp"
```