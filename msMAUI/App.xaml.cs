using msMAUI.Data;
namespace msMAUI;
public partial class App : Application
{
    public static msMauiDatabase msMAUIRepo { get; private set; }
    public App(msMauiDatabase repo)
    {
        InitializeComponent();
        MainPage = new Views.Bienvenida();
        msMAUIRepo = repo;
    }
}
