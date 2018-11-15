using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    class MarketingFirm
    {
        ISweepstakesManager sweepstakesManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        private void CreateSweepstake()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            sweepstakes.Name = UserInterface.CreateSweepstakes();
            sweepstakesManager.AddSweepstakes(sweepstakes);
        }
    }
}
