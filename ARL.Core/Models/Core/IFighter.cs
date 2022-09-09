﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core;

public interface IFighter
{
    public int HP { get; set; }
    public Dice Damage { get; }
    public int Attack { get; }
    public int Defence { get; }
    public int Protection { get; }
}
