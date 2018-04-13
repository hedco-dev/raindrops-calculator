using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaindropsCalculator.Core
{
    public interface IRaindropsCounter
    {
        int MinHeight { get; }
        int MaxHeight { get; }
        int Solve(int[] heights);
    }
}
