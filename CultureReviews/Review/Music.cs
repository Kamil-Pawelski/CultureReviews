using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    public class Music : Reviewable
    {
        private TimeSpan time;
        MusicGenres genre;
        public Music(string title, MusicGenres genre, ushort year, TimeSpan time, char rate) : base(title, year, rate) 
        { 
            this.time = time; 
            this.genre = genre;
        }
        public MusicGenres Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public TimeSpan Time
        {
            get { return time; }
            set { if (value > TimeSpan.Zero) time = value; }
        }
        public override string ToString()
        {
            return title + "|" + genre + "|" + releaseYear + "|" + time.ToString() + "|" + rate;
        }
    }
}
