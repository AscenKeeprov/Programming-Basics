using System;

namespace SumSeconds
{
	class Program
	{
		static void Main(string[] args)
		{
			var t1 = int.Parse(Console.ReadLine());
			var t2 = int.Parse(Console.ReadLine());
			var t3 = int.Parse(Console.ReadLine());
			var tAll = t1 + t2 + t3;
			if (tAll > 3 && tAll <= 59)
			{
				Console.WriteLine("0:{0:00}", tAll);
			}
			else if (tAll > 59 && tAll <= 119)
			{
				Console.WriteLine("1:{0:00}", (tAll - 60));
			}
			else if (tAll > 119 && tAll <= 150)
			{
				Console.WriteLine("2:{0:00}", (tAll - 120));
			}
		}
	}
}