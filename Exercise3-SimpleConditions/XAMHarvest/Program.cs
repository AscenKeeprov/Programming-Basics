using System;

namespace XAMHarvest
{
	class Program
	{
		static void Main(string[] args)
		{
			var X = int.Parse(Console.ReadLine());
			var Y = double.Parse(Console.ReadLine());
			var Z = int.Parse(Console.ReadLine());
			var W = int.Parse(Console.ReadLine());
			var wine = X * Y * 0.4 / 2.5;
			if (wine < Z) Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(Z - wine));
			else
			{
				Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
				Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - Z), Math.Ceiling((wine - Z) / W));
			}
		}
	}
}