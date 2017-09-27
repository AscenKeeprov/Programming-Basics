using System;

namespace XAMSleepyPussTom
{
	class Program
	{
		static void Main(string[] args)
		{
			var fDays = int.Parse(Console.ReadLine());
			var wDays = 365 - fDays;
			var pTime = fDays * 127 + wDays * 63;
			if (pTime > 30000)
			{
				Console.WriteLine("Tom will run away");
				Console.WriteLine("{0} hours and {1} minutes more for play", (pTime - 30000) / 60, (pTime - 30000) % 60);
			}
			else
			{
				Console.WriteLine("Tom sleeps well");
				Console.WriteLine("{0} hours and {1} minutes less for play", (30000 - pTime) / 60, (30000 - pTime) % 60);
			}
		}
	}
}