namespace msMAUI.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var userValidate = userEntry.Text;
        if (!string.IsNullOrEmpty(userValidate))
        {
            Navigation.PushAsync(new MoviePage());
        }
    }
}