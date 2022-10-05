using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ARL.Core.Models.Arena;

public class Arena
{
    public List<ArenaEnemy> Enemies { get; set; }
    [JsonIgnore]
    public ArenaEnemy CurrentEnemy { get => Enemies.Where(e => !e.Completed).FirstOrDefault(); }
}
