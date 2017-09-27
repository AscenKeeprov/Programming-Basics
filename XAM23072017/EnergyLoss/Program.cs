using System;

namespace EnergyLoss
{
	class Program
	{
		static void Main(string[] args)
		{
			var days = int.Parse(Console.ReadLine());
			var dancers= int.Parse(Console.ReadLine());
			var energy = days * dancers * 100;
			var fatigue = 0.00;
			for (int d = 1; d <= days; d++)
			{
				var hours = int.Parse(Console.ReadLine());
				if (d % 2 == 0 && hours % 2 == 0) fatigue += 68;
				else if (d % 2 != 0 && hours % 2 == 0) fatigue += 49;
				else if (d % 2 == 0 && hours % 2 != 0) fatigue += 65;
				else if (d % 2 != 0 && hours % 2 != 0) fatigue += 30;
			}
			var energyloss = dancers * fatigue;
			var reserve = energy - energyloss;
			if (fatigue / days <= 50) Console.WriteLine("They feel good! Energy left: {0:0.00}", reserve / days / dancers);
			else Console.WriteLine("They are wasted! Energy left: {0:0.00}", reserve / days / dancers);
		}
	}
}