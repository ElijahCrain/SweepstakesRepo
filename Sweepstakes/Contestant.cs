using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
	class Contestant
	{
		//a first name, last name, email
		//address, and registration number

		//Variables
		public string firstName;
		public string lastName;
		public string email;
		public int registrationNumber;


		//constructor

		public Contestant(string firstNameEntered, string lastNameEntered, string emailEntered, int registrationNumberEntered)
		{
			firstName = firstNameEntered;
			lastName = lastNameEntered;
			email = emailEntered;
			registrationNumber = registrationNumberEntered;

		}

		//methods 
		public void FirstName()
		{
			Console.WriteLine("Please enter your First Name");
			Console.ReadLine();
		}
		public void LastName()
		{
			Console.WriteLine("Please enter your Last Name");
			Console.ReadLine();
		}
		public void Email()
		{
			Console.WriteLine("Please enter your email");
			Console.ReadLine();
		}
		public void RegNumber()
		{

		}

	}
}
