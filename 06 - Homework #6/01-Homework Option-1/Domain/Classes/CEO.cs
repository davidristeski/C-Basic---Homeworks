using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class CEO : Employee
    {
        public Array Employees { get; set; }
        protected int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public double AddSharesPrice(double sharesprice)
        {
            return _sharesPrice = sharesprice;
        }
        public void PrintEmployees(object[] company)
        {
            Console.WriteLine("Companies members are:");
            for (int i = 0; i < company.Length; i++)
            {
                
                if (company[i] is Employee employee)
                {
                    Console.WriteLine(employee.FirstName + " "+ employee.LastName);
                }
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * _sharesPrice;
        }
        public CEO(string firstName, string lastName, int salary, int shares, int sharesPrice)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Shares = shares;
            _sharesPrice = sharesPrice;
            Role = RoleEnum.CEO;
        }
    }
    
}
