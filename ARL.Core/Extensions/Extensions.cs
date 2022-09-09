using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Extensions;

public static class Extensions
{
    public static int CropNegative(this int value) => value < 0 ? 0 : value;
}
