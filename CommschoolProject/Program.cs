﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("enter a word");
var word = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Red;
Console.ResetColor();
Console.WriteLine(word + " is my name");
Console.WriteLine(word is "23 years old");
Console.WriteLine("i live in tbilisi");
Console.WriteLine("i play footbal as well");

Console.ReadLine();

