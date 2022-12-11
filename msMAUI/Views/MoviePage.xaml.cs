
namespace msMAUI.Views;
[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class MoviePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "movies.txt");
    public MoviePage()
    {
        InitializeComponent();
        Entry entry = new Entry { Placeholder = "Enter text" };
        entry.TextChanged += OnEntryTextChanged;
        entry.Completed += OnEntryCompleted;
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.movies.txt";
        LoadMovie(Path.Combine(appDataPath, randomFileName));
    }
    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Movie movie)
            File.WriteAllText(movie.Filename, e1.Text);
        /*File.WriteAllText(movie.Filename, e2.Text);
        File.WriteAllText(movie.Filename, e3.Text);
        File.WriteAllText(movie.Filename, e4.Text);
        File.WriteAllText(movie.Filename, e5.Text);
        File.WriteAllText(movie.Filename, e6.Text);
        File.WriteAllText(movie.Filename, e7.Text);
        File.WriteAllText(movie.Filename, e8.Text);
        File.WriteAllText(movie.Filename, e9.Text);
        File.WriteAllText(movie.Filename, e10.Text);*/
        await Shell.Current.GoToAsync("..");
    }

    private async void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.Movie movie)
        {
            // Delete the file.
            if (File.Exists(movie.Filename))
                File.Delete(movie.Filename);
        }

        await Shell.Current.GoToAsync("..");
    }

    private void LoadMovie(string fileName)
    {

        Models.Movie movieModel = new Models.Movie();
        movieModel.Filename = fileName;
        if (File.Exists(fileName))
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

        BindingContext = movieModel;
    }

    public string ItemId
    {
        set { LoadMovie(value); }
    }

    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = e1.Text;
    }

    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}