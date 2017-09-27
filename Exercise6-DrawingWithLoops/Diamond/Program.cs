using System;

namespace Diamond
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var outer = (n - 1) / 2;
			var inner = -1;
			if (n >= 1 && n <= 100)
			{
				for (int t = 1; t <= (n - 1) / 2; t++)
				{
					Console.Write(new string('-', outer));
					Console.Write("*");
					inner = n - 2 * outer - 2;
					if (inner >= 0)
					{
						Console.Write(new string('-', inner));
						Console.Write("*");
					}
					Console.WriteLine(new string('-', outer));
					outer--;
				}
				for (int b = (n - 1) / 2; b >= 0; b--)
				{
					Console.Write(new string('-', outer));
					Console.Write("*");
					inner = n - 2 * outer - 2;
					if (inner >= 0)
					{
						Console.Write(new string('-', inner));
						Console.Write("*");
					}
					Console.WriteLine(new string('-', outer));
					outer++;
				}
			}
		}
	}
}