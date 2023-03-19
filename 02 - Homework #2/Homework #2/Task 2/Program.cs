// See https://aka.ms/new-console-template for more information

// Task 2: Integers array whcih will sum the even ones:

int[] arrayOfIntegers = new int[6];
for(int i = 1; i<=arrayOfIntegers.Length; i++)
{
    Console.WriteLine("Enter integer " + i +" :");
    arrayOfIntegers[i-1] = Convert.ToInt32(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < arrayOfIntegers.Length; i++)
{
    if (arrayOfIntegers[i] % 2 == 0)
    {
        sum += arrayOfIntegers[i];
    }
    
}
Console.WriteLine("The sum of the even numbers in the array is: " + sum);