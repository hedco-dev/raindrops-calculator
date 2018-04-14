using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaindropsCalculator.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new RaindropsCounter().Solve(new int[] { 5, 2, 3, 4, 5, 4, 1, 3, 1 }));
        }
    }
}
