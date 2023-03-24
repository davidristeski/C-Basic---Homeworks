using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        protected string Password {get; set;}
        public int PhoneNumber { get; set; }
        public string DateOfRegistration { get; set; }

        public RoleEnum Role {  get; set; }
        
        public void DisplayInfo()
        {
            Console.WriteLine($" {FirstName} {LastName} | Registered on: {DateOfRegistration}");
        }


    }
}
