using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    public class GreedyAlgorithm : Solver
    {
        public GreedyAlgorithm(List<ColorChip> chips) : base(chips) { }

        public override List<ColorChip> Solve()
        {
            var sequence = new List<ColorChip>();
            var currentColor = Color.Blue;

            while (true) //until a valid sequence is formed or no more matching chips are found
            {
                var matchingChips = Chips.Where(c => c.StartColor == currentColor).ToList();
                if (!matchingChips.Any())
                    break;

                var nextChip = matchingChips.First();//first matching chip is selected
                sequence.Add(nextChip);
                currentColor = nextChip.EndColor;

                Chips.Remove(nextChip); //remove used chip
            }

            return sequence;
        }
    }
}
