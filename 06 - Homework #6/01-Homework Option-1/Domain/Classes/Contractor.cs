using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        protected int PayPerHour { get; set; }
        public Employee Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Employee responsible)
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public void CurrentPosition()
        {
            Console.WriteLine(Responsible.Role);
        }
    }
}
