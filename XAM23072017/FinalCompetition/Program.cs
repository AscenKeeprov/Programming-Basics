using System;

namespace FinalCompetition
{
	class Program
	{
		static void Main(string[] args)
		{
			var dancers = int.Parse(Console.ReadLine());
			var score = double.Parse(Console.ReadLine());
			string season = Console.ReadLine().ToLower();
			string location = Console.ReadLine().ToLower();
			var price = 0.00;
			var expenses = 0.00;
			if (location == "bulgaria")
			{
				price = score * dancers;
				if (season == "summer") expenses = price * 0.05;
				else if ( season == "winter") expenses = price * 0.08;
			}
			else if (location == "abroad")
			{
				price = score * dancers * 1.5;
				if (season == "summer") expenses = price * 0.1;
				else if (season == "winter") expenses = price * 0.15;
			}
			price -= expenses;
			var donation = price * 0.75;
			var cut = (price * 0.25) / dancers;
			Console.WriteLine("Charity - {0:0.00}", donation);
			Console.WriteLine("Money per dancer - {0:0.00}", cut);
		}
	}
}