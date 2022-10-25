using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Dungeon;

public class Level : INameable, IWithId<string>
{
    public string Id { get; set; } //id уровня в словаре Dungeon.Levels

    public string Name { get; set; }
    public string Description { get; set; }

    public List<Event> Events { get; set; } = new List<Event>();
    public Event GetNextEvent() => Events.First(); //TODO: генерация события на основании вероятности
}
