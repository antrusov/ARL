using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.World
{
    public class World
    {
        public Hero.Hero Hero { get; set; }

        public bool FinalBossKilled { get; set; }

        public string CurrentTownId { get; set; }
        public Dictionary<string, Town.Town> Towns{ get; set; }

        public Dictionary<(string fromTownId, string toTownId), Road> Roads { get; set; }

        //TODO: статистика (время, очки, общий урон, кол-во убийство, получено денег)
    }
}
