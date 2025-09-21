using Avalonia;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyProject.Browser;
using MyProject.Data;
using Blazored.Toast;

namespace MyProject
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args) 
        {
            HostApplicationBuilder appBuilder = Host.CreateApplicationBuilder(args);
            appBuilder.Services.AddBlazorWebView();
            appBuilder.Services.AddSingleton<WeatherForecastService>();
            appBuilder.Services.AddDbContext<AppDbContext>();
            appBuilder.Services.AddBlazoredToast();


            using IHost myApp = appBuilder.Build();

            myApp.Start();

            BuildAvaloniaApp(myApp.Services)
                .StartWithClassicDesktopLifetime(args);
            
            Task.Run(async () => await myApp.StopAsync()).Wait();
        }

        private static AppBuilder BuildAvaloniaApp(IServiceProvider serviceProvider)
            => AppBuilder.Configure<App>(() => new App(serviceProvider))
                .UsePlatformDetect()
                .LogToTrace();
                
        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => BuildAvaloniaApp(null);
    }
}