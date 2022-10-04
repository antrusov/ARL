using ARL.Core.Models.World;
using ARL.Logic.Interfaces;
using ARL.Logic.Settings;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ARL.Logic.Services;

//см. https://docs.microsoft.com/ru-ru/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-6-0
public class WorldViaJsonFileService : IWorldService
{
    private readonly GameSettings _gameSettings;

    public WorldViaJsonFileService(IOptions<GameSettings> gameSettings)
    {
        _gameSettings = gameSettings.Value;
    }

    public World World { get; set; }

    public async Task LoadAsync()
    {
        string jsonString = File.ReadAllText(_gameSettings.GameDefinitionJsonFile);
        World = JsonSerializer.Deserialize<World>(jsonString)!;

        
    }

    public async Task SaveAsync()
    {
        try
        {
            var json = JsonSerializer.Serialize(World, new JsonSerializerOptions { WriteIndented = true });
            //->
            //var fileName = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _gameSettings.GameDefinitionJsonFile);
            var fileName = _gameSettings.GameDefinitionJsonFile;
            //-<
            File.WriteAllText(fileName, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
