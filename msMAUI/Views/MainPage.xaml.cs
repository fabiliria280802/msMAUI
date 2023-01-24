namespace msMAUI.Views;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void GoToButtom(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AboutPage));
    }
}