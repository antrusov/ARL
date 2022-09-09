using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Dungeon;

public class Dungeon : INameable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Dictionary<string, DungeonLevel> Levels { get; set; }
}
