using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Shop;

public class Shop
{
    public List<ShopItem> Items { get; set; } = new List<ShopItem>();
}
