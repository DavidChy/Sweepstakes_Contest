using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesContest
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => emailAddress; set => emailAddress = value; }

        public Contestant ContestantInfo()
        {
            Contestant contestant = new Contestant();
            contestant.firstName = UserInterface.GetFirstName();
            contestant.lastName = UserInterface.GetLastName();
            contestant.emailAddress = UserInterface.GetEmail();
            return contestant;
        }
    }

    

}
