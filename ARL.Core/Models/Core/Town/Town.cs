using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core.Town;

public class Town : INameable
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Arena.Arena Arena { get; set; }
    public Shop.Shop Shop { get; set; }
    public List<Dungeon.Dungeon> Dungeons { get; set; }
}
