using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using msMAUI.Models;
using msMAUI.Services;
using msMAUI.Views;
using SQLite;
using System.Collections.ObjectModel;
namespace msMAUI.Data
{
    public class msMauiDatabase
    {
        //public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
        //private readonly IMovieService _movieService;
        string _dbPath;
        public SQLiteConnection conn;
        public msMauiDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Movie>();
        }
        public int AddNewMovie(Movie movie)
        {
            Init();
            //int result = conn.Insert(flburger);
            //return result;
            try
            {
                if (movie.Id != 0)
                {
                    return conn.Update(movie);
                }
                else
                {
                    return conn.Insert(movie);
                }
            }
            catch (Exception eee)
            {
                return movie.Id;
            }

        }
        public List<Movie> GetAllMovies()
        {
            Init();
            List<Movie> movies = conn.Table<Movie>().ToList();
            return movies;
        }
        public int DeleteItem(Movie item)
        {
            Init();
            return conn.Delete(item);
        }
        public Movie ShowItem(Movie item)
        {
            Init();
            List<Movie> movies = conn.Table<Movie>().ToList();
            //foreach item in burgers():
            return null;
            //aqui falta codigo que recorra la lista en busca de  los datos de una determinada hamburgesa
        }
    }
}
