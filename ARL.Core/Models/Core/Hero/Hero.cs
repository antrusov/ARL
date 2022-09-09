using ARL.Core.Models.Core.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Hero;

public class Hero: IFighter
{
    public int Money { get; set; }
    public List<ShopItem> Equipment { get; set; }

    public int MaxHP { get; set; }
    public int HP { get; set; }
    public Dice Damage { get => Equipment.Where(e => e is ShopWeapon).Select(e => e as ShopWeapon).FirstOrDefault()?.Damage ?? new Dice(); }
    public int Attack { get => Equipment.Where(e => e is ShopWeapon).Select(e => e as ShopWeapon).FirstOrDefault()?.Attack ?? 0; }
    public int Defence { get => Equipment.Where(e => e is ShopArmor).Select(e => e as ShopArmor).Sum(e => e.Defence); }
    public int Protection { get => Equipment.Where(e => e is ShopArmor).Select(e => e as ShopArmor).Sum(e => e.Protection); }
}

