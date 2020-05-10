using System;
using System.Linq;

namespace Ants
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] x = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(i => int.Parse(i)).ToArray();
            int minT = 0;
            int maxT = 0;
            foreach (var xi in x)
            {
                minT = Math.Max(minT, Math.Min(xi, L - xi));
                maxT = Math.Max(maxT, Math.Max(xi, L - xi));
            }
            Console.WriteLine($"min: {minT}, max: {maxT}");
        }
    }
}
