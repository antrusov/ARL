using ARL.Core.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Con.Builder;

public class SetupWorldBuilder : WorldBuilder
{
    public SetupWorldBuilder(World _world) : base(_world) { }

    public SetupWorldBuilder SetCurrentTown(string id)
    {
        _world.CurrentTownId = id;
        return this;
    }

    //todo: прочие настройки, общие для всего World
}
