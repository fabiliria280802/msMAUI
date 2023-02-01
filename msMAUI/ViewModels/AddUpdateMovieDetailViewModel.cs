using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using msMAUI.Models;
using msMAUI.Services;
using msMAUI.Views;

namespace msMAUI.ViewModels
{
    [QueryProperty(nameof(MovieDetail), "MovieDetail")]
    public partial class AddUpdateMovieDetailViewModel : ObservableObject
    {
        [ObservableProperty]
        private Movie movieDetail = new Movie();
        private readonly IMovieService _movieService;
        public AddUpdateMovieDetailViewModel(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [RelayCommand]
        public async void AddUpdateMovie()
        {
            int response = -1;
            if (MovieDetail.Id > 0)
            {
                response = await _movieService.UpdateMovie(MovieDetail);
            }
            else
            {
                response = await _movieService.AddMovie(new Movie
                {
                    title = MovieDetail.title,
                    year = MovieDetail.year,
                    director = MovieDetail.director,
                    shortFilm = MovieDetail.shortFilm,
                    income = MovieDetail.income,
                    distributor = MovieDetail.distributor,
                    gender = MovieDetail.gender,
                    classification = MovieDetail.classification,
                    synopsis = MovieDetail.synopsis,
                    portadaPath= MovieDetail.portadaPath
                });
            }

            if (response > 0)
            {
                await Shell.Current.DisplayAlert("Película añadida", "Información guardada con éxito", "OK");
                await Shell.Current.GoToAsync("///MovieListPage");
            }
            else
            {
                await Shell.Current.DisplayAlert("Hubo un problema!", "Verifica e intenta de nuevo", "OK");

            }
        }
    }
}
