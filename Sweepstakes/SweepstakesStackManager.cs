using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
	public class SweepstakesStackManager : ISweepstakesManager 
	{
		Stack<Sweepstakes> MyStack = new Stack<Sweepstakes>();


		public void InsertSweepstakes(Sweepstakes sweepstakes)
		{
			MyStack.Push(sweepstakes);
		}
		public Sweepstakes GetSweepstakes()
		{
			MyStack.Pop();
			return MyStack.Pop();
		} 
	}
}
