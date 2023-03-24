using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Employee : Member
    {
        protected double Salary { get; set; } //300 is default
        public double HoursPerMonth { get; set; }
        public double Bonus { get; set; }

        public Employee(string firstname, string lastname, int age, string username, string password, int phonenumber, string dateofregistration, double hourspermonth) 
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            UserName = username;
            Password = password;
            PhoneNumber = phonenumber;
            DateOfRegistration = dateofregistration;
            HoursPerMonth = hourspermonth;
            Salary = 300;
            Role = RoleEnum.Employee

        }
        public void SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus = 0.3;
            }
            else if (HoursPerMonth < 160)
            {
                Bonus = 0;
            }

        }
        public double SetSalary()
        {
            return Salary += HoursPerMonth * Bonus;
        }
    }
}
