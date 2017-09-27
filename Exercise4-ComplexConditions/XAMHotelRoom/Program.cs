using System;

namespace XAMHotelRoom
{
	class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine().ToLower();
			var nights = int.Parse(Console.ReadLine());
			var aPrice = 0.00;
			var sPrice = 0.00;
			if (month == "may" || month == "october")
			{
				if (nights > 7 && nights <= 14)
				{
					aPrice = 65 * nights;
					sPrice = 50 * 0.95 * nights;
				}
				else if (nights > 14)
				{
					aPrice = 65 * 0.9 * nights;
					sPrice = 50 * 0.7 * nights;
				}
				else
				{
					aPrice = 65 * nights;
					sPrice = 50 * nights;
				}
			}
			if (month == "june" || month == "september")
			{
				if (nights > 14)
				{
					aPrice = 68.7 * 0.9 * nights;
					sPrice = 75.2 * 0.8 * nights;
				}
				else
				{
					aPrice = 68.7 * nights;
					sPrice = 75.2 * nights;
				}
			}
			if (month == "july" || month == "august")
			{
				if (nights > 14)
				{
					aPrice = 77 * 0.9 * nights;
					sPrice = 76 * nights;
				}
				else
				{
					aPrice = 77 * nights;
					sPrice = 76 * nights;
				}
			}
			Console.WriteLine("Apartment: {0:0.00} lv.", aPrice);
			Console.WriteLine("Studio: {0:0.00} lv.", sPrice);
		}
	}
}