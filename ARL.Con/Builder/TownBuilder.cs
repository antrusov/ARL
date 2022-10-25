using ARL.Core.Models.Town;
using ARL.Core.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Con.Builder;

public class TownBuilder : WorldBuilder
{
    protected Town _town;
    public TownBuilder(World world, string townId, string name, string desc) : base(world)
    {
        _town = new Town() { Id = townId, Name = name, Description = desc};
        _world.Towns[townId] = _town;
    }

    //SetName
    //SetDescription
    //...
}
