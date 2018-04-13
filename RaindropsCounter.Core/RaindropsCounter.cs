using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaindropsCalculator.Core
{
    public class RaindropsCounter : IRaindropsCounter
    {
        public int MaxHeight => 32000;
        public int MinHeight => 0;
        private bool IsHill(int colvalue, int row)
        {
            return row <= colvalue;
        }
        public int Solve(int[] heights)
        {
            var max = heights.Max();
            var min = heights.Min();
            if (max >= MaxHeight)
            {
                throw new ArgumentOutOfRangeException(nameof(MaxHeight));
            }
            if (min < MinHeight)
            {
                throw new ArgumentOutOfRangeException(nameof(MinHeight));
            }

            var all = 0;
            for (int row = 1; row <= max; row++)
            {
                var h = 0;
                var p = 0;
                for (int col = 0; col < heights.Length; col++)
                {
                    var colvalue = heights[col];
                    if (IsHill(colvalue, row))
                    {
                        h++;
                        if (h > 1)
                        {
                            all += p;
                            p = 0;
                        }
                        continue;
                    }
                    else
                    {
                        p++;
                    }
                }
            }
            return all;
        }
    }
}
