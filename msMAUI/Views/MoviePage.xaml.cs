namespace msMAUI.Views;
[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class MoviePage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "movies.txt");
    public MoviePage()
    {


        InitializeComponent();
        //Editor entry = new Editor { Placeholder = "Enter text" };
        //entry.TextChanged += OnEntryTextChanged;
        //entry.Completed += OnEntryCompleted;
        string appDataPath = FileSystem.AppDataDirectory;
        string randomFileName = $"{Path.GetRandomFileName()}.movies.txt";
        LoadMovie(Path.Combine(appDataPath, randomFileName));
    }

    private async void SaveButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            int num = int.Parse(e3.Text);
            decimal num2 = decimal.Parse(e6.Text);
            string recaudacion;
            string anio;
            int aux;
            string shortFilm;
            if (e5.IsChecked)
                shortFilm = "Si";
            else
                shortFilm = "No";
            do
            {
                if (num > 1989 && num <= 2022)
                {
                    anio = e3.Text;
                }
                else
                {
                    anio = "";
                    await DisplayAlert("Alerta:", "No habia peliculas antes de 1989 o no puedes ingresar una pelicula despues del 2022.", "OK");
                }
            } while (num.Equals(""));

            do
            {
                if (num2 > 0)
                {
                    recaudacion = e6.Text;
                }
                else
                {
                    recaudacion = "";
                    await DisplayAlert("Alerta:", "No puede ingresar valores menores a 0.", "OK");
                }
            } while (recaudacion.Equals(""));

            aux = 1;
            string text = "Titulo: " + e1.Text + "\nAño: " + anio + "\nDirector: " + e4.Text + "\nShortFilm: " + shortFilm
            + "\nRecaudacion: " + e6.Text + "\nDistribuidor: " + e7.Text + "\nGenero: " + e8.Items[e8.SelectedIndex]
            + "\nClasificacion: " + e9.Items[e9.SelectedIndex] + "\nSinopsis: " + e10.Text;
            if (BindingContext is Models.Movie movie)
                File.WriteAllText(movie.Filename, text);
            await DisplayAlert("Alerta:", "Se guardo correctamente la película llamada " + e1.Text, "Ok");
            await Shell.Current.GoToAsync("..");
        }
        catch (ArgumentNullException nre)
        {
            await DisplayAlert("Alerta:", "Debe llenar todos los campos.", "Ok");
        }
        /*do
        {
            if (e1.Text.Equals(null) && e4.Text.Equals(null) && e7.Text.Equals(null) && e8.Items[e8.SelectedIndex].Equals(null) && e9.Items[e9.SelectedIndex].Equals(null) && e10.Text.Equals(null))
            {
                aux = 0;
                await DisplayAlert("Alerta:", "Debe llenar todos los campos.", "Ok");
            }
            else
            {
                
            }
        } while (aux == 0);*/


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
            //movieModel.time = DateTime.Parse(File.ReadAllText(fileName));
            /*movieModel.year = File.ReadAllText(fileName);
            movieModel.director = File.ReadAllText(fileName);
            movieModel.shortFilm = File.ReadAllText(fileName);
            movieModel.income = File.ReadAllText(fileName);
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