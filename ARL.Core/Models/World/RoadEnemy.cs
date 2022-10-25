using ARL.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.World;

public class RoadEnemy : Event, IFighter
{
    public int HP { get; set; }

    public Dice Damage { get; set; }

    public int Attack { get; set; }

    public int Defence { get; set; }

    public int Protection { get; set; }

    public Drop Treasure { get; set; }
}
