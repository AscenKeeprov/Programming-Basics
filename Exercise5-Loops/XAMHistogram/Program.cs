using System;

namespace XAMHistogram
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var p1 = 0.00;
			var p2 = 0.00;
			var p3 = 0.00;
			var p4 = 0.00;
			var p5 = 0.00;
			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				if (num >= 1 && num < 200) p1++;
				else if (num >= 200 && num <= 399) p2++;
				else if (num >= 400 && num <= 599) p3++;
				else if (num >= 600 && num <= 799) p4++;
				else if (num >= 800 && num <= 1000) p5++;
			}
			var pool = p1 + p2 + p3 + p4 + p5;
			Console.WriteLine("{0:0.00}%", p1 / pool * 100);
			Console.WriteLine("{0:0.00}%", p2 / pool * 100);
			Console.WriteLine("{0:0.00}%", p3 / pool * 100);
			Console.WriteLine("{0:0.00}%", p4 / pool * 100);
			Console.WriteLine("{0:0.00}%", p5 / pool * 100);
		}
	}
}