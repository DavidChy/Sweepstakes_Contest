using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
        public Sweepstakes GetSweepstakes()
        {
            string input = UserInterface.PickSweepstakes();

            for (int i = 0; i < stack.Count(); i++)
            {
                if (input.ToLower().Trim() == stack.ElementAt(i).Name.ToLower().Trim())
                {
                    return stack.ElementAt(i);
                }
            }
            throw new ApplicationException("No sweepstake with that name exist!");
        }
    }
}
