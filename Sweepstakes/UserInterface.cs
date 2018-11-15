using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    public static class UserInterface
    {
        public static string GetFirstName()
        {
            Console.WriteLine("What is the contestant's first name?");
            string firstNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return firstNameInput;
        }

        public static string GetLastName()
        {
            Console.WriteLine("What is the contestant's last name?");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return lastNameInput;
        }

        public static string GetEmail()
        {
            Console.WriteLine("What is the contestant's email?");
            string emailInput = Console.ReadLine();
            Console.WriteLine(" ");

            return emailInput;
        }

        public static string MenuSelect()
        {
            Console.WriteLine("Press [1] to register a contestant for sweepstakes.");
            Console.WriteLine("Press [2] to display a contestant's info.");
            Console.WriteLine("Press [3] to display all contestants registered.");
            Console.WriteLine("Press [4] to start the sweepstakes.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }
        public static string CreateSweepstakes()
        {
            Console.WriteLine("What is the name of the sweepstake?");
            string sweepstake = Console.ReadLine();
            Console.Clear();
            return sweepstake;
        }
        public static string SelectorTool()
        {
            Console.WriteLine("Welcome the the sweepstakes application manager.");
            Console.WriteLine("First establish which Sweepstakes Mangment you'd perfer to use.");
            Console.WriteLine("Input [Q] for a Queue Manger.");
            Console.WriteLine("Or");
            Console.WriteLine("Input [S] for a Stack Manager.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static void SweepstakesCreator()
        {
            Console.WriteLine("Now that we have a sweepstake manager lets create some sweepstakes!");
            Console.WriteLine("Press [ENTER] to start creating your sweepstakes!");
            Console.ReadLine();
            Console.Clear();
        }

        public static string MakeMoreSweepstakes()
        {
            Console.WriteLine("'Sweepstake was succesfully added!'");
            Console.WriteLine("Do you want to make another sweepstake?");
            Console.WriteLine("Input [Y] for yes.");
            Console.WriteLine("Or");
            Console.WriteLine("Input [N] for no.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static void GoToSweepstakes()
        {
            Console.WriteLine("Now that the manager has all your Sweepstakes lets add some contestant's,");
            Console.WriteLine("its not a Sweepstake without any contestants!");
            Console.WriteLine("Press [ENTER] to continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static string AddMoreContestants()
        {
            Console.WriteLine("'Contestant was succefully added!'");
            Console.WriteLine("Would you like to add another contestant?");
            Console.WriteLine("Input [Y] for yes.");
            Console.WriteLine("Or");
            Console.WriteLine("Input [N] for no.");
            string input = Console.ReadLine();
            Console.Clear();
            return input;
        }

        public static string PickSweepstakes()
        {
            Console.WriteLine("What sweepstake would you like to go use?");
            string input = Console.ReadLine();
            return input;
        }
    }
}
