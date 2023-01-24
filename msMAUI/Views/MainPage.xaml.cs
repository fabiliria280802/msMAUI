namespace msMAUI.Views;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private async void GoToButtom(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///AboutPage");
    }
}