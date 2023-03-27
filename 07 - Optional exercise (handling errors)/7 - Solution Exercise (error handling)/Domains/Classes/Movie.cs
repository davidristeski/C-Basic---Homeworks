using Domains.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Classes
{
    public class Movie
    {
        public string Title { get; set; }
        public GenreEnum Genre { get; set; }
       
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string title, GenreEnum genre, int rating, int ticketPrice)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = ticketPrice;
            try 
            {
                if (rating >= 1 &&  rating <= 5)
                {
                    Rating = rating;
                }
                else
                {
                    throw new Exception("Invalid rating number entered");
                }
            }
            catch(Exception ex) {
                Console.WriteLine("Error happend: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally 
            {
            }
            
        }
    }
}
