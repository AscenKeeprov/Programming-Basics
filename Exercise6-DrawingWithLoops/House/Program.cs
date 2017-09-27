using System;

namespace Sunglasses
{
	class Program
	{
		static void Main(string[] args)
		{
			var odd = 1;
			var n = int.Parse(Console.ReadLine());
			if (n % 2 == 0) odd++;
			if (n >= 2 && n <= 100)
			{
				for (int i = 1; i < (n + 1) / 2; i++)
				{
					Console.Write(new string('-', (n - odd) / 2));
					Console.Write(new string('*', odd));
					Console.WriteLine(new string('-', (n - odd) / 2));
					odd += 2;
				}
				Console.WriteLine(new string('*', n));
				Console.Write("|");
				Console.Write(new string('*', n - 2));
				Console.WriteLine("|");
				for (int j = 0; j < n / 2 - 1; j++)
				{
					Console.Write("|");
					Console.Write(new string('*', n - 2));
					Console.WriteLine("|");
				}
			}
		}
	}
}