using msMAUI.ViewModels;
namespace msMAUI.Views;
public partial class AddUpdateMovieDetail : ContentPage
{
    public AddUpdateMovieDetail(AddUpdateMovieDetailViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }

    private async void UploadImageClicked(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync(new PickOptions
        {
            PickerTitle = "Suba una imagen",
            FileTypes = FilePickerFileType.Images
        });
        if (result == null)
            return;

        var stream = await result.OpenReadAsync();
        Imagen.Source = ImageSource.FromStream(() => stream);
        Imagen.Source = result.FullPath;
    }
}