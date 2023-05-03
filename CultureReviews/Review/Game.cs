using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureReviews
{
    public class Game : Reviewable
    {
        GamesGenres genre;
        List<Platform> platforms;
        
        public Game(string title, GamesGenres genre, ushort year, List<Platform> platforms, char rate) : base(title, year, rate)
        {
            this.genre = genre;
            this.platforms = platforms;
        }

        public GamesGenres Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }

        public List<Platform> Platforms 
        { 
            get { return this.platforms; } 
            set { platforms = value; }
        }
        public override string ToString()
        {
            return title + "|" + genre + "|" + releaseYear + "|" + platformsToString() + "|" + rate;
        }

        private string platformsToString()
        {
            string platformString = "";
            for(int i = 0; i < platforms.Count; i++)
            {
                platformString += platforms[i].ToString();
                if(i !=  platforms.Count - 1) { platformString  += ", "; }
            }
            return platformString;
        }
    }
}
