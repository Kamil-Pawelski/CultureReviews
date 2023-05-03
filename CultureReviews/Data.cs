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
        private static List<Movie> movie = new List<Movie>();
        private static List<Music> music = new List<Music>();
        private static List<Game> games = new List<Game>();
        private static List<Series> series = new List<Series>();

        public static User UserData { set { users.Add(value.Name, value); } }
        
        public static Dictionary<string, User> UserList { get { return users; } }
        
        public static Book BooksData {  set { books.Add(value); } }
        
        public static List<Book> BookList { get { return books; } }
        public static Movie MoviesData { set { movie.Add(value); } }
        public static List<Movie> MoviesList { get { return movie; } }
        public static Music MusicData { set {  music.Add(value); } }
        public static List<Music> MusicList { get { return music; } }
        public static Game GamesData { set {  games.Add(value); } }
        public static List<Game> GamesList { get { return games; } }
        public static Series SeriesData {  set { series.Add(value); } }

        public static List<Series> SeriesList { get { return series; } }

        public static void Save(string filePath) //sprawdzić potem
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, users);
                formatter.Serialize(stream, books);
                formatter.Serialize(stream, movie);
                formatter.Serialize(stream, music);
                formatter.Serialize(stream, games);
                formatter.Serialize(stream, series);
            }
        }
        public static void Load(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                users = (Dictionary<string, User>)formatter.Deserialize(stream);
                books = (List<Book>)formatter.Deserialize(stream);
                movie = (List<Movie>)formatter.Deserialize(stream);
                music = (List<Music>)formatter.Deserialize(stream);
                games = (List<Game>)formatter.Deserialize(stream);
                series = (List<Series>)formatter.Deserialize(stream);
            }
        }
    }
}
