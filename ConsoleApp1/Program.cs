﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.Write("Enter your first name: ");
string firstName = Console.ReadLine();

Console.Write("Enter your middle name or initial: ");
string middleName = Console.ReadLine();

Console.Write("Enter your last name: ");
string lastName = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("You entered '{0}', '{1}', and '{2}'.",
                firstName, middleName, lastName);

string name = ((firstName.Trim() + " " + middleName.Trim()).Trim() + " " +
            lastName.Trim()).Trim();
Console.WriteLine("The result is " + name + ".");