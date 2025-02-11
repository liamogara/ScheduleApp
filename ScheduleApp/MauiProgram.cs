using ScheduleApp.Data;
using Microsoft.Extensions.Logging;

namespace ScheduleApp
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "schedule.db");

            builder.Services.AddSingleton(s =>
                ActivatorUtilities.CreateInstance<EventList>(s, dbPath));

            return builder.Build();
        }
    }
}
