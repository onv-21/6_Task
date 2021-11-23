// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string startString, invertedString = "";
startString = Console.ReadLine();
for (int i = startString.Length - 1; i >= 0; i--)
{
    invertedString += startString[i].ToString();
}
if (invertedString == startString)
{
    Console.WriteLine("Строка является палиндромом\n Введенная строка {0}, а наоборот {1}", startString, invertedString);
}
else
{
    Console.WriteLine("Строка не является палиндромом\n Введенная строка {0}, а наоборот {1}", startString, invertedString);
}