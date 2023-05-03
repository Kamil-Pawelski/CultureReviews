using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    public abstract class Reviewable
    {
        protected string title;
        protected ushort releaseYear;
        protected char rate;
       
        public string Title
        {
            get { return title; }
            set { if (value.Length <= 30 && value.Length >= 0) title = value; else { Console.WriteLine("Length should be between 1 and 30"); } }
        }

        public ushort ReleaseYear
        {
            get { return releaseYear;}
            set { if (value >= 0 && value <= 2023) releaseYear = value; else { Console.WriteLine("Year should be between 0 and 2023"); } }
        }
        public char Rate
        {
            get { return rate; }
            set { if (value >= 1 && value <= 10) rate = value; else { Console.WriteLine("Rate should be between 1 and 10"); } }
        }
        public Reviewable(string title, ushort releaseYear, char rate)
        {
            this.title = title;
            this.releaseYear = releaseYear;
            this.rate = rate;
        }
    }
}
