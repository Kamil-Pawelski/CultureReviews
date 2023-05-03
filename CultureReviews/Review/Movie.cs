using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    public class Movie : Reviewable
    {
        private TimeSpan time;
        BMSGenres genre;
        public Movie(string title, BMSGenres genre, ushort year, TimeSpan time, char rate) : base(title, year, rate)
        {
            this.genre = genre;
            this.time = time;
        }

        public BMSGenres Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public TimeSpan Time 
        {
            get { return time; } 
            set { if(value > TimeSpan.Zero) time = value; } 
        }

        public override string ToString()
        {
            return title + "|" + genre + "|" + releaseYear + "|" + time.ToString() + "|" + rate;
        }
    }
}
