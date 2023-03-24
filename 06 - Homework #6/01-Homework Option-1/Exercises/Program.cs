using Domain.Classes;
using Domain.Enums;

Employee employee = new Employee()
{
    FirstName = "Ed",
    LastName = "Sheeran",
    Role = RoleEnum.Manager
};
Console.WriteLine(employee.GetInfo());

int enumToInt = (int)employee.Role;
Console.WriteLine(enumToInt);

SalesPerson salesPerson = new SalesPerson("Zara", "Larsson");
salesPerson.AddSuccessRevenue(400);
Console.WriteLine(salesPerson.GetSalary());

Manager manager = new Manager("Tom", "Cruise", 1200);
Console.WriteLine(manager.GetSalary());
manager.AddBonus(250);
Console.WriteLine(manager.GetSalary());
Manager DesignManager = new Manager("Joshua", "Buggins", 1350);

Contractor Bill = new Contractor("Bill", "Larson", 160, 20, salesPerson);
Bill.CurrentPosition();
Contractor Jeff = new Contractor("Park", "Sung", 80, 25, salesPerson);

object[] company = {Bill, Jeff, manager, DesignManager, salesPerson};

CEO Elon = new CEO("Elon","Musk", 5000, 95, 4000);
Console.WriteLine(Elon.GetInfo());
Elon.PrintEmployees(company);
Console.WriteLine(Elon.GetSalary());
