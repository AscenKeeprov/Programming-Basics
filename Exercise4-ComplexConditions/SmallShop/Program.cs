using System;

namespace SmallShop
{
	class Program
	{
		static void Main(string[] args)
		{
			string grad = Console.ReadLine().ToLower();
			string prod = Console.ReadLine().ToLower();
			var qty = double.Parse(Console.ReadLine());
			if (grad == "sofia")
			{
				if (prod == "coffee")
				{
					Console.WriteLine(qty * 0.50);
				}
				else if (prod == "water")
				{
					Console.WriteLine(qty * 0.80);
				}
				else if (prod == "beer")
				{
					Console.WriteLine(qty * 1.20);
				}
				else if (prod == "sweets")
				{
					Console.WriteLine(qty * 1.45);
				}
				else if (prod == "peanuts")
				{
					Console.WriteLine(qty * 1.60);
				}
			}
			else if (grad == "plovdiv")
			{
				if (prod == "coffee")
				{
					Console.WriteLine(qty * 0.40);
				}
				else if (prod == "water")
				{
					Console.WriteLine(qty * 0.70);
				}
				else if (prod == "beer")
				{
					Console.WriteLine(qty * 1.15);
				}
				else if (prod == "sweets")
				{
					Console.WriteLine(qty * 1.30);
				}
				else if (prod == "peanuts")
				{
					Console.WriteLine(qty * 1.50);
				}
			}
			else if (grad == "varna")
			{
				if (prod == "coffee")
				{
					Console.WriteLine(qty * 0.45);
				}
				else if (prod == "water")
				{
					Console.WriteLine(qty * 0.70);
				}
				else if (prod == "beer")
				{
					Console.WriteLine(qty * 1.10);
				}
				else if (prod == "sweets")
				{
					Console.WriteLine(qty * 1.35);
				}
				else if (prod == "peanuts")
				{
					Console.WriteLine(qty * 1.55);
				}
			}
		}
	}
}