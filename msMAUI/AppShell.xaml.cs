using msMAUI.ViewModels;
using msMAUI.Views;
namespace msMAUI;
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(AddUpdateMovieDetailViewModel), typeof(AddUpdateMovieDetail));
        //Routing.RegisterRoute(nameof(MainPageViewModel), typeof(MainPageDetail));
    }
}

