﻿Console.WriteLine(" \n");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("SOLETRANDO \n");
Console.ForegroundColor = ConsoleColor.Black;
Console.Write("Digite uma palavra: ");
string palavra = Console.ReadLine()!;
var caracteres = palavra.ToCharArray();
string palavraSoletrada = String.Join('-', caracteres).ToUpper();

Console.WriteLine($"\nSoletrando \"{palavra.ToUpper()}\": {palavraSoletrada} \n");