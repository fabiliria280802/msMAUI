using msMAUI.ViewModels;
namespace msMAUI.Views;
public partial class MovieListPage : ContentPage
{
    private MovieListPageViewModel _viewMode;
    public MovieListPage(MovieListPageViewModel viewModel)
    {
        InitializeComponent();
        _viewMode = viewModel;
        this.BindingContext = _viewMode;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewMode.GetMovieListCommand.Execute(null);
    }
}