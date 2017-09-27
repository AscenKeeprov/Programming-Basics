using System;

namespace MidStarsRectangle
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			if (n >= 2 && n <= 1000)
			{
				Console.WriteLine(new string('%', 2 * n));
				var rows = n - 1;
				if (n % 2 == 1) rows = n;
				for (int i = 1; i <= rows; i++)
				{
					Console.Write("%");
					Console.Write(new string(' ', n - 2));
					if (i == (rows + 1) / 2) Console.Write("**");
					else Console.Write("  ");
					Console.Write(new string(' ', n - 2));
					Console.WriteLine("%");
				}
				Console.WriteLine(new string('%', 2 * n));
			}
		}
	}
}