using SQLite;
using msMAUI.Models;

namespace msMAUI.Services
{
    public class MovieService : IMovieService
    {
        private SQLiteAsyncConnection _dbConnection;
        public MovieService()
        {
            SetUpDb();
        }
        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Movie.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Movie>();
            }
        }
        public Task<int> AddMovie(Movie movie)
        {
            return _dbConnection.InsertAsync(movie);
        }

        public Task<int> DeleteMovie(Movie movie)
        {
            return _dbConnection.DeleteAsync(movie);
        }

        public Task<List<Movie>> GetMovieList()
        {
            var MovieList = _dbConnection.Table<Movie>().ToListAsync();
            return MovieList;
        }

        public Task<int> UpdateMovie(Movie movie)
        {
            return _dbConnection.UpdateAsync(movie);
        }
    }
}
