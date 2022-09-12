using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Arena;

public class Arena
{
    public List<ArenaEnemy> Enemies { get; set; }
    public ArenaEnemy CurrentEnemy { get => Enemies.Where(e => !e.Completed).FirstOrDefault(); }
}
