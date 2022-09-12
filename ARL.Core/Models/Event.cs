using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Interfaces;

namespace ARL.Core.Models;

public class Event : INameable, IEvent
{
    public int Probability { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
