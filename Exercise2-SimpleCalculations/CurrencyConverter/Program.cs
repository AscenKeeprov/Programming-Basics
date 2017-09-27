using System;

namespace CurrencyConverter
{
	class Program
	{
		static void Main(string[] args)
		{
			var sum = double.Parse(Console.ReadLine());
			var curr1 = (Console.ReadLine());
			var curr2 = (Console.ReadLine());
			if (sum > 0)
			{
				if (curr1 == "BGN")
				{
					if (curr2 == "EUR")
					{
						Console.WriteLine(Math.Round(sum / 1.95583, 2) + " " + curr2);
					}
					else if (curr2 == "GBP")
					{
						Console.WriteLine(Math.Round(sum / 2.53405, 2) + " " + curr2);
					}
					else if (curr2 == "USD")
					{
						Console.WriteLine(Math.Round(sum / 1.79549, 2) + " " + curr2);
					}
					else
					{
						Console.WriteLine("ERROR: Invalid input");
					}
				}
				else if (curr1 == "EUR")
				{
					if (curr2 == "BGN")
					{
						Console.WriteLine(Math.Round(sum * 1.95583, 2) + " " + curr2);
					}
					else if (curr2 == "GBP")
					{
						Console.WriteLine(Math.Round(sum * 0.77182, 2) + " " + curr2);
					}
					else if (curr2 == "USD")
					{
						Console.WriteLine(Math.Round(sum * 1.08930, 2) + " " + curr2);
					}
					else
					{
						Console.WriteLine("ERROR: Invalid input");
					}
				}
				else if (curr1 == "GBP")
				{
					if (curr2 == "BGN")
					{
						Console.WriteLine(Math.Round(sum * 2.53405, 2) + " " + curr2);
					}
					else if (curr2 == "EUR")
					{
						Console.WriteLine(Math.Round(sum * 1.29564, 2) + " " + curr2);
					}
					else if (curr2 == "USD")
					{
						Console.WriteLine(Math.Round(sum * 1.41134, 2) + " " + curr2);
					}
					else
					{
						Console.WriteLine("ERROR: Invalid input");
					}
				}
				else if (curr1 == "USD")
				{
					if (curr2 == "BGN")
					{
						Console.WriteLine(Math.Round(sum * 1.79549, 2) + " " + curr2);
					}
					else if (curr2 == "EUR")
					{
						Console.WriteLine(Math.Round(sum * 0.91802, 2) + " " + curr2);
					}
					else if (curr2 == "GBP")
					{
						Console.WriteLine(Math.Round(sum * 0.70855, 2) + " " + curr2);
					}
					else
					{
						Console.WriteLine("ERROR: Invalid input");
					}
				}
				else
				{
					Console.WriteLine("ERROR: Invalid input");
				}
			}
			else
			{
				Console.WriteLine("ERROR: Invalid input");
			}
		}
	}
}