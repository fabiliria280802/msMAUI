using msMAUI.Models;
using msMAUI.Data;
namespace msMAUI.Views;
[QueryProperty("Item", "Item")]
public partial class MoviePage : ContentPage
{
    public Movie Item
    {
        get => BindingContext as Movie;
        set => BindingContext = value;
    }
    public MoviePage()
    {
        InitializeComponent();
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        App.msMAUIRepo.AddNewMovie(Item);
        Shell.Current.GoToAsync("..");
    }
    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        App.msMAUIRepo.DeleteItem(Item);
        Shell.Current.GoToAsync("..");
        //Shell.Current.GoToAsync(nameof(MainPage));
        /*if (BindingContext is Models.Movie movie)
        {
            // Delete the file.
            if (File.Exists(movie.Filename))
                File.Delete(movie.Filename);
        }*/

        //await Navigation.PushAsync(new AllMoviesPage());
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
        Shell.Current.GoToAsync(nameof(AllMoviesPage));
    }
    private void e8_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedGender = (string)e8.SelectedItem;
        DisplayAlert("Seleccionaste:", selectedGender, "OK");
    }
    private void e9_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedClasi = (string)e9.SelectedItem;
        DisplayAlert("Seleccionaste:", selectedClasi, "OK");
    }
}