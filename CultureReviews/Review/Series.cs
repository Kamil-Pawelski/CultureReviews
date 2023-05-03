using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    
    public class Series : Reviewable
    {
        BMSGenres genre;
        private ushort seasons;
        public Series(string title, BMSGenres genre, ushort year, ushort seasons, char rate) : base(title, year, rate)
        { 
            this.seasons = seasons; 
            this.genre = genre;
        }
        public BMSGenres Genre
        {
            get { return genre; }
            set { this.genre = value; }
        }
        public ushort Seasons 
        { 
            get { return seasons; } 
            set { this.seasons = value; }
        }
        public override string ToString()
        {
            return title + "|" + genre + "|" + releaseYear + "|" + seasons + "|" + rate;
        }
    }
}
