using ARL.Core.Models;
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

    protected RoadBuilder(World world, Road road) : base(world)
    {
        _road = road;
    }

    public RoadBuilder(World world, string fromid, string toid, int cost, int days, bool twoway) : base(world)
    {
        _road = new Road() { SafeTravelCost = cost, Days = days };
        _world.Roads[(fromid, toid)] = _road;
        if (twoway)
            _world.Roads[(toid, fromid)] = _road;
    }

    public RoadEnemyBuilder AddEnemy(int propability, string name, string desc)
    {
        var enemy = new RoadEnemy()
        {
            Probability = propability,
            Name = name,
            Description = desc,
        };
        _road.Events.Add(enemy);        
        return new RoadEnemyBuilder(_world,_road,enemy);
    }

    public RoadBuilder AddTreasure(int propability, string name, string desc, string message, int start, int size)
    {
        _road.Events.Add(
            new RoadTreasure()
            {
                Probability = propability,
                Name = name,
                Description = desc,
                Message = message,
                Treasure = new Drop() { Start = start, Interval = size}
            }
        );
        return this;
    }

    public RoadBuilder AddTrash(int propability, string name, string desc)
    {
        _road.Events.Add(
            new RoadTrash()
            {
                Probability = propability,
                Name = name,
                Description = desc
            }
        );
        return this;
    }
}
