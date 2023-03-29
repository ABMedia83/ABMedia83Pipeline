

using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ABPipeline;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public static IHost? AppHost { get; private set; }

    public App()
    {
        AppHost = Host.CreateDefaultBuilder()
         .ConfigureServices((hostContext, services) =>
         {
             //Add the MainShell as a Singleton
             services.AddSingleton<MainShell>();

             //Add the PipelineViewModel 
             services.AddSingleton<PipelineViewModel>();

             //Add Page services 
             services.AddSingleton<CodePipeline>();
             services.AddSingleton<DesignPipeline>();
             services.AddSingleton<NotesPipeline>();
             services.AddSingleton<WebPipeline>();



         })
     .Build();
    }

    protected override async void OnStartup(StartupEventArgs e)
    {
        await AppHost!.StartAsync();

        //Create the Main Shell
        MainShell shell = App.AppHost.Services.GetRequiredService<MainShell>();

        // Show the Shell Winodw  
        shell.Show();

        base.OnStartup(e);
    }
    protected override async void OnExit(ExitEventArgs e)
    {
        await AppHost!.StopAsync();
        base.OnExit(e);
    }
}
