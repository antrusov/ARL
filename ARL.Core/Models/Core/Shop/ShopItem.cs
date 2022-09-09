using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Shop;

public class ShopItem : IProduct, INameable
{
    public int Cost { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
