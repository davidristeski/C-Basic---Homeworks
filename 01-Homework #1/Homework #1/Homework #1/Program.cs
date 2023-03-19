// See https://aka.ms/new-console-template for more information
//Simple calculator with two numbers and the functions ( +, - , * , / )

Console.WriteLine("This is a simple two numbers calculator.");
Console.WriteLine("");
Console.WriteLine("Please enter the first number");
double inputNumberOne = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter the second number");
double inputNumberTwo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please enter one of the following operators ( +, - , * , / )");
string inputMathSign = Console.ReadLine();

double result;

if (inputMathSign == "+")
{
    result = inputNumberOne + inputNumberTwo;
    Console.WriteLine("The result of " + inputNumberOne + " + " + inputNumberTwo + " is " + result);
}
else if (inputMathSign == "-")
{
    result = inputNumberOne - inputNumberTwo;
    Console.WriteLine("The result of " + inputNumberOne + " - " + inputNumberTwo + " is " + result);
}
else if (inputMathSign == "*")
{
    result = inputNumberOne * inputNumberTwo;
    Console.WriteLine("The result of " + inputNumberOne + " * " + inputNumberTwo + " is " + result);
}
else if (inputMathSign == "/")
{
       if(inputNumberTwo == 0)
    {
        Console.WriteLine("Cannot divide with 0! Retry!");
    }
       else { 
    result = (double)inputNumberOne / inputNumberTwo;
    Console.WriteLine("The result of " + inputNumberOne + " / " + inputNumberTwo + " is " + result);
    }
}
