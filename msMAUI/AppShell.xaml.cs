using msMAUI.Views;
namespace msMAUI;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(AddUpdateMovieDetail), typeof(AddUpdateMovieDetail));
    }
}

