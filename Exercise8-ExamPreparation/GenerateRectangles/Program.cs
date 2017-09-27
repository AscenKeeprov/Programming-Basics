using System;

namespace GenerateRectangles
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var m = int.Parse(Console.ReadLine());
			var area = 0;
			if (n >= 1 && n <= 100 && area >= 0 && area <= 50000)
			{
				for (int up = -n; up <= n; up++)
				{
					for (int left = -n; left <= n; left ++)
					{
						for (int down = -n; down <= n; down++)
						{
							for (int right = -n; right <= n; right++)
							{
								area = Math.Abs((up - down) * (left - right));
								if (up < right && left < down && area >= m)
								{
									Console.WriteLine($"({up},{left}) ({right},{down}) -> {area}");
								}
							}
						}
					}
				}
				if (area < m) Console.WriteLine("No");
			}
		}
	}
}