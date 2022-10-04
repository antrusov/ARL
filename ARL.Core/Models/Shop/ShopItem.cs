using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Shop;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "Type")]
[JsonDerivedType(typeof(ShopArmor), "Armor")]
[JsonDerivedType(typeof(ShopWeapon), "Weapon")]
public class ShopItem : IProduct, INameable
{
    public int Cost { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
