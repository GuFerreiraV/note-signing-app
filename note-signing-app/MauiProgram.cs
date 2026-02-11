using CommunityToolkit.Maui;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using note_signing_app.Data;
using note_signing_app.Services;

namespace note_signing_app
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp ()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiCommunityToolkit()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // DBcontext
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseOracle("User Id=prodata_2;Password=U4D2B3P71I2D;Data Source=172.17.10.60:1521/totvs"));

            // Registrar Serviços
            builder.Services.AddTransient<NoteServices>();
            builder.Services.AddTransient<SmbStorageService>();
            builder.Services.AddTransient<MainPage>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
