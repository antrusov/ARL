using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Interfaces;

namespace ARL.Core.Models.Town;

public class Town : INameable, IWithId<string>
{
    public string Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }

    public Arena.Arena Arena { get; set; }
    public Shop.Shop Shop { get; set; }
    public List<Dungeon.Dungeon> Dungeons { get; set; }
}
