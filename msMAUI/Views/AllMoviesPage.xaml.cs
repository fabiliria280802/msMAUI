namespace msMAUI.Views;

public partial class AllMoviesPage : ContentPage
{
    public AllMoviesPage()
    {
        InitializeComponent();
        BindingContext = new Models.AllMovies();
    }

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
                await Shell.Current.GoToAsync($"{nameof(MoviePage)}?{nameof(MoviePage.ItemId)}={movie.Filename}");
                //codigo que no funcionan
                //await Navigation.PushAsync(nameof(MoviePage.ItemId)=movie.Filename);
                // Unselect the UI
                moviesCollection.SelectedItem = null;
                    //Shell.Current.GoToAsync($"{nameof(MoviePage)}?{nameof(MoviePage.ItemId)}={movie.Filename}");
            }
            else
            {
                await DisplayAlert("Alerta: ", "No entra al if", "Ok");

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
}