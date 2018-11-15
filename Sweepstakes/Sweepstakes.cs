using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary;
        private string name;
        private int registrationNumber;
        private Random random;

        public string Name { get => name; set => name = value; }
        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }

        public Sweepstakes()
        {
            dictionary = new Dictionary<int, Contestant>();
            name = null;
            random = new Random();
        }

        public void SweepstakesMenu()
        {
            string input = UserInterface.MenuSelect();

            switch (input)
            {
                case "1":
                    AddContestant();
                    break;
                case "2":
                    DisplayContestant();
                    break;
                case "3":
                    DisplayDictionary();
                    break;
                case "4":
                    RunSweepstakes();
                    break;
            }
        }

        public void AddContestant()
        {
            CreateContestant();

            string input = UserInterface.AddMoreContestants();

            if (input.ToLower().Trim() == "y")
            {
                while (input.ToLower().Trim() == "y")
                {
                    CreateContestant();
                    input = UserInterface.AddMoreContestants();
                    if (input.ToLower().Trim() == "n")
                    {
                        SweepstakesMenu();
                    }
                }
            }
            else
            {
                throw new ApplicationException("That input was not valid!");
            }
        }

        private void DisplayContestant()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            bool person = dictionary.TryGetValue(input - 1, out Contestant contestant);

            if (person == true)
            {
                PrintContestantInfo(contestant);
            }
            else if (person == false)
            {
                Console.WriteLine("No contestant was found found with that Registraiton number please try again!");
                SweepstakesMenu();
            }
        }

        private void DisplayDictionary()
        {
            foreach (KeyValuePair<int, Contestant> contastant in dictionary)
            {
                Console.WriteLine("Registration Number: {0}, \n First Name: {1} \n Last Name: {2} \n Email: {3}", contastant.Key, contastant.Value.FirstName, contastant.Value.LastName, contastant.Value.Email);
                Console.ReadLine();
            }
        }

        private void RunSweepstakes()
        {
            string winner = PickWinner();
            Console.WriteLine(winner + " is the winner of the sweepstakes!");
            Console.ReadLine();
        }

        private void RegisterContestant(Contestant contestant)
        {
            RegistrationNumber = dictionary.Count();
            dictionary.Add(RegistrationNumber, contestant);
        }
        private void CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant = contestant.ContestantInfo();
            RegisterContestant(contestant);
            Console.Clear();
        }

        private void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(" First Name: {0} \n Last Name: {1} \n Email: {2} ", contestant.FirstName, contestant.LastName, contestant.Email);
            Console.ReadLine();
        }

        private string PickWinner()
        {
            int winningContestant;
            string name;

            winningContestant = random.Next(1, dictionary.Count());
            for (int i = 0; i < dictionary.Count(); i++)
            {
                if (winningContestant == dictionary.ElementAt(i).Key)
                {
                    name = dictionary.ElementAt(i).Value.FirstName + dictionary.ElementAt(i).Value.LastName;
                    return name;
                }
            }
            throw new ApplicationException("If you're seeing this....It's my fault sorry...");
        }
    }
}
