// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string startString=Console.ReadLine();
string[]stringArray=startString.Split(' ');
int maxWord = 0, index=0;
for (int i = 0; i < stringArray.Length; i++)
{
    if(stringArray[i].Length > maxWord)
    {
        maxWord = stringArray[i].Length;
        index = i;
    }
}
Console.WriteLine("Самое длинное слово: {0}", stringArray[index]);