using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CultureReviews.Data;
namespace CultureReviews
{
    public class User
    {
        private readonly uint id;
        private static uint nextID = 1;
        private string name;
        private string email;
        private string password;
        private List<Book> books;
        private List<Movie> movies;
        private List<Music> music;
        private List<Game> games;
        private List<Series> series;
        public User(string name, string email, string password)
        {
            id = nextID++;
            this.name = name;
            this.email = email;
            this.password = password;
            books = new List<Book>();
            movies = new List<Movie>();
            music = new List<Music>();
            series = new List<Series>();
            games = new List<Game>();
            if(this != null)
            Data.UserData = this;
        }

        public uint ID { get { return id; } }
        public string Name { get { return name; } }
        public string Email { get { return email; } private set { email = value; } }
        public string Password { get { return password; } private set { password = value; } }
        public List<Book> Books { get { return books; } }
        public List<Movie> Movies { get { return movies; } }
        public List<Music> Music { get { return music; } }
        public List<Game> Games { get { return games; } }
        public List<Series> Series { get { return series; } }



        public void AddReview(Object review)
        {
            if (review == null) throw new ArgumentNullException();
            if (review is Movie rMovie) { movies.Add(rMovie); MoviesData = rMovie; }
            else if (review is Music rMusic) { music.Add(rMusic); MusicData = rMusic; }
            else if (review is Game rGame) { games.Add(rGame); GamesData = rGame; }
            else if (review is Series rSeries) { series.Add(rSeries); SeriesData = rSeries; }
            else if (review is Book rBook) { books.Add(rBook); BooksData = rBook; }
            else Console.WriteLine("Wrong type");

        }

        public void DeleteReview(string title, string objectName)
        {
            switch (objectName.ToLower()) //jak beda takie same tytuly to do wyboru ktory usunac
            {
                case "book":
                    foreach (Book book in books)
                    {
                        if (book.Title == title)
                        {
                            books.Remove(book);
                            foreach (Book dBook in BookList)
                            {
                                if (dBook.Title == title)
                                {
                                    BookList.Remove(dBook);
                                    return;
                                }
                            }
                        }
                    }
                    break;
                case "movie":
                    foreach (Movie movie in movies)
                    {
                        if (movie.Title == title)
                        {
                            movies.Remove(movie);
                            foreach (Movie dMovie in MoviesList)
                            {
                                if (dMovie.Title == title)
                                {
                                    MoviesList.Remove(dMovie);
                                    return;
                                }
                            }
                        }
                    }
                    break;
                case "music":
                    foreach (Music uMusic in music)
                    {
                        if (uMusic.Title == title)
                        {
                            music.Remove(uMusic);
                            foreach (Music dMusic in MusicList)
                            {
                                if (dMusic.Title == title)
                                {
                                    MusicList.Remove(dMusic);
                                    return;
                                }
                            }
                        }
                    }
                    break;
                case "game":
                    foreach (Game game in games)
                    {
                        if (game.Title == title)
                        {
                            games.Remove(game);
                            foreach (Game dGame in GamesList)
                            {
                                if (dGame.Title == title)
                                {
                                    GamesList.Remove(dGame);
                                    return;
                                }
                            }
                        }
                    }
                    break;
                case "series":
                    foreach (Series uSeries in series)
                    {
                        if (uSeries.Title == title)
                        {
                            series.Remove(uSeries);
                            foreach (Series dSeries in SeriesList)
                            {
                                if (dSeries.Title == title)
                                {
                                    SeriesList.Remove(dSeries);
                                    return;
                                }
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Not exist");
                    break;
            }
            Console.WriteLine("Not exist");
        }


        public void ChangeRate(string title, string objectName)
        {
            switch (objectName.ToLower())
            {
                case "book":
                   
                    foreach (Book book in books) 
                    {
                        if (book.Title == title)
                        {
                            char newRate;
                            if (char.TryParse(Console.ReadLine(), out newRate)) { book.Rate = newRate; }
                            return;
                        }
                    }
                    break;
                case "movie":
                    foreach (Movie movie in movies) 
                    { 
                        if (movie.Title == title)
                        {
                            char newRate;
                            if (char.TryParse(Console.ReadLine(), out newRate)) { movie.Rate = newRate; }
                            return; 
                        }
                    }
                    break;
                case "music":
                    foreach (Music musicU in music)
                    {
                        if (musicU.Title == title)
                        {
                            char newRate;
                            if (char.TryParse(Console.ReadLine(), out newRate)) { musicU.Rate = newRate; }
                            return;
                        }
                    }
                    break;
                case "game":
                    foreach (Game game in games)
                    {
                        if (game.Title == title)
                        {
                            char newRate;
                            if (char.TryParse(Console.ReadLine(), out newRate)) { game.Rate = newRate; }
                            return;
                        }
                    }
                    break;
                case "series":
                    foreach (Series seriesU in series)
                    {
                        if (seriesU.Title == title)
                        {
                            char newRate;
                            if (char.TryParse(Console.ReadLine(), out newRate)) { seriesU.Rate = newRate; }
                            return;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Not exist");
                    break;
            }
            Console.WriteLine("Not exist");
        }

        public void PrintAll()
        {
            PrintBooks();
            Console.WriteLine();
            PrintGames();
            Console.WriteLine();
            PrintMovies();
            Console.WriteLine();
            PrintMusic();
            Console.WriteLine();
            PrintSeries();
            Console.WriteLine();
        }
        public void PrintBooks()
        {
            Console.WriteLine("BOOK:(title)|(genre)|(release year)|(pages)|(rate)");
            foreach (Book wBook in books) Console.WriteLine(wBook);
        }
        public void PrintMovies()
        {
            Console.WriteLine("MOVIE:(title)|(genre)|(release year)|(time)|(rate)");
            foreach (Movie wMovie in movies) Console.WriteLine(wMovie);
        }
        public void PrintMusic()
        {
            Console.WriteLine("MUSIC:(title)|(genre)|(release year)|(time)|(rate)");
            foreach (Music wMusic in music) Console.WriteLine(wMusic);
        }
        public void PrintGames()
        {
            Console.WriteLine("GAME:(title)|(genre)|(release year)|(platforms)|(rate)");
            foreach (Game wGames in games) Console.WriteLine(games);
        }
        public void PrintSeries()
        {
            Console.WriteLine("SERIES:(title)|(genre)|(release year)|(seasons)|(rate)");
            foreach (Series wSeries in series) Console.WriteLine(wSeries);
        }

    }
}
