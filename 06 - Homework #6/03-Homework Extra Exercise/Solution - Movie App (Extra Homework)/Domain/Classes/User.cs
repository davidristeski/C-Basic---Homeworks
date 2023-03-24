using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class User : Member
    {
        public int Id { get; set; }
        public TypeOfSubscription TypeOfSubscription { get; set; }
        public Array Movies { get; set; }

        public User(string firstname, string lastname, int age, string username, string password, int phonenumber, string dateofregistration, int id, TypeOfSubscription typeofsubscription)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            UserName = username;
            Password = password;
            DateOfRegistration = dateofregistration;
            Id = id;
            TypeOfSubscription = typeofsubscription;
            Role = RoleEnum.User;



        }
    }
}
