using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Shop;

public class ShopArmor : ShopItem, IArmor
{
    public int Defence { get; set; }
    public int Protection { get; set; }
    public ArmorSlot Slot { get; set; }
}
