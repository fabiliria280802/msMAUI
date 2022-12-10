namespace msMAUI.Views;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();

    }
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is Models.About about)
            // Navegar en el URL especifico dentro del system browser.
            await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}