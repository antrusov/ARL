using ARL.Core.Interfaces;
using ARL.Core.Models.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Hero;

public class Hero: IFighter
{
    public int Money { get; set; }
    public List<ShopItem> Equipment { get; set; }

    public int MaxHP { get; set; }
    public int HP { get; set; }
    public Dice Damage { get => Equipment.OfType<ShopWeapon>().Select(e => e.Damage).FirstOrDefault() ?? new Dice(); }
    public int Attack { get => Equipment.OfType<ShopWeapon>().Select(e => e.Attack).FirstOrDefault(); }
    public int Defence { get => Equipment.OfType<ShopArmor>().Select(e => e.Defence).Sum(); }
    public int Protection { get => Equipment.OfType<ShopArmor>().Select(e => e.Protection).Sum(); }
}

