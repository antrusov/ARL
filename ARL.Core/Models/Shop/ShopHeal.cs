using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Shop
{
    public class ShopHeal : ShopItem
    {
        public int Heal { get; set; } //todo: добавить разных эффектов (heal, boost, permaboost, regen)
    }
}
