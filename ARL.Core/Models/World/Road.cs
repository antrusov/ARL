using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.World;

public class Road
{
    public int SafeTravelCost { get; set; } //стоимость безопасного путешествия (с караваном)
    public int Days { get; set; }
    public List<Event> Events { get; set; } = new List<Event>();
}
