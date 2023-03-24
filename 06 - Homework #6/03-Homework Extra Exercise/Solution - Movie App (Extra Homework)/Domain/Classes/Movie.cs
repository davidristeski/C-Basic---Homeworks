using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        private int Price { get; set; }
        public Movie(string title, string description, int year, Genre genre) 
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
        }
        public int SetPrice()
        {
            if (Year < 2000)
            {
                return Price = new Random().Next(100, 200);
            }
            else if(Year >=2000 &&  Year <= 2010)
            {
               return Price = new Random().Next(200, 300);
            }
            else
            {
                return Price = new Random().Next(300, 500);
            }
        }
    }
}
