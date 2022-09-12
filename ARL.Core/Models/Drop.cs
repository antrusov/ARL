using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models;

public class Drop
{
    private static Random rnd = new Random();

    public int Start { get; set; }
    public int Interval { get; set; }

    public int Getvalue() => Start + rnd.Next(Interval + 1);
}
