using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Dungeon;

public class DungeonEvent: INameable
{
    public int Probability { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
