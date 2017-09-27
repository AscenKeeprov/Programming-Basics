using System;

namespace DateIn5Days
{
	class Program
	{
		static void Main(string[] args)
		{
			var d = int.Parse(Console.ReadLine());
			var m = int.Parse(Console.ReadLine());
			if (m >= 1 && m <= 12 && d >= 1 && d <= 31)
			{
				int mDays = 31;
				if (m == 4 || m == 6 || m == 9 || m == 11) mDays = 30;
				else if (m == 2) mDays = 28;
				if (d <= mDays)
				{
					d += 5;
					if (d > mDays)
					{
						d -= mDays;
						m++;
						if (m > 12) m -= 12;
					}
					Console.WriteLine("{0}.{1:00}", d, m);
				}
				else Console.WriteLine("Invalid input.");
			}
			else Console.WriteLine("Invalid input.");
		}
	}
}