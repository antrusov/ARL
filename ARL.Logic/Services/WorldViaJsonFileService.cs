using ARL.Core.Models.World;
using ARL.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Logic.Services;

//см. https://docs.microsoft.com/ru-ru/dotnet/standard/serialization/system-text-json-how-to?pivots=dotnet-6-0
public class WorldViaJsonFileService : IWorldService
{
    public World World { get; set; }

    public Task LoadAsync()
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}
