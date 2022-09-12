using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Enums;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Dungeon
{
    public class LevelEnemy : Event, IFighter
    {
        public int HP { get; set; }

        public Dice Damage { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public int Protection { get; set; }

        public Drop Treasure { get; set; }

        public EnemyKind Kind { get; set; }
    }
}
