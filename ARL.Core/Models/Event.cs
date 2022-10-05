using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ARL.Core.Interfaces;
using ARL.Core.Models.Dungeon;
using ARL.Core.Models.Shop;
using ARL.Core.Models.World;

namespace ARL.Core.Models;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Type")]
[JsonDerivedType(typeof(LevelEnemy), nameof(LevelEnemy))]
[JsonDerivedType(typeof(LevelExit), nameof(LevelExit))]
[JsonDerivedType(typeof(LevelLadder), nameof(LevelLadder))]
[JsonDerivedType(typeof(LevelTrash), nameof(LevelTrash))]
[JsonDerivedType(typeof(LevelTreasure), nameof(LevelTreasure))]
[JsonDerivedType(typeof(RoadEnemy), nameof(RoadEnemy))]
[JsonDerivedType(typeof(RoadTrash), nameof(RoadTrash))]
[JsonDerivedType(typeof(RoadTreasure), nameof(RoadTreasure))]
public class Event : INameable, IEvent
{
    public int Probability { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
