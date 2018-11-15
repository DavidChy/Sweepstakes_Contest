using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    public static class UserInterface
    {
        public static void MenuSelect()
        {
            string userInput;
            bool runSweep = true;
            Sweepstakes sweepstakes;
            
            Console.WriteLine("Please select one of the options below.");
            Console.WriteLine("1. Register contestant for a sweepstakes!");
            Console.WriteLine("2. Pick a contestant to win!");
            Console.WriteLine("3. Create a sweepstakes!");
        }
    }
}
