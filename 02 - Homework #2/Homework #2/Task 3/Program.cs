// See https://aka.ms/new-console-template for more information
// Task 3: Print students' group

string[] groupOneStudents = { "Tom", "Mike", "Angela", "Jackson", "Peter" };
string[] groupTwoStudents = { "Jeff", "Natale", "Monica", "Anna", "Joe" };

Console.WriteLine("Enter group's number to print out students list:");

int groupNumber = Convert.ToInt32(Console.ReadLine());

if (groupNumber == 1)
{
    Console.WriteLine("Group 1 students are:");
    foreach (string student in groupOneStudents)
    {
        Console.WriteLine("- " + student);
    }
}
else if (groupNumber == 2)
{
    Console.WriteLine("Group 2 students are:");
    foreach (string student in groupTwoStudents)
    {
        Console.WriteLine("- " + student);
    }
}
else
{
    Console.WriteLine("That group number does not exist");
}

