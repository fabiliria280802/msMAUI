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

    private void moviesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
/*
protected override void OnAppearing()
{
    ((Models.AllMovies)BindingContext).LoadMovies();
}

private async void Add_Clicked(object sender, EventArgs e)
{
    try
    {
        await Navigation.PushAsync(new MoviePage());
    }
    catch (ArgumentException ae)
    {
        await DisplayAlert("Alerta", "Todo mal", "Ok");
    }
}

private async void moviesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    try
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            var movie = (Models.Movie)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            //await Shell.Current.GoToAsync($"{nameof(MoviePage)}?{nameof(MoviePage.ItemId)}={movie.Filename}");
            //codigo que no funcionan
            await Navigation.PushAsync(new MoviePage());
            //await Navigation.PushAsync(nameof(MoviePage.ItemId)=movie.Filename);
            // Unselect the UI
            moviesCollection.SelectedItem = null;
            //Shell.Current.GoToAsync($"{nameof(MoviePage)}?{nameof(MoviePage.ItemId)}={movie.Filename}");
        }
    }
    catch (InvalidCastException ice)
    {
        await DisplayAlert("Alerta: ", "No pasa a MoviePage", "Ok");
    }
    catch (ArgumentException ae)
    {

        await DisplayAlert("Alerta: ", "No pasa a MoviePage", "Ok");
    }
    catch (System.Reflection.TargetInvocationException xe)
    {
        await DisplayAlert("Alerta: ", "No entra en allpages", "OK");
    }
}
}*/