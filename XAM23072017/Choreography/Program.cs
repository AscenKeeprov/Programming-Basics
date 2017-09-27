using System;

namespace Choreography
{
	class Program
	{
		static void Main(string[] args)
		{
			var steps = int.Parse(Console.ReadLine());
			var dancers = int.Parse(Console.ReadLine());
			var days = int.Parse(Console.ReadLine());
			var stepsPerDay = Math.Ceiling(100.00 * (steps / days) / steps);
			var stepsPerDancer = stepsPerDay / dancers;
			if (stepsPerDay <= 13) Console.WriteLine("Yes, they will succeed in that goal! {0:0.00}%.", stepsPerDancer);
			else Console.WriteLine("No, They will not succeed in that goal! Required {0:0.00}% steps to be learned per day.", stepsPerDancer);
		}
	}
}