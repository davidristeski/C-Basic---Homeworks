// See https://aka.ms/new-console-template for more information

// Task 1: Swapping input numbers
Console.WriteLine("Enter the first number");
int inputNumberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number");
int inputNumberTwo = Convert.ToInt32(Console.ReadLine());

int emptyPlaceNumber;

emptyPlaceNumber = inputNumberOne;
inputNumberOne = inputNumberTwo;
inputNumberTwo = emptyPlaceNumber;

Console.WriteLine("After swapping, the first number is " + inputNumberOne + ", the second number is " + inputNumberTwo);

//Task 2: Console application sum of Even


