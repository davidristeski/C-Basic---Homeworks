// See https://aka.ms/new-console-template for more information

// Task 1 - Input string and print the last 5 chars
Console.WriteLine("Enter a string");
string inputString = Console.ReadLine();

string outputString = inputString.Substring(inputString.Length - 5);
Console.WriteLine(outputString);


