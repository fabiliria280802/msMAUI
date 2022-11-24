namespace msMAUI;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    Image image = new Image
    {
        Source = ImageSource.FromFile("dotnet_bot.png")
    };
}

