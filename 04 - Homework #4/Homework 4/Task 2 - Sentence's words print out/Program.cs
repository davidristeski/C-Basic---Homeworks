// See https://aka.ms/new-console-template for more information

//Task 2 - Inputed sentence divided in words
Console.WriteLine("Enter a sentence");

string userInputSentence = Console.ReadLine();
string[] words = userInputSentence.Split(" ");

foreach (string word in words)
{
    Console.WriteLine(word);
}

