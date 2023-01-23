using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using msMAUI.Models;
using System.Threading.Tasks;

namespace msMAUI.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetMovieList();
        Task<int> AddMovie(Movie movie);
        Task<int> DeleteMovie(Movie movie);
        Task<int> UpdateMovie(Movie movie);
    }
}
