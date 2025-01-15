using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ResidentBrowser.ApplicationLayer.Interfaces.ProvinceInterfaces;
using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.ApplicationLayer.Services;
using ResidentBrowser.InfrastructureLayer.Repositories;
using ResidentBrowser.WinForms.Forms.ResidentForms;
using Serilog;

namespace ResidentBrowser.WinForms;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }
    public static Microsoft.Extensions.Logging.ILogger Logger;

    [STAThread]
    static void Main()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("Logs/app.log", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddSerilog();
            builder.SetMinimumLevel(LogLevel.Information);
        });

        Logger = loggerFactory.CreateLogger("ResidentBrowser.WinForms");
        Logger.LogInformation("The application has been launched.");

        var services = new ServiceCollection();
        ConfigureServices(services);

        ServiceProvider = services.BuildServiceProvider();

        ApplicationConfiguration.Initialize();

        var mainForm = ServiceProvider.GetRequiredService<MainForm>();

        Application.Run(mainForm);

        Logger.LogInformation("The application has been closed.");
        Log.CloseAndFlush();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        //Services:
        services.AddScoped<IResidentService, ResidentService>();
        services.AddScoped<IProvinceService, ProvinceService>();

        //Repositories:
        services.AddScoped<IResidentRepository, ResidentRepository>();
        services.AddScoped<IProvinceRepository, ProvinceRepository>();

        services.AddTransient<MainForm>();
        services.AddTransient<ResidentForm>();
        services.AddTransient<AddResidentForm>();
    }
}