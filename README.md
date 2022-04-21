# Decimal <-> Hexadecimal Converter

A command-line tool for converting multiple decimal values to hexadecimal (or vice versa).

## Features

- Output to a file and/or print out the result
- Input from either a file or a string.
- Cross-platform and multi-language console application: See [this document](https://github.com/Haltroy/dec2hex/blob/main/LANGS.md) for a full list of supported languages and languages that will be added in future.

## Requirements

Can be used in a folder without installing it. Requirements are:

- .NET Core 3.1 supported machine (see [this document](https://github.com/dotnet/core/blob/main/release-notes/3.1/3.1-supported-os.md))
  - NOTE: The Official Document for .NET Core 3.1 might not include every operating system (such as Arch Linux), in order to learn if you operating system supports it or not, search on the internet (for example, I learned that Arch Linux supports .NET Core 3.1 by just typing `dotnet arch` into Google.)

## Development

Can be developed under any operating systems. The only requirement is that .NET SDK (in most package managers, `dotnet-sdk`) should be installed to the machine.

To build, navigate to source folder from your terminal-of-choice and use `dotnet build` command to build.
To build a release package, use `dotnet build -c Release` instead. 

## Usage

Can be used directly from binary file or from `dotnet` command.

First, navigate to the parent folder of downlaoded file or source code and execute command that corresponds:

 - Running from file : `d2h [Arguments]`
 - Running from `dotnet` : `dotnet run -- [Arguments]`
 
To see all arguments and information about this software, use `help` argument.
