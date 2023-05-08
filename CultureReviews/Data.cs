using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace CultureReviews
{
    public static class Data
    {
        private static Dictionary<string, User> users = new Dictionary<string, User>();
        private static List<Book> books = new List<Book>();
        private static List<Movie> movies = new List<Movie>();
        private static List<Music> music = new List<Music>();
        private static List<Game> games = new List<Game>();
        private static List<Series> series = new List<Series>();

        public static User UserData { set { users.Add(value.Name, value); } }
        
        public static Dictionary<string, User> UserList { get { return users; } }
        
        public static Book BooksData {  set { books.Add(value); } }
        
        public static List<Book> BookList { get { return books; } }
        public static Movie MoviesData { set { movies.Add(value); } }
        public static List<Movie> MoviesList { get { return movies; } }
        public static Music MusicData { set {  music.Add(value); } }
        public static List<Music> MusicList { get { return music; } }
        public static Game GamesData { set {  games.Add(value); } }
        public static List<Game> GamesList { get { return games; } }
        public static Series SeriesData {  set { series.Add(value); } }

        public static List<Series> SeriesList { get { return series; } }

        public static void Save(string fileName)
        {
            string folderPath = "..\\..\\..\\";
            string filePath = Path.Combine(folderPath, fileName);
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, new { Users = users, Books = books, Movies = movies, Music = music, Games = games, Series = series });
            }
        }

        public static void Load(string filePath)
        {
            using (StreamReader file = File.OpenText(filePath))
            { //załatwić null
                JsonSerializer serializer = new JsonSerializer();
                users = (Dictionary<string, User>)serializer.Deserialize(file, typeof(Dictionary<string, User>));
                books = (List<Book>)serializer.Deserialize(file, typeof(List<Book>));
                movies = (List<Movie>)serializer.Deserialize(file, typeof(List<Movie>));
                music = (List<Music>)serializer.Deserialize(file, typeof(List<Music>));
                games = (List<Game>)serializer.Deserialize(file, typeof(List<Game>));
                series = (List<Series>)serializer.Deserialize(file, typeof(List<Series>));

            }

        }
    }
}
