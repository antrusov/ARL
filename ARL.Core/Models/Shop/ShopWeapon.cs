using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Shop;

public class ShopWeapon : ShopItem, IWeapon
{
    public int Attack { get; set; }
    public Dice Damage { get; set; }
}
