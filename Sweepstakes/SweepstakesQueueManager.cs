using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
	public class SweepstakesQueueManager : ISweepstakesManager 
	{
		Queue<Sweepstakes> myQueue = new Queue<Sweepstakes>();


		public void InsertSweepstakes(Sweepstakes sweepstakes)
		{
			myQueue.Enqueue(sweepstakes);
		}

		public Sweepstakes GetSweepstakes()
		{
			myQueue.Dequeue();
			return myQueue.Dequeue();
		} 
	}
}
