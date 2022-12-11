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
            movieModel.title = File.ReadAllText(fileName);
            movieModel.time = DateTime.Parse(File.ReadAllText(fileName));
            movieModel.year = int.Parse(File.ReadAllText(fileName));
            movieModel.director = File.ReadAllText(fileName);
            movieModel.shortFilm = Convert.ToBoolean(File.ReadAllText(fileName));
            movieModel.income = Decimal.Parse(File.ReadAllText(fileName));
            movieModel.distributor = File.ReadAllText(fileName);
            movieModel.gender = File.ReadAllText(fileName);
            movieModel.classification = File.ReadAllText(fileName);
            movieModel.synopsis = File.ReadAllText(fileName);*/
        }
    }

    private void e7_SelectedIndexChanged(object sender, EventArgs e)
    {
        var genders = e7.Items[e7.SelectedIndex];
        DisplayAlert(genders, "Seleccionaste:", "OK");
    }
}