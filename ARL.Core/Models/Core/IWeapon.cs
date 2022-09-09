using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core;

public interface IWeapon
{
    public int Attack { get; set; } //шанс попадания (сравнивается с Defence)
    public Dice Damage { get; set; }
}
