using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Dungeon;

public class LevelLadder : Event
{
    public string TargetLevelId { get; set; }
}
