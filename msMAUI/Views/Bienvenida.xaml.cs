using Microsoft.Maui.ApplicationModel.Communication;

namespace msMAUI.Views;

public partial class Bienvenida : ContentPage
{
	public Bienvenida()
	{
		InitializeComponent();
	}

    void OnCounterClicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new AppShell());
        Application.Current.MainPage = new AppShell();
        App.Current.MainPage.DisplayAlert("¡Bienvenido de nuevo!", nombre.Text, "Continuar");
    }
}
