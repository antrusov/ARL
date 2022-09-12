using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Dungeon;

public class LevelTreasure : Event
{
    public Drop Treasure { get; set; }
    public string Message { get; set; }
}
