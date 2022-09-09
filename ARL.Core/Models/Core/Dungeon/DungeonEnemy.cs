using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Dungeon
{
    public class DungeonEnemy : DungeonEvent, IFighter
    {
        public int HP { get; set; }

        public Dice Damage { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public int Protection { get; set; }

        public Drop Treasure { get; set; }

        public DungeonEnemyKind Kind { get; set; }
    }
}
