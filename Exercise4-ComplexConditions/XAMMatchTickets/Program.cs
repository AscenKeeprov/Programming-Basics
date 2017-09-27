using System;

namespace XAMMatchTickets
{
	class Program
	{
		static void Main(string[] args)
		{
			var budget = double.Parse(Console.ReadLine());
			string ticket = Console.ReadLine().ToLower();
			var fans = int.Parse(Console.ReadLine());
			var expense = 0.00;
			if (fans >= 1 && fans <= 4) budget *= 0.25;
			else if (fans >= 5 && fans <= 9) budget *= 0.4;
			else if (fans >= 10 && fans <= 24) budget *= 0.5;
			else if (fans >= 25 && fans <= 49) budget *= 0.6;
			else if (fans >= 50 && fans <= 200) budget *= 0.75;
			if (ticket == "normal") expense = fans * 249.99;
			else if (ticket == "vip") expense = fans * 499.99;
			if (expense <= budget) Console.WriteLine("Yes! You have {0:0.00} leva left.", budget - expense);
			else Console.WriteLine("Not enough money! You need {0:0.00} leva.", expense - budget);
		}
	}
}