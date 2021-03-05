using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
	public class Sweepstakes
	{
		//varaibles 
		Dictionary<int, Contestant> contestantinfo = new Dictionary<int, Contestant>();
		Random random;
		private string name;
		public string Name;
		//ctor
		public Sweepstakes(string name)
		{
			name = Name;
			random = new Random();
		}
		//method
		public void RegesterContestant(Contestant contestant)
		{
			contestant.firstName = UserInterface.FirstName();
			contestant.lastName = UserInterface.LastName();
			contestant.email = UserInterface.Email();
			contestant.registrationNumber = UserInterface.RegNumber();
		}
		public Contestant PickWinner()
		{
			int randomRegNumber = random.Next(contestantinfo.Count);
			Contestant winner = new Contestant();
			winner = contestantinfo[randomRegNumber];
			return winner;
		}
		public void PrintContestentInfo(Contestant contestant)
		{
			Console.WriteLine();
		}
		


	}
}
