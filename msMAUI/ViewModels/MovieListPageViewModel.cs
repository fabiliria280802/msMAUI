//using Microsoft.Toolkit.Mvvm.ComponentModel;
//using Microsoft.Toolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using msMAUI.Models;
using msMAUI.Services;
using msMAUI.Views;
using System.Collections.ObjectModel;

namespace msMAUI.ViewModels
{
    public partial class MovieListPageViewModel : ObservableObject
    {
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();
        private readonly IMovieService _movieService;
        public MovieListPageViewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [RelayCommand]
        public async void GetMovieList()
        {
            var movieList = await _movieService.GetMovieList();
            if (movieList?.Count > 0)
            {
                Movies.Clear();
                foreach (var movie in movieList)
                {
                    Movies.Add(movie);
                }
            }
        }
        [RelayCommand]
        public async void AddUpdateMovie()
        {
            await AppShell.Current.GoToAsync(nameof(AddUpdateMovieDetailViewModel));
        }
        /*
        [RelayCommand]
        public async void DisplayAction(Movie movie)
        {
            var response = await AppShell.Current.DisplayActionSheet("Select Option", "OK", null, "Edit", "Delete");
            if (response == "Edit")
            {
                var navParam = new Dictionary<string, object>();
                navParam.Add("MovieDetail", movie);
                await AppShell.Current.GoToAsync(nameof(AddUpdateMovieDetailViewModel), navParam);
            }
            else if (response == "Delete")
            {
                var delResponse = await _movieService.DeleteMovie(movie);
                if (delResponse > 0)
                {
                    GetMovieList();
                }
            }
        }*/
    }
}
