using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface.MenuSelect();
            MarketingFirm marketing = new MarketingFirm(manager);
            Sweepstakes sweep = new Sweepstakes();
            marketing.FirmMenu();
            sweep.SweepstakesMenu();
            Console.ReadLine();
        }
    }
}
