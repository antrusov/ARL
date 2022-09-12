using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Enums;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Shop;

public class ShopArmor : ShopItem, IArmor
{
    public int Defence { get; set; }
    public int Protection { get; set; }
    public ArmorSlot Slot { get; set; }
}
