using Microsoft.Extensions.DependencyInjection;
using ResidentBrowser.ApplicationLayer.Interfaces.ResidentInterfaces;
using ResidentBrowser.ApplicationLayer.Services;
using ResidentBrowser.InfrastructureLayer.Repositories;
using ResidentBrowser.WinForms.Forms.ResidentForms;

namespace ResidentBrowser.WinForms;

internal static class Program
{
    public static IServiceProvider? ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();
        ConfigureServices(services);

        ServiceProvider = services.BuildServiceProvider();

        ApplicationConfiguration.Initialize();

        var mainForm = ServiceProvider.GetRequiredService<MainForm>();

        Application.Run(mainForm);
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        //Services:
        services.AddScoped<IResidentService, ResidentService>();

        //Repositories:
        services.AddScoped<IResidentRepository, ResidentRepository>();

        services.AddTransient<MainForm>();
        services.AddTransient<ResidentForm>();
    }
}