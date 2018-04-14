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
        private bool IsHill(int height, int row)
        {
            return row <= height;
        }
        public int Solve(int[] heights)
        {
            var max = heights.DefaultIfEmpty(0).Max();
            var min = heights.DefaultIfEmpty(0).Min();
            if (max >= MaxHeight)
            {
                throw new ArgumentOutOfRangeException(nameof(MaxHeight));
            }
            if (min < MinHeight)
            {
                throw new ArgumentOutOfRangeException(nameof(MinHeight));
            }

            var all = 0;
            for (int row = min; row <= max; row++)
            {
                var hills = 0;
                var pits = 0;
                for (int col = 0; col < heights.Length; col++)
                {
                    var height = heights[col];
                    if (IsHill(height, row))
                    {
                        hills++;
                        if (hills > 1)
                        {
                            all += pits;
                            pits = 0;
                        }
                    }
                    else
                    {
                        pits++;
                    }
                }
            }
            return all;
        }
    }
}
