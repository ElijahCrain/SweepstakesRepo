using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
	public class UserInterface
	{
	

		//methods 
		public static string FirstName()
		{
			Console.WriteLine("Please enter your First Name");
			string firstNameEntered = Console.ReadLine();
			return firstNameEntered;
		}
		public static string LastName()
		{
			Console.WriteLine("Please enter your Last Name");
			string lastNameEntered  = Console.ReadLine();
			return lastNameEntered;
		}
		public static  string Email()
		{
			Console.WriteLine("Please enter your email");
			string emailEntered = Console.ReadLine();
			return emailEntered;
		}
		public static int RegNumber()
		{
			Console.WriteLine("Please enter your registation number ");
			int registrationNumberEnterd = Convert.ToInt32(Console.ReadLine());
			return registrationNumberEnterd;
		}

	}
}
