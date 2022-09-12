using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Interfaces;

public interface IEvent
{
    public int Probability { get; set; }
}
