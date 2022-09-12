﻿using Microsoft.Extensions.Configuration;
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

		//services
		builder.Services.AddTransient<MainPage>();

        return builder.Build();
	}
}
