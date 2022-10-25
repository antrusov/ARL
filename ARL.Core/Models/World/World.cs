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

        public bool FinalBossKilled { get; set; } = false;

        public string CurrentTownId { get; set; }
        public Dictionary<string, Town.Town> Towns { get; set; } = new Dictionary<string, Town.Town>();

        public Dictionary<(string fromTownId, string toTownId), Road> Roads { get; set; } = new Dictionary<(string fromTownId, string toTownId), Road>();

        //TODO: статистика (время, очки, общий урон, кол-во убийство, получено денег)
    }
}
