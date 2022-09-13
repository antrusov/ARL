using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ARL.Logic.Settings;
using ARL.Logic.Interfaces;
using ARL.Logic.Services;
using ARL.Core.Models.Hero;
using ARL.Core.Models.Shop;
using ARL.Core.Models.World;
using ARL.Core.Enums;

using IHost host = Host
    .CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
        services
            .Configure<GameSettings>(context.Configuration.GetSection(nameof(GameSettings)))
            .AddSingleton<IWorldService, WorldViaJsonFileService>()
    )
    .Build();

var _worldService = host.Services.GetService<IWorldService>();

_worldService.World = new World();
_worldService.World.Hero = new Hero()
{
    HP = 100,
    Equipment = new List<ShopItem>()
    {
        new ShopArmor()
        {
            Cost = 10,
            Defence = 5,
            Protection = 2,
            Name = "Щит",
            Description = "Простой деревянный щит",
            Slot = ArmorSlot.Sheld
        }
    }
};

_worldService.SaveAsync();

//await host.RunAsync();
