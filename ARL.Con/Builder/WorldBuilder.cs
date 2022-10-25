using ARL.Core.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Con.Builder;

public class WorldBuilder
{
    protected World _world;

    public WorldBuilder() => _world = new World();
    public WorldBuilder(World world) => _world = world;
    public World Build() => _world;

    public HeroBuilder SetupHero() => new HeroBuilder(_world);
    public SetupWorldBuilder SetupWorld() => new SetupWorldBuilder(_world);
    public TownBuilder AddTown(string id, string name = "", string desc = "") => new TownBuilder(_world, id, name, desc);
    public RoadBuilder AddRoad(string fromid, string toid, int cost, int days, bool twoway = false) => new RoadBuilder(_world, fromid, toid, cost, days, twoway);
}
