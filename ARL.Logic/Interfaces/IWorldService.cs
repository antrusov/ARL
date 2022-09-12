using ARL.Core.Models.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Logic.Interfaces;

public interface IWorldService
{
    public World World { get; set; }
    public Task SaveAsync();
    public Task LoadAsync();
}
