// See https://aka.ms/new-console-template for more information
//Task 3 - Sum of digits of the input number

int sumOfDigits(int digits)
{
    int sum = 0;
    string digitString = Convert.ToString(digits);
    char[] numChars = digitString.ToCharArray();
    foreach (char c in numChars)
    {
        //int digit = Convert.ToInt32(c); [char to integer can't be converted(blocker)]
        int digit = (int)Char.GetNumericValue(c);
        sum += digit;
    }
    return sum;
}

Console.WriteLine("Enter a number");
int inputedNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumOfDigits(inputedNumber));


