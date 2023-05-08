using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    class Program 
    {


        static void Main(string[] args)
        {

            //Movie movie = new Movie("Rock", BMSGenres.ROMANCE, 2021 ,new TimeSpan (0,56,45), '7');
            // Music music = new Music("Abc", MusicGenres.POP, 2022, new TimeSpan(0, 3, 31), '5');
            // Music musi2c = new Music("Testowy2", MusicGenres.BLUES, 2011, new TimeSpan(0, 4, 12), '8');
            // Book book1 = new Book("Lalka", BMSGenres.HORROR, 1857, 753, '5');
            // User user = new User("Heniek", "absd@wp.pl", "34123ew");
            Data.Save("data.json");
            
            
        }
    }
    
}