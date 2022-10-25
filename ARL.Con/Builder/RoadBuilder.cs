using ARL.Core.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Con.Builder;

public class RoadBuilder : WorldBuilder
{
    protected Road _road;
    public RoadBuilder(World world, string fromid, string toid, int cost, int days, bool twoway) : base(world)
    {
        _road = new Road() { SafeTravelCost = cost, Days = days };
        _world.Roads[(fromid, toid)] = _road;
        if (twoway)
            _world.Roads[(toid, fromid)] = _road;
    }

    public RoadBuilder AddEnemy(int propability, string name, string desc)
    {
        //...
        return this;
    }

    public RoadBuilder AddTreasure(int propability, string name, string desc, string message, int start, int size)
    {
        //...
        return this;
    }

    public RoadBuilder AddTrash(int propability, string name, string desc)
    {
        //...
        return this;
    }
}
