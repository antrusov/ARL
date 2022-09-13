using ARL.Logic.Interfaces;
using ARL.Logic.Services;
using ARL.Logic.Settings;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace ARL.Client;

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

		//add configuration
        using var stream = Assembly.GetExecutingAssembly()
            .GetManifestResourceStream("ARL.Client.appsettings.json");
        var config = new ConfigurationBuilder().AddJsonStream(stream).Build();
        builder.Configuration.AddConfiguration(config);

        //add configuration options
        builder.Services.Configure<GameSettings>(config.GetSection(nameof(GameSettings)));
		builder.Services.AddSingleton<IWorldService, WorldViaJsonFileService>();

        //services
        builder.Services.AddTransient<MainPage>();

        return builder.Build();
	}
}
