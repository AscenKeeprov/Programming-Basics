using System;

namespace XAMRemainderlessDivision
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var p1 = 0.00;
			var p2 = 0.00;
			var p3 = 0.00;
			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				if (num % 2 == 0) p1++;
				if (num % 3 == 0) p2++;
				if (num % 4 == 0) p3++;
			}
			Console.WriteLine("{0:0.00}%", p1 / n * 100);
			Console.WriteLine("{0:0.00}%", p2 / n * 100);
			Console.WriteLine("{0:0.00}%", p3 / n * 100);
		}
	}
}