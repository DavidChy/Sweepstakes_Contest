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
            sweepstakesManager.InsertSweepstakes(sweepstakes);
        }

        public void FirmMenu()
        {
            UserInterface.SweepstakesCreator();
            CreateSweepstake();
            string input = UserInterface.MakeMoreSweepstakes();

            if (input.ToLower().Trim() == "y")
            {
                while (input.ToLower().Trim() == "y")
                {
                    CreateSweepstake();
                    input = UserInterface.MakeMoreSweepstakes();
                }
            }
            else if (input.ToLower().Trim() == "n")
            {
                UserInterface.GoToSweepstakes();
                return;
            }
            else
            {
                throw new ApplicationException("That input was not valid!");
            }
        }
    }
}
