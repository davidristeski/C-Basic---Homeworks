// See https://aka.ms/new-console-template for more information
// Average number function

Console.WriteLine("This is a simple average function.");
Console.WriteLine("");
Console.WriteLine("Please enter the first number:");
double inputNumberOne = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the second number:");
double inputNumberTwo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the third number:");
double inputNumberThree = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the fourth number:");
double inputNumberFour = Convert.ToDouble(Console.ReadLine());

double averageResult = (inputNumberOne + inputNumberTwo + inputNumberThree + inputNumberFour) / 4;
Console.WriteLine("The average of the following numbers: " + inputNumberOne + ", " + inputNumberTwo + ", " + inputNumberThree + ", " + inputNumberFour + " is " + averageResult + "!");
