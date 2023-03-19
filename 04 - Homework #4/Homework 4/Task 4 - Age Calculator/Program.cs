// See https://aka.ms/new-console-template for more information

//Task 4 - Age Calculator

string AgeCalculator(DateTime birthDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;
    if (birthDate > today.AddYears(-age))
    {
        age--;
    }
    return "Your age is " + age + " and your birth date is " + birthDate;
}

Console.WriteLine("Enter your birth date (MM/DD/YYYY):");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
string ageString = AgeCalculator(birthDate);
Console.WriteLine(ageString);