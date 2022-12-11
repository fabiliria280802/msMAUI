namespace msMAUI.Views;

public partial class AllMoviesPage : ContentPage
{
    /*public AllMoviesPage()
    {
        InitializeComponent();
        BindingContext = new Models.AllMovies();
    }

    protected override void OnAppearing()
    {
        ((Models.AllMovies)BindingContext).LoadMovies();
    }*/

    private async void Add_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(MoviePage));
    }

    private async void moviesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count != 0)
        {
            // Get the note model
            //var movie = (Models.Movie)e.CurrentSelection[0];

            // Should navigate to "NotePage?ItemId=path\on\device\XYZ.notes.txt"
            //await Shell.Current.GoToAsync($"{nameof(MoviePage)}?{nameof(MoviePage.ItemId)}={movie.Filename}");

            // Unselect the UI
            //moviesCollection.SelectedItem = null;
        }
    }
}