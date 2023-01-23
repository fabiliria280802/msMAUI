using msMAUI.ViewModels;
namespace msMAUI.Views;
public partial class AddUpdateMovieDetail : ContentPage
{
    public AddUpdateMovieDetail(AddUpdateMovieDetailViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}