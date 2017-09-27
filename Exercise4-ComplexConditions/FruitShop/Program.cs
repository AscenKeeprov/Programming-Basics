﻿using System;

namespace FruitShop
{
	class Program
	{
		static void Main(string[] args)
		{
			string fruit = Console.ReadLine().ToLower();
			string day = Console.ReadLine().ToLower();
			var qty = double.Parse(Console.ReadLine());
			var price = -1.00;
			if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
			{
				if (fruit == "banana")
				{
					price = 2.50;
				}
				else if (fruit == "apple")
				{
					price = 1.20;
				}
				else if (fruit == "orange")
				{
					price = 0.85;
				}
				else if (fruit == "grapefruit")
				{
					price = 1.45;
				}
				else if (fruit == "kiwi")
				{
					price = 2.70;
				}
				else if (fruit == "pineapple")
				{
					price = 5.50;
				}
				else if (fruit == "grapes")
				{
					price = 3.85;
				}
			}
			else if (day == "saturday" || day == "sunday")
			{
				if (fruit == "banana")
				{
					price = 2.70;
				}
				else if (fruit == "apple")
				{
					price = 1.25;
				}
				else if (fruit == "orange")
				{
					price = 0.90;
				}
				else if (fruit == "grapefruit")
				{
					price = 1.60;
				}
				else if (fruit == "kiwi")
				{
					price = 3.00;
				}
				else if (fruit == "pineapple")
				{
					price = 5.60;
				}
				else if (fruit == "grapes")
				{
					price = 4.20;
				}
			}
			if (price == -1.00)
			{
				Console.WriteLine("error");
			}
			else
			{
				Console.WriteLine("{0:F2}", (qty * price));
			}
		}
	}
}