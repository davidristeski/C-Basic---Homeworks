// See https://aka.ms/new-console-template for more information

//Homework 3 - Simple calculator, input from users

int Sum(int num1, int num2)
{
    return num1 + num2;
}
int Subtract(int num1, int num2)
{
    return num1 - num2;
}
int Divide(int num1, int num2)
{   
    if (num2 == 0)
    {
        Console.WriteLine("Error, can't divide with 0!");
        return 0;
    }
    else
    {
        return num1 / num2;
    }
    
}
int Multiply (int num1, int num2)
{
    return (num1 * num2);
}

int Calculator(char operations, int num1, int num2)
{
    int result = 0;
    switch (operations)
    {
        case '+': result = Sum(num1, num2);
            break;
        case '-': result = Subtract(num1, num2);
            break;
        case '/': result = Divide(num1, num2);
            break;
        case '*': result = Multiply(num1, num2);
            break;
        default: return result;
    }
    return result;
}
Console.WriteLine("Enter operations");
char op = char.Parse(Console.ReadLine());
Console.WriteLine("Enter number 1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int number2 = Convert.ToInt32(Console.ReadLine());


int Res = Calculator(op, number1, number2);
Console.WriteLine(number1 +" "+ op +" "+ number2 + " = " + Res);
