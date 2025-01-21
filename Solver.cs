using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChipSecuritySystem
{
    public abstract class Solver
    {
        protected List<ColorChip> Chips;

        public Solver(List<ColorChip> chips)
        {
            this.Chips = chips;
        }

        public abstract List<ColorChip> Solve();

        public void Print(List<ColorChip> sequence)
        {
            if (sequence == null || !sequence.Any() || 
                sequence.First().StartColor != Color.Blue || 
                sequence.Last().EndColor != Color.Green)
            {
                if(sequence == null || !sequence.Any())
                {
                    Console.WriteLine("No chips found");
                }
                else if (sequence.First().StartColor != Color.Blue)
                {
                    Console.WriteLine("First chip is not Blue");
                }
                else if (sequence.Last().EndColor != Color.Green)
                {
                    Console.WriteLine("Last chip is not Green");
                }

                return;
            }

            Console.Write("Blue -> ");
            foreach (var chip in sequence)
            {
                Console.Write($"[{chip}] -> ");
            }
            Console.Write("Green");

        }

    }
}
