using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    public interface ISweepstakesManager
    {

        void AddSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();
    }
}
