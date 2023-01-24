using msMAUI.Models;
using msMAUI.Data;
namespace msMAUI.Views;
public partial class AllMoviesPage : ContentPage
{
    public AllMoviesPage()
    {
        InitializeComponent();
        BindingContext = this;
        // BindingContext = new Models.AllMovies();
    }
    public void OnItemAdded(object sender, EventArgs e)
    {
        //await Shell.Current.GoToAsync(nameof(FLBurgerItemPage)
        Shell.Current.GoToAsync(nameof(MoviePage), true, new Dictionary<string, object>
        {
            ["Item"] = new Movie()
        });
    }

    private void OnUpdate(object sender, EventArgs e)
    {
        //fetch new items and update the Burgers property
        List<Movie> newMovies = App.msMAUIRepo.GetAllMovies();
        movieList.ItemsSource = newMovies;
        //AddBurger?.Invoke(this, EventArgs.Empty);
    }

    private void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        OnUpdate(sender, e);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<Movie> newMovies = App.msMAUIRepo.GetAllMovies();
        movieList.ItemsSource = newMovies;
        //base.OnNavigatedTo(args);
    }

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //Aqui falta codigo que tome el item seleccionado y lo pase a la pagina FLBurgerItemPage
        Movie movies = e.CurrentSelection.FirstOrDefault() as Movie;
        if (movies == null)
            return;
        Shell.Current.GoToAsync(nameof(MoviePage), true, new Dictionary<string, object>
        {
            {"Item", movies }
        });
        ((CollectionView)sender).SelectedItem = null;
    }
}