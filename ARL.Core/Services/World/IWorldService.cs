using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Services.World;

public interface IWorldService
{
    public Models.World.World World { get; set; }
    public Task SaveAsync();
    public Task LoadAsync();
}
