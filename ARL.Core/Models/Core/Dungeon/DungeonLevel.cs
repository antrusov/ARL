using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Dungeon;

public class DungeonLevel : INameable
{
    public string LevelId { get; set; } //id уровня в словаре Dungeon.Levels

    public string Name { get; set; }
    public string Description { get; set; }

    public LinkedList<DungeonEvent> Events { get; set; }
    public DungeonEvent GetNextEvent() => Events.First(); //TODO: генерация события на основании вероятности
}
