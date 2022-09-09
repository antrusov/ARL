using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Dungeon;

public class DungeonLadder : DungeonEvent
{
    public string TargetLevelId { get; set; }
}
