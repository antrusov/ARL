using ARL.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARL.Core.Models.Core
{
    public class Dice
    {
        private static Random rnd = new Random();

        private int _count;
        public int DiceCount { get => _count; set => _count.CropNegative(); }

        private int _size;
        public int DiceSize { get => _size; set => _size.CropNegative(); }

        private int _addition;
        public int Addition { get => _addition; set => _addition.CropNegative(); }


        public Dice() =>
            (DiceCount, DiceSize, Addition) = (1, 1, 0);
        public Dice(int count, int size, int addition = 0) =>
            (DiceCount, DiceSize, Addition) = (count, size, addition);

        public int Next
        {
            get
            {
                int res = Addition;
                for (int i = 0; i < DiceCount; i++)
                    Addition += rnd.Next(DiceSize) + 1;
                return res;
            }
        }

        public override string ToString() =>
            $"{DiceCount}d{DiceSize}{Addition.ToString("+#;-#;''")}";
    }
}
