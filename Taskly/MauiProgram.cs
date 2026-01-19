using Microsoft.Extensions.Logging;
using Taskly.Services;
using Taskly.Shared.Services;

namespace Taskly
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
                });

            // Add device-specific services used by the Taskly.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();
            builder.Services.AddSingleton<HttpClient>(sp => new HttpClient
            {
                BaseAddress = new Uri("http://taskly2.runasp.net/") // Set your actual hosted API URL
            });
            builder.Services.AddSingleton<ITasksService, TasksService>();
            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
