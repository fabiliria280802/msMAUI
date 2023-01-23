using msMAUI.Data;
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
        string dbPath = msMauiFileAccessHelper.GetLocalFilePath("movie.db3");
        builder.Services.AddSingleton<msMauiDatabase>(s => ActivatorUtilities.CreateInstance<msMauiDatabase>(s, dbPath));
        return builder.Build();
    }
}
