using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    public class Book : Reviewable
    {
        BMSGenres genre;
        private ushort pages;
      
        public Book(string title, BMSGenres genre, ushort year, ushort pages, char rate) : base(title, year, rate)
        {
            this.genre = genre;
            this.pages = pages;
        }

        public BMSGenres BMSGenres 
        { 
            get { return genre; } 
            set { genre = value; } 
        }

        public ushort Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        public override string ToString()
        {
            return title + "|" + genre + "|" + releaseYear + "|" + pages + "|" + rate;
        }
    }
}
