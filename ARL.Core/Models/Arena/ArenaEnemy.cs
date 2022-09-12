using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Arena;

public class ArenaEnemy : IFighter, INameable
{
    public int Revard { get; set; }
    public bool Completed { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public int HP { get; set; }
    public Dice Damage { get; set; }
    public int Attack { get; set; }
    public int Defence { get; set; }
    public int Protection { get; set; }
}
