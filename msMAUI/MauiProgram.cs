using msMAUI.Views;
using msMAUI.ViewModels;
using msMAUI.Services;
namespace msMAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
        //Services
        builder.Services.AddSingleton<IMovieService, MovieService>();
        //Views Registration
        builder.Services.AddSingleton<MovieListPage>();
        builder.Services.AddSingleton<AddUpdateMovieDetail>();
        //View Models
        builder.Services.AddSingleton<MovieListPageViewModel>();
        builder.Services.AddSingleton<AddUpdateMovieDetailViewModel>();
        return builder.Build();
    }
}
