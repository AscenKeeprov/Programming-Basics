using System;

namespace XAMTrip
{
	class Program
	{
		static void Main(string[] args)
		{
			var budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine().ToLower();
			string destination = "unknown";
			string site = "nowhere";
			var expense = 0.00;
			if (budget >= 10 && budget <= 100) destination = "Bulgaria";
			else if (budget > 100 && budget <= 1000) destination = "Balkans";
			else if (budget > 1000 && budget <= 5000) destination = "Europe";
			if (destination == "Bulgaria")
			{
				if (season == "summer")
				{
					site = "Camp";
					expense = budget * 0.3;
				}
				else if (season == "winter")
				{
					site = "Hotel";
					expense = budget * 0.7;
				}
			}
			else if (destination == "Balkans")
			{
				if (season == "summer")
				{
					site = "Camp";
					expense = budget * 0.4;
				}
				else if (season == "winter")
				{
					site = "Hotel";
					expense = budget * 0.8;
				}
			}
			else if (destination == "Europe")
			{
				site = "Hotel";
				expense = budget * 0.9;
			}
			Console.WriteLine("Somewhere in {0}", destination);
			Console.WriteLine("{0} - {1:0.00}", site, expense);
		}
	}
}