using System;

namespace TradeCommissions
{
	class Program
	{
		static void Main(string[] args)
		{
			string grad = Console.ReadLine().ToLower();
			var sales = double.Parse(Console.ReadLine());
			var com = -1.00;
			if (grad == "sofia")
			{
				if (sales >= 0 && sales <= 500)
				{
					com = 0.05;
				}
				else if (sales > 500 && sales <= 1000)
				{
					com = 0.07;
				}
				else if (sales > 1000 && sales <= 10000)
				{
					com = 0.08;
				}
				else if (sales > 10000)
				{
					com = 0.12;
				}
			}
			else if (grad == "plovdiv")
			{
				if (sales >= 0 && sales <= 500)
				{
					com = 0.055;
				}
				else if (sales > 500 && sales <= 1000)
				{
					com = 0.08;
				}
				else if (sales > 1000 && sales <= 10000)
				{
					com = 0.12;
				}
				else if (sales > 10000)
				{
					com = 0.145;
				}
			}
			else if (grad == "varna")
			{
				if (sales >= 0 && sales <= 500)
				{
					com = 0.045;
				}
				else if (sales > 500 && sales <= 1000)
				{
					com = 0.075;
				}
				else if (sales > 1000 && sales <= 10000)
				{
					com = 0.10;
				}
				else if (sales > 10000)
				{
					com = 0.13;
				}
			}
			if (com == -1.00)
			{
				Console.WriteLine("error");
			}
			else
			{
				Console.WriteLine("{0:F2}", (sales * com));
			}
		}
	}
}