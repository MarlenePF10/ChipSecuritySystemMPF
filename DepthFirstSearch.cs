using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    public class DepthFirstSearch : Solver
    {
        public DepthFirstSearch(List<ColorChip> chips) : base(chips) { }

        public override List<ColorChip> Solve()
        {
            return FindLongestSequenceDFS(Color.Blue, Chips, new List<ColorChip>());
        }

        private List<ColorChip> FindLongestSequenceDFS(Color currentColor, List<ColorChip> remainingChips, List<ColorChip> currentSequence)
        {
            if (!remainingChips.Any()) //stops recursion
            {
                // Return the current sequence only if it ends with Green
                return currentSequence.LastOrDefault()?.EndColor == Color.Green ? currentSequence : null;
            }

            List<ColorChip> bestSequence = null;
                    
            foreach (var chip in remainingChips.Where(c => c.StartColor == currentColor))
            {
                var newSequence = new List<ColorChip>(currentSequence) { chip };//add selected chip

                //recursive call to continue the search
                var nextSequence = FindLongestSequenceDFS(chip.EndColor,
                                                          remainingChips.Except(new[] { chip }).ToList(),//new list excluding the selected chip
                                                          newSequence);

                if (bestSequence == null || (nextSequence != null && nextSequence.Count > bestSequence.Count))
                {
                    bestSequence = nextSequence;
                }
            }

            return bestSequence ?? currentSequence; //if no valid sequence found, return current sequence, otherwise return best sequence
        }
    }
}
