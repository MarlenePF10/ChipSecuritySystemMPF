using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ColorChip> chips = new List<ColorChip>() {
                new ColorChip(Color.Blue, Color.Yellow),
                new ColorChip(Color.Red, Color.Green),
                new ColorChip(Color.Yellow, Color.Red),
                new ColorChip(Color.Orange, Color.Purple)
            };

            //To explore all possible paths, I propose to use depth first search algorithm 
            var dfs = new DepthFirstSearch(new List<ColorChip>(chips));
            var dfsResult = dfs.Solve();
            Console.WriteLine("Depth First Search Solution:");
            dfs.Print(dfsResult);
            Console.WriteLine("\n\n");

            //When needing a fast approximation, I propose to use greeady algorithm approach
            var greedy = new GreedyAlgorithm(new List<ColorChip>(chips));
            var greedyResult = greedy.Solve();
            Console.WriteLine("Greedy Algorithm Solution:");
            greedy.Print(greedyResult);

        }
    }
}
