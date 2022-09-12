using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ARL.Core.Models;

namespace ARL.Core.Interfaces;

public interface IWeapon
{
    public int Attack { get; set; } //шанс попадания (сравнивается с Defence)
    public Dice Damage { get; set; }
}
