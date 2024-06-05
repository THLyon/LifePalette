using LifePalette.Services;
using Microsoft.Extensions.Logging;

namespace LifePalette
{
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

            // Register the authentication service
            builder.Services.AddSingleton<IAuthService, AuthService>();

            return builder.Build();
        }
    }
}
