namespace msMAUI.Views;
public partial class MoviePage : ContentPage
{
    public MoviePage()
    {
        InitializeComponent();
        e7.Items.Add("Acción");
        e7.Items.Add("Musical");
        e7.Items.Add("Aventura");
        e7.Items.Add("Ciencia Ficción");
        e7.Items.Add("Terror");
        e7.Items.Add("Misterio");
        e7.Items.Add("Comedia");
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("..");
    }

    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {

        await Shell.Current.GoToAsync("..");
    }

    bool OnTogged(object sender, TextChangedEventArgs e)
    {
        bool shortfilm = e3.IsEnabled;
        if (shortfilm.Equals("true"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void e7_SelectedIndexChanged(object sender, EventArgs e)
    {
        var genders = e7.Items[e7.SelectedIndex];
        DisplayAlert(genders, "Seleccionaste:", "OK");
    }
}