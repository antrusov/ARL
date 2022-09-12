using ARL.Core.Models.World;
using ARL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Services.Services;

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
