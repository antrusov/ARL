using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Dungeon;

public class Dungeon : INameable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool BossKilled { get; set; }
    public string CurrentLevelId { get; set; }

    public Dictionary<string, Level> Levels { get; set; }
}
