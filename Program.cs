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

namespace DecimalToHex
{
    internal class Program
    {
        private static string loc { get; set; } = string.Empty;
        private static string inputPath { get; set; } = string.Empty;
        private static string outputPath { get; set; } = string.Empty;
        private static bool verbose { get; set; } = false;
        private static bool inputIsString { get; set; } = false;
        private static bool hex2dec { get; set; } = false;

        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                loc = System.Globalization.CultureInfo.CurrentCulture.TwoLetterISOLanguageName;

                for (int i = 0; i < args.Length; i++)
                {
                    switch (args[i])
                    {
                        case "help":
                        case "--help":
                        case "-help":
                        case "-h":
                        case "/?":
                            string help = GetHelp(loc);
                            Console.WriteLine(help);
                            return;

                        case "-i":
                            inputIsString = true;
                            break;

                        case "-v":
                            verbose = true;
                            break;

                        case "-s":
                            hex2dec = true;
                            break;

                        default:

                            if (string.IsNullOrWhiteSpace(inputPath))
                            {
                                inputPath = inputIsString ? args[i].Replace("\"", "") : Path.GetFullPath(args[i].Replace("\"", ""));
                            }
                            else
                            {
                                outputPath = Path.GetFullPath(args[i].Replace("\"", ""));
                            }
                            break;
                    }
                }
                if (!string.IsNullOrWhiteSpace(inputPath))
                {
                    if (inputIsString)
                    {
                        string outputString = hex2dec ? GetDec(inputPath) : GetHex(inputPath);
                        WriteBack(outputString);
                    }
                    else
                    {
                        if (File.Exists(inputPath))
                        {
                            string inputString = string.Empty;
                            using (FileStream fileStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                            {
                                using StreamReader sr = new StreamReader(fileStream);
                                inputString = sr.ReadToEnd();
                            }
                            string outputString = hex2dec ? GetDec(inputString) : GetHex(inputString);
                            WriteBack(outputString);
                        }
                        else
                        {
                            Console.Error.WriteLine(GetError(loc, 2), inputPath);
                        }
                    }
                }
                else
                {
                    Console.Error.WriteLine(GetError(loc, 3));
                }
            }
            else
            {
                Console.Error.WriteLine(GetError(loc, 1));
            }
        }

        private static void WriteBack(string outputString)
        {
            if (!string.IsNullOrWhiteSpace(outputPath))
            {
                using FileStream outputStream = new FileStream(outputPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                using StreamWriter writer = new StreamWriter(outputStream);
                writer.Write(outputString);
            }
            else
            {
                if (!verbose)
                {
                    Console.Error.WriteLine(GetError(loc, 0));
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
            if (verbose) { Console.WriteLine(outputString); }
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
            if (verbose) { Console.WriteLine(outputString); }
            outputString = outputString.Trim();
            return outputString;
        }

        private static string GetError(string loc, int index)
        {
            switch (loc)
            {
                case "en":
                default:
                    switch (index)
                    {
                        case 0:
                            return "Output path was empty.";

                        case 1:
                            return "No arguments given.";

                        case 2:
                            return "File \"{0}\" does not exists.";

                        case 3:
                            return "Input was empty.";

                        default:
                            return "Unknown error code \"" + index + "\".";
                    }
                case "tr":
                    switch (index)
                    {
                        case 0:
                            return "Çıkış dosyası konumu boştu.";

                        case 1:
                            return "Hiç bir argüman girilmemiş.";

                        case 2:
                            return "Dosya \"{0}\" bulunamadı.";

                        case 3:
                            return "Giriş argümanı boştu.";

                        default:
                            return "Bilinmeyen hata kodu \"" + index + "\".";
                    }
            }
        }

        private static string GetHelp(string loc)
        {
            switch (loc)
            {
                case "en":
                default:
                    return "Decimal <-> Hexadecimal Converter"
                           + Environment.NewLine
                           + "Converts Decimal to Hexadecimal and vice-versa."
                           + Environment.NewLine
                           + "Made by haltroy."
                           + Environment.NewLine
                           + "https://github.com/haltroy/dec2hex"
                           + Environment.NewLine
                           + ""
                           + Environment.NewLine
                           + "USAGE:"
                           + Environment.NewLine
                           + "d2h [-v] [-i] [-s] [help|--help|/?|-h|-help] [Input] [Output Path]"
                           + Environment.NewLine
                           + "-v                              Verboses the output to console."
                           + Environment.NewLine
                           + "-s                              Switches mode to Hexadecimal -> Decimal."
                           + Environment.NewLine
                           + "-i                              Changes Input from path to string."
                           + Environment.NewLine
                           + "help --help -help /? -h         Prints this output to console and quits."
                           + Environment.NewLine
                           + "[Input]                         File or string that contains the decimals seperated with a single space. Important."
                           + Environment.NewLine
                           + "[output Path]                   File that will contain the conversion result.";

                case "tr":
                    return "10'luk Sayı Sistemi <-> 16'lık Sayı Sistemi Çevirici"
                           + Environment.NewLine
                           + "10'luk Sayı sistemini 16'lık Sayı Sistemine veya ters şekilde çevirir."
                           + Environment.NewLine
                           + "haltroy tarafından yapılmıştır."
                           + Environment.NewLine
                           + "https://github.com/haltroy/dec2hex"
                           + Environment.NewLine
                           + ""
                           + Environment.NewLine
                           + "KULLANIM:"
                           + Environment.NewLine
                           + "d2h [-v] [-i] [-s] [help|--help|/?|-h|-help] [Giriş] [Çıkış Yolu]"
                           + Environment.NewLine
                           + "-v                              Çıkışı buraya yazar."
                           + Environment.NewLine
                           + "-s                              16'lık Sayı Sistemi -> 10'luk Sayı Sistemi moduna geçer."
                           + Environment.NewLine
                           + "-i                              Giriş yolunu giriş yazısına çevirir."
                           + Environment.NewLine
                           + "help --help -help /? -h         Bu menüyü yazıp kapanır."
                           + Environment.NewLine
                           + "[Giriş]                         10'luk yada 16'lık Sayı Sistemi ile yazılmış ve sayılar arasında boşluk olan yazı yada yazıyı içeren dosyanın konumunu belirler. Önemlidir."
                           + Environment.NewLine
                           + "[Çıkış Yolu]                    Çeviri sonucunnun yazılacağı dosya konumunu belirler.";
            }
        }
    }
}