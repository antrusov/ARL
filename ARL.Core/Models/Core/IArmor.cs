using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core;

public interface IArmor
{
    public int Defence { get; set; } //шанс уклонения (сравнивается с Attack)
    public int Protection { get; set; } //поглощение урона
    public ArmorSlot Slot { get; set; }
}
