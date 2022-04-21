/*
 *
 * Name: Decimal To Hexadecimal converter
 * Description: Converts a series of decimal numbers to hexadecimal numbers and vice-versa.
 * Author: haltroy
 * Language: C#
 * Framework: .NET Core 3.1
 * Type: Cross-platform Console Application
 * Source Code: https://github.com/haltroy/dec2hex
 *
 */

using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace DecimalToHex
{
    internal class Program
    {
        private static string Loc { get; set; } = string.Empty;
        private static string InputPath { get; set; } = string.Empty;
        private static string OutputPath { get; set; } = string.Empty;
        private static bool Verbose { get; set; } = false;
        private static bool InputIsString { get; set; } = false;
        private static bool Hex2Dec { get; set; } = false;

        private class CI
        {
            public CI(string name, string shortName)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
                ShortName = shortName ?? throw new ArgumentNullException(nameof(shortName));
            }

            public string Name { get; set; }
            public string ShortName { get; set; }

            public override bool Equals(object obj)
            {
                return obj is CI cI &&
                       ShortName == cI.ShortName;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(ShortName);
            }

            public static bool operator ==(CI left, CI right)
            {
                return EqualityComparer<CI>.Default.Equals(left, right);
            }

            public static bool operator !=(CI left, CI right)
            {
                return !(left == right);
            }
        }

        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Loc = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "help":
                        case "--help":
                        case "-help":
                        case "-h":
                        case "/?":
                            string help = Translations.GetHelp(Loc);
                            Console.WriteLine(help);
                            return;

                        case "-i":
                            InputIsString = true;
                            break;

                        case "-v":
                            Verbose = true;
                            break;

                        case "-s":
                            Hex2Dec = true;
                            break;

                        default:

                            if (string.IsNullOrWhiteSpace(InputPath))
                            {
                                InputPath = InputIsString ? args[i].Replace("\"", "") : Path.GetFullPath(args[i].Replace("\"", ""));
                            }
                            else
                            {
                                OutputPath = Path.GetFullPath(args[i].Replace("\"", ""));
                            }
                            break;
                    }
                }
                if (!string.IsNullOrWhiteSpace(InputPath))
                {
                    if (InputIsString)
                    {
                        string outputString = Hex2Dec ? GetDec(InputPath) : GetHex(InputPath);
                        WriteBack(outputString);
                    }
                    else
                    {
                        if (File.Exists(InputPath))
                        {
                            string inputString = string.Empty;
                            using (FileStream fileStream = new FileStream(InputPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            {
                                using StreamReader sr = new StreamReader(fileStream);
                                inputString = sr.ReadToEnd();
                            }
                            string outputString = Hex2Dec ? GetDec(inputString) : GetHex(inputString);
                            WriteBack(outputString);
                        }
                        else
                        {
                            Console.Error.WriteLine(Translations.GetError(Loc, 2), InputPath);
                        }
                    }
                }
                else
                {
                    Console.Error.WriteLine(Translations.GetError(Loc, 3));
                }
            }
            else
            {
                Console.Error.WriteLine(Translations.GetError(Loc, 1));
            }
        }

        private static void WriteBack(string outputString)
        {
            if (!string.IsNullOrWhiteSpace(OutputPath))
            {
                using FileStream outputStream = new FileStream(OutputPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                using StreamWriter writer = new StreamWriter(outputStream);
                writer.Write(outputString);
            }
            else
            {
                if (!Verbose)
                {
                    Console.Error.WriteLine(Translations.GetError(Loc, 0));
                }
            }
        }

        private static string GetHex(string inputString)
        {
            string[] decimals = inputString.Split(' ');
            string outputString = string.Empty;
            for (int i = 0; i < decimals.Length; i++)
            {
                var val = int.Parse(decimals[i]);
                outputString += BitConverter.ToString(new byte[] { (byte)val }) + ' ';
            }
            if (Verbose) { Console.WriteLine(outputString); }
            outputString = outputString.Trim();
            return outputString;
        }

        private static string GetDec(string inputString)
        {
            string[] decimals = inputString.Split(' ');
            string outputString = string.Empty;
            for (int i = 0; i < decimals.Length; i++)
            {
                var val = int.Parse(decimals[i]);
                outputString += BitConverter.ToString(new byte[] { (byte)val }) + ' ';
            }
            if (Verbose) { Console.WriteLine(outputString); }
            outputString = outputString.Trim();
            return outputString;
        }
    }
}