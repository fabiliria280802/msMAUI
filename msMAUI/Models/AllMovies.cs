using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace msMAUI.Models
{
    internal class AllMovies
    {
        /*public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
        public AllMovies() =>
            LoadMovies();

        public void LoadMovies()
        {
            Movies.Clear();

            // Get the folder where the notes are stored.
            string appDataPath = FileSystem.AppDataDirectory;

            // Use Linq extensions to load the *.notes.txt files.
            IEnumerable<Movie> movies = Directory

                                        // Select the file names from the directory
                                        .EnumerateFiles(appDataPath, "*.movies.txt")

                                        // Each file name is used to create a new Note
                                        .Select(filename => new Movie()
                                        {
                                            Filename = filename,
                                            title = File.ReadAllText(filename),
                                            //time = DateTime.Parse(File.ReadAllText(filename)),
                                            year = int.Parse((File.ReadAllText(filename))),
                                            director = File.ReadAllText(filename),
                                            shortFilm = Convert.ToBoolean(File.ReadAllText(filename)),
                                            income = Decimal.Parse(File.ReadAllText(filename)),
                                            distributor = File.ReadAllText(filename),
                                            gender = File.ReadAllText(filename),
                                            classification = File.ReadAllText(filename),
                                            synopsis = File.ReadAllText(filename)
                                        })

                                        // With the final collection of notes, order them by date
                                        .OrderBy(movie => movie.title);

            // Add each note into the ObservableCollection
            foreach (Movie movie in movies)
                Movies.Add(movie);
        }*/
    }
}
