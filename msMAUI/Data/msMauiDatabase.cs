using SQLite;

namespace msMAUI.Data
{
    public class msMauiDatabase
    {
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
            conn.CreateTable<Models.Movie>();
        }
        public int AddNewBurger(Models.Movie movie)
        {
            Init();
            //int result = conn.Insert(flburger);
            //return result;
            if (movie.Id != 0)
            {
                return conn.Update(movie);
            }
            else
            {
                return conn.Insert(movie);
            }
        }
        public List<Models.Movie> GetAllBurgers()
        {
            Init();
            List<Models.Movie> movie = conn.Table<Models.Movie>().ToList();
            return movie;
        }
        public int DeleteItem(Models.Movie item)
        {
            Init();
            return conn.Delete(item);
        }
        public Models.Movie ShowItem(Models.Movie item)
        {
            Init();
            List<Models.Movie> burgers = conn.Table<Models.Movie>().ToList();
            //foreach item in burgers():
            return null;
            //aqui falta codigo que recorra la lista en busca de  los datos de una determinada hamburgesa
        }
    }
}
