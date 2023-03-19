// See https://aka.ms/new-console-template for more information
using Student_Class_and_find_option.Models;

//Homework 5 - Search for a student in array

Student[] studentsArray = new Student[]
{
    new Student("David Risteski", "SEDC", "Group 2"),
    new Student("Tom Lockwood", "SEDC", "Group 3"),
    new Student("John Piers", "SEDC", "Group 2"),
    new Student("John Johnson", "SEDC", "Group 2"),
    new Student("Mark Owen", "SEDC", "Group 3"),
};

Console.WriteLine("Enter students name:");
string inputStudentName = Console.ReadLine();

Student searchedStudent = null;

foreach (Student student in studentsArray)
{
    if (student.Name == inputStudentName)
    {
        searchedStudent = student;
        Console.WriteLine($"Name: {searchedStudent.Name}, Academy: {searchedStudent.Academy}, Group: {searchedStudent.Group}");
        break;
    }
    else
    {
        Console.WriteLine($"Error: The student with name: {inputStudentName} does not exist in the system");
        break;
    }
}

